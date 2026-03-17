namespace APBD_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] list = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 0, 0, 0, 0};
            print(list);
            Console.WriteLine(CalculateAverage(list));
            Console.WriteLine(CalculateMax(list));
            Console.WriteLine(CalculateMin(list));
        }

        public static double CalculateAverage(int[] values)
        {
            int sum = 0;
            int count = 0;
            foreach (var entry in values)
            {
                sum += entry;
                ++count;
            }
            return sum/count;
        }

        public static double CalculateMax(int[] values)
        {
            int max = 0;
            foreach (var entry in values)
            {
                if (entry > max)
                {
                    max = entry;
                }
            }
            return max;
        }

        public static double CalculateMin(int[] values)
        {
            int min = values[0];
            foreach (var entry in values)
            {
                if (entry < min)
                {
                    min = entry;
                }
            }
            return min;
        }

        public static void print(int[] list)
        {
            foreach (var entry in list)
            {
                Console.Write(entry + ", ");
            }
            Console.WriteLine();
        }
    }
}


