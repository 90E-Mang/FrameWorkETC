using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ex04_Var_List
{

    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<string, bool> dic 을 var로 초기화
            var dic = new Dictionary<int, bool>();
            dic.Add(1, true);
            dic.Add(2, false);

            // collection류를 다룰 때, var 타입을 자주 쓴다.
            List<int> keys = new List<int>(dic.Keys);
            foreach (var item in keys)
            {
                Console.WriteLine($"key : {item}");
            }

            var datalist = new List<string>(new string[] {"A","B","C","D","E","F"});
            var range = datalist.GetRange(1,2);
            //List<string> range
            foreach (var item in range)
            {
                Console.WriteLine($"range : {item}");
            }

        }
    }
}
