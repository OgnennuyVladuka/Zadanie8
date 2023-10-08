namespace z8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество ступеней:");
            int vvod = Convert.ToInt32(Console.ReadLine());
            string[] mas1 = new string[vvod];
            mas1[0] = "1";
            Console.WriteLine(mas1[0]);
            string k = "";
            for (int i = 1; i < vvod; i++)
            {
                k = Convert.ToString(i + 1);
                mas1[i] = mas1[i - 1] + k;
                Console.WriteLine(mas1[i]);
            }
        }
    }
}