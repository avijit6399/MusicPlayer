using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicPlayer_1._0.classes
{
    public class User
    {
        public String userIdNumber { get; set; }
        public String userName { get; set; }
       
        public User(String userIdNumber, String userName)
        {
            this.userIdNumber = userIdNumber;
            this.userName = userName;
        }
    }
}
