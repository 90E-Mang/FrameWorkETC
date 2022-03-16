using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Yield
{
    class Program
    {
        static IEnumerable<int> getNumber()
        {
            // IEnumerable 상속하고 있는 모든 자원이 return 대상이다.
            // return new[] {1,2,3,4,5}; <- 가능 ! 배열은 내부적으로 IEnumerable를 구현함
            //return new List<int>() {1,2,3,4,5};  <- 얘도 가능

            yield return 10; // 처음 호출 리턴
            yield return 20;
            yield return 30;
        }
        static IEnumerable<int> getNumber2()
        {
            Console.WriteLine("getNumber2 호출");
            // IEnumerable 상속하고 있는 모든 자원이 return 대상이다.
            return new[] { 1, 2, 3, 4, 5 }; // <- 가능 ! 배열은 내부적으로 IEnumerable를 구현함
            //return new List<int>() {1,2,3,4,5};  <- 얘도 가능
        }
        static void Main(string[] args)
        {
            foreach (var item in getNumber2())
            {
                Console.WriteLine(item);
            }

            foreach (var item in getNumber())
            {
                Console.WriteLine("getNumber : {0}",item);
            }
        }
    }
}
