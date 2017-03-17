using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGGEA
{
    public interface ILogin
    {
        bool ValidarLogin(string username, string password);
    }
}
