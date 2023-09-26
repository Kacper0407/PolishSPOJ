/*
PRIME_T - Liczby Pierwsze
Sprawdź, które spośród danych liczb są liczbami pierwszymi

Input
n - liczba testów n<100000, w kolejnych liniach n liczb z przedziału [1..10000]

Output
Dla każdej liczby słowo TAK, jeśli liczba ta jest pierwsza, słowo: NIE, w przeciwnym wypadku.

Example
Input:
3
11
1
4

Output:
TAK
NIE
NIE
*/
class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int[] liczba = new int [n];
        for(int i=0; i<n; i++){
            liczba[i] = Convert.ToInt32(Console.ReadLine().Trim());
        }
        for(int i=0; i<n; i++){
            Console.WriteLine(PRIME_T(liczba[i]));
        }
    }
    static string PRIME_T(int liczba){
        if(liczba<2)
        {
            return "NIE";
        }
        for(int i=2; i*i<=liczba; i++)
        {
            if(liczba%i==0)
            {
                return "NIE";
            }
        }
        return "TAK";
    } 
}
