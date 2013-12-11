using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo;

namespace HeapSort
{
    public class HeapSort: Algorithm
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
        private int[] r;
        public HeapSort()
        {
            rand = new Random();

            Info = new AlgorithmInformations();

            Info.DauRa = "Mảng đã sắp xếp";
            Info.DauVao = "Mảng số nguyên";
            Info.GhiChu = "Định dạng đầu vào: [số lượng phần tử] danh-sách-các-phần-tử";
            Info.Kieu = "Biến đổi để trị";
            Info.Chuong = "Chương 4";
            Info.PhienBan = "0.0.1";
            Info.TacGia = "Bình Nguyên";
            Info.TenThuatToan = "Heapsort";
            Info.TheLoai = "Sắp xếp";
            Info.XuLi = "Sắp xếp mảng theo thuật toán trộn";
        }

        public bool GenerateInput(int n, Output output)
        {
            output.Write(n + " ");
            for (int i = 0; i < n; ++i)
            {
                output.Write(rand.Next(n) + " ");
            }

            return true;
        }

        public static void Heapsort(int[] array)
        {
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                RepairTop(array, array.Length - 1, i);
            }
            for (int i = array.Length - 1; i > 0; i--)
            {
                Swap(array, 0, i);
                RepairTop(array, i - 1, 0);
            }
        }

        private static void RepairTop(int[] array, int bottom, int topIndex)
        {
            int tmp = array[topIndex];
            int succ = topIndex * 2 + 1;
            if (succ < bottom && array[succ] > array[succ + 1]) succ++;

            while (succ <= bottom && tmp > array[succ])
            {
                array[topIndex] = array[succ];
                topIndex = succ;
                succ = succ * 2 + 1;
                if (succ < bottom && array[succ] > array[succ + 1]) succ++;
            }
            array[topIndex] = tmp;
        }

        private static void Swap(int[] array, int left, int right)
        {
            int tmp = array[right];
            array[right] = array[left];
            array[left] = tmp;
        }


        public bool Performance()
        {
            Heapsort(r);
            return true;
        }

        public bool PrepareInput()
        {
            try
            {
                n = Input.NextInt();
            }
            catch (FormatException ex)
            {
                ex.ToString();
                return false;
            }

            r = new int[n];
            for (int i = 0; i < n; ++i)
            {
                try
                {
                    r[i] = Input.NextInt();
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
            for (int i = r.Length - 1; i >= 0; --i)
            {
                Output.Write(r[i] + " ");
            }

            return true;
        }
    }
}
