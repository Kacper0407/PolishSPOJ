class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] wynik = new int [n]; 
        for(int i=0; i<n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(input[0]);
            int b = Convert.ToInt32(input[1]);

            //wynik[i] = a%10;
        }
        for(int i=0; i<n; i++)
        {
            Console.WriteLine(wynik[i]);
        }
    }
}