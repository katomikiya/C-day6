using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per1, per2;
            per1 = new Person();
            per2 = new Person();

            per1.name = "山田太郎";
            per1.age = 19;
            per2.SetAgeAndName("佐藤花子", 23);

            per1.showAgeAndName();
            per2.showAgeAndName();
        }
    }
}
