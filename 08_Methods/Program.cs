using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            //()

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //}

            //CustomerList();
            // void Sum()
            //{
            //    int x = 5;
            //    int y = 9;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("UMUT CAN YAVRU");

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();


            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";


            //    return name + " " + surname;

            //}
            //Console.WriteLine(StudentCard());

           // string CountryCard(string countryName,string capital,string flagColor)
           // {
           //     string cardInfo = countryName + capital + flagColor;
           //     return cardInfo;
           // }

           // string x,y,z;
           // Console.Write("Ülke Adını Giriniz:");
           // x = Console.ReadLine();
           // Console.Write("Başkenti Giriniz:");
           // y = Console.ReadLine();
           // Console.Write("Bayrak Giriniz:");
           // z = Console.ReadLine();

           //Console.WriteLine(CountryCard(x, y, z));


            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(90, 80));
            //Console.WriteLine(Sum(70, 80));
            //Console.WriteLine(Sum(770, 80));
            //Console.WriteLine(Sum(450, 80));

            string ExamResults(string student,int exam1,int exam2,int exam3)
            {
                int results = (exam1 + exam2 + exam3) / 3;
                if (results >= 50)
                {
                    return student + "isimli öğrenci sınavı geçti" +"Otalama"+results;
                }
                else
                {
                    return "Öğrenci başarısız oldu";
                }

            }

            Console.WriteLine(ExamResults("Ali",25,41,85));
            Console.WriteLine(ExamResults("Ayşe",36,88,33));


            #endregion
        }
    }
}
