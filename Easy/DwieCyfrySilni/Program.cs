class Program
{
    static void Main(string[] args)
    {
        byte n = Convert.ToByte(Console.ReadLine());
        int num = 0;
        int[] silnie = new int [n];
        for(int i=0; i<n; i++)
        {
            num = Convert.ToInt32(Console.ReadLine());
            if(num<10)
            {
                silnie[i] = Silnia(num);       
            }
            else
            {
                silnie[i] = 0;
            }
        }
        for(int i=0; i<n; i++)
        {
            Console.WriteLine($"{(silnie[i]/10)%10} {silnie[i]%10}");
        }
    }
    static int Silnia(int num)
    {
        int silnia = 1;
        for(int j=2; j<=num; j++)
        {
            silnia*=j;    
        }
        return silnia;
    }
}