namespace Task3
{
    public static class SortInt
    {
        //сортировка пузырьком. Время O(n2) - O(n), память O(1)
        public static int[] SortingArrayBubble(this int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            return array;
        }

        //шейкер-сортировка. Время O(n2) - O(n), память O(1)
        public static int[] SortingArrayShaker(this int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
                for (int j = array.Length - i - 2; j > i + 1; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        Swap(ref array[j], ref array[j - 1]);
                    }
                }
            }
            return array;
        }

        //сортировка расческой. Время O(n2) - O(nlogn), память O(1)
        public static int[] SortingArrayComb(this int[] array)
        {
            int way = array.Length;
            for (int i = 0; i < array.Length - 1; i++)
            { 
                for (int j = 0; j < array.Length - way; j++)
                {
                    if (array[j] > array[j + way])
                    {
                        Swap(ref array[j], ref array[j + way]);
                    }
                }
                way = (int)(way / 1.247);
                if (way < 1) break;
            }

            //пузырьковая сортировка
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            return array;
        }

        //сортировка вставкой. Время O(n2) - O(n), память O(1)
        public static int[] SortingArrayInsert(this int[] array)
        {            
            for (int i = 1; i < array.Length; i++)
            {
                int a = array[i];
                int j = i;
                while (j > 0 && array[j - 1] > a)
                {
                    array[j] = array[j - 1];
                    --j;
                }
                array[j] = a;
            }
            return array;
        }

        //Сортировка Шелла / Shellsort

        //сортировка выбором. Время O(n2) - O(n2), память O(1)

        //сортировка быстрая. Время O(n2) - O(n), память O(n)

        //сортировка слиянием. Время O(nlogn) - O(nlogn), память O(n)

        //Гномья сортировка / Gnome sort

        //Сортировка деревом / Tree sort

        //Сортировка подсчетом / Counting sort

        //Блочная сортировка / Bucket sort

        //Поразрядная сортировка / Radix sort
        //LSD (least significant digit):
        //MSD (most significant digit):

        //Битонная сортировка / Bitonic sort:

        //Timsort

        //пирамидальная сортировка (двоичная куча). Время O(nlogn) - O(nlogn), память O(n)
        public static int[] SortingArrayBynaryHeap(this int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int a = array[i];
                int j = i;
                while (j > 0 && array[j - 1] > a)
                {
                    array[j] = array[j - 1];
                    --j;
                }
                array[j] = a;
            }
            return array;
        }

        //поменять местами значения двух переменных
        private static void Swap(ref int a1, ref int a2)
        {
            int a = a1;
            a1 = a2;
            a2 = a;
        }
    }
}
