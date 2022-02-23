using System.Collections;

namespace arrayList2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList person = new ArrayList();
            string name;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("請輸入要儲存在 arylst 的姓名：");
                name = Console.ReadLine();
                person.Add(name);
            }

            Console.WriteLine("\n");

            // 1.原來名單
            Console.WriteLine("1. 原來名單：");
            foreach (string n in person)
            {
                Console.Write("{0}\t", n);
            }

            Console.WriteLine("\n");

            // 2.找出Fred的索引值
            Console.Write("2. {0} 的索引值為 {1}", person[person.IndexOf("Fred")], person.IndexOf("Fred"));

            Console.WriteLine("\n");

            // 3.遞增排序
            person.Sort();
            Console.WriteLine("3. 遞增排序之結果：");
            foreach (string n in person)
            {
                
                Console.Write("{0}\t", n);
            }

            Console.WriteLine("\n");

            // 4.遞減排序
            person.Reverse();
            Console.WriteLine("4. 遞減排序之結果：");
            foreach (string n in person)
            {
                Console.Write("{0}\t", n);
            }
            Console.Read();
        }
    }
}