namespace sipCaller
{
    partial class FormCallAssistant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_Display = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCallTimer = new System.Windows.Forms.Label();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.btn_Hold = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_CallState = new System.Windows.Forms.Label();
            this.lbl_DomainHost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_HangUp = new System.Windows.Forms.Button();
            this.btn_PickUp = new System.Windows.Forms.Button();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_OtherPartyNote = new System.Windows.Forms.TextBox();
            this.tb_OtherPartyCountry = new System.Windows.Forms.TextBox();
            this.tb_OtherPartyRealName = new System.Windows.Forms.TextBox();
            this.tb_OtherPartyUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.callTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Display
            // 
            this.tb_Display.Location = new System.Drawing.Point(23, 75);
            this.tb_Display.Name = "tb_Display";
            this.tb_Display.Size = new System.Drawing.Size(310, 20);
            this.tb_Display.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelCallTimer);
            this.panel1.Controls.Add(this.btn_Transfer);
            this.panel1.Controls.Add(this.btn_Hold);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.lbl_DomainHost);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_HangUp);
            this.panel1.Controls.Add(this.btn_PickUp);
            this.panel1.Controls.Add(this.lbl_UserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_Display);
            this.panel1.Location = new System.Drawing.Point(431, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 412);
            this.panel1.TabIndex = 1;
            // 
            // labelCallTimer
            // 
            this.labelCallTimer.AutoSize = true;
            this.labelCallTimer.Location = new System.Drawing.Point(159, 13);
            this.labelCallTimer.Name = "labelCallTimer";
            this.labelCallTimer.Size = new System.Drawing.Size(0, 13);
            this.labelCallTimer.TabIndex = 22;
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Transfer.Location = new System.Drawing.Point(187, 124);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(63, 33);
            this.btn_Transfer.TabIndex = 21;
            this.btn_Transfer.Text = "Transfer";
            this.btn_Transfer.UseVisualStyleBackColor = false;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // btn_Hold
            // 
            this.btn_Hold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Hold.Location = new System.Drawing.Point(106, 124);
            this.btn_Hold.Name = "btn_Hold";
            this.btn_Hold.Size = new System.Drawing.Size(63, 33);
            this.btn_Hold.TabIndex = 20;
            this.btn_Hold.Text = "Hold";
            this.btn_Hold.UseVisualStyleBackColor = false;
            this.btn_Hold.Click += new System.EventHandler(this.btn_Hold_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_CallState);
            this.groupBox2.Location = new System.Drawing.Point(248, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(85, 66);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CallState";
            // 
            // lbl_CallState
            // 
            this.lbl_CallState.AutoSize = true;
            this.lbl_CallState.Location = new System.Drawing.Point(21, 33);
            this.lbl_CallState.Name = "lbl_CallState";
            this.lbl_CallState.Size = new System.Drawing.Size(0, 13);
            this.lbl_CallState.TabIndex = 20;
            this.lbl_CallState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DomainHost
            // 
            this.lbl_DomainHost.AutoSize = true;
            this.lbl_DomainHost.Location = new System.Drawing.Point(80, 38);
            this.lbl_DomainHost.Name = "lbl_DomainHost";
            this.lbl_DomainHost.Size = new System.Drawing.Size(51, 13);
            this.lbl_DomainHost.TabIndex = 18;
            this.lbl_DomainHost.Text = "OFFLINE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Online at:";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(269, 354);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(64, 24);
            this.button14.TabIndex = 16;
            this.button14.Text = "#";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(146, 354);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(64, 24);
            this.button13.TabIndex = 15;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(23, 354);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(64, 24);
            this.button12.TabIndex = 14;
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(269, 300);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(64, 24);
            this.button11.TabIndex = 13;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(146, 300);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(64, 24);
            this.button10.TabIndex = 12;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(23, 300);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 24);
            this.button9.TabIndex = 11;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(269, 246);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 24);
            this.button8.TabIndex = 10;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(146, 246);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 24);
            this.button7.TabIndex = 9;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 246);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 24);
            this.button6.TabIndex = 8;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(269, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 24);
            this.button5.TabIndex = 7;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(146, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 24);
            this.button4.TabIndex = 6;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 24);
            this.button3.TabIndex = 5;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // btn_HangUp
            // 
            this.btn_HangUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_HangUp.Location = new System.Drawing.Point(268, 115);
            this.btn_HangUp.Name = "btn_HangUp";
            this.btn_HangUp.Size = new System.Drawing.Size(64, 42);
            this.btn_HangUp.TabIndex = 4;
            this.btn_HangUp.Text = "Hang Up";
            this.btn_HangUp.UseVisualStyleBackColor = false;
            this.btn_HangUp.Click += new System.EventHandler(this.btn_HangUp_Click);
            // 
            // btn_PickUp
            // 
            this.btn_PickUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_PickUp.Location = new System.Drawing.Point(24, 115);
            this.btn_PickUp.Name = "btn_PickUp";
            this.btn_PickUp.Size = new System.Drawing.Size(64, 42);
            this.btn_PickUp.TabIndex = 3;
            this.btn_PickUp.Text = "Pick Up";
            this.btn_PickUp.UseVisualStyleBackColor = false;
            this.btn_PickUp.Click += new System.EventHandler(this.btn_PickUp_Click);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(80, 13);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(51, 13);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "OFFLINE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Online as:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_OtherPartyNote);
            this.groupBox1.Controls.Add(this.tb_OtherPartyCountry);
            this.groupBox1.Controls.Add(this.tb_OtherPartyRealName);
            this.groupBox1.Controls.Add(this.tb_OtherPartyUserName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 412);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information about the other party";
            // 
            // tb_OtherPartyNote
            // 
            this.tb_OtherPartyNote.Enabled = false;
            this.tb_OtherPartyNote.Location = new System.Drawing.Point(88, 224);
            this.tb_OtherPartyNote.Multiline = true;
            this.tb_OtherPartyNote.Name = "tb_OtherPartyNote";
            this.tb_OtherPartyNote.ReadOnly = true;
            this.tb_OtherPartyNote.Size = new System.Drawing.Size(278, 174);
            this.tb_OtherPartyNote.TabIndex = 7;
            // 
            // tb_OtherPartyCountry
            // 
            this.tb_OtherPartyCountry.Enabled = false;
            this.tb_OtherPartyCountry.Location = new System.Drawing.Point(88, 154);
            this.tb_OtherPartyCountry.Name = "tb_OtherPartyCountry";
            this.tb_OtherPartyCountry.ReadOnly = true;
            this.tb_OtherPartyCountry.Size = new System.Drawing.Size(278, 20);
            this.tb_OtherPartyCountry.TabIndex = 6;
            // 
            // tb_OtherPartyRealName
            // 
            this.tb_OtherPartyRealName.Enabled = false;
            this.tb_OtherPartyRealName.Location = new System.Drawing.Point(88, 113);
            this.tb_OtherPartyRealName.Name = "tb_OtherPartyRealName";
            this.tb_OtherPartyRealName.ReadOnly = true;
            this.tb_OtherPartyRealName.Size = new System.Drawing.Size(278, 20);
            this.tb_OtherPartyRealName.TabIndex = 5;
            // 
            // tb_OtherPartyUserName
            // 
            this.tb_OtherPartyUserName.Enabled = false;
            this.tb_OtherPartyUserName.Location = new System.Drawing.Point(88, 52);
            this.tb_OtherPartyUserName.Name = "tb_OtherPartyUserName";
            this.tb_OtherPartyUserName.ReadOnly = true;
            this.tb_OtherPartyUserName.Size = new System.Drawing.Size(278, 20);
            this.tb_OtherPartyUserName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Note:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Country: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Real name:";
            // 
            // callTimer
            // 
            this.callTimer.Interval = 1000;
            this.callTimer.Tick += new System.EventHandler(this.callTimer_Tick);
            // 
            // FormCallAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCallAssistant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Assistant";
            this.Load += new System.EventHandler(this.form_CallAssistant_Load);
            this.Shown += new System.EventHandler(this.FormCallAssistant_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Display;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_DomainHost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_HangUp;
        private System.Windows.Forms.Button btn_PickUp;
        private System.Windows.Forms.TextBox tb_OtherPartyCountry;
        private System.Windows.Forms.TextBox tb_OtherPartyRealName;
        private System.Windows.Forms.TextBox tb_OtherPartyUserName;
        private System.Windows.Forms.TextBox tb_OtherPartyNote;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_CallState;
        private System.Windows.Forms.Button btn_Transfer;
        private System.Windows.Forms.Button btn_Hold;
        private System.Windows.Forms.Timer callTimer;
        private System.Windows.Forms.Label labelCallTimer;
    }
}

