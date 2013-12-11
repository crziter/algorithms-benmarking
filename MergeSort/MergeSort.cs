using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo;

namespace MergeSort
{
    public class MergeSort: Algorithm
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
        public MergeSort()
        {
            rand = new Random();

            Info = new AlgorithmInformations();

            Info.DauRa = "Mảng đã sắp xếp";
            Info.DauVao = "Mảng số nguyên";
            Info.GhiChu = "Định dạng đầu vào: [số lượng phần tử] danh-sách-các-phần-tử";
            Info.Kieu = "Chia để trị";
            Info.Chuong = "Chương 3";
            Info.PhienBan = "0.0.1";
            Info.TacGia = "Bình Nguyên";
            Info.TenThuatToan = "Sắp xếp trộn";
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

        public void Merge_Sort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Merge_Sort(input, left, middle);
                Merge_Sort(input, middle + 1, right);

                //Merge
                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(input, left, leftArray, 0, middle - left + 1);
                Array.Copy(input, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                for (int k = left; k < right + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                }
            }
        }

        public bool Performance()
        {
            Merge_Sort(arr, 0, arr.Length - 1);
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
            foreach (int i in arr)
            {
                Output.Write(i + " ");
            }

            return true;
        }
    }
}
