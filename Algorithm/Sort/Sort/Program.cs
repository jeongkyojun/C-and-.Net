using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            List<int> lists = new List<int>();
            List<int> res = new List<int>();
            Random r = new Random();
            int n = r.Next(10, 20);
            for(int i = 0; i < n; i++)
            {
                lists.Add(r.Next(1, 100));
                res.Add(lists[i]);
            }

            Console.WriteLine("before");
            for (int i = 0; i < n; i++)
            {
                Console.Write(lists[i] + " ");
            }
            Console.WriteLine();

            //MergeSort(0, n - 1, ref lists, ref res);
            QuickSort(0, n-1 , ref res);

            Console.WriteLine("after");
            for (int i = 0; i < n; i++)
            {
                Console.Write(res[i] + " ");
            }
            Console.WriteLine();
        }

        static void QuickSort(int low, int high, ref List<int> lists)
        {
            if (low >= high) return;
            int pivot = low;
            int j = low;
            int tmp;
            for (int i=low+1;i<=high;i++)
            {
                if (lists[pivot] >= lists[i])
                {
                    Console.Write("# ");
                    tmp = lists[i];
                    lists[i] = lists[++j];
                    lists[j] = tmp;
                }
            }
            tmp = lists[j];
            lists[j] = lists[pivot];
            lists[pivot] = tmp;
            for (int i = 0; i < lists.Count(); i++)
            {
                Console.Write(lists[i] + " ");
            }
            Console.WriteLine();
            QuickSort(low, j-1, ref lists);
            QuickSort(j+1, high, ref lists);
        }


        static void MergeSort(int low, int high, ref List<int>lists, ref List<int> res)
        {
            if (low >= high) return;
            int mid = (low + high) / 2;
            MergeSort(low, mid, ref lists, ref res);
            MergeSort(mid + 1, high, ref lists, ref res);
            Merge(low,mid, high, ref lists, ref res);
        }

        static void Merge(int low,int mid, int high, ref List<int> lists, ref List<int> res)
        {
            int li = low;
            int hi = mid+1;
            int pi = low;

            while (li <= mid && hi <= high)
            {
                if(lists[li]<lists[hi])
                {
                    res[pi++] = lists[li++];
                }
                else
                {
                    res[pi++] = lists[hi++];
                }
            }
            if (li == mid + 1)
            {
                for(int i = hi; i <= high; i++)
                {
                    res[pi++] = lists[i];
                }
            }
            else
            {
                for(int i = li; i <= mid; i++)
                {
                    res[pi++] = lists[i];
                }
            }

            lists.RemoveRange(low,(high-low+1));
            lists.InsertRange(low, res.GetRange(low, high - low+1));
        }
    }
}
