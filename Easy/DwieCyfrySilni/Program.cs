class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] silnie = new int [n];
        for(int i=0; i<n; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            silnie[i] = Silnia(num);
        }
        for(int i=0; i<n; i++)
        {
            Console.WriteLine($"{silnie[i]/10} {silnie[i]%10}");
        }
    }
    public static int Silnia(int num)
    {
        int result = 1;
        while (num != 1)
        {
            result *= num;
            num --;
        }
        return result;
    }
    
}