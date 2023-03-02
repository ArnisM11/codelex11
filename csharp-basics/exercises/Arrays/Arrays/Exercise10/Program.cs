namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] arr2 = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            int[] arr3 = { 91, -4, 80, -73, -28 };
            int[] arr4 = { };
            
            printResult(arr1);
            printResult(arr2);
            printResult(arr3);
            printResult(arr4);
            Console.ReadKey();
        }

        static int[] CountPosSumNeg(int[] array)
        {
            int positiveNumbers = 0;
            int sumOfNegativeNum = 0;
            int[] result = new int[2];
            if (array.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0) positiveNumbers++;
                    else sumOfNegativeNum += array[i];
                }

                result[0] = positiveNumbers;
                result[1] = sumOfNegativeNum;
            }
            else result = new int[0];
            return result;
        }
        static void printResult(int[] array)
        {
            int[] res1 = CountPosSumNeg(array);
            if (res1.Length != 0) Console.WriteLine("[" + res1[0] + ", " + res1[1] + "]");
            else Console.WriteLine("[]");
        }
    }
}