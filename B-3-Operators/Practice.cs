using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {   
            Console.Write("Ведите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ведите второе число: ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($"Сумма чичел = {sum}");
        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            
            Console.Write("Ведите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ведите второе число: ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;

            startloop:
                Console.WriteLine("Введите сумму");
                string answe = Console.ReadLine();
                int sum2 = Convert.ToInt32(answe);
                if (sum2 == sum)
                {
                    Console.WriteLine($"Ваш ответ верный сумма чичел = {sum}");
                }
                else
                {
                    Console.WriteLine("Ответ неверный");
                    goto startloop;
                }
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {

            Console.Write("Ведите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ведите второе число: ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            startloop:
            Console.WriteLine("Введите сумму");
            string answe = Console.ReadLine();
            int sum2 = Convert.ToInt32(answe);
            if (sum2 == sum)
                Console.WriteLine($"Ваш ответ верный сумма чичел = {sum}");
            else
            {
                if (sum2 < sum)
                    Console.WriteLine("Ответ неверный занчение меньше");
                else
                {
                    Console.WriteLine("Ответ неверный занчение больше");
                }

                goto startloop;
            }
        }


        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            string oper1 = "+";
            string oper2 = "-";
            int sum, sum2;

            Console.Write("Ведите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ведите второе число: ");
            int b = int.Parse(Console.ReadLine());

            opers:
            Console.WriteLine("Введите оператор \"+\" или \"-\" :");
            string oper = Console.ReadLine();
            if ((oper == oper1) && (oper != null))
                sum = a+b;
            else
            {
                if ((oper == oper2) && (oper != null))
                    sum = a-b;
                else
                {
                    Console.WriteLine("Вы ввели неправильный оператор или пустое значение");
            goto opers;
                }
            }
            startloop:
            Console.WriteLine($"Введите сумму");
            string answe = Console.ReadLine();
            bool isInt = int.TryParse(answe, out sum2);
            if (isInt)
            {
                sum2 = Convert.ToInt32(answe);
            }
            else
            {
                Console.WriteLine($"ввели не число");
                goto startloop;
            }

            if (sum2 == sum)
                Console.WriteLine($"Ваш ответ верный сумма чичел равна:{sum}");
            else
            {
                if (sum2 < sum)
                    Console.WriteLine("Ответ неверный занчение меньше");
                else
                    Console.WriteLine("Ответ неверный занчение больше");
            goto startloop;
            }
        }


        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {
            string oper1 = "+";
            string oper2 = "-";
            int sum, sum2;

            Console.Write("Ведите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ведите второе число: ");
            int b = int.Parse(Console.ReadLine());

        opers:
            Console.WriteLine("Введите оператор \"+\" или \"-\" :");
            string oper = Console.ReadLine();
            if ((oper == oper1) && (oper != null))
                sum = a + b;
            else
            {
                if ((oper == oper2) && (oper != null))
                    sum = a - b;
                else
                {
                    Console.WriteLine("Вы ввели неправильный оператор или пустое значение");
                    goto opers;
                }
            }
            
            for (int i = 0; i <3; i++)
            {
            startloop:
                Console.WriteLine($"Введите сумму");
                string answe = Console.ReadLine();
                bool isInt = int.TryParse(answe, out sum2);
                if (isInt)
                {
                    sum2 = Convert.ToInt32(answe);
                }
                else
                {
                    Console.WriteLine($"ввели не число");
                    goto startloop;
                }

                if (sum2 == sum)
                    Console.WriteLine($"Ваш ответ верный сумма чичел равна:{sum}");
                else
                {
                    if (sum2 < sum)
                        Console.WriteLine("Ответ неверный занчение меньше");
                    else
                        Console.WriteLine("Ответ неверный занчение больше");
                    goto startloop;
                }
            }
        }
        


        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {
            string oper1 = "+";
            string oper2 = "-";
            int sum, sum2;

            Console.Write("Ведите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ведите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Ведите третье число: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Ведите четвёртое число: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Ведите пятое число: ");
            int e = int.Parse(Console.ReadLine());

        opers:
            Console.WriteLine("Введите оператор \"+\" или \"-\" :");
            string oper = Console.ReadLine();
            if ((oper == oper1) && (oper != null))
                sum = a + b + c + d + e;
            else
            {
                if ((oper == oper2) && (oper != null))
                    sum = a - b - c - d - e;
                else
                {
                    Console.WriteLine("Вы ввели неправильный оператор или пустое значение");
                    goto opers;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                startloop:
                Console.WriteLine($"Введите сумму");
                string answe = Console.ReadLine();
                bool isInt = int.TryParse(answe, out sum2);
                if (isInt)
                {
                    sum2 = Convert.ToInt32(answe);
                }
                else
                {
                    Console.WriteLine($"ввели не число");
                    goto startloop;
                }

                if (sum2 == sum)
                {
                    Console.WriteLine($"Ваш ответ верный сумма чичел равна:{sum}");
                    break;
                }
                else
                {
                    if (sum2 < sum)
                        Console.WriteLine("Ответ неверный занчение меньше");
                    else
                        Console.WriteLine("Ответ неверный занчение больше");
                    goto startloop;
                }
            }
        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
            string oper1 = "+";
            string oper2 = "-";
            int sum, sum2;

            Console.Write("Ведите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ведите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Ведите третье число: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Ведите четвёртое число: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Ведите пятое число: ");
            int e = int.Parse(Console.ReadLine());

        opers:
            Console.WriteLine("Введите оператор \"+\" или \"-\" :");
            string oper = Console.ReadLine();
            if ((oper == oper1) && (oper != null))
                sum = a + b + c + d + e;
            else
            {
                if ((oper == oper2) && (oper != null))
                    sum = a - b - c - d - e;
                else
                {
                    Console.WriteLine("Вы ввели неправильный оператор или пустое значение");
                    goto opers;
                }
            }

            for (int i = 0; i < 3; i++)
            {
            startloop:
                Console.WriteLine($"Введите сумму");
                string answe = Console.ReadLine();
                bool isInt = int.TryParse(answe, out sum2);
                if (isInt)
                {
                    sum2 = Convert.ToInt32(answe);
                }
                else
                {
                    Console.WriteLine($"ввели не число");
                    goto startloop;
                }

                if (sum2 == sum)
                {
                    Console.WriteLine($"Ваш ответ верный сумма чичел равна:{sum}. Ваш ответ: {sum2}");
                    break;
                }
                else
                {
                    if (sum2 < sum)
                        Console.WriteLine("Ответ неверный занчение меньше");
                    else
                        Console.WriteLine("Ответ неверный занчение больше");
                    goto startloop;
                }
            }
        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {
            double s;
            startloop:
            Console.Write("Введите радиус: ");
            string temp = Console.ReadLine();
            if (temp.Contains('.'))
            {
                Console.WriteLine(@"укажите разделитель"","" f а не "".""");
                goto startloop;
            }
            else
            {
                double r = double.Parse(temp);
                s = Math.PI * Math.Pow(r, 2);
                Console.WriteLine($"Плошадь круга с радуисом {r} равна: {s}");
            }
        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
            double rate;        // Годовая процентная ставка по кредиту
            double loanservece; // Процентная ставка в месяц
            decimal sum;            // Сумма по кредиту
            double term ;           // Срок на который берется кредит
            decimal k;           // коэффициента аннуитета   
            decimal pay;         // месячный платёж
            decimal sum1;        // сумма процентов за первый месяц
            decimal loann;       // остаток кредита по месяцам
            decimal balacepay;   // сумма погашения основного долга

            Console.Write("Введите срок кредита в месяцах:" );
            term = double.Parse(Console.ReadLine());
            Console.Write("Введите сумму кредита: ");
            sum = decimal.Parse(Console.ReadLine());
            Console.Write("Введите годовую процентную ставку: ");
            rate = double.Parse(Console.ReadLine());

            loanservece = rate / 1200;
            decimal loans = Convert.ToDecimal(loanservece);

            double temp = Math.Pow((1 + loanservece), term);
            decimal t = Convert.ToDecimal(temp);
            
            k= (loans * t) / (t - 1);
            pay = k * sum;
            Console.WriteLine(term);
            while (term > 0)
            {

                sum1 = loans * sum;
                loann = pay - sum1;
                balacepay = sum - loann;
                sum = balacepay;
                ;
                term--;
                Console.WriteLine($"месяц:{term}   Остаток: {balacepay}   Погашение % {sum1}   Погашение осн. долга {loann}   Месячный платёж {pay}");
            }
        }
    }
}
