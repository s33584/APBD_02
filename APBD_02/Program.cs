namespace APBD_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 0, 0, 0, 0};
            print(list);
            Console.WriteLine(CountAvg(list));
        }

        public static double CountAvg(List<int> values)
        {
            int sum = 0;
            for (int i = 0; i < values.Count; ++i)
            {
                sum += values[i];
            }
            return sum/values.Count;
            // return values.Sum()/values.Count;
        }

        public static void print(List<int> list)
        {
            foreach (var entry in list)
            {
                Console.Write(entry + ", ");
            }
            Console.WriteLine();
        }
    }
}