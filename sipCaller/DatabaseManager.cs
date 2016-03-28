using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sipCaller
{
    class DatabaseManager
    {
        string _connectionString;
        SqlConnection _connection;

        public DatabaseManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            _connection = new SqlConnection(_connectionString);

            OpenConnection();
            TestAdder();
        }

        public void AddUserInfo(UserInfo userInfo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO UserInfos (UserName, RealName, Country, Note) values ('" + userInfo.UserName + "', '" + userInfo.RealName + "', '" + userInfo.Country + "', '" + userInfo.Note + "')";
                command.ExecuteNonQuery();
            }
        }

        void OpenConnection()
        {
            try
            {
                _connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public UserInfo GetOtherPartyInfos(string userName)
        {
            UserInfo userInfo;

            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM UserInfos WHERE Username = '" + userName + "'";

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        var realName = reader["RealName"].ToString();
                        var country = reader["Country"].ToString();
                        var note = reader["Note"].ToString();

                        userInfo = new UserInfo(userName, realName, country, note);

                        return userInfo;
                    }
                }
            }

            userInfo = new UserInfo("userName", "N/A", "N/A", "N/A");
            return userInfo;
        }

        void TestAdder()
        {
            UserInfo userInfo;
            userInfo = new UserInfo("1001", "First User", "Hungary", "Only a user with no creative note.");
            AddUserInfo(userInfo);

            userInfo = new UserInfo("1002", "Second User", "England", "User from far-far away, still with no creative note.");
            AddUserInfo(userInfo);

            userInfo = new UserInfo("1003", "Third User", "Chile", "User who can bring us cherries.");
            AddUserInfo(userInfo);
        }
    }
}
