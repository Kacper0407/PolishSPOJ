#include <stdlib.h>
#include <stdio.h>
void main()
{
    int n = 0;
    scanf("%d", &n);
    int num = 0;
    for(int i=0; i<n; i++)
    {
        scanf("%d", &num);
        switch(num){
                case 1:
                case 2:
                case 3:
                case 4:
                   for(int j=num-1; j>0; j--){
                        num = num*j;
                    }
                   break;
                case 5:
                case 6:
                    num = 20;
                    break;
                case 7:
                    num = 40;
                    break;
                case 8:
                    num = 20;
                    break;
                case 9:
                    num = 80;
                    break;
                default:
                    num = 0;
                    break;
            }
        printf("%d %d\n", num/10, num%10);
    }
    
}