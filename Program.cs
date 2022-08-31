using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    internal class Program
    {
        public static void Caculate()
        {
            try
            {
                Console.WriteLine("Nhap 1 so");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Can bac hai cua " + a + " = ");
                Console.Write(Math.Sqrt(a));
            }
            catch (InvalidDataException a)
            {
                Console.WriteLine(a.Message);
            }
            finally
            {
                Console.WriteLine();
            }
        }
        public static void Input()
        {
            int num1, num2;
            byte result;
            num1 = 30;
            num2 = 60;
            try
            {
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} ={2}", num1, num2, result);
                Console.ReadLine();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overload", ex.Message);
            }
        }
        public static void ReadNumber(int star, int end)
        {
            int[] a = new int[end - star+1];
            bool flag = true;
             try
            {
                while (flag) {
                    for (int i = end; i <= star; i++)
                    {
                        a[i] = int.Parse(Console.ReadLine());
                    }
                    for (int i = star; i <= end; i++)
                    {
                        for (int j = star + 1; j <= end; j++)
                        {
                            if (a[i] == a[j])
                            {
                                Console.WriteLine("Input bi sai");
                                flag = true;
                            }
                        }
                    }
                }
            }
            catch (InvalidDataException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine();
            }
        }

        public static void Convertt()
        {
            Console.WriteLine("Nhap so :");
            string dling = Console.ReadLine();
            Console.WriteLine("Chuyen doi :");
            double a;
            double.TryParse(dling, out a);
            Console.WriteLine("a :" + a);
        }
        public static void Main(string[] cmd)
        {
            Console.WriteLine("input name:");
            string name = Console.ReadLine();
            Console.WriteLine("input age:");
            int age = int.Parse(Console.ReadLine());
            Student student = new Student(age, name);
            Console.WriteLine(student.ToString());
        }
    }
}
