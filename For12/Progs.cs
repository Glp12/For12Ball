using System;

namespace For12
{
    public class Progs
    {
        public void For4(int a)
        {

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(a * i);
            }

        }
        public int For8(int a, int b)
        {
            if (a > b)
            {
                return 0;
            }
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += (b * i);
            }
            return sum;
        }
        public double For12(int n)
        {
            double a = 1.1;
            if (n <= 0)
            {
                return 0;
            }
            double sum = 1;
            for (int i = 1; i <= n; i++, a += 0.1)
            {
                sum *= a;
            }
            return (sum);
        }
        public void For16()
        {
            int n = 5;
            double a = 1.2;
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum *= a;
                Console.WriteLine(sum);
            }
        }
        public void For20()
        {
            int n = 5;
            double last = 1;
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                last *= i;
                sum += last;
            }
            Console.WriteLine(sum);
        }
        public void For24()
        {
            int n = 3;
            double x = 1.2;
            int v = 2;
            int last = 1;
            double plus = 1, mins = 0;

            for (int i = 2; i <= n; i++, v *= 2)
            {
                if (i % 2 != 0)
                {
                    double sum = 1;
                    for (int y = 1; i <= v; y++)
                    {
                        sum *= x;
                    }
                    plus += sum / (last * i);
                }
                else
                {
                    double sum = 1;
                    for (int y = 1; i <= v; y++)
                    {
                        sum *= x;
                    }
                    mins += sum / (last * i);
                }
            }
            Console.WriteLine(plus - mins);
        }
        public void For28()
        {
            int n = 3;
            double x = 0.2;
            int v = 2;
            int u = 1;
            int last = 2;
            double plus = 1, mins = 0;

            for (int i = 2; i <= n; i++, v *= 2, u *= 3)
            {
                if (i % 2 == 0)
                {
                    double sum = 1;
                    for (int y = 1; i <= v; y++)
                    {
                        sum *= x;
                    }
                    plus += (u * sum) / (last * i);
                }
                else
                {
                    double sum = 1;
                    for (int y = 1; i <= v; y++)
                    {
                        sum *= x;
                    }
                    mins += (u * sum) / (last * i);
                }
            }
            Console.WriteLine(plus - mins);
        }
        public void For32()
        {
            int k = 1;
            int n = 4;
            double a = 1;
            double last = a;
            for (int i = 0; i < n; i++, k++)
            {
                a = (last + 1) / k;
                last = a;
                Console.WriteLine(a);
            }
        }
    }
}
