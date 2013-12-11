using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo;

namespace TinhTongS
{
    public class TinhTongS : Algorithm
    {
        public AlgorithmInformations Info { get; set; }
        public Input Input { get; set; }
        public Output Output { get; set; }

        private int n = 0;
        private int s = 0;

        public TinhTongS()
        {
            Info = new AlgorithmInformations();

            Info.DauRa = "Tổng S = 1^2 + 2^2 + 3^2 + ... + n^2";
            Info.DauVao = "Số n";
            Info.GhiChu = "Không có";
            Info.Kieu = "Trực tiếp - vét cạn";
            Info.Chuong = "Chương 2";
            Info.PhienBan = "0.0.1";
            Info.TacGia = "Bình Nguyên";
            Info.TenThuatToan = "Tính tổng S";
            Info.TheLoai = "Không biết";
            Info.XuLi = "Tính tổng S = 1^2 + 2^2 + 3^2 + ... + n^2";
        }
        public bool GenerateInput(int n, Output output)
        {
            output.Write(n);
            return true;
        }

        public bool Performance()
        {
            for (int i = 1; i <= n; ++i)
            {
                s += (i * i);
            }

            return true;
        }

        public bool PrepareInput()
        {
            n = Input.NextInt();
            s = 0;
            return true;
        }

        public bool PrintOutput()
        {
            Output.Write(s);
            return true;
        }
    }
}
