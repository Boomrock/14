using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабраторная_14
{
    class Calc
    {
        public static void SelectSort(ref int[] M)
        {
            for (int i = 0; i < M.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < M.Length; j++)
                {
                    if (M[j] < M[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int t = M[i];
                    M[i] = M[min];
                    M[min] = t;
                }
            }
        }
        public static void BubbleSort(ref int[] M)
        {
            for (int i = 0; i < M.Length; i++)
            {
                for (int j = i + 1; j < M.Length; j++)
                {
                    if (M[i] > M[j])
                    {
                        int t = M[i];
                        M[i] = M[j];
                        M[j] = t;
                    }
                }
            }
        }
        public static void QSort(ref int[] M)
        {
            QSort(ref M, 0, M.Length - 1);
        }
        private static void QSort(ref int[] M, int Left, int Right)
        {
            int i = Left;
            int j = Right;
            int x = M[(Left + Right) / 2];
            do
            {
                while (M[i] < x)
                    ++i;
                while (M[j] > x)
                    --j;
                if (i <= j)
                {
                    int t = M[i];
                    M[i] = M[j];
                    M[j] = t;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (Left < j)
                QSort(ref M, Left, j);
            if (i < Right)
                QSort(ref M, i, Right);
        }
        public static int SimpleSearch(ref int[] M, int Value)
        {
            for (int i = 0; i < M.Length; i++)
                if (M[i] == Value)
                    return i;
            return -1;
        }
        public static int IndexOf(ref int[] M, int Value, out int count)
        {
            count = 0; 
            return IndexOf(ref M, Value, 0, M.Length - 1, ref count);
        }
        private static int IndexOf(ref int[] M, int Value, int Left, int Right, ref int count)
        {
            count++;

            int x = (Left + Right) / 2;

            if (M[x] == Value)
                return x;


            if ((x == Left) || (x == Right))
                return -1;

            if (M[x] < Value)
                return IndexOf(ref M, Value, x, Right, ref count);
            else
                return IndexOf(ref M, Value, Left, x, ref count);
        }
            

       
    }
}
