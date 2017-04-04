#include <stdio.h>
#include <stdlib.h>

int sumaNumeros (int num1, int num2);


int main()
{   int a;
    int b;
    int suma;

     printf("ingrese el primer operador");
     scanf("%d",&a);
     printf("ingrese el segundo operador: ");
     scanf("%d",&b);
     suma=sumaNumeros(a , b);
     printf("La suma es: %d",suma);
    return 0;
}

int sumaNumeros (int num1, int num2)
 {
     int result = num1+num2;
     return result;
 }
