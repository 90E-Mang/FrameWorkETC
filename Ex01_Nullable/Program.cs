using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Nullable
{
    /*
     * System.Nullable
     * 값 타입 : int, long, double 원칙적으로 >> null (x)
     * string, Car >> null(O)
     * string name = null (참조타입) null 가능
     * Car car = null     (참조타입) null 가능
     * 
     * 근데 문제가 생김
     * > DB 설계할 때 : table column 타입 정한 후 null 여부 지정
     * 
     * create table emp (empno int not null, emane nvarchar(10) null, age int null));
     * insert into emp(empno, enmae, age) values(7788,'홍길동',10);
     * >> 7788/홍길동/10
     * insert into emp(empno) values(7902);
     * >> 7902 /null /null
     * 
     * class Emp{
     * int empno;
     * string ename;
     * int age;
     * 
     * 
     * }
     * 
     * 보통 class랑 table이랑 1대 1 매칭인데 위의 경우 null이 들어가면 ..
     * 예외가 발생...
     * 개발자 요구 사항
     * 
     * >> int age = null; <- 이거 안되는건데 허용하길 원함 ! 
     * ㄴ> 새로운 문법 >> 사용하면 >> null 허용(값타입)
     * >> int? i = null 가능 자료형 끝에 ?를 붙여서 쓴다 !
     */
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            Console.WriteLine($"null 허용 : {i}");
            double? j = 1.23456;

            int? i2 = null;
            int j2;
            //j2 = i2;   i2가 null 가지고 있어서 안됨 !!!!

            // 혼재 되어 있는 경우 사용법 1(길어서 비선호)
            if (i2 == null)
            {
                j2 = 0;
            }
            else
            {
                //j2 = i2;  <- 값타입이 null을 가지는 순간 heap 영역으로 빠짐 !
                j2 = (int)i2;  // <- 그래서 이렇게 값타입으로 바꿔야 처리해야된다.
            }
            Console.WriteLine(j2);

            // 혼재 되어 있는 경우 사용법 2(짧아서 여기를 선호)
            // ?? 연산자( ?가 2개 !)
            // ??의 의미 : null이라면 오른쪽 값을 사용
            int? i3 = null;
            i3 = 100;
            int j3 = i3 ?? -1;  // null 이면 오른쪽 값, 아니면 왼쪽값.
            Console.WriteLine($"j3 : {j3}");

            int? i4 = null;
            int? j4 = i4 + 100;
            // 이 경우 값이 뭐가 나올까?
            // ***프로그래밍 or DB에서 원칙적으로 같은 것 : null과의 모든 연산은 null이다.***
            Console.WriteLine($"null 과의 모든 연산 : {j4}"); // 그래서 이 결과가 null이다 !
        }
    }
}
