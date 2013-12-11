using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo;

namespace HoanVi
{
    public class HoanVi: Algorithm
    {
        public AlgorithmInformations Info { get; set; }
        public Input Input { get; set; }
        public Output Output { get; set; }

        private Random rand;
        private int n;
        private int k;
        private int[] arr;
        private bool[] used;
        public HoanVi()
        {
            Info = new AlgorithmInformations();
            rand = new Random();

            Info.DauRa = "Chỉnh hợp chập k của n phần tử";
            Info.DauVao = "Số n và n phần tử của tập hợp";
            Info.GhiChu = "Hai số đầu tiên là n và k (k<n), n số tiếp theo là các phần tử của tập hợp. Ví dụ:\r\n\r\n5 3 1 2 3 4 5";
            Info.Kieu = "Quay lui";
            Info.Chuong = "Chương 7";
            Info.PhienBan = "0.0.1";
            Info.TacGia = "Bình Nguyên";
            Info.TenThuatToan = "Hoán vị k phần tử của n";
            Info.TheLoai = "Không biết";
            Info.XuLi = "Tìm các hoán vị k phần tử của tập hợp n phần tử";
        }

        public bool GenerateInput(int n, Output output)
        {
            output.Write(n + " ");
            int k = rand.Next(n - 1) + 1;
            output.Write(k + " ");

            for (int i = 0; i < n; ++i)
            {
                output.Write((i + 1) + " ");
            }
                return true;
        }

        private List<string> result;
        private int[] rs;
        private void TimHoanVi(int i)
        {
            if (i == k)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < k; ++j)
                    sb.Append(rs[j] + " ");

                result.Add(sb.ToString());
            }
            else
            {
                for (int j = 0; j < n; ++j)
                {
                    if (!used[j])
                    {
                        used[j] = true;
                        rs[i] = arr[j];
                        TimHoanVi(i + 1);
                        used[j] = false;
                    }
                }
            }
        }

        public bool Performance()
        {
            result = new List<string>();
            rs = new int[k];

            TimHoanVi(0);

            return true;
        }

        public bool PrepareInput()
        {
            n = Input.NextInt();
            k = Input.NextInt();

            arr = new int[n];
            for (int i = 0; i < n; ++i)
            {
                arr[i] = Input.NextInt();
            }

            used = new bool[n];
            return true;
        }

        public bool PrintOutput()
        {
            int i = 1;
            foreach (var rs in result)
            {
                Output.WriteLine(i + ". " + rs);
                i++;
            }
            
            return true;
        }
    }
}
