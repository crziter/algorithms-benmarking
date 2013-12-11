using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo;
using System.Numerics;

namespace Fibo_BienDoi
{
    public class Fibo : Algorithm
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
            Info.Kieu = "Biến đổi để trị";
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

        private BigInteger rs = BigInteger.Negate(BigInteger.MinusOne);
        private int n = -1;

        private BigInteger fibo(int n)
        {
            BigInteger[,] F = new BigInteger[2, 2] { { 1, 1 }, { 1, 0 } };
            if (n == 0)
                return 0;
            power(F, n - 1);

            return F[0, 0];
        }

        private void multiply(BigInteger[,] F, BigInteger[,] M)
        {
            BigInteger x = F[0, 0] * M[0, 0] + F[0, 1] * M[1, 0];
            BigInteger y = F[0, 0] * M[0, 1] + F[0, 1] * M[1, 1];
            BigInteger z = F[1, 0] * M[0, 0] + F[1, 1] * M[1, 0];
            BigInteger w = F[1, 0] * M[0, 1] + F[1, 1] * M[1, 1];

            F[0, 0] = x;
            F[0, 1] = y;
            F[1, 0] = z;
            F[1, 1] = w;
        }

        private void power(BigInteger[,] F, long n)
        {
            int i;
            BigInteger[,] M = new BigInteger[2, 2] { { 1, 1 }, { 1, 0 } };

            for (i = 1; i < n; i++)
                multiply(F, M);
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
                Output.Write(rs.ToString());
                return true;
            }
            else return false;
        }
    }
}
