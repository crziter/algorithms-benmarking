using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo;

namespace Fibo_TrucTiep
{
    public class Fibo: Algorithm
    {
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

        public Fibo()
        {
            Info = new AlgorithmInformations();

            Info.DauRa = "Số fibonacy thứ n";
            Info.DauVao = "Số n";
            Info.GhiChu = "Không có";
            Info.Kieu = "Trực tiếp - vét cạn";
            Info.Chuong = "Chương 5";
            Info.PhienBan = "0.0.1";
            Info.TacGia = "Bình Nguyên";
            Info.TenThuatToan = "Fibonacy";
            Info.TheLoai = "Không biết";
            Info.XuLi = "Tính số fibonacy thứ n";
        }

        public bool GenerateInput(int n, Output output)
        {
            output.Write(n);
            return true;
        }

        private long rs = -1;
        private int n = -1;
        
        private long fibo(int i)
        {
            if (i == 1 || i == 2) return 1;
            else return fibo(i - 1) + fibo(i - 2);
        }

        public bool Performance()
        {
            if (n == -1) return false;
            else rs = fibo(n);

            return true;
        }

        public bool PrepareInput()
        {
            try
            {
                n = Input.NextInt();
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }

            return true;
        }

        public bool PrintOutput()
        {
            if (rs != -1)
            {
                Output.Write(rs);
                return true;
            }
            else return false;
        }
    }
}
