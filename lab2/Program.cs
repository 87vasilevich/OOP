using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// лабораторная работа №2 (первая по c#)

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ПЕРВОЕ ЗАДАНИЕ

            string type;
            char choose1, choose2, choose3, choose4, choose5, choose6;

            // 1-а
            Console.WriteLine("Задание 1-a"+"\n"+"Хотите ли вы заполнить переменные вручную? y - да, n - нет");
            type = Console.ReadLine();
            choose1 = Convert.ToChar(type);

            // создание переменных
            byte b;
            sbyte c;
            short l;
            ushort m;
            int h;
            uint i;
            long k;
            ulong n;
            float g;
            double f;
            decimal e;
            char d;
            string s;
            bool a;
            object x;

            // 1-я версия развития событий
            if (choose1 == 'y')  
            {
                ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 1-a

                Console.WriteLine("Тип byte. Введите целое число (MIN = 0, MAX = 255):");
                type = Console.ReadLine();
                b = Convert.ToByte(type);
                Console.WriteLine(b);


                Console.WriteLine("Тип sbyte. Введите целое число (MIN = -128, MAX = 127):");
                type = Console.ReadLine();
                c = Convert.ToSByte(type);
                Console.WriteLine(c);


                Console.WriteLine("\nТип short. Введите целое число (MIN = -32768, MAX = 32768):");
                type = Console.ReadLine();
                l = Convert.ToInt16(type);
                Console.WriteLine(l);


                Console.WriteLine("\nТип ushort. Введите целое число (MIN = 0, MAX = 65535):");
                type = Console.ReadLine();
                m = Convert.ToUInt16(type);
                Console.WriteLine(m);


                Console.WriteLine("\nТип int. Введите целое число (MIN = -21474783648, MAX = 21474783648):");
                type = Console.ReadLine();
                h = Convert.ToInt32(type);
                Console.WriteLine(h);


                Console.WriteLine("\nТип uint. Введите целое число (MIN = 0, MAX = 4294967295):");
                type = Console.ReadLine();
                i = Convert.ToUInt32(type);
                Console.WriteLine(i);


                Console.WriteLine("\nТип long. Введите целое число (MIN = -9223372036854775808, MAX = 9223372036854775808):");
                type = Console.ReadLine();
                k = Convert.ToInt64(type);
                Console.WriteLine(k);


                Console.WriteLine("\nТип ulong. Введите целое число (MIN = 0, MAX = 18446744073709551615):");
                type = Console.ReadLine();
                n = Convert.ToUInt64(type);
                Console.WriteLine(n);


                Console.WriteLine("\nТип float. Введите число с плавающей точкой (MIN = -3,402823E+38, MAX = 3,402823E+38):");
                type = Console.ReadLine();
                g = Convert.ToSingle(type);
                Console.WriteLine(g);


                Console.WriteLine("\nТип double. Введите число с плавающей точкой (MIN = -1,79769313486232E+308, MAX = 1,79769313486232E+308):");
                type = Console.ReadLine();
                f = Convert.ToDouble(type);
                Console.WriteLine(f);


                Console.WriteLine("\nТип decimal. Введите число с плавающей точкой (MIN = -79228162514264337593543950335, MAX = 79228162514264337593543950335):");
                type = Console.ReadLine();
                e = Convert.ToDecimal(type);
                Console.WriteLine(e);


                Console.WriteLine("\nТип char. Введите символ (MIN = , MAX = ?):");
                type = Console.ReadLine();
                d = Convert.ToChar(type);
                Console.WriteLine(d);


                Console.WriteLine("\nТип string. Введите значение (MIN = N/A, MAX = N/A):");
                type = Console.ReadLine();
                s = Convert.ToString(type); // можно не писать эту строку, так как введённые с клавиатуры данные по умолчанию имеют формат string
                Console.WriteLine(s);


                Console.WriteLine("\nТип bool. Введите значение (MIN = False, MAX = True):");
                type = Console.ReadLine();
                a = Convert.ToBoolean(type);
                Console.WriteLine(a);


                Console.WriteLine("\nТип object. Введите значение (MIN = N/A, MAX = N/A):");
                x = Console.ReadLine();
                Console.WriteLine(x);



                ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 1-b



                Console.WriteLine("\nПереходить ли на задание 1-b? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");

                type = Console.ReadLine();
                choose2 = Convert.ToChar(type);
                if (choose2 == 'y')
                {
                    Console.Clear();

                    Console.WriteLine("////////////////////////////////////////////////\n\n" + "Задание 1-b" + '\n' + "Пять примеров неявного преобразования:" + '\n');
                    Console.WriteLine("h = " + h + " -> " + h.GetType() + "          " + "k = " + k + " -> " + k.GetType() + "\n");
                    k = h;
                    Console.WriteLine("k = h\t" + "k = " + k + " -> " + k.GetType());


                    Console.WriteLine("\n\n" + "b = " + b + " -> " + b.GetType() + "          " + "l = " + l + " -> " + l.GetType() + "\n");
                    l = b;
                    Console.WriteLine("l = b\t" + "l = " + l + " -> " + l.GetType());


                    Console.WriteLine("\n\n" + "i = " + i + " -> " + i.GetType() + "          " + "n = " + n + " -> " + n.GetType() + "\n");
                    n = i;
                    Console.WriteLine("n = i\t" + "n = " + n + " -> " + n.GetType());


                    Console.WriteLine("\n\n" + "g = " + g + " -> " + g.GetType() + "          " + "f = " + f + " -> " + f.GetType() + "\n");
                    f = g;
                    Console.WriteLine("f = g\t" + "f = " + f + " -> " + f.GetType());


                    Console.WriteLine("\n\n" + "c = " + c + " -> " + c.GetType() + "          " + "l = " + l + " -> " + l.GetType() + "\n");
                    l = c;
                    Console.WriteLine("l = c\t" + "l = " + l + " -> " + l.GetType());




                    Console.WriteLine("\n\nПять примеров явного преобразования:\n");
                    Console.WriteLine("h = " + h + " -> " + h.GetType() + "          " + "k = " + k + " -> " + k.GetType() + "\n");
                    k = (long)h;
                    Console.WriteLine("k = (long)h\t" + "k = " + k + " -> " + k.GetType());


                    Console.WriteLine("\n\n" + "b = " + b + " -> " + b.GetType() + "          " + "l = " + l + " -> " + l.GetType() + "\n");
                    l = (short)b;
                    Console.WriteLine("l = (short)b\t" + "l = " + l + " -> " + l.GetType());


                    Console.WriteLine("\n\n" + "i = " + i + " -> " + i.GetType() + "          " + "n = " + n + " -> " + n.GetType() + "\n");
                    n = (ulong)i;
                    Console.WriteLine("n = (ulong)i\t" + "n = " + n + " -> " + n.GetType());


                    Console.WriteLine("\n\n" + "g = " + g + " -> " + g.GetType() + "          " + "f = " + f + " -> " + f.GetType() + "\n");
                    f = (double)g;
                    Console.WriteLine("f = (double)g\t" + "f = " + f + " -> " + f.GetType());


                    Console.WriteLine("\n\n" + "c = " + c + " -> " + c.GetType() + "          " + "l = " + l + " -> " + l.GetType() + "\n");
                    l = (short)c;
                    Console.WriteLine("l = (short)c\t" + "l = " + l + " -> " + l.GetType());



                    ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 1-с



                    Console.WriteLine("\nПереходить ли на задание 1-c? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                    type = Console.ReadLine();
                    choose3 = Convert.ToChar(type);
                    if (choose3 == 'y')
                    {
                        Console.Clear();

                        Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 1-c\n");

                        Console.WriteLine("x = " + x + ", h = " + h + ". Упаковка. У нас есть две переменные: переменная x типа object и переменная h типа int.\nx=h // упаковка h, х указывает на упакованный объект.");
                        x = h;
                        Console.WriteLine("\nx = " + x);

                        Console.WriteLine("\nЗатем мы используем переменную k типа long. k = "+k+"\nk=(Int64)(Int32)x // распаковка, а затем приведение типа");
                        k = (Int64)(Int32)x;
                        Console.WriteLine("k = " + k);
                    }



                    ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 1-d



                    Console.WriteLine("\nПереходить ли на задание 1-d? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                    type = Console.ReadLine();
                    choose4 = Convert.ToChar(type);
                    if (choose4 == 'y')
                    {
                        Console.Clear();

                        Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 1-d\n");

                        var d12 = 777;
                        var d1 = "Azino";

                        Console.WriteLine("У нас есть две нетипизированные переменные: d1 и d12. d1 = "+ d1 + " -> " + d1.GetType()+", d12 = "+ d12 + " -> " + d12.GetType());

                        d12 = d12 + 111;
                        Console.WriteLine("Для примера, к переменной d12 прибавили число 111. По итогу получили: d12 = " + d12+" -> " + d12.GetType());
                    }



                    ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 1-e



                    Console.WriteLine("\nПереходить ли на задание 1-e? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                    type = Console.ReadLine();
                    choose5 = Convert.ToChar(type);
                    if (choose5 == 'y')
                    {
                        Console.Clear();

                        Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 1-e\n");

                        int? e1 = null;
                        int? e12 = 348;

                        Console.WriteLine("Даны две переменные: е1 и е12: е1 = "+e1+", e12 = "+e12+"\n");

                        if (!e1.HasValue) // возвращает true, если объект Nullable хранит некоторое значение
                        {
                            Console.WriteLine("e1 is a null!");
                        }
                        else { Console.WriteLine("e1 isn't a null!"); }


                        if (!e12.HasValue)
                        {
                            Console.WriteLine("e12 is a null!");
                        }
                        else { Console.WriteLine("e12 isn't a null!"); }

                    }



                    ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 1-f



                    Console.WriteLine("\nПереходить ли на задание 1-f? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                    type = Console.ReadLine();
                    choose6 = Convert.ToChar(type);
                    if (choose6 == 'y')
                    {
                        Console.Clear();

                        Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 1-f\n");

                        Console.WriteLine("var f1 = 543;\nМы не можем присвоить данной переменной значение другого типа, например, символ. Единственное отличие неявно типизированной переменной от обычной,\nявно типизированной переменной, — в способе определения ее типа. Как только этот тип будет определен, он закрепляется за переменной до конца ее существования.\n\n\t\tКОНЕЦ ПЕРВОГО ЗАДАНИЯ");
                    }
                }
            }
            // 2-я версия развития событий 
            else
            {
                if (choose1 == 'n')
                {
                    ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 1-a


                    Console.WriteLine("Тип byte:");
                    b = 133;
                    Console.WriteLine(b);


                    Console.WriteLine("\nТип sbyte:");
                    c = 54;
                    Console.WriteLine(c);


                    Console.WriteLine("\nТип short:");
                    l = 1188;
                    Console.WriteLine(l);


                    Console.WriteLine("\nТип ushort:");
                    m = 2650;
                    Console.WriteLine(m);


                    Console.WriteLine("\nТип int:");
                    h = -466267;
                    Console.WriteLine(h);


                    Console.WriteLine("\nТип uint:");
                    i = 763350;
                    Console.WriteLine(i);


                    Console.WriteLine("\nТип long:");
                    k = -645367133;
                    Console.WriteLine(k);



                    Console.WriteLine("\nТип ulong:");
                    n = 133462758382;
                    Console.WriteLine(n);


                    Console.WriteLine("\nТип flat:");
                    g = 133.62622F;
                    Console.WriteLine(g);


                    Console.WriteLine("\nТип double:");
                    f = 45.2678657;
                    Console.WriteLine(f);


                    Console.WriteLine("\nТип decimal:");
                    e = 133.5757752857M;
                    Console.WriteLine(e);


                    Console.WriteLine("\nТип char:");
                    d = 'k';
                    Console.WriteLine(d);


                    Console.WriteLine("\nТип string:");
                    s = "Hello, my dear friends!";
                    Console.WriteLine(s);


                    Console.WriteLine("\nТип bool:");
                    a = true;
                    Console.WriteLine(a);


                    Console.WriteLine("\nТип object:");
                    x = "Демонстрация типа object";
                    Console.WriteLine(x);



                    ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 1-b



                    Console.WriteLine("\nПереходить ли на задание 1-b? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");

                    type = Console.ReadLine();
                    choose2 = Convert.ToChar(type);
                    if (choose2 == 'y')
                    {
                        Console.Clear();

                        Console.WriteLine("////////////////////////////////////////////////\n\n" + "Второе задание" + '\n' + "Пять примеров неявного преобразования:" + '\n');
                        Console.WriteLine("h = " + h + " -> " + h.GetType() + "          " + "k = " + k + " -> " + k.GetType() + "\n");
                        k = h;
                        Console.WriteLine("k = h\t" + "k = " + k + " -> " + k.GetType());


                        Console.WriteLine("\n\n" + "b = " + b + " -> " + b.GetType() + "          " + "l = " + l + " -> " + l.GetType() + "\n");
                        l = b;
                        Console.WriteLine("l = b\t" + "l = " + l + " -> " + l.GetType());


                        Console.WriteLine("\n\n" + "i = " + i + " -> " + i.GetType() + "          " + "n = " + n + " -> " + n.GetType() + "\n");
                        n = i;
                        Console.WriteLine("n = i\t" + "n = " + n + " -> " + n.GetType());


                        Console.WriteLine("\n\n" + "g = " + g + " -> " + g.GetType() + "          " + "f = " + f + " -> " + f.GetType() + "\n");
                        f = g;
                        Console.WriteLine("f = g\t" + "f = " + f + " -> " + f.GetType());


                        Console.WriteLine("\n\n" + "c = " + c + " -> " + c.GetType() + "          " + "l = " + l + " -> " + l.GetType() + "\n");
                        l = c;
                        Console.WriteLine("l = c\t" + "l = " + l + " -> " + l.GetType());




                        Console.WriteLine("\n\nПять примеров явного преобразования:\n");
                        Console.WriteLine("h = " + h + " -> " + h.GetType() + "          " + "k = " + k + " -> " + k.GetType() + "\n");
                        k = (long)h;
                        Console.WriteLine("k = (long)h\t" + "k = " + k + " -> " + k.GetType());


                        Console.WriteLine("\n\n" + "b = " + b + " -> " + b.GetType() + "          " + "l = " + l + " -> " + l.GetType() + "\n");
                        l = (short)b;
                        Console.WriteLine("l = (short)b\t" + "l = " + l + " -> " + l.GetType());


                        Console.WriteLine("\n\n" + "i = " + i + " -> " + i.GetType() + "          " + "n = " + n + " -> " + n.GetType() + "\n");
                        n = (ulong)i;
                        Console.WriteLine("n = (ulong)i\t" + "n = " + n + " -> " + n.GetType());


                        Console.WriteLine("\n\n" + "g = " + g + " -> " + g.GetType() + "          " + "f = " + f + " -> " + f.GetType() + "\n");
                        f = (double)g;
                        Console.WriteLine("f = (double)g\t" + "f = " + f + " -> " + f.GetType());


                        Console.WriteLine("\n\n" + "c = " + c + " -> " + c.GetType() + "          " + "l = " + l + " -> " + l.GetType() + "\n");
                        l = (short)c;
                        Console.WriteLine("l = (short)c\t" + "l = " + l + " -> " + l.GetType());



                        ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 1-с



                        Console.WriteLine("\nПереходить ли на задание 1-c? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                        type = Console.ReadLine();
                        choose3 = Convert.ToChar(type);
                        if (choose3 == 'y')
                        {
                            Console.Clear();

                            Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 1-c\n");

                            Console.WriteLine("x = "+x+", h = "+h+". Упаковка. У нас есть две переменные: переменная x типа object и переменная h типа int.\nx=h // упаковка h, х указывает на упакованный объект.");
                            x = h;
                            Console.WriteLine("\nx = "+x);

                            Console.WriteLine("\nЗатем мы используем переменную k типа long. k = "+k+"\nk=(Int64)(Int32)x // распаковка, а затем приведение типа");
                            k = (Int64)(Int32)x;
                            Console.WriteLine("k = "+k);
                        }



                        ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 1-d



                        Console.WriteLine("\nПереходить ли на задание 1-d? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                        type = Console.ReadLine();
                        choose4 = Convert.ToChar(type);
                        if (choose4 == 'y')
                        {
                            Console.Clear();

                            Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 1-d\n");

                            var d12 = 777;
                            var d1 = "Azino";

                            Console.WriteLine("У нас есть две нетипизированные переменные: d1 и d12. d1 = " + d1 + " -> " + d1.GetType() + ", d12 = " + d12 + " -> " + d12.GetType());

                            d12 = d12 + 111;
                            Console.WriteLine("Для примера, к переменной d12 прибавили число 111. По итогу получили: d12 = " + d12 +" -> "+ d12.GetType());
                        }



                        ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 1-e



                        Console.WriteLine("\nПереходить ли на задание 1-e? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                        type = Console.ReadLine();
                        choose5 = Convert.ToChar(type);
                        if (choose5 == 'y')
                        {
                            Console.Clear();

                            Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 1-e\n");

                            int? e1 = null;
                            int? e12 = 348;

                            Console.WriteLine("Даны две переменные: е1 и е12: е1 = " + e1 + ", e12 = " + e12 + "\n");

                            if (!e1.HasValue) // возвращает true, если объект Nullable хранит некоторое значение
                            {
                                Console.WriteLine("e1 is a null!");
                            }
                            else { Console.WriteLine("e1 isn't a null!"); }


                            if (!e12.HasValue)
                            {
                                Console.WriteLine("e12 is a null!");
                            }
                            else { Console.WriteLine("e12 isn't a null!"); }

                        }



                        ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 1-f



                        Console.WriteLine("\nПереходить ли на задание 1-f? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                        type = Console.ReadLine();
                        choose6 = Convert.ToChar(type);
                        if (choose6 == 'y')
                        {
                            Console.Clear();

                            Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 1-f\n");

                            Console.WriteLine("var f1 = 543;\nМы не можем присвоить данной переменной значение другого типа, например, символ. Единственное отличие неявно типизированной переменной от обычной,\nявно типизированной переменной, — в способе определения ее типа. Как только этот тип будет определен, он закрепляется за переменной до конца ее существования.\n\n\t\tКОНЕЦ ПЕРВОГО ЗАДАНИЯ");
                        }
                    }
                }
            }
        }
    }
}

