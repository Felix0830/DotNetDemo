using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleDemo
{
    public abstract class Student
    {
        public abstract void SetName(string name);

        public virtual void GetName()
        {
            Console.WriteLine($"抽象类中的虚方法");
        }

        public void SetAge()
        {
            Console.WriteLine($"抽象类方法实现");
        }
    }
}
