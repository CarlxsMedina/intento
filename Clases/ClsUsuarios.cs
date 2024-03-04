using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ejemplo.Clases
{
    internal class ClsUsuarios
    {
        private int userId;
        private string userName;
        private string userPassword;
        private string userRol;

        public ClsUsuarios()
        {

        }

        public ClsUsuarios(int userId, string userName, string userPassword, string userRol)
        {
            this.userId = userId;
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRol = userRol;
        }

        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserRol { get => userRol; set => userRol = value; }


    }
}
