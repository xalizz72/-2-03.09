using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2_03._09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ticketName = "";
            Console.Write("введите возраст ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("введите тип билета ");
            int ticket = Convert.ToInt32(Console.ReadLine());
            double basePrice = 0;
            switch (ticket)
            {
                case 1: ticketName = "обычный";
                        basePrice = 500;
                        break;
                case 2: ticketName = "студенческий"; 
                        basePrice = 350;
                        break;
                case 3: ticketName = "VIP";
                        basePrice = 1000;
                        break;

                default:
                    Console.WriteLine("Некорректный билет."); break;
            }
            Console.Write("введите день недели ");
    
            int Week = Convert.ToInt32(Console.ReadLine());
            bool isWeekend = (Week == 6 || Week == 7) ? true : false;
            double finalPrice = basePrice;
            string ageDiscountInfo = "нет";
            if (age < 18)
            {
                finalPrice *= 0.8; 
                ageDiscountInfo = "20%";
            }
            else if (age >= 60)
            {
                finalPrice *= 0.7; 
                ageDiscountInfo = "30%";
            }

            
            if (isWeekend)
            {
                finalPrice *= 1.1; 
            }
            Console.WriteLine($"Тип билета: {ticketName}");
            Console.WriteLine($"Возрастная скидка: {ageDiscountInfo}");

           
            string weekendOutput = isWeekend ? "да" : "нет";
            Console.WriteLine($"Выходной день: {weekendOutput}");

            Console.WriteLine($"Итоговая стоимость: {(int)finalPrice}");

        }
        }
    }

