using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_modul_7
{
    class Array : IOutput, IMath, ISort
    {
       private int[] arr;

       public Array(int[] arr)
        {
            this.arr = arr;
        }

        public float Avg()
        {
            int sum = arr.Sum();
            float avg = (float)sum / (float)arr.Length;
            return avg;
        }

        public int Max()
        {
            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public int Min()
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if  (valueToSearch == arr[i])
                {
                    return true;
                }
            }
            return false;
        }

        public void Show()
        {
            foreach( int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
       public void Show(string info)
        {
            Console.WriteLine(info);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public void SortAsc()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length - i - 1; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        int tmp = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k + 1] = tmp;
                    }

                }
            }
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

        public void SortDesc()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length - i - 1; k++)
                {
                    if (arr[k] < arr[k+1])
                    {
                        int tmp = arr[k];
                        arr[k] = arr[k+1];
                        arr[k+1] = tmp;
                    }

                }
            }
        }
    }
}
