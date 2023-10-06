class Program
{
    static void Main(string[] args)
    {
        byte n = Convert.ToByte(Console.ReadLine());
        int num = 0;
        for(int i=0; i<n; i++)
        {
            num = Convert.ToInt32(Console.ReadLine());
            int silnia = 1;
            if(num<10)
            {
                for(int j=2; j<=num; j++)
                {
                    silnia*=j;    
                }
                Console.WriteLine($"{(silnia/10)%10} {silnia%10}");
            }
            else
            {
                Console.WriteLine($"{0} {0}");
            }
        }
    }
}