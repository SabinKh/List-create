using CreateList.Collections;
using System;

namespace CreateList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
            list.Add("Hello1");
            list.Add("Hello2");
            list.Add("Hello3");
            list.Add("Hello4");
            list.Add("Hello5");
            list.Add("Hello6");
            list.Add("Hello7");
            list.Add("Hello8");
            list.Add("Hello9");
            list.Add("Hello10");
            list.Add("Hello11");
            MyList<int> list2 = new MyList<int>();
            Console.WriteLine(list2.Find(i=>i==100));

        }
    }
}
