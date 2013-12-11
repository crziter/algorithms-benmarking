using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Input
    {
        private StreamReader _strReader = null;

        public Input()
        {
        }

        public void FromOutput(Output output)
        {
            _strReader = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(output.GetAllAsString())));
        }
        public void FromString(String frmstr)
        {
            _strReader = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(frmstr)));
        }

        public string NextWord()
        {
            int c;
            StringBuilder str = new StringBuilder();
            while (true)
            {
                /* c = _strReader.Peek();
                if (c == ',' || c==')')
                {
                    break;
                } */

                c = _strReader.Read();
                if (c == -1)
                {
                    if (str.Length > 0) return str.ToString();
                    return null;
                }

                if (c == ' ' || c == '\n' || c == '\t'  || c=='\r' || c==',' || c==')')
                {
                    if (str.Length > 0) break;
                }
                else
                {
                    str.Append((char) c);
                }
            }

            return str.ToString();
        }

        public string NextLine()
        {
            return _strReader.ReadLine();
        }

        /**
         * Hàm này sẽ trả về số nguyên tiếp theo và 1 exception (Format) nếu không có số 
         * Chú ý: abc124sdf sẽ trả về 124 mà không có lỗi
         */
        public int NextInt()
        {
            String word = NextWord();
            int si = -1, ei = -1;

            for (int i = 0; i < word.Length; ++i)
            {
                if (word[i] >= '0' && word[i] <= '9')
                {
                    if (si == -1) si = i;
                }
                else
                {
                    if (si > -1)
                    {
                        ei = i;
                        break;
                    }
                }
            }

            if (si == -1) throw new FormatException();
            if (ei == -1) ei = word.Length;
            return Int32.Parse(word.Substring(si, ei-si));
        }

        // Trả về điểm tiếp theo theo định dạng x,y
        public string NextPoint()
        {
            int step = 0; // get (
            int c;
            StringBuilder rs = new StringBuilder();

            do
            {
                switch (step)
                {
                    case 0: // get (
                        c = _strReader.Read();
                        if (c == -1) return null;
                        if (c == '(')
                            step++;
                        break;

                    case 1: // Get X
                        int x = NextInt();
                        rs.Append(x + ",");
                        step++;
                        break;

                    case 2: // Get y
                        int y = NextInt();
                        rs.Append(y + "");
                        return rs.ToString();
                }
            } while (true);
        }
    }
}
