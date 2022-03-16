using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Singleton
{
    // singleton 의 기본 : 생성자가 private --> 객체를 한개만 static으로 만들겠다 !
    // 생성자가 private인데 어떻게 객체를 안만들고 접근함 ? ---> static !
    class Test
    {
        private static Test instance;        // 현재 이 상태에서는 instance member field의 주소값이 없음(메모리)
        private Test()
        {

        }
        public static Test getInstance()        // 유일한 public 함수인 얘를 통해서 객체를 얻겠다 !
        {
            if (instance == null)
            {
                instance = new Test();      // instance가 null일때 객체생성함
            }
            return instance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Test test = new Test();  --> 그래서 싱글톤에서는 얘가 안됨.
            // Test.   <--- .찍어서도 위의 instance에 접근이 안됨.

            // 그래서 이렇게 Test class에 있는 getInstance 함수에 접근해서 객체 생성
            Test t = Test.getInstance();
            Test t2 = Test.getInstance();               // t2, t3은 함수안의 if문으로 인해 객체 생성은 안되고 이미 생성된 주소값을 받아옴.
            Test t3 = Test.getInstance();

            Console.WriteLine(t == t2);                 // 그래서 여기 값이 다 똑같음.
            Console.WriteLine(t2 == t3);
            Console.WriteLine(t.GetHashCode() + "/" + t2.GetHashCode() + "/" + t3.GetHashCode());
        }
    }
}
