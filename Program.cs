using System;

namespace Cs_3_report
{
    class Program
    {
        class cal
        {
            public decimal _add(decimal a, decimal b)
            {
                return a + b;
            }
            public decimal _sub(decimal a, decimal b)
            {
                return a - b;
            }
            public decimal _div(decimal a, decimal b)
            {
                return a / b;
            }
            public decimal _share(decimal a, decimal b)
            {
                return a % b;
            }
            public decimal _multiply(decimal a, decimal b)
            {
                return a * b;
            }
            public decimal _pow(decimal a, decimal b)
            {   //decimal의 거듭제곱은 아래형태로 변환해야합니다.
                Double X = (double)a;
                Double Y = (double)b;
                return (decimal)System.Math.Pow(X, Y);
            }
            public void _abs(decimal a, decimal b)
            {
                if (a < 0 && b < 0)
                {
                    a = a * (-1);
                    b = b * (-1);

                }
                else if (a < 0) { a = a * (-1); }
                else if (b < 0) { b = b * (-1); }
                Console.WriteLine("\n\n첫 번째 절댓값 : {0}, 두번째 절댓값 : {1}\n\n", a, b);
            }

        }

        static void Main(string[] args)
        {
            while (true)
            {

                // 변수 선언 
                decimal result = 0;
                decimal input1, input2;
                string input3;
                string[] cal = { "덧셈", "뺄셈", "나눗셈", "몫", "곱하기", "거듭제곱", "절댓값", "종료" };
                int num, check = 1;

                //숫자가 아닐경우 예외처리
                try   
                {
                    // 1번 인자 받기
                    Console.Write("첫번째 숫자(정수 or 실수)를 입력하세요 ex) 1, 1.4 : ");
                    input1 = decimal.Parse(Console.ReadLine());

                    // 2번인자받기
                    Console.Write("두번째 숫자(정수 or 실수)를 입력하세요 ex) 1, 1.4 : ");
                    input2 = decimal.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("숫자를 입력하쇼");
                    break;
                }

                //계산 물어보기
                Console.Write("'덧셈', '뺄셈', '나눗셈', '몫', '곱하기', '거듭제곱', '절댓값' or '종료'를 입력하세요 : ");
                input3 = Console.ReadLine();
                num = Array.IndexOf(cal, input3);     //배열과 비교

                cal _cal = new cal();                   //class 선언

                //계산
                if (num == 0) { result = _cal._add(input1, input2); }
                else if (num == 1) { result = _cal._sub(input1, input2); }
                else if (num == 2) { result = _cal._div(input1, input2); }
                else if (num == 3) { result = _cal._share(input1, input2); }
                else if (num == 4) { result = _cal._multiply(input1, input2); }
                else if (num == 5) { result = _cal._pow(input1, input2); }
                else if (num == 6)
                {
                    _cal._abs(input1, input2);
                    check = 0;
                }
                else if (num == 7) { break;}
                else
                {
                    Console.WriteLine("다시입력하세요");
                    check = 0;
                }

                //수식이 올바를 경우만 출력
                if (check == 1)
                {
                    result = decimal.Round(result, 2);         //소수 2째 반올림
                    Console.WriteLine("\n\n1번 입력 : {0} \n2번 입력 : {1} \n결과 : {2}\n\n", input1, input2, result);
                }
            }
        }
    }
}