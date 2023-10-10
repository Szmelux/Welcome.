using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte number;
            //var number1 = 999;
            //number1 = 123;
            //Console.WriteLine(number1);
            //double number2 = 123.41;
            //decimal amount = 31.12M;
            //bool isReady = false;
            //string name = "Klasa IIITPI";
            //char sign = '\0';
            //DateTime today = new DateTime(2023, 9, 12, 15, 35, 08);
            //Klasa klasa = new Klasa();
            //List<int> lista = new List<int>() { 1, 2, 3 };
            //lista.Add(4);
            //lista.Remove(1);
            //Console.WriteLine(lista[0]);
            //List<string> lista1 = new List<string>() { "A", "B", "C" };
            //int age = 20;
            //string myAge = "30";
            //age = int.Parse(myAge);
            //myAge = age.ToString();
            //Robot robot = new Robot("1234");
            //Robot robot2 = new Robot("2222");
            //Robot robot3 = new Robot("333");
            //Robot robot4 = new Robot("444");
            //Robot robot5 = new Robot("555");
            //robot.SayHello();
            //robot2.SayHello();
            //robot3.SayHello();
            //robot4.SayHello();
            //robot5.SayHello();
            //var currentRobotTime = robot.GetCurrentDate();
            //robot.name = "Robot 2020";
            //Console.WriteLine(robot.name);
            //var minAge = 10;
            //var maxAge = 20;
            //Console.Write("Proszę podaj swój wiek:");
            //var age = int.Parse(Console.ReadLine());
            //if(age > minAge && age < maxAge)
            //{
            //    Console.WriteLine("Możesz dołączyć do klubu");
            //}
            //else
            //{
            //    Console.WriteLine("Nie możesz dołączyć do klubu");
            //}
            //try 
            //{
            //    Console.Write("Dzielenie dwóch liczb.\n Podaj dzielną: ");
            //    var dividend = decimal.Parse(Console.ReadLine());
            //    Console.Write("Podaj dzielnik: ");
            //    var divider = decimal.Parse(Console.ReadLine());
            //    var result = dividend / divider;
            //    Console.WriteLine("Iloraz wynosi: " + result);
            //} catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Dzielnik nie może być zero");
            //    throw ex;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Nieprawidłowe dane");
            //    throw ex;
            //}
            //finally
            //{
            //    Console.WriteLine("Kod po try catch");
            //}
            try
            {
                Console.Write("Podaj pierwszą liczbę: ");
                //var num1 = int.Parse(Console.ReadLine());
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    throw new Exception("Podana wartość jest nieprawidłowa");
                }

                Console.WriteLine("Jaką operacje chcesz teraz wykonać? Możliwe operacje to '+','-','*','/'.");
                var action = Console.ReadLine();

                Console.Write("Podaj drugą liczbę:");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    throw new Exception("Podana wartość jest nieprawidłowa");
                }

                var result = Calculate(num1, num2, action);
                Console.WriteLine("Wynik twojego działania " + result);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static int Calculate(int num1 , int num2, string action)
        {
            switch (action)
            {
                case "+":
                    return  num1 + num2;
                    break;
                case "-":
                    return  num1 - num2;
                    break;
                case "*":
                    return  num1 * num2;
                    break;
                case "/":
                    return  num1 / num2;
                    break;
                default:
                    throw new Exception("Wybrałeś złą operacje!");
            }
        }
   
}
