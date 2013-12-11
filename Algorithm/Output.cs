using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Output
    {
        private StringBuilder str = null;

        public Output()
        {

        }
        public String GetAllAsString()
        {
            if (str != null) return str.ToString();
            return "";
        }

        public void WriteLine()
        {
            if (str != null) str.Append("\r\n");
            else str = new StringBuilder("\r\n");
        }

        public void WriteLine(int i)
        {
            if (str != null) str.Append("" + i + "\r\n");
            else str = new StringBuilder("" + i + "\r\n");
        }

        public void Write(long i)
        {
            if (str != null) str.Append("" + i);
            else str = new StringBuilder(i.ToString());
        }

        public void Write(int i)
        {
            if (str != null) str.Append("" + i);
            else str = new StringBuilder(i.ToString());
        }

        public void WriteLine(String ostr)
        {
            if (str != null) str.Append(ostr + "\r\n");
            else str = new StringBuilder(ostr + "\r\n");
        }

        public void Write(String ostr)
        {
            if (str != null) str.Append(ostr);
            else str = new StringBuilder(ostr);
        }
    }
}
