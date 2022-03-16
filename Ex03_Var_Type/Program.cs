using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ex03_Var_Type
{
    class Human
    {
        public string Name;
        public List<string> hobby = new List<string>();// 취미가 여러개
    }
    class Program
    {
        static void Main(string[] args)
        {

            // List<Human> Friend
            var Friend = new List<Human>
            {
                // 생성자가 아니라 Property로 초기화 가능 !
                new Human{Name = "이", hobby = {"노래","기타","축구" } },
                new Human{Name = "김", hobby = {"야구","축구" } },
                new Human{Name = "박", hobby = {"농구" } },
            };

            Console.WriteLine(Friend[0].Name + "/" + Friend[0].hobby);
            foreach (var item in Friend[0].hobby)
            {
                Console.WriteLine($"hobby : {item}");
            }

            // 카페 210번, 227번글 참고
            //

            ///////////////////////////////////////////////////////////
            var x = 10; // int
            var y = 5;  // int
            var str = "문자열";    // string

            int[] arr = {1,2,3,4,5 };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            List<string> list = new List<string> {"가","나","다" };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // var는 주로 익명타입(이름 없는 클래스) >> 1회성 클래스 >> 재사용이 안됨.

            // 사실 원래 클래스는
            /*
             * class Member{
             * private string name;
             * private int age;
             * 
             * public Member(name,age){
             *  this.name = name;
             *  this.age = age;
             *  }
             * }
             * 
             * var member = new Member("홍길동",100);
             */

            // 익명 클래스(무명 클래스)는 주로 LINQ(데이터)에 사용됨.
            var lee = new {name ="홍길동", age=100 };
            Console.WriteLine(lee.name);
            Console.WriteLine(lee.age);
        }
    }
}
