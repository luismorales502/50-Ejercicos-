using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_Ejercicios_C_Luis_Morales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01. hacer un algoritmo que imprima los números del 0 al 100");
            Console.ReadKey();

            int num;
            num = 1;

            while (num <= 100)
            {
                Console.WriteLine(num);
                num = num + 1;
            }
            Console.ReadKey();









            //aqui empieza el segundo ejercicio

            Console.WriteLine("02. Hacer un algoritmo que imprima los números del 100 al 0 en orden decreciente");
            Console.ReadKey();

            int num2;
            num2 = 100;

            while (num2 >= 0)
            {
                Console.WriteLine(num2);
                num2 = num2 - 1;
            }
            Console.ReadKey();


            //aqui empieza el tercer ejercicio

            Console.WriteLine("03. Hacer un algoritmo que imprima las sumas de los 100 primeros números enteros");
            Console.ReadKey();

            int suma3 = 0;
            String cad3 = "";

            for (int i = 0; i <= 100; i = i + 1)
            {
                cad3 = cad3 + " " + i;
                suma3 = suma3 + i;
            }

            Console.WriteLine(cad3);
            Console.WriteLine("La suma de los numeros anteriores es " + suma3);

            Console.ReadKey();

            //aqui empieza el cuarto ejercicio

            Console.WriteLine("04. Hacer un algoritmo que imprima los números pares entre el 0 al 100");
            Console.ReadKey();

            int i4 = 0, par4 = 0;
            for (i4 = 1; i4 < 100; i4++)
            {
                if (i4 % 2 == 0)
                {
                    Console.WriteLine("{0}", i4);
                    par4++;
                }
            }



            Console.ReadKey();

            //aqui empieza el quinto ejercicio

            Console.WriteLine("05. Hacer un algoritmo que imprima los números impares hasta el 100 y que imprima cuantos impares hay");
            Console.ReadKey();

            int i5, conteo5 = 0;

            for (i5 = 0; i5 < 100; i5++)
            {
                if (i5 % 2 != 0)

                {
                    Console.WriteLine("{0}", i5);


                    conteo5 = conteo5 + 1;
                }

            }

            Console.WriteLine("hay " + conteo5 + " numeros impares numeros pares");
            Console.ReadKey();

            ////aqui empieza el sexto ejercicio

            Console.WriteLine("06. Hacer un algoritmo que imprima los números impares desde el 0 hasta 100 y que calcule su suma");
            Console.ReadKey();

            double num6;
            double suma6;
            num6 = 0;
            suma6 = 0;

            while (num6 <= 100)
            {
                if (num6 % 2 != 0)
                    Console.Write(+num6 + " - ");

                {
                    suma6 = suma6 + num6;
                }
                num6 = num6 + 1;
            }

            Console.WriteLine("La suma de los numeros impares entre 0 y 100 es: " + suma6);
            Console.ReadKey();


            //aqui empieza el  ejercicio siete

            int numingresado7;

            Console.WriteLine("07.  Hacer un algoritmo que imprima todos los números naturales que hay desde la unidad hasta un número introducido   por teclado");
            Console.ReadKey();
            Console.WriteLine("Ingrese un numero");
            numingresado7 = int.Parse(Console.ReadLine());

            int num7;
            num7 = 1;
            while (num7 <= numingresado7)
            {
                Console.WriteLine(num7);
                num7 = num7 + 1;
            }
            Console.ReadKey();

            ////aqui empieza el  ejercicio Ocho

            Console.WriteLine("08.  Hacer un algoritmo que imprima y cuente los múltiplos de 3 que hay entre 1 y 100");
            Console.ReadKey();

            double contador8;
            double num8;
            num8 = 1;
            contador8 = 0;

            while (num8 <= 100)
            {
                if (num8 % 3 == 0)
                {
                    Console.WriteLine(num8);
                    contador8 = contador8 + 1;
                }
                num8 = num8 + 1;
            }

            Console.WriteLine("Se encontraron " + contador8 + " numeros multiplos de 3");
            Console.ReadKey();



            //aqui empieza el  ejercicio NUEVE

            Console.WriteLine("09.  Hacer un algoritmo que calculas la suma de los números impares comprendidos entre el 0 y 100");
            Console.ReadKey();

            double num9;
            double suma9;
            num9 = 0;
            suma9 = 0;

            while (num9 <= 100)
            {
                if (num9 % 2 != 0)
                    Console.Write(+num9 + " - ");

                {
                    suma9 = suma9 + num9;
                }
                num9 = num9 + 1;
            }

            Console.WriteLine("La suma de los numeros impares entre 0 y 100 es: " + suma9);
            Console.ReadKey();

            //aqui empieza el ejercicio DIEZ

            Console.WriteLine("10.  Hacer un algoritmo que imprima y cuente los múltiplos de 5 que hay entre 1 y 500");
            Console.ReadKey();

            double contador10;
            double num10;
            num10 = 1;
            contador10 = 0;

            while (num10 <= 500)
            {
                if (num10 % 5 == 0)
                {
                    Console.WriteLine(num10);
                    contador10 = contador10 + 1;
                }
                num10 = num10 + 1;
            }
            Console.WriteLine("los multiplos que se encontraron de 5 son " + contador10);
            Console.ReadKey();

            //aqui empieza el ejercicio ONCE

            Console.WriteLine("11.  Imprimir, contar y sumar los múltiplos de 2 hasta un número que introducimos por teclado");
            Console.ReadKey();

            double contador11;
            double limite11;
            double num11;
            double suma11;

            Console.WriteLine("Ingrese un limite:");
            limite11 = int.Parse(Console.ReadLine());
            num11 = 1;
            contador11 = 0;
            suma11 = 0;

            while (num11 <= limite11)
            {
                if (num11 % 2 == 0)
                {
                    Console.WriteLine(num11);
                    contador11 = contador11 + 1;
                    suma11 = suma11 + num11;
                }
                num11 = num11 + 1;
            }
            Console.WriteLine("Se encontraron multiples de 2 (" + contador11 + ")");
            Console.WriteLine("La suma de ellos es (" + suma11 + ")");
            Console.ReadKey();


            //aqui empieza el ejercicio DOCE

            Console.WriteLine("12.  Imprimir, contar y sumar los múltiplos de 10 hasta un número que introducimos por teclado");
            Console.ReadKey();
            double contador12;
            double limite12;
            double num12;
            double suma12;

            Console.WriteLine("Ingrese un limite:");
            limite12 = int.Parse(Console.ReadLine());
            num12 = 1;
            contador12 = 0;
            suma12 = 0;

            while (num12 <= limite12)
            {
                if (num12 % 10 == 0)
                {
                    Console.WriteLine(num12);
                    contador12 = contador12 + 1;
                    suma12 = suma12 + num12;
                }
                num12 = num12 + 1;
            }
            Console.WriteLine("Se encontraron multiplos de 10 (" + contador12 + ")");
            Console.WriteLine("La suma de ellos es ( " + suma12 + ")");
            Console.ReadKey();


            //aqui empieza el ejercicio TRECE

            Console.WriteLine("13.  Introducir un número por teclado menor que 500. Imprimir, sumar y contar los números que estan separado entre si 8 posiciones, desde ese numero al 500");
            Console.ReadKey();

            double contador13;
            double limite13;
            double num13;
            double suma13;

            contador13 = 0;
            suma13 = 0;
            Console.WriteLine("Ingrese un número menor a 500");
            limite13 = int.Parse(Console.ReadLine());
            if (limite13 >= 500)
            {
                Console.WriteLine("El numero ingresado es mayor a 500");
            }
            else
            {
                num13 = limite13;
                while (num13 <= 500)
                {
                    Console.WriteLine(num13);
                    contador13 = contador13 + 1;
                    suma13 = suma13 + num13;
                    num13 = num13 + 8;
                }
                Console.WriteLine("Se encontraron " + contador13 + " numeros entre " + limite13 + " y 500");
                Console.WriteLine("La suma de ellos es " + suma13);



            }
            Console.ReadKey();

            //aqui empieza el ejercicio CATORCE

            Console.WriteLine("14.  Calcular la suma de los cuadrados de los números pares entre el 0 y el 100.");
            Console.ReadKey();

            double num14;
            double suma14;
            num14 = 0;
            suma14 = 0;

            while (num14 <= 100)
            {
                if (num14 % 2 == 0)
                {
                    Console.WriteLine(num14);
                    suma14 = suma14 + (Math.Pow(num14, 2));
                }
                num14 = num14 + 1;
            }

            Console.WriteLine("La suma de los numeros pares al cuadrado entre 0 y 100 es: " + suma14);
            Console.ReadKey();

            //aqui empieza el ejercicio 16

            Console.WriteLine("16.  Introducir un numero por teclado que nos diga si es positivo o negativo");
            Console.ReadKey();


            double num16;
            Console.WriteLine("Ingrese un numero para ver si es negatio o positivo: ");
            num16 = int.Parse(Console.ReadLine());

            if (num16 > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }
            Console.ReadKey();

            //aqui empieza el ejercicio 17

            Console.WriteLine("17. Introducir un número por teclado. Que nos diga si es par o impar.");
            Console.ReadKey();

            double num17;
            Console.WriteLine("Ingrese un numero:");
            num17 = int.Parse(Console.ReadLine());

            if (num17 % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
            Console.ReadKey();



            //aqui empieza el ejercicio 18

            Console.WriteLine("18. Imprimir y contar los múltiplos de 3 desde la unidad hasta un número que introducimos por teclado.");
            Console.ReadKey();

            double contador18;
            double limite18;
            double num18;

            num18 = 1;
            contador18 = 0;
            Console.WriteLine("Ingrese un numero límite:");
            limite18 = int.Parse(Console.ReadLine());

            while (num18 <= limite18)
            {
                if (num18 % 3 == 0)
                {
                    Console.WriteLine(num18);
                    contador18 = contador18 + 1;
                }
                num18 = num18 + 1;
            }

            Console.WriteLine("Se encontraron " + contador18 + " numeros multiplos de 3");
            Console.ReadKey();

            //aqui empieza el ejercicio 19

            Console.WriteLine("19. Hacer un algoritmo que imprima los números del 1 al 100 .que calcule la suma de todos los números pares por un lado y otro la de todos los impares.");
            Console.ReadKey();

            double num19;
            double suma_impar19;
            double suma_par19;
            num19 = 1;
            suma_par19 = 0;
            suma_impar19 = 0;

            while (num19 <= 100)
            {
                Console.WriteLine(num19);
                if (num19 % 2 == 0)
                {
                    suma_par19 = suma_par19 + num19;
                }
                else
                {
                    suma_impar19 = suma_impar19 + num19;
                }
                num19 = num19 + 1;
            }

            Console.WriteLine("La suma de los numero pares entre 1 y 100 es: " + suma_par19);
            Console.WriteLine("La suma de los numero impares entre 1 y 100 es: " + suma_impar19);
            Console.ReadKey();

            //aqui empieza el ejercicio 20

            Console.WriteLine("20. Imprimir y contar los números que son múltiplos de 2 o 3 que hay del 1 y 100..");
            Console.ReadKey();

            double contador20;
            double num20;
            num20 = 1;
            contador20 = 0;

            while (num20 <= 100)
            {
                if (num20 % 2 == 0 || num20 % 3 == 0)
                {
                    Console.WriteLine(num20);
                    contador20 = contador20 + 1;
                }
                num20 = num20 + 1;
            }

            Console.WriteLine("El total de numeros multiplos de 2 o 3 encontrados es: " + contador20);
            Console.ReadKey();





            //aqui empieza el ejercicio 21

            Console.WriteLine("21. Imprimir y contar los números que son múltiplos de 2 y 3 que hay del 1 al 100");
            Console.ReadKey();


            double contador21;
            double num21;
            num21 = 1;
            contador21 = 0;

            while (num21 <= 100)
            {
                if (num21 % 2 == 0 && num21 % 3 == 0)
                {
                    Console.WriteLine(num21);
                    contador21 = contador21 + 1;
                }
                num21 = num21 + 1;
            }
            Console.WriteLine("El total de numeros multiplos de 2 y 3 encontrados es: " + contador21);

            Console.ReadKey();





            //aqui empieza el ejercicio 22

            Console.WriteLine("22. Hacer un algoritmo que imprima el mayor el menor de una serie de cinco números  que vamos introduciendo por teclado");
            Console.ReadKey();

            double contador;
            double maximo;
            double minimo;
            double n;
            contador = 0;
            n = 0;
            maximo = 0;
            minimo = 99999;

            while (contador <= 5)
            {
                Console.WriteLine("Ingrese un numero: ");
                n = Double.Parse(Console.ReadLine());
                if (n > maximo)
                {
                    maximo = n;
                }
                if (n < minimo)
                {
                    minimo = n;
                }
                contador = contador + 1;
            }


            Console.WriteLine("El mayor de los numeros es:" + maximo);

            Console.WriteLine("El menor de los numeros es:" + minimo);

            Console.ReadKey();






            //aqui empieza el ejercicio 23

            Console.WriteLine("23. Introducir dos números por teclado. Imprimir los números naturales que hay entre ambos números empezando por el más pequeño, contar cuantos hay y cuantos de ellos son pares. Calcular la suma de los impares.");
            Console.ReadKey();

            double contador23;
            double cont_par23;
            double num23;
            double num123;
            double num223;
            double suma_impar23;
            contador23 = 0;
            cont_par23 = 0;
            suma_impar23 = 0;

            Console.WriteLine("Ingrese el primer número");
            num123 = int.Parse(Console.ReadLine()); ;
            Console.WriteLine("Ingrese el segundo numero");
            num223 = int.Parse(Console.ReadLine());
            num23 = num123;


            while (num23 <= num223)
            {
                Console.WriteLine(num23);
                if (num23 % 2 == 0)
                {
                    cont_par23 = cont_par23 + 1;
                }
                else
                {
                    suma_impar23 = suma_impar23 + num23;
                }
                contador23 = contador23 + 1;
                num23 = num23 + 1;
            }


            Console.WriteLine("Hay " + contador23 + " numeros entre " + num123 + " y " + num223);
            Console.WriteLine(cont_par23 + " de ellos son pares");
            Console.WriteLine("La suma de los impares es " + suma_impar23);

            Console.ReadKey();





            //aqui empieza el ejercicio 24

            Console.WriteLine("24.Introducir una serie de números. Decir si esos números son mayores o menores de 10");
            Console.ReadKey();

            double cant24;
            double datos24;
            double num24;
            datos24 = 0;

            Console.WriteLine("Cuantos numeros desea ingresar");
            cant24 = int.Parse(Console.ReadLine());


            while (datos24 <= cant24)
            {
                Console.WriteLine("Ingrese un numero");
                num24 = int.Parse(Console.ReadLine());
                if (num24 > 10)
                {
                    Console.WriteLine("El numero es MAYOR a 10");
                }
                else
                {
                    Console.WriteLine("El numero es MENOR a 10");
                }
                datos24 = num24;
                datos24 = datos24 + 1;


            }
            Console.ReadKey();


            //aqui empieza el ejercicio 25



            Console.WriteLine("25.Introducir tantos números que hay entre el 1 al 100.excepto los múltiplos de 2");
            Console.ReadKey();

            double num25;
            num25 = 1;

            while (num25 <= 100)
            {
                if (num25 % 2 != 0)
                {
                    Console.WriteLine(num25);
                }
                num25 = num25 + 1;
            }
            Console.ReadKey();





            //aqui empieza el ejercicio 26


            Console.WriteLine("26.Imprimir y sumar los números desde el cero hasta un numero determinado, excepto los múltalos de 5 imprimir el valor de la suma de los múltiplos de 5");
            Console.ReadKey();

            double limite26;
            double num26;
            double suma26;
            double suma_multiplos_526;
            suma26 = 0;
            suma_multiplos_526 = 0;
            num26 = 0;


            Console.WriteLine("Ingrese un numero limite");
            limite26 = int.Parse(Console.ReadLine());

            while (num26 <= limite26)
            {
                if (num26 % 5 == 0)
                {
                    suma_multiplos_526 = suma_multiplos_526 + num26;
                }
                else
                {
                    Console.WriteLine(num26);
                    suma26 = suma26 + num26;
                }
                num26 = num26 + 1;
            }

            Console.WriteLine("La suma de los numeros entre 0 y " + limite26 + " sin los multiplos de 5 es: " + suma26);
            Console.WriteLine("La suma de los multiplos de 5 es: " + suma_multiplos_526);

            Console.ReadKey();





            //aqui empieza el ejercicio 27

            Console.WriteLine("27.Imprimir y contar los números, que son a la vez múltiplos de 2 y 3, que hay entre la unidad y el determinado número");
            Console.ReadKey();

            double contador27;
            double limite27;
            double num27;
            num27 = 1;
            contador27 = 0;


            Console.WriteLine("Ingrese un numero limite");
            limite27 = int.Parse(Console.ReadLine());

            while (num27 <= limite27)
            {
                if (num27 % 2 == 0 && num27 % 3 == 0)
                {
                    Console.WriteLine(num27);
                    contador27 = contador27 + 1;
                    Console.ReadKey();
                }
                num27 = num27 + 1;

            }
            Console.WriteLine("El total de numeros multiplos de 2 y 3 encontrados es: " + contador27);

            Console.ReadKey();



            //aqui empieza el ejercicio 28

            Console.WriteLine("28.Introducir una serie de números. Sumar los múltiplos  de 5. Cual es el mayor y cuantos números se han introducido.SEPARADO EN 7 UNIDADES, SUMAR LOS IMPARES ");
            Console.ReadKey();

            double contador28;
            double num28;
            double num_mayor28;
            string resp28;
            double suma_528;
            num_mayor28 = 0;
            suma_528 = 0;
            contador28 = 0;

            do
            {
                Console.WriteLine("Ingrese un numero");
                num28 = Double.Parse(Console.ReadLine());
                if (num28 % 5 == 0)
                {
                    suma_528 = suma_528 + num28;
                }
                if (num28 > num_mayor28)
                {
                    num_mayor28 = num28;
                }
                contador28 = contador28 + 1;
                Console.WriteLine("Desea ingresar otro numero (S/N)");

                resp28 = Console.ReadLine();
            }

            while (!(resp28.Equals("no") || resp28.Equals("NO") || resp28.Equals("No") || resp28.Equals("n") || resp28.Equals("N")));
            Console.WriteLine("La suma de los multiplos de 5 es: " + suma_528);
            Console.WriteLine("El numero mayor de la serie ingresada es: " + num_mayor28);
            Console.WriteLine("En total se ingresaron " + contador28 + " numeros");



            Console.ReadKey();


            //aqui empieza el ejercicio 29

            Console.WriteLine("29.Introducir dos números por teclado de tal forma que el segundo sea mayor que el primero. A partir del primero. Imprimir los números separados. 29Entre si 7 unidades, contarlos. Cuantos de estos son pares y cuanto vale la suma de los impares ");
            Console.ReadKey();

            double a29;
            double b29;
            double contador29;
            double contador_pares29;
            double num29;
            double suma_impares29;
            contador29 = 0;
            contador_pares29 = 0;
            suma_impares29 = 0;


            Console.WriteLine("Ingrese un numero inicial");
            a29 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero limite");
            b29 = int.Parse(Console.ReadLine());
            num29 = a29;

            while (num29 <= b29)
            {
                Console.WriteLine(num29);
                if (num29 % 2 == 0)
                {
                    contador_pares29 = contador_pares29 + 1;
                }
                else
                {
                    suma_impares29 = suma_impares29 + num29;
                }
                contador29 = contador29 + 1;
                num29 = num29 + 7;
            }

            Console.WriteLine("Entre el rango de " + a29 + " y " + b29);
            Console.WriteLine("Se encontraron " + contador_pares29 + " numeros pares");
            Console.WriteLine("La suma de los numeros impares es " + suma_impares29);
            Console.ReadKey();



            //aqui empieza el ejercicio 30

            Console.WriteLine("30.Introducir una cantidad por teclado. Si es menor que 500, sumarle el 50 por ciento; si es mayor o igual a 500 pero menor que 1000, sumarle el 7 31por ciento; si es mayor que 1000 y menor o igual a 5000, restarle el 5 por ciento. ");
            Console.ReadKey();



            double cantidad30;
            double total30;

            Console.WriteLine("Ingrese una cantidad");
            cantidad30 = Double.Parse(Console.ReadLine());

            if (cantidad30 < 500)
            {
                total30 = cantidad30 + (cantidad30 * 0.50);
            }
            else
            {
                if (cantidad30 >= 500 && cantidad30 < 1000)
                {
                    total30 = cantidad30 + (cantidad30 * 0.07);
                }
                else
                {
                    if (cantidad30 >= 1000 && cantidad30 <= 5000)
                    {
                        total30 = cantidad30 - (cantidad30 * 0.05);
                    }
                    else
                    {
                        total30 = cantidad30;
                    }
                }
            }

            Console.WriteLine("La nueva cantidad es: " + total30);
            Console.ReadKey();






            //aqui empieza el ejercicio 31


            Console.WriteLine("31.Imprimir diez veces la serie de números del 1 al 10");
            Console.ReadKey();

            double i31;
            double j31;

            for (i31 = 1; i31 <= 10; i31++)
            {
                Console.WriteLine(i31 + "° VUELTA");
                for (j31 = 1; j31 <= 10; j31++)
                {
                    Console.WriteLine(j31);
                }


                Console.ReadLine();
                Console.ReadKey();



                //aqui empieza el ejercicio 32

                Console.WriteLine("32.Imprimir, contar y sumar los múltiplos de 2 que hay entre una serie de número, tal que el segundo sea mayor o igual que el primero");
                Console.ReadKey();

                double a32;
                double b32;
                double contador32;
                double num32;
                double suma32;
                contador32 = 0;
                suma32 = 0;

                Console.WriteLine("Ingrese un numero inicial");
                a32 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese un numero limite");
                b32 = int.Parse(Console.ReadLine());
                num32 = a32;


                while (num32 <= b32)
                {
                    if (num32 % 2 == 0)
                    {
                        Console.WriteLine(num32);
                        contador32 = contador32 + 1;
                        suma32 = suma32 + num32;
                    }
                    num32 = num32 + 1;
                }

                Console.WriteLine("Entre el rango de " + a32 + " y " + b32);
                Console.WriteLine("Se encontraron " + contador32 + " numeros pares");
                Console.WriteLine("La suma de ellos es: " + suma32);
                Console.ReadKey();




                //aqui empieza el ejercicio 33

                Console.WriteLine("33.Calcular e imprimar la factorial de un número ingresado vía teclado");
                Console.ReadKey();

                double factorial33;
                double i33;
                double num33;
                factorial33 = 1;

                Console.WriteLine("Ingrese un numero para obtener el factorial");
                num33 = Double.Parse(Console.ReadLine());

                for (i33 = num33; i33 >= 1; i33--)
                {
                    factorial33 = factorial33 * i33;
                }

                Console.WriteLine("El factorial de " + num33 + " es: " + factorial33);
                Console.ReadKey();







                //aqui empieza el ejercicio 34

                Console.WriteLine("34.Hacer un programa que obtenga el producto de dos números enteros positivos mediante restas sucesivas");
                Console.ReadKey();

                double contador34;
                double num134;
                double num234;
                double producto34;
                producto34 = 0;
                contador34 = 0;

                Console.WriteLine("Ingresar dividendo");
                num134 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresar divisor");
                num234 = int.Parse(Console.ReadLine());


                if (num134 > 0 && num234 > 0)
                {
                    while (contador34 < num134)
                    {
                        contador34 = contador34 + 1;
                        producto34 = producto34 + num234;
                    }


                    Console.WriteLine("El producto es: " + producto34);
                    Console.ReadKey();





                    //aqui empieza el ejercicio 35

                    Console.WriteLine("35.Obtener el cociente y el resto de dos números enteros positivos mediante restas sucesivas");
                    Console.ReadKey();


                    double contador35;
                    double dividendo35;
                    double divisor35;


                    Console.WriteLine("Ingrese el dividendo");
                    dividendo35 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el divisor");
                    divisor35 = Double.Parse(Console.ReadLine());
                    contador35 = 0;

                    while (dividendo35 >= divisor35)
                    {
                        dividendo35 = dividendo35 - divisor35;
                        contador35 = contador35 + 1;
                    }


                    Console.WriteLine("El cociente es " + contador35);
                    Console.WriteLine("El resto es " + dividendo35);
                    Console.ReadKey();







                    //aqui empieza el ejercicio 36

                    Console.WriteLine("36.Hacer un algoritmo que calcule las raíces  de una ecuación de segundo grado. Repetir el proceso tantas veces como se desee.");
                    Console.ReadKey();

                    double a36;
                    double b36;
                    double c36;
                    double neg36;
                    double raizcua36;
                    string resp36;
                    double totalx136;
                    double totalx236;

                    Console.WriteLine("Ingrese el valor de a");
                    a36 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el valor de b");
                    b36 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el valor de c");
                    c36 = Double.Parse(Console.ReadLine());
                    neg36 = -b36;
                    raizcua36 = Math.Pow((Math.Pow(b36, 2) - 4 * a36 * c36), 0.5);


                    if (raizcua36 <= 0)
                    {
                        Console.WriteLine("La ecuacion no se puede resolver");
                    }
                    else
                    {
                        totalx136 = (neg36 + raizcua36) / (2 * a36);
                        totalx236 = (neg36 - raizcua36) / (2 * a36);
                        Console.WriteLine("X1 = " + totalx136);
                        Console.WriteLine("X2 = " + totalx236);
                    }

                    Console.WriteLine("Desea realizar otra ecuacion (S/N)");
                    resp36 = Console.ReadLine();
                    Console.ReadKey();





                    //aqui empieza el ejercicio 37

                    Console.WriteLine("37.Hacer un programa que determine cuantas cifras posee un número entero positivo introducido por teclado .repetir el proceso");
                    Console.ReadKey();

                    double contador37;
                    double control37;
                    double num37;
                    control37 = 10;
                    contador37 = 1;


                    Console.WriteLine("Ingrese un numero");
                    num37 = int.Parse(Console.ReadLine());


                    while (control37 <= num37)
                    {
                        contador37 = contador37 + 1;
                        control37 = control37 * 10;
                    }

                    Console.WriteLine("El numero " + num37 + " tiene " + contador37 + " cifras");
                    Console.ReadKey();



                    //aqui empieza el ejercicio 39

                    Console.WriteLine("39.Hacer un algoritmo que imprima los primeros 30 términos de la serie de Fibonacci. La serie es: 0, 1, 2, 3, 5, 8");
                    Console.ReadKey();

                    double a39;
                    double b39;
                    double c39;
                    double i39;
                    double n39;
                    n39 = 30;
                    a39 = 0;
                    b39 = 1;


                    for (i39 = 1; i39 <= n39; i39++)
                    {
                        Console.WriteLine(a39);
                        c39 = a39 + b39;
                        a39 = b39;
                        b39 = c39;
                        Console.ReadKey();






                        //aqui empieza el ejercicio 40

                        Console.WriteLine("40.Calcular el menor numero primo de un numero que introducimos vía teclado");
                        Console.ReadKey();
                        double cant_a_mostrar40;
                        double cant_mostrados40;
                        bool es_primo40;
                        double i40;
                        double n40;


                        Console.WriteLine("Ingrese la cantidad de numeros primos a mostrar:");
                        cant_a_mostrar40 = int.Parse(Console.ReadLine());

                        Console.WriteLine("1: 2");
                        cant_mostrados40 = 1;
                        n40 = 3;

                        while (cant_mostrados40 < cant_a_mostrar40)
                        {
                            es_primo40 = true;
                            for (i40 = 0; i40 <= Math.Sqrt(n40); i40 += 2)
                            {
                                if (n40 % i40 == 0)
                                {
                                    es_primo40 = false;
                                }
                            }
                            if (es_primo40)
                            {
                                cant_mostrados40 = cant_mostrados40 + 1;
                                Console.WriteLine(cant_mostrados40 + ": " + n40);
                            }
                            n40 = n40 + 2;

                        }
                        Console.ReadKey();

                        //aqui empieza el ejercicio 41

                        Console.WriteLine("41.Introducir un número entero, imprimir el valor equivalente en binario");
                        Console.ReadKey();

                        double bin41;
                        double c41;
                        double i41;
                        double x41;


                        Console.WriteLine("Ingresa un numero entero");
                        x41 = int.Parse(Console.ReadLine());


                        if (x41 > 0)
                        {
                            c41 = x41;
                            i41 = 1;
                            bin41 = 0;
                            while (c41 != 1)
                            {
                                bin41 = bin41 + (c41 % 2) * i41;
                                c41 = Math.Truncate(c41 / 2);
                                i41 = i41 * 10;
                            }
                            bin41 = bin41 + (c41 % 2) * i41;


                            Console.WriteLine(bin41);

                            Console.ReadKey();








                            //aqui empieza el ejercicio 42


                            Console.WriteLine("42.Implementar un método en java que reciba como parámetro un vector de 20 elementos ");
                            Console.ReadKey();

                            string entrada42;
                            int i42;
                            int j42;
                            string[] dato = new string[20];


                            for (i42 = 1; i42 <= 20; i42++)
                            {
                                Console.WriteLine("Ingrese un numero");
                                entrada42 = Console.ReadLine();
                                dato[i42 - 1] = entrada42;
                            }
                            for (j42 = 1; j42 <= 20; j42++)
                            {
                                Console.WriteLine(dato[j42 - 1]);




                            }
                            Console.ReadKey();







                            //aqui empieza el ejercicio 43

                            Console.WriteLine("43.Introducir dos números por teclado. Imprimir los números naturales que hay entre ambos números empezando por el mas pequeño , contar cuantos hay y cuantos de ellos son pares. Calcular la suma de los impares. ");
                            Console.ReadKey();

                            double a43;
                            double b43;
                            double contador43;
                            double contador_pares43;
                            double num43;
                            double suma_impares43;
                            contador_pares43 = 0;
                            contador43 = 0;
                            suma_impares43 = 0;

                            Console.WriteLine("Ingrese un numero inicial");
                            a43 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese un numero limite");
                            b43 = int.Parse(Console.ReadLine());
                            num43 = a43;


                            while (num43 <= b43)
                            {
                                Console.WriteLine(num43);
                                if (num43 % 2 == 0)
                                {
                                    contador_pares43 = contador_pares43 + 1;
                                }
                                else
                                {
                                    suma_impares43 = suma_impares43 + num43;
                                }
                                contador43 = contador43 + 1;
                                num43 = num43 + 1;
                            }


                            Console.WriteLine("En el rango de " + a43 + " a " + b43);
                            Console.WriteLine("Se encontraron " + contador43 + " numeros en total");
                            Console.WriteLine(contador_pares43 + " de ellos son pares");
                            Console.WriteLine("La suma de los impares es " + suma_impares43);

                            Console.ReadKey();






                            //aqui empieza el ejercicio 44

                            Console.WriteLine("44.Obtener el cociente y el resto de dos números enteros positivos mediante resta sucesivas");
                            Console.ReadKey();

                            double contador44;
                            double dividendo44;
                            double divisor44;

                            Console.WriteLine("Ingrese el dividendo");
                            dividendo44 = Double.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el divisor");
                            divisor44 = Double.Parse(Console.ReadLine());
                            contador44 = 0;


                            while (dividendo44 >= divisor44)
                            {
                                dividendo44 = dividendo44 - divisor44;
                                contador44 = contador44 + 1;
                            }

                            Console.WriteLine("El cociente es " + contador44);
                            Console.WriteLine("El resto es " + dividendo44);

                            Console.ReadKey();






                            //aqui empieza el ejercicio 45

                            Console.WriteLine("45. Introducir dos números por teclado de tal forma que el segundo sea mayor que el primero .a partir del primer, imprimir los números por separados entre si 7 unidades, contarlas. De estos cuantos son pares y cuanto vale la suma de los impares.");
                            Console.ReadKey();

                            double a45;
                            double b45;
                            double contador45;
                            double contador_pares45;
                            double num45;
                            double suma_impares45;


                            contador45 = 0;
                            contador_pares45 = 0;
                            suma_impares45 = 0;


                            Console.WriteLine("Ingrese un numero inicial");
                            a45 = int.Parse(Console.ReadLine());


                            Console.WriteLine("Ingrese un numero limite");
                            b45 = int.Parse(Console.ReadLine());
                            num45 = a45;


                            while (num45 <= b45)
                            {
                                Console.WriteLine(num45);
                                if (num45 % 2 == 0)
                                {
                                    contador_pares45 = contador_pares45 + 1;
                                }
                                else
                                {
                                    suma_impares45 = suma_impares45 + num45;
                                }
                                contador45 = contador45 + 1;
                                num45 = num45 + 7;
                            }


                            Console.WriteLine("Entre el rango de " + a45 + " y " + b45);
                            Console.WriteLine("Se encontraron " + contador_pares45 + " numeros pares");
                            Console.WriteLine("La suma de los numeros impares es " + suma_impares45);
                            Console.ReadKey();







                            //aqui empieza el ejercicio 46


                            Console.WriteLine("46. Imprimir, contar y sumar los múltiplos de 2 que hay entre dos números enteros positivos, tal que el segundo sea mayor o igual que el primero, los dos números deben ser ingresados vía teclado");
                            Console.ReadKey();

                            double a46;
                            double b46;
                            double contador46;
                            double num46;
                            double suma46;
                            contador46 = 0;
                            suma46 = 0;

                            Console.WriteLine("Ingrese un numero inicial");
                            a46 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese un numero limite");
                            b46 = int.Parse(Console.ReadLine());
                            num46 = a46;


                            while (num46 <= b46)
                            {
                                if (num46 % 2 == 0)
                                {
                                    Console.WriteLine(num46);
                                    contador46 = contador46 + 1;
                                    suma46 = suma46 + num46;
                                }
                                num46 = num46 + 1;
                            }

                            Console.WriteLine("Entre el rango de " + a46 + " y " + b46);
                            Console.WriteLine("Se encontraron " + contador46 + " numeros pares");
                            Console.WriteLine("La suma de ellos es: " + suma46);
                            Console.ReadKey();






                            ////aqui empieza el ejercicio 47

                            Console.WriteLine("47. Hacer un algoritmo que calcule independientemente las sumas de impares de los números entre el 1 y el 1000");
                            Console.ReadKey();

                            double num47;
                            double suma47;
                            num47 = 1;
                            suma47 = 0;


                            while (num47 <= 1000)
                            {
                                if (num47 % 2 != 0)
                                {
                                    suma47 = suma47 + num47;
                                }
                                num47 = num47 + 1;
                            }
                            Console.WriteLine("La suma de los impares entre 1 y 1000, es " + suma47);
                            Console.ReadKey();





                            ////aqui empieza el ejercicio 48

                            Console.WriteLine("48. Escriba un programa que solicite al usuario que ingrese vía teclado dos números enteros, tome los dos numero de usuario, e imprima las suma, el producto, la diferencia, el cociente y el restos de los dos números");
                            Console.ReadKey();

                            double cociente48;
                            double diferencia48;
                            double num148;
                            double num248;
                            double producto48;
                            double resto48;
                            double suma48;


                            Console.WriteLine("Ingrese el primer numero");
                            num148 = Double.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el segundo numero");
                            num248 = Double.Parse(Console.ReadLine());
                            suma48 = num148 + num248;
                            producto48 = num148 * num248;
                            diferencia48 = num148 - num248;
                            cociente48 = num148 / num248;
                            resto48 = num148 % num248;


                            Console.WriteLine("La suma es " + suma48);
                            Console.WriteLine("El producto es " + producto48);
                            Console.WriteLine("La diferencia es " + diferencia48);
                            Console.WriteLine("El cociente es " + cociente48);
                            Console.WriteLine("El resto es " + resto48);
                            Console.ReadKey();







                            //////aqui empieza el ejercicio 49

                            Console.WriteLine("49.Escriba un programa que permite ingresar 3 números enteros diferentes por teclado, y a continuación imprima la suma, la media aritmética, el menor, el mayor de estos números");
                            Console.ReadKey();

                            double media49;
                            double num149;
                            double num249;
                            double num349;
                            double suma49;


                            Console.WriteLine("Ingrese el primer numero");
                            num149 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el segundo numero");
                            num249 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el tercer numero");
                            num349 = int.Parse(Console.ReadLine());
                            suma49 = num149 + num249;
                            media49 = suma49 / 3;

                            Console.WriteLine("La suma es " + suma49);


                            Console.WriteLine("La media aritmetica es " + media49);
                            if (num149 > num249 && num149 > num349)
                            {
                                Console.WriteLine("El mayor es:" + num149);
                            }
                            else
                            {
                                if (num249 > num149 && num249 > num349)
                                {
                                    Console.WriteLine("El mayor es:" + num249);
                                }
                                else
                                {
                                    if (num349 > num149 && num349 > num249)
                                    {
                                        Console.WriteLine("El mayor es:" + num349);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Son iguales");
                                    }
                                }
                            }
                            if (num149 < num249 && num149 < num349)
                            {
                                Console.WriteLine("El menor es: " + num149);
                            }
                            else
                            {
                                if (num249 < num149 && num249 < num349)
                                {
                                    Console.WriteLine("El menor es: " + num249);
                                }
                                else
                                {
                                    if (num349 < num149 && num349 < num249)
                                    {
                                        Console.WriteLine("El menor es: " + num349);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Son iguales");
                                    }
                                }
                                Console.ReadKey();


                            }
                        }
                    }
                }
            }

        }
    }
}
