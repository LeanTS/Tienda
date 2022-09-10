using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Inicio
    {
        int User;

        public object Ingreso(bool user,
                              bool password)
        {
            if (user == true && password == true)
            {
                User = 2;
                return User;
            }
            else if (user == true && password == false)
            {
                User = 1;
                return User;
            }
            else if (user == false && password == false)
            {
                User = 0;
                return User;
            }
            else
            {
                User = 0;
                return User;
            }

        }
    }
}
