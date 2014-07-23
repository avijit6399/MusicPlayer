using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace MusicPlayer_1._0.classes
{
    class DBClass
    {
        public static Boolean isLoginSuccessful(string userName, string userPassword)
        {
            Boolean isLoginDone = false;
            OracleConnection con = new OracleConnection(Config.DB_CON_STR);
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from UserMaster where userName = :userName and userPassword = :userPassword";           
            
            //Adding oracle parameter to avoid sql injection
            cmd.Parameters.Add( new OracleParameter("userName", userName));
            cmd.Parameters.Add(new OracleParameter("userPassword", userPassword));
            
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while(reader.Read()){
                    Config.USER_ID_NO = Convert.ToInt16(reader["UserIdNumber"]);
                    Config.USER_NAME = Convert.ToString(reader["UserName"]);
                    isLoginDone = true;
                }
                    
            }

            reader.Close();
            con.Close();

            return isLoginDone;
        }

        public static void updateMediaListFromDB(List<Medias> mediaList, Int16 userIdNumber)
        {
            OracleConnection con = new OracleConnection(Config.DB_CON_STR);
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from SongMaster where UserIdNumber = :userIdNumber order by SongId";
            cmd.Parameters.Add(new OracleParameter("userIdNumber", userIdNumber));
            OracleDataReader reader = cmd.ExecuteReader();

            int countMediaList = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    countMediaList = mediaList.Count;
                    countMediaList += 1; //Incrementing the count
                    mediaList.Add(new Medias(countMediaList + ". " + reader["fileName"].ToString(), reader["fileName"].ToString(), reader["filePath"].ToString()));
                }

            }
            reader.Close();
            con.Close();

        }

        public static void insertMediaIntoDB(List<Medias> mediaList)
        {
            OracleConnection con = new OracleConnection(Config.DB_CON_STR);
            con.Open();

            //Delete all songs related to User
            OracleCommand cmdForDelete = con.CreateCommand();
            cmdForDelete.CommandText = "Delete SongMaster where UserIdNumber = :userIdNumber";
            cmdForDelete.Parameters.Add(new OracleParameter("userIdNumber", Config.USER_ID_NO));
            int a=cmdForDelete.ExecuteNonQuery();
            cmdForDelete.Dispose();

            
            int count = mediaList.Count;

            for (int i = 0; i <= count - 1; i++)
            {
                //increment += 1;
                //mediaList[i].fileNameNumber = increment + ". " + mediaList[i].fileName;
                OracleCommand cmdForInsert = con.CreateCommand();
                cmdForInsert.CommandText = "Insert into SongMaster (UserIdNumber, FileName, FilePath) values ( :userIdNumber , :fileName , :filePath )";
                cmdForInsert.Parameters.Add(new OracleParameter("userIdNumber", Config.USER_ID_NO));
                cmdForInsert.Parameters.Add(new OracleParameter("fileName", mediaList[i].fileName));
                cmdForInsert.Parameters.Add(new OracleParameter("filePath", mediaList[i].fileFullPath));
                int b = cmdForInsert.ExecuteNonQuery();
                cmdForInsert.Dispose();
            } 
            con.Close();
        }

        public static string updatePassword(String oldPassword, string newPassword)
        {
            String oldPasswordFromDb = "null";

            OracleConnection con = new OracleConnection(Config.DB_CON_STR);
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select USERPASSWORD from UserMaster where UserIdNumber = :userIdNumber";

            //Adding oracle parameter to avoid sql injection
            cmd.Parameters.Add(new OracleParameter("userIdNumber", Config.USER_ID_NO));

            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    oldPasswordFromDb = Convert.ToString(reader["USERPASSWORD"]);
                }

                if (oldPasswordFromDb.Equals(oldPassword))
                {
                    //Update the new password
                    OracleCommand cmdForUpdate = con.CreateCommand();
                    cmdForUpdate.CommandText = "Update UserMaster set UserPassword = :UserPassword where UserIdNumber = :userIdNumber";
                    cmdForUpdate.Parameters.Add(new OracleParameter("UserPassword", newPassword));
                    cmdForUpdate.Parameters.Add(new OracleParameter("userIdNumber", Config.USER_ID_NO));
                    int b = cmdForUpdate.ExecuteNonQuery();
                    cmdForUpdate.Dispose();
                    con.Close();

                    return "Password successfully updated";

                }
                else
                {
                    return "Old password is not correct";
                }

            }
            else //No User found
            {
                return "User not found";
            }
            
        }

        
        public static void getAllUserList(List<User> userList)
        {
            OracleConnection con = new OracleConnection(Config.DB_CON_STR);
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from UserMaster where UserName != 'admin'";
            OracleDataReader reader = cmd.ExecuteReader();

            //Remove all user from List
            userList.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userList.Add(new User(reader["userIdNumber"].ToString(), reader["userName"].ToString()));
                }

            }

            reader.Close();
            con.Close();
        }

        public static String insertUser(String userName, String userPassword)
        {
            OracleConnection con = new OracleConnection(Config.DB_CON_STR);
            con.Open();

            //Checking duplicate UserName
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from UserMaster where userName = :userName";

            //Adding oracle parameter to avoid sql injection
            cmd.Parameters.Add(new OracleParameter("userName", userName));
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                con.Close();
                return "User already exists. Please try with a new UserName.";
            }
            else
            {
                OracleCommand cmdForInsert = con.CreateCommand();
                cmdForInsert.CommandText = "Insert into UserMaster (UserName, UserPassword) values ( :userName , :userPassword )";
                cmdForInsert.Parameters.Add(new OracleParameter("userName", userName));
                cmdForInsert.Parameters.Add(new OracleParameter("userPassword", userPassword));
                int b = cmdForInsert.ExecuteNonQuery();
                cmdForInsert.Dispose();
                con.Close();

                return "User sucessfully added.";
            }
        }
        
    }
}
