using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleDemo
{
    public class StudentTest : Student
    {
        public override void SetName(string name)
        {
            Console.WriteLine("继承抽象类的实现 SetName");
        }

        public override void GetName()
        {
            base.GetName();
            Console.WriteLine("继承抽象类的实现  重写虚方法");
        }
    }
}
