using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    class Commands
    {
        public const string Login = "LOGIN";
        /// Username
        /// Password

        public const string AutoLogin = "LOGIN_AUTO";
        /// Username
        /// Password

        public const string Register = "REGISTER";
        ///Username
        ///Password
        ///Email
        ///Name
        ///Lastname

        public const string LoginOK = "LOGIN_OK";

        public static string createPacket(string command, List<string> list)
        {
            command += "|" + string.Join("|", list);
            return command;
        }
    }
}
