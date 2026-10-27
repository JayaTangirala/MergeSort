namespace MergeSort
{
    internal class Program
    {       
        static void MergeSort(int[] A, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                MergeSort(A, left, middle);
                MergeSort(A, middle + 1, right);

                Merge(A, left, middle, right);
            }
        }

        static void Merge(int[] A, int left, int middle, int right)
        {
            int[] temp = new int[right - left + 1];

            int i = left;
            int j = middle + 1;
            int k = 0;

            while (i <= middle && j <= right)
            {
                if (A[i] <= A[j])
                {
                    temp[k] = A[i];
                    i++;
                }
                else
                {
                    temp[k] = A[j];
                    j++;
                }

                k++;
            }

            while (i <= middle)
            {
                temp[k] = A[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                temp[k] = A[j];
                j++;
                k++;
            }

            for (int p = 0; p < temp.Length; p++)
            {
                A[left + p] = temp[p];
            }
        }

        static void Main()
        {
            int[] A = { 38, 12, 27, 43, 9, 31, 18, 25 };

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", A));

            MergeSort(A, 0, A.Length - 1);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(", ", A));
        }
    }
}

