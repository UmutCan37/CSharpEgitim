using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cities = { "milona", "roma", "budapeşte", "anakra", "istanbul", "varşova" };
            //foreach(string city in cities)
            //{
            //    Console.WriteLine(city);
            //}
            //int[] numbers = {45,78,985,635,74,11,12,33,22,205,6578,10394};
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;

            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("----------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayan diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 adet sınav notu girişi alıyoruz
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // notları topluyoruz
                }
                Console.WriteLine();

                studentExamAvg[i] = totalExamResult / 3;
            }

            //Öğrencilerin sınav ortalaması
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("----------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin geçip kalma durumu
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
            }
            #endregion

        }
    }
}
