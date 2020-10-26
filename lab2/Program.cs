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
            char choose1, choose2, choose3, choose4, choose5, choose6, choose22;

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

                }

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
                            e1 = 35;
                            Console.WriteLine("e1 is a null!. Присвоили значение этой переменной. Теперь е1 -> " + e1);
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



                    ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 2-a



                    Console.WriteLine("\nПереходить ли на задание 2-a? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                    type = Console.ReadLine();
                    choose22 = Convert.ToChar(type);
                    if (choose22 == 'y')
                    {
                        Console.Clear();

                        Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 2-a\n");

                        string s22 = "It's me, MARIO!", s221 = "uKRAINE";

                        Console.WriteLine("Первая строка -> "+s22+", вторая строка -> "+s221+"\n");

                        if(s22==s221)
                        {
                            Console.WriteLine("Строки идентичины");
                        }
                        else
                        {
                            Console.WriteLine("Строки не идентичины");
                        }
                    }



                    ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 2-b



                    Console.WriteLine("\nПереходить ли на задание 2-b? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                    type = Console.ReadLine();
                    choose22 = Convert.ToChar(type);
                    if (choose22 == 'y')
                    {
                        Console.Clear();

                        Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 2-b\n");

                        string temporary;
                        string s222 = "Azino777";
                        string s22 = "It's me, MARIO!", s221 = "uKRAINE";

                        Console.WriteLine("Даны три строки:\nПервая -> "+s22+", вторая -> "+s221+", третья -> "+s222+"\n");


                        s22 += s221 + s222;
                        Console.WriteLine("1) Сцепление трёх строк: "+s22+"\n\n");


                        temporary = String.Copy(s221);
                        Console.WriteLine("2) Копирование строки s221 = uKRAINE в строку temporary. temporary -> "+temporary+"\n\n");


                        Console.WriteLine("3) Выделение подстроки. Из строки temporary выделели подстроку, которая начинается со второго символа -> "+ temporary.Substring(1, 6)+"\n\n");


                        string text = "Я разделяю строкууууу на словаааа";
                        Console.WriteLine("4) Разделение строки. Дана строка с названием text -> "+text+"\n");
                        string[] words = text.Split(' ');   // массив разделителей, по которым разбивается текст на слова
                        Console.WriteLine("Строка была разделена на слова:\n");
                        foreach(string ll in words)         /*Оператор цикла foreach действует следующим образом. Когда цикл начинается, первый элемент массива выбирается и присваивается переменной цикла.*/                           
                        {                                   /*На каждом последующем шаге итерации выбирается следующий элемент массива, который сохраняется в переменной цикла.*/ 
                            Console.WriteLine(ll+"\n");     /*Цикл завершается, когда все элементы массива окажутся выбранными.*/
                        }


                        text = "Я шагаю по столу ";
                        string text1 = "как Назарбаев в Астану";
                        Console.WriteLine("\n5) Вставка строки в другую строку в заданную позицию.\nДаны две строки: 1-я строка ->"+text+", 2-я -> "+text1+"\n");
                        text = text.Insert(17, text1);      // первым параметром в функции Insert является индекс, по которому надо вставлять подстроку, а второй параметр - собственно подстрока.
                        Console.WriteLine("Итоговая строка: "+text+"\n\n");


                        Console.WriteLine("6) Удаление заданной подстроки.\nДана строка -> "+text1+"\n");
                        text1 = text1.Remove(0, 4);
                        Console.WriteLine("Удалили слово *как *. Итог -> "+ text1+"\n\n");


                        Console.WriteLine("7) Интерполяция строк.\n");
                        int w1 = 8, w2 = 33;
                        Console.WriteLine($"Если сложить числа {w1} и {w2} - будет {w1+w2}.");
                    }



                    ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 2-c



                    Console.WriteLine("\nПереходить ли на задание 2-c? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                    type = Console.ReadLine();
                    choose22 = Convert.ToChar(type);
                    if (choose22 == 'y')
                    {
                        Console.Clear();

                        Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 2-c\n");

                        string name = null;
                        string ff = "Вроде бы что-то есть...";

                        bool test = String.IsNullOrEmpty(name); // возвращает значение true, если параметр value равен null или пустой текст ""
                        if (test)
                        {
                            Console.WriteLine("Строка пустая");
                        }
                        else
                        {
                            Console.WriteLine("Строка не пустая");
                        }

                        Console.WriteLine("\nДана строка -> "+ff+"\nСейчас в неё я скопирую null-строку:\n");
                        ff = String.Copy(name);
                        Console.WriteLine("Результат -> "+name);
                    }



                    ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 2-d



                    Console.WriteLine("\nПереходить ли на задание 2-d? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                    type = Console.ReadLine();
                    choose22 = Convert.ToChar(type);
                    if (choose22 == 'y')
                    {
                        Console.Clear();

                        Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 2-d\n");

                        StringBuilder hello = new StringBuilder("Привет, меня зовут Василевич Владимир", 140);
                        Console.WriteLine(hello+"\n");
                        hello.Remove(9, 4); // удаляет 4 элемента, начиная с 9 позиции
                        Console.WriteLine(hello+"\n");
                        hello.Insert(0, "xxx");
                        hello.Insert(37, "xxx");
                        Console.WriteLine(hello+ "\n\n\t\tКОНЕЦ ВТОРОГО ЗАДАНИЯ");
                    }



                    ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 3-a



                    Console.WriteLine("\nПереходить ли на задание 3-a? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                    type = Console.ReadLine();
                    choose22 = Convert.ToChar(type);
                    if (choose22 == 'y')
                    {
                        Console.Clear();

                        Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 3-a\n");
                        int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                        int rows = mas.GetUpperBound(0) + 1;
                        int columns = mas.Length / rows;
                        for (int q = 0; q < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                Console.Write($"{mas[q, j]} \t");
                            }
                            Console.WriteLine();
                        }
                    }



                    ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 3-b



                    Console.WriteLine("\nПереходить ли на задание 3-b? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                    type = Console.ReadLine();
                    choose22 = Convert.ToChar(type);
                    if (choose22 == 'y')
                    {
                        Console.Clear();

                        Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 3-b\n");
                        string[] massive = new string[4] { "1st string", "2nd string", "3rd string", "4th string" };
                        foreach(string oo in massive)
                        {
                            Console.WriteLine(oo+"\n");
                        }
                        Console.WriteLine("Размерность массива - "+massive.Length+"\n");

                        string position;
                        int pose;
                        Console.WriteLine("Введите номер элемента массива, который вы хотите заменить (от 0 до 3):");
                        position = Console.ReadLine();
                        pose = Convert.ToInt32(position);
                        massive[pose]= Console.ReadLine();
                        Console.WriteLine("Изменённый массив\n");
                        foreach (string oo in massive)
                        {
                            Console.WriteLine(oo + "\n");
                        }

                    }



                ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 3-c



                Console.WriteLine("\nПереходить ли на задание 3-c? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                type = Console.ReadLine();
                choose22 = Convert.ToChar(type);
                if (choose22 == 'y')
                {
                    Console.Clear();
                    Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 3-c\n");
                    float[][] masc = new float[3][];
                    masc[0] = new float[2];
                    masc[1] = new float[3];
                    masc[2] = new float[4];
                    Console.WriteLine("Введите значения элементов массива:");
                    int roows = 1, cools = 0;
                    for (int iroows = 0; iroows < 3; iroows++)
                    {
                        masc[iroows][cools] = Convert.ToSingle(Console.ReadLine());
                        roows++;
                        cools++;
                    }
                    cools = 0;
                    for (int iroows = 0; iroows < 3; iroows++)
                    {
                        foreach(int element in masc[iroows])
                        {
                            Console.WriteLine($"{masc[iroows][cools]} ");
                            cools++;
                        }
                        Console.WriteLine();
                        roows++;
                        cools = 0;
                    }
                }



                ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 3-a



                Console.WriteLine("\nПереходить ли на задание 3-d? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                type = Console.ReadLine();
                choose22 = Convert.ToChar(type);
                if (choose22 == 'y')
                {
                    Console.Clear();

                    Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 3-d\n");
                    var masssivchik = new [] { "stroke1", "stroke2", "stroke3" };
                    var stroka = "stroke4";
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
                                e1 = 35;
                                Console.WriteLine("e1 is a null!. Присвоили значение этой переменной. Теперь е1 -> " + e1);
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



                        ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 2-a



                        Console.WriteLine("\nПереходить ли на задание 2-a? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                        type = Console.ReadLine();
                        choose22 = Convert.ToChar(type);
                        if (choose22 == 'y')
                        {
                            Console.Clear();

                            Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 2-a\n");

                            string s22 = "It's me, MARIO!", s221 = "uKRAINE";

                            Console.WriteLine("Первая строка -> " + s22 + ", вторая строка -> " + s221 + "\n");

                            if (s22 == s221)
                            {
                                Console.WriteLine("Строки идентичины");
                            }
                            else
                            {
                                Console.WriteLine("Строки не идентичины");
                            }
                        }



                        ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 2-b



                        Console.WriteLine("\nПереходить ли на задание 2-b? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                        type = Console.ReadLine();
                        choose22 = Convert.ToChar(type);
                        if (choose22 == 'y')
                        {
                            Console.Clear();

                            Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 2-b\n");

                            string temporary;
                            string s222 = "Azino777";
                            string s22 = "It's me, MARIO!", s221 = "uKRAINE";

                            Console.WriteLine("Даны три строки:\nПервая -> " + s22 + ", вторая -> " + s221 + ", третья -> " + s222 + "\n");


                            s22 += s221 + s222;
                            Console.WriteLine("1) Сцепление трёх строк: " + s22 + "\n\n");


                            temporary = String.Copy(s221);
                            Console.WriteLine("2) Копирование строки s221 = uKRAINE в строку temporary. temporary -> " + temporary + "\n\n");


                            Console.WriteLine("3) Выделение подстроки. Из строки temporary выделели подстроку, которая начинается со второго символа -> " + temporary.Substring(1, 6) + "\n\n");


                            string text = "Я разделяю строкууууу на словаааа";
                            Console.WriteLine("4) Разделение строки. Дана строка с названием text -> " + text + "\n");
                            string[] words = text.Split(' ');   // массив разделителей, по которым разбивается текст на слова
                            Console.WriteLine("Строка была разделена на слова:\n");
                            foreach (string ll in words)         /*Оператор цикла foreach действует следующим образом. Когда цикл начинается, первый элемент массива выбирается и присваивается переменной цикла.*/
                            {                                   /*На каждом последующем шаге итерации выбирается следующий элемент массива, который сохраняется в переменной цикла.*/
                                Console.WriteLine(ll + "\n");     /*Цикл завершается, когда все элементы массива окажутся выбранными.*/
                            }


                            text = "Я шагаю по столу ";
                            string text1 = "как Назарбаев в Астану";
                            Console.WriteLine("\n5) Вставка строки в другую строку в заданную позицию.\nДаны две строки: 1-я строка ->" + text + ", 2-я -> " + text1 + "\n");
                            text = text.Insert(17, text1);      // первым параметром в функции Insert является индекс, по которому надо вставлять подстроку, а второй параметр - собственно подстрока.
                            Console.WriteLine("Итоговая строка: " + text + "\n\n");


                            Console.WriteLine("6) Удаление заданной подстроки.\nДана строка -> " + text1 + "\n");
                            text1 = text1.Remove(0, 4);
                            Console.WriteLine("Удалили слово *как *. Итог -> " + text1 + "\n\n");


                            Console.WriteLine("7) Интерполяция строк.\n");
                            int w1 = 8, w2 = 33;
                            Console.WriteLine($"Если сложить числа {w1} и {w2} - будет {w1 + w2}.");
                        }



                        ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 2-c



                        Console.WriteLine("\nПереходить ли на задание 2-c? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                        type = Console.ReadLine();
                        choose22 = Convert.ToChar(type);
                        if (choose22 == 'y')
                        {
                            Console.Clear();

                            Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 2-c\n");

                            string name = null;
                            string ff = "Вроде бы что-то есть...";

                            bool test = String.IsNullOrEmpty(name); // возвращает значение true, если параметр value равен null или пустой текст ""
                            if (test)
                            {
                                Console.WriteLine("Строка пустая");
                            }
                            else
                            {
                                Console.WriteLine("Строка не пустая");
                            }

                            Console.WriteLine("\nДана строка -> " + ff + "\nСейчас в неё я скопирую null-строку:\n");
                            ff = String.Copy(name);
                            Console.WriteLine("Результат -> " + name);
                        }



                        ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 2-d



                        Console.WriteLine("\nПереходить ли на задание 2-d? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                        type = Console.ReadLine();
                        choose22 = Convert.ToChar(type);
                        if (choose22 == 'y')
                        {
                            Console.Clear();

                            Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 2-d\n");

                            StringBuilder hello = new StringBuilder("Привет, меня зовут Василевич Владимир", 140);
                            Console.WriteLine(hello + "\n");
                            hello.Remove(9, 4);
                            Console.WriteLine(hello + "\n");
                            hello.Insert(0, "xxx");
                            hello.Insert(37, "xxx");
                            Console.WriteLine(hello + "\n\n\t\tКОНЕЦ ВТОРОГО ЗАДАНИЯ");
                        }



                        ///////////////////////////////////////////////////////////////////////// ЗАДАНИЕ 3-a



                        Console.WriteLine("\nПереходить ли на задание 3-a? y - да (тогда экран очистится). Если хотите оставаться на этом задании, то ничего не нажимайте.");
                        type = Console.ReadLine();
                        choose22 = Convert.ToChar(type);
                        if (choose22 == 'y')
                        {
                            Console.Clear();

                            Console.WriteLine("////////////////////////////////////////////////\n\nЗадание 3-a\n");
                            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                            int rows = mas.GetUpperBound(0) + 1;
                            int columns = mas.Length / rows;
                            for (int q = 0; q < rows; i++)
                            {
                                for (int j = 0; j < columns; j++)
                                {
                                    Console.Write($"{mas[q, j]} \t");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}

