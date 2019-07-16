namespace SortArray
{
    static class ArrayManager
    {
        public static void SortAscending(this int[] array) {
            int buf = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if ((i > j && array[i] < array[j]))
                    {
                        buf = array[j];
                        array[j] = array[i];
                        array[i] = buf;
                    }
                }
            }
        }
    }
}