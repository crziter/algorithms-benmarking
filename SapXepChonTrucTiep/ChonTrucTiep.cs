using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo;

namespace SapXepChonTrucTiep
{
    public class ChonTrucTiep: Algorithm
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

        private Random rand;
        private int n;
        private int[] arr;

        public ChonTrucTiep()
        {
            Info = new AlgorithmInformations();

            Info.DauRa = "Dãy đã sắp xếp tăng dần";
            Info.DauVao = "[Số phần tử] Dãy các phần tử";
            Info.GhiChu = "Các số đầu vào ghi cách nhau một khoảng trắng ví dụ: 3 0 5 2 1";
            Info.Kieu = "Trực tiếp - vét cạn";
            Info.Chuong = "Chương 2";
            Info.PhienBan = "0.0.1";
            Info.TacGia = "Bình Nguyên";
            Info.TenThuatToan = "Sắp xếp chọn trực tiếp";
            Info.TheLoai = "Sắp xếp";
            Info.XuLi = "Sắp xếp một chuỗi các số tăng dần";

            rand = new Random();
        }

        public bool GenerateInput(int n, Output output)
        {
            output.Write(n + " ");

            for (int i = 0; i < n; ++i)
            {
                output.Write(rand.Next(100000) + " ");
            }

            return true;
        }

        public bool Performance()
        {
            int min;
            int min_idx;

            for (int i = 0; i < n; ++i)
            {
                min = arr[i];
                min_idx = i;

                for (int j = i+1; j < n; ++j)
                {
                    if (min > arr[j])
                    {
                        min = arr[j];
                        min_idx = j;
                    }
                }

                // Swap
                int tmp = arr[i];
                arr[i] = arr[min_idx];
                arr[min_idx] = tmp;
            }

            return true;
        }

        public bool PrepareInput()
        {
            n = Input.NextInt();
            arr = new int[n];

            for (int i = 0; i < n; ++i)
            {
                try
                {
                    arr[i] = Input.NextInt();
                }
                catch (FormatException ex)
                {
                    ex.ToString();
                    return false;
                }
            }

            return true;
        }

        public bool PrintOutput()
        {
            for (int i = 0; i < n; ++i)
            {
                Output.Write(arr[i] + " ");
            }

            return true;
        }
    }
}
