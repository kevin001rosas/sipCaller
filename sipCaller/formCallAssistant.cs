using System;
using System.Windows.Forms;
using Ozeki.Media;
using Ozeki.VoIP;

namespace sipCaller
{
    public partial class FormCallAssistant : Form
    {
        int secondsCounter = 0;
        string duration = ""; 
        ISoftPhone _softPhone;
        IPhoneLine _phoneLine;
        public RegState _phoneLineState;
        IPhoneCall _call;

        Microphone _microphone;
        Speaker _speaker;
        MediaConnector _connector;
        PhoneCallAudioSender _mediaSender;
        PhoneCallAudioReceiver _mediaReceiver;

        DatabaseManager _databaseManager;

        UserInfo _otherParty;

        bool _incomingCall;

        public FormCallAssistant()
        {
            InitializeComponent();
        }

        public void form_CallAssistant_Load(object sender, EventArgs e)
        {
            
            _microphone = Microphone.GetDefaultDevice();
            _speaker = Speaker.GetDefaultDevice();
            _connector = new MediaConnector();
            _mediaSender = new PhoneCallAudioSender();
            _mediaReceiver = new PhoneCallAudioReceiver();

            _databaseManager = new DatabaseManager();
            InitializeSoftphone(); 
               
        }

        void InitializeSoftphone()
        {
            try
            {
                _softPhone = SoftPhoneFactory.CreateSoftPhone(SoftPhoneFactory.GetLocalIP(), 5700, 5750);
                string [] datosRegistro = new string[4]; 
                formSipRegister ventanaDatosDeRegistro = new formSipRegister();

                ventanaDatosDeRegistro.ShowDialog();
                ventanaDatosDeRegistro.getRegisterData(datosRegistro);


                SIPAccount sa = new SIPAccount(true, datosRegistro[0], datosRegistro[0], datosRegistro[0], datosRegistro[1], datosRegistro[2], Convert.ToInt16(datosRegistro[3])); 
                

                _phoneLine = _softPhone.CreatePhoneLine(sa);
                _phoneLine.RegistrationStateChanged += _phoneLine_RegistrationStateChanged;

                _softPhone.IncomingCall += _softPhone_IncomingCall;
                
                _softPhone.RegisterPhoneLine(_phoneLine);

                _incomingCall = false;

                ConnectMedia();
            }
            catch (Exception ex)
            {
                InvokeGUIThread(() => { tb_Display.Text = ex.Message; });
            }
        }

        void _phoneLine_RegistrationStateChanged(object sender, RegistrationStateChangedArgs e)
        {
            _phoneLineState = e.State;
            
            if (_phoneLineState == RegState.RegistrationSucceeded)
            {
                //MessageBox.Show("Conexión exitosa");
                InvokeGUIThread(() => { lbl_UserName.Text = _phoneLine.SIPAccount.UserName; });
                InvokeGUIThread(() => { lbl_DomainHost.Text = _phoneLine.SIPAccount.DomainServerHost; });
            }
            else
                if((_phoneLineState == RegState.Error) || (_phoneLineState == RegState.NotRegistered))
                { 
                //MessageBox.Show("Error de conexión"); 
                    }
        }

        void _softPhone_IncomingCall(object sender, VoIPEventArgs<IPhoneCall> e)
        {

            var userName = e.Item.DialInfo.CallerDisplay;
            InvokeGUIThread(() => { tb_Display.Text = "Ringing from (" + userName + ")"; });

            _call = e.Item;
            WireUpCallEvents();
            _incomingCall = true;

            _otherParty = _databaseManager.GetOtherPartyInfos(userName);
            ShowUserInfos(_otherParty);
        }

        void call_CallStateChanged(object sender, CallStateChangedArgs e)
        {
            InvokeGUIThread(() => { lbl_CallState.Text = e.State.ToString(); });

            if (e.State == CallState.Answered)
            {
                StartDevices();
                _mediaSender.AttachToCall(_call);
                _mediaReceiver.AttachToCall(_call);
                
                InvokeGUIThread(() => { tb_Display.Text = "In call with: " + ((IPhoneCall)sender).DialInfo.CallerDisplay; });
                
            }
            else if (e.State == CallState.InCall)
            {
                StartDevices();
                InvokeGUIThread(() => { callTimer.Start(); }); 
            }

            if (e.State == CallState.LocalHeld || e.State == CallState.InactiveHeld)
            {
                StopDevices();
                InvokeGUIThread(() => { btn_Hold.Text = "Unhold"; });
            }
            else
            {
                InvokeGUIThread(() => { btn_Hold.Text = "Hold"; });
            }

            if (e.State.IsCallEnded())
            {
                
                StopDevices();
                InvokeGUIThread(() => { stopTimer(); }); 
                
                _mediaSender.Detach();
                _mediaReceiver.Detach();

                WireDownCallEvents();

                _call = null;

                InvokeGUIThread(() => { tb_Display.Text = String.Empty; });
                ClearUserInfos();
            }


        }

        void ShowUserInfos(UserInfo otherParty)
        {
            InvokeGUIThread(() =>
                {
                    tb_OtherPartyUserName.Text = otherParty.UserName;
                    tb_OtherPartyRealName.Text = otherParty.RealName;
                    tb_OtherPartyCountry.Text = otherParty.Country;
                    tb_OtherPartyNote.Text = otherParty.Note;
                    formDatosUsuario datosDelUsuario = new formDatosUsuario();
                    datosDelUsuario.ShowDialog(); 
                });
        }

        void ClearUserInfos()
        {
            InvokeGUIThread(() =>
            {
                tb_OtherPartyUserName.Text = String.Empty;
                tb_OtherPartyRealName.Text = String.Empty;
                tb_OtherPartyCountry.Text = String.Empty;
                tb_OtherPartyNote.Text = String.Empty;
            });
        }

        void buttonKeyPadButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (_call != null)
                return;

            if (btn == null)
                return;

            tb_Display.Text += btn.Text.Trim();
        }

        void StartDevices()
        {
            if (_microphone != null)
                _microphone.Start();

            if (_speaker != null)
                _speaker.Start();
        }

        void StopDevices()
        {
            if (_microphone != null)
                _microphone.Stop();

            if (_speaker != null)
                _speaker.Stop();
        }

        void ConnectMedia()
        {
            if (_microphone != null)
                _connector.Connect(_microphone, _mediaSender);

            if (_speaker != null)
                _connector.Connect(_mediaReceiver, _speaker);
        }

        void WireUpCallEvents()
        {
            _call.CallStateChanged += (call_CallStateChanged);
        }

        void WireDownCallEvents()
        {
            _call.CallStateChanged -= (call_CallStateChanged);
        }

        void InvokeGUIThread(Action action)
        {
            Invoke(action);
        }

        void btn_PickUp_Click(object sender, EventArgs e)
        {
            if (_incomingCall)
            {
                
                _incomingCall = false;
                _call.Answer();

                return;
            }

            if (_call != null)
                return;

            if (_phoneLineState != RegState.RegistrationSucceeded)
            {
                InvokeGUIThread(() => { tb_Display.Text = "OFFLINE! Please register."; });
                InitializeSoftphone(); 
                return;
            }

            if (!String.IsNullOrEmpty(tb_Display.Text))
            {
                var userName = tb_Display.Text;

                _call = _softPhone.CreateCallObject(_phoneLine, userName);
                WireUpCallEvents();
                _call.Start();

                _otherParty = _databaseManager.GetOtherPartyInfos(userName);
                ShowUserInfos(_otherParty);
            }
        }

        void btn_HangUp_Click(object sender, EventArgs e)
        {
            if (_call != null)
            {
                if (_incomingCall && _call.CallState == CallState.Ringing)
                {
                    _call.Reject();
                }
                else
                {
                    _call.HangUp();
                    stopTimer(); 
                }
                _incomingCall = false;
                _call = null;
            }
            tb_Display.Text = string.Empty;
            
        }

        void btn_Transfer_Click(object sender, EventArgs e)
        {
            string transferTo = "1001";

            if (_call == null)
                return;

            if (string.IsNullOrEmpty(transferTo))
                return;

            if (_call.CallState != CallState.InCall)
                return;

            _call.BlindTransfer(transferTo);
            InvokeGUIThread(() => { tb_Display.Text = "Transfering to:" + transferTo; });
        }

        void btn_Hold_Click(object sender, EventArgs e)
        {
            
            if (_call != null)
                _call.ToggleHold();
        }

        private void callTimer_Tick(object sender, EventArgs e)
        {
            secondsCounter++;
            int minutes = Convert.ToInt16(Math.Floor(Convert.ToDouble(secondsCounter / 60)));
            int seconds = secondsCounter - minutes * 60;

            if((minutes<10) && (seconds<10))
            {
                duration = "0" + minutes.ToString() + ":" + "0"+ seconds.ToString();
            }
            else if (seconds<10)                
            {
                duration = minutes.ToString() + ":" + "0" + seconds.ToString();
            }
            else if (minutes<10)                
            {
                duration = "0" + minutes.ToString() + ":" + seconds.ToString();
            }
            else
            {
                duration = minutes.ToString() + ":" + seconds.ToString(); 
            }
            labelCallTimer.Text = duration; 
        }

        private void stopTimer(){
                callTimer.Stop();
                InvokeGUIThread(() => { labelCallTimer.Text = ""; });                
                secondsCounter = 0; 
        }

        private void FormCallAssistant_Shown(object sender, EventArgs e)
        {
            
        }

    }
}
