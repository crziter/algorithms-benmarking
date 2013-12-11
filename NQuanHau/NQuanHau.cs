using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo;

namespace NQuanHau
{
    public class NQuanHau:Algorithm
    {
        public AlgorithmInformations Info { get; set; }
        public Input Input { get; set; }
        public Output Output { get; set; }

        private int n;
        private bool[] cot;
        private bool[] cheo_trai;
        private bool[] cheo_phai;

        private int[] kq_cot;

        public NQuanHau()
        {
            Info = new AlgorithmInformations();

            Info.DauRa = "Các vị trí của n quân hậu";
            Info.DauVao = "Số n";
            Info.GhiChu = "Không có";
            Info.Kieu = "Quay lui";
            Info.Chuong = "Chương 7";
            Info.PhienBan = "0.0.1";
            Info.TacGia = "Bình Nguyên";
            Info.TenThuatToan = "N quân hậu";
            Info.TheLoai = "Không biết";
            Info.XuLi = "Đặt các vị trí quân hậu trên bàn cờ sao cho không ăn được nhau";
        }

        public bool GenerateInput(int n, Output output)
        {
            output.Write(n);
            return true;
        }

        private List<string> lstViTri;
        // i: dong
        private void PutQeen(int i)
        {
            if (i == n)
            {
                StringBuilder sb = new StringBuilder();
                for (int k = 0; k < n; k++)
                {
                    sb.Append("[" + k + "," + kq_cot[k] + "] ");
                }
                lstViTri.Add(sb.ToString());
            }
            else
            {
                //dong[i] = true;
                for (int j = 0; j < n; j++)
                {
                    if (cot[j] == false && cheo_phai[i + j] == false && cheo_trai[i + n - 1 - j] == false)
                    {
                        cot[j] = true;
                        cheo_phai[i + j] = true;
                        cheo_trai[i + n - 1 - j] = true;

                        kq_cot[i] = j;
                        PutQeen(i + 1);

                        cot[j] = false;
                        cheo_phai[i + j] = false;
                        cheo_trai[i + n - 1 - j] = false;
                    }
                }
                //dong[i] = false;
            }
        }

        public bool Performance()
        {
            // Khoi tao
            this.cot = new bool[this.n];
            this.cheo_phai = new bool[this.n * 2 - 1];
            this.cheo_trai = new bool[this.n * 2 - 1];
            this.kq_cot = new int[this.n];

            for (int i = 0; i < n; ++i)
                this.cot[i] = false;

            for (int j = 0; j < n * 2 - 1; ++j)
            {
                this.cheo_phai[j] = false;
                this.cheo_trai[j] = false;
            }

            lstViTri = new List<string>();
            PutQeen(0);
            return true;
        }

        public bool PrepareInput()
        {
            this.n = Input.NextInt();
            return true;
        }

        public bool PrintOutput()
        {
            int i = 1;
            foreach (var vt in lstViTri)
            {
                Output.WriteLine(i + ". " + vt);
                i++;
            }

            return true;
        }
    }
}
