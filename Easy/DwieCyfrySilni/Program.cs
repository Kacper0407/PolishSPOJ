class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] silnie = new int [n];
        string [,] result = new string [2,n];
        for(int i=0; i<n; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            silnie[i] = Silnia(num);
        }
        for(int i=0; i<n; i++)
        {
            if(silnie[i]<10)
            {
                result[i,0] = "0";
                result[i,1] = silnie[i].ToString();
            }
            else
            {
                for(int j=0; j<2; j++)
                {   
                    result[i,j] = silnie[i].ToString().ElementAt(j).ToString();
                }
            }
        }
        for(int i=0; i<n; i++){
            for(int j=0; j<2; j++){
                Console.Write($"{result[i,j]} ");
            }
            Console.WriteLine();
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