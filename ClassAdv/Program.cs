using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAdv
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 소멸자 실습
            Product product1 = new Product("과자", 1000);
            Product product2 = new Product("뺴뺴로", 1500);
            Product product3 = new Product("닭꼬치", 3500);
            Product product4 = new Product("탕후루", 3000);

            Console.WriteLine("안녕하세요");
            Console.WriteLine("안녕하세요");
            Console.WriteLine("안녕하세요");
            Console.WriteLine("안녕하세요");
            Console.WriteLine("안녕하세요");

            // 속성(Property) 실습
            Box box = new Box(10, 10);
            box.Width = 100;
            try
            {
                box.Height = -190;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
