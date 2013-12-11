using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo;

namespace TrungChuoiKiTu
{
    public class TrungChuoiKiTu: Algorithm
    {
        private Random rand;
        private string str1;
        private string str2;
        private int idx = -1;

        public AlgorithmInformations Info
        {
            get;
            set;
        }

        public Input Input
        {
            get;
            set;
        }

        public Output Output
        {
            get;
            set;
        }

        public TrungChuoiKiTu()
        {
            rand = new Random();

            Info = new AlgorithmInformations();

            Info.DauRa = "Những đoạn text trùng";
            Info.DauVao = "Hai chuỗi văn bản";
            Info.GhiChu = "Chuỗi dưới ngắn hơn chuỗi trên";
            Info.Kieu = "Trực tiếp - vét cạn";
            Info.Chuong = "Chương 2";
            Info.PhienBan = "0.0.1";
            Info.TacGia = "Bình Nguyên";
            Info.TenThuatToan = "Trùng mẫu của chuỗi kí tự";
            Info.TheLoai = "Không biết";
            Info.XuLi = "Tìm và in ra những đoạn chuỗi trùng";
        }

        public bool GenerateInput(int n, Output output)
        {
            StringBuilder sb = new StringBuilder();
            if (n <= 0) return false;

            for (int i = 0; i < n; ++i)
            {
                sb.Append((char)(rand.Next(94) + 32));
            }

            output.WriteLine(sb.ToString());

            sb = new StringBuilder();
            for (int i = 0; i < rand.Next(n-1) + 1; ++i)
            {
                sb.Append((char)(rand.Next(94) + 32));
            }

            output.WriteLine(sb.ToString());
            return true;
        }

        public bool Performance()
        {
            int i = 0;
            while(i < str1.Length)
            {
                if (str1[i] == str2[0])
                {
                    int j = 1;
                    idx = i;
                    while (j < str2.Length)
                    {
                        if (str1[i + j] != str2[j]) break;
                        j++;
                    }
                    if (j == str2.Length)
                    {
                        return true;
                    }
                }

                i++;
            }
            idx = -1;
            return true;
        }

        public bool PrepareInput()
        {
            str1 = Input.NextLine();
            str2 = Input.NextLine();
            return true;
        }

        public bool PrintOutput()
        {
            if (idx == -1)
            {
                Output.WriteLine("Không tìm thấy");
            }
            else
            {
                Output.WriteLine("Vị trí: " + idx);
            }
            return true;
        }
    }
}
