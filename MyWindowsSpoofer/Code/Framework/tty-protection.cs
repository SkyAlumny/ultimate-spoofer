using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace spoofer
{
    class tty_protection
    {
        internal bool isStartedAsAdmin()
        {
            var userID = WindowsIdentity.GetCurrent();
            if (userID == null)
            {
                // NOT STARTED AS ADMIN
                return false;
            }

            var wP = new WindowsPrincipal(userID);
            return wP.IsInRole(WindowsBuiltInRole.Administrator);
        }

        internal bool Authenticated()
        {
            return true;
        }

        internal bool executeProtection()
        {
            return true;
        }

        internal void SecureStringInMemory(string pln)
        {
            using (SecureString secrStr = new SecureString())
            {
                byte[] bytes = Encoding.Unicode.GetBytes(pln);
                IntPtr ptr = Marshal.AllocHGlobal(bytes.Length);
                Marshal.Copy(bytes, 0, ptr, bytes.Length);
                char[] chars = new char[pln.Length];
                Marshal.Copy(ptr, chars, 0, pln.Length);
                pln = null;
                foreach (char c in chars)
                {
                    secrStr.AppendChar(c);
                }
                secrStr.MakeReadOnly();
            }
        }

    }
}
