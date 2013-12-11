using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo;

namespace CapDiemGanNhat
{
    internal class Diem
    {
        public int x;
        public int y;
    }

    public class CapDiemGanNhat: Algorithm
    {
        public AlgorithmInformations Info { get; set; }
        public Input Input { get; set; }
        public Output Output { get; set; }

        private Random rand;
        private int n;
        private Diem[] arr;
        private Diem d1 = null;
        private Diem d2 = null;
        private double minDistance;
        public CapDiemGanNhat()
        {
            rand = new Random();

            Info = new AlgorithmInformations();

            Info.DauRa = "Cặp điểm có khoảng cách gần nhau nhất";
            Info.DauVao = "Các điểm trên hệ tọa độ đề các";
            Info.GhiChu = "Số đầu tiên là số điểm, n cặp số tiếp theo là tọa độ của điểm theo định dạng: (x,y)";
            Info.Kieu = "Trực tiếp - vét cạn";
            Info.Chuong = "Chương 2";
            Info.PhienBan = "0.0.1";
            Info.TacGia = "Bình Nguyên";
            Info.TenThuatToan = "Tìm cặp điểm gần nhất";
            Info.TheLoai = "Không biết";
            Info.XuLi = "Tìm ra cặp điểm có khoảng cách gần nhau nhất";
        }

        public bool GenerateInput(int n, Output output)
        {
            output.Write(n + " ");

            for (int i = 0; i < n; ++i)
            {
                output.Write("(" + rand.Next(n) + "," + rand.Next(n) + ") ");
            }

            return true;
        }

        private double d(Diem d1, Diem d2)
        {
            return Math.Sqrt(Math.Pow(d1.x - d2.x, 2) + Math.Pow(d1.y - d2.y, 2));
        }

        public bool Performance()
        {
            minDistance = double.MaxValue;
            double tmpd;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == j) continue;

                    tmpd = d(arr[i], arr[j]);
                    if (tmpd < minDistance)
                    {
                        minDistance = tmpd;
                        d1 = arr[i];
                        d2 = arr[j];
                    }
                }
            }

            return true;
        }

        public bool PrepareInput()
        {
            n = Input.NextInt();
            if (n < 2) return false;

            arr = new Diem[n];
            for (int i = 0; i < n; ++i)
            {
                arr[i] = new Diem();

                string diem = Input.NextPoint();
                if (diem == null) return false;
                string[] diems = diem.Split(',');
                arr[i].x = int.Parse(diems[0]);
                arr[i].y = int.Parse(diems[1]);
            }
                
            return true;
        }

        public bool PrintOutput()
        {
            Output.Write("Điểm ngắn nhất là: (" + d2.x + "," + d2.y + ") và (" + d1.x + "," + d1.y + ") với khoảng cách " + minDistance);
            return true;
        }
    }
}
