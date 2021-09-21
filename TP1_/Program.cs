using System;

namespace TP1_
{
    internal class Program
    {
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        private static int Fib(int n1)
        {
            if (n1 <= 2)
                return 1;
            else
                return Fib(n1 - 1) + Fib(n1 - 2);
        }

        private static int PowerFunction(int x)
        {
            return (int) (Math.Pow(x, 2) - 4);
        }


        public static void Main(string[] args)
        {
            //Exo1();

            //Exo2();

            //Exo3();
            
            //Exo4();
            
        }

        private static void Exo4()
        {
            int N;
            int M;
            do
            {
                Console.WriteLine("Choisir un premier nombre : ");
                N = AskUserForParameter();
            } while (N > 1000 || N < 1);

            do
            {
                Console.WriteLine("Choisir un deuxième nombre : ");
                M = AskUserForParameter();
            } while (M > 1000 || M < 1);


            for (int x = 0; x < M; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    if (x == 0 || x == M - 1)
                    {
                        if (y == 0 || y == N - 1)
                        {
                            Console.Write('0');
                        }
                        else
                        {
                            Console.Write('_');
                        }
                    }
                    else if (y == 0 || y == N - 1)
                    {
                        Console.Write('|');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
            }
        }
        
        private static void Exo3()
        {
            int res = 0;
            for (int i = -3; i <= 3; i++)
            {
                try
                {
                    res = 10 / PowerFunction(i);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception caught for i = {i}.", e);
                }
            }
        }

        private static void Exo2()
        {
            //1)
            int number = 0;
            int res = 0;
            int flag = 0;
            int i = 0;
            do
            {
                number = AskUserForParameter();
            } while (number > 1000);

            for (int j = 2; j <= number; j++)
            {
                res = j / 2;
                flag = 0;
                for (i = 2; i <= res; i++)
                {
                    if (j % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                    Console.Write($"{j} ");
            }
            
            //2)
            int nombreee;
            do
            {
                nombreee = AskUserForParameter();
            } while (nombreee > 1000);

            for (int k = 1; k <= number; k++)
            {
                Console.WriteLine($"F({i})={Fib(i)}");
            }

            //3)
            int nombree;
            int fin = 1;
            do
            {
                nombree = AskUserForParameter();
            } while (nombree > 25);

            for (int j = 1; j < nombree; j++)
            {
                fin = fin * j;
            }

            Console.WriteLine($"Factoriel de {number} = {res}");
        }

        private static void Exo1()
        {
            for (int compteur = 1; compteur < 11; compteur++)
            {
                Console.WriteLine("Table of :" + compteur);
                for (int multi = 1; multi < 11; multi++)
                {
                    int res = compteur * multi;
                    if (res % 2 != 0)
                    {
                        //Console.Write(compteur+"*"+multi+"="+compteur*multi+"\n");
                        Console.Write($"{compteur} * {multi} = {compteur * multi}\n");
                    }
                }
            }

            int number = AskUserForParameter();
            Console.WriteLine("Table of :" + number);
            for (int multi = 1; multi < 11; multi++)
            {
                int res = number * multi;
                Console.Write($"{number} * {multi} = {number * multi}\n");
            }
        }
    }
}