#include <stdlib.h>
#include <stdio.h>
int silnia(int);
void main()
{
    int n = 0;
    int* silnie;
    scanf("%d", &n);
    int num = 0;

    silnie = (int*)calloc(n, sizeof(int));
    for(int i=0; i<n; i++)
    {
        scanf("%d", &num);
        silnie[i] = silnia(num);
    }
    
    for(int i=0; i<n; i++)
    {
        printf("%d %d\n", silnie[i]/10, silnie[i]%10);
    }
}
int silnia(int num)
{
    int result = 1;
    while (num != 1)
    {
        result *= num;
        num --;
    }
    return result;
}