using Algo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemTuyenTinh
{
    public class TimKiemTuyenTinh: Algorithm
    {
        private int n;
        private int[] arr;
        private int k;
        private int k_i;

        public Input Input { get; set; }
        public Output Output { get; set; }
        public AlgorithmInformations Info { get; set; }

        public TimKiemTuyenTinh()
        {
            Info = new AlgorithmInformations();

            Info.DauRa = "Chỉ số đầu tiên của phần tử muốn tìm nếu có, nếu không có thì in ra \"Không có\"";
            Info.DauVao = "Số n, n số nguyên, số muốn tìm";
            Info.GhiChu = "Các số đầu vào ghi cách nhau một khoảng trắng ví dụ: 3 1 5 2 1 nghĩa là có 3 số 1 5 2 và tìm số 1";
            Info.Kieu = "Trực tiếp - vét cạn";
            Info.Chuong = "Chương 2";
            Info.PhienBan = "0.0.2";
            Info.TacGia = "Bình Nguyên";
            Info.TenThuatToan = "Tìm kiếm tuyến tính";
            Info.TheLoai = "Tìm kiếm";
            Info.XuLi = "Tìm kiếm một số theo tuần tự";

            k_i = -1;
        }

        public Boolean PrepareInput()
        {
            n = Input.NextInt();
            arr = new int[n];

            for (int i = 0; i < n; ++i)
            {
                arr[i] = Input.NextInt();
            }

            k = Input.NextInt();
            k_i = -1;
            return true;
        }

        public Boolean Performance()
        {
            for (int i = 0; i < n; ++i)
            {
                if (arr[i] == k)
                {
                    k_i = i;
                    break;
                }
            }
                return true;
        }

        public Boolean PrintOutput()
        {
            if (k_i != -1)
            {
                Output.Write("Tìm được số " + k + " ở vị trí " + k_i);
            }
            else
            {
                Output.Write("Không có số " + k + " trong mảng đã cho");
            }

            return true;
        }

        /**
         * Khởi tạo đầu vào
         */
        public Boolean GenerateInput(int n, Output output)
        {
            output.Write(n + " ");

            int[] ar = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; ++i)
            {
                ar[i] = rand.Next(1000);
                output.Write("" + ar[i] + " ");
            }

            output.Write(ar[rand.Next(n-1)]);
            
            return true;
        }
    }
}
