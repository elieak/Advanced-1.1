using System;

namespace DynInvoke
{
    class Program
    {
        static void Main()
        {
            var classA = new A();
            var classB = new B();
            var classC = new C();

            InvokeHello(classA,"Class A");
            InvokeHello(classB, "Class B");
            InvokeHello(classC, "Class C");
        }

        static void InvokeHello(object obj, string myStr)
        {
            var str = obj.GetType().GetMethod("Hello").Invoke(obj, new object[] {myStr});
            Console.WriteLine(str);
        }
    }
    public class A
    {
        public string Hello(string str)
        {
            return "Hello " + str;
        }
    }
    public class B
    {
        public string Hello(string str)
        {
            return "Bonjour " + str;
        }
    }
    public class C
    {
        public string Hello(string str)
        {
            return "Nihau " + str;
        }
    }
}
