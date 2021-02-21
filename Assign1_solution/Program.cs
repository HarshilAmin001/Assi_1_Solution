using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1_solution
{
    class Program
    {

        public static void Main(string[] args)
        {
            void Menu()
            {
                Console.WriteLine("Select the option using Number");
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Please select an option from the above list");
            }
            Console.WriteLine("Please enter the width");
            int width = int.Parse(Console.ReadLine());
            if (width <= 0)
            {
                Console.WriteLine("Please enter valid width, Cannot be a nagative or 0");
                width = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please enter length");
            int length = int.Parse(Console.ReadLine());
            if (length <= 0)
            {
                Console.WriteLine("Please enter valid length, Cannot be a nagative or 0");
                length = int.Parse(Console.ReadLine());
            }

            Rectangle rectObj = new Rectangle(length, width);

            var a = true;
            while (a)
            {
                Menu();
                int num = int.Parse(Console.ReadLine());

                if (num <= 0 || num > 7)
                {
                    Console.WriteLine("Entered Number is Invalid");
                    Menu();
                    num = int.Parse(Console.ReadLine());

                }

                switch (num)
                {
                    case 1:
                        {
                            Console.WriteLine("Lenght of the rectangle is " + rectObj.GetLength());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n\nPlease enter new length");
                            var newLength = int.Parse(Console.ReadLine());
                            if (newLength <= 0)
                            {
                                Console.WriteLine("Please enter valid length,Cannot be 0 or negative");
                                newLength = int.Parse(Console.ReadLine());
                            }
                            rectObj.SetLength(newLength);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Weight of  rectangle is " + rectObj.GetWidth());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\n\nPlease enter new width");
                            var newWidth = int.Parse(Console.ReadLine());
                            if (newWidth <= 0)
                            {
                                Console.WriteLine("Please enter valid width, Cannot be 0 or negative");
                                newWidth = int.Parse(Console.ReadLine());
                            }
                            rectObj.SetWidth(newWidth);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Perimeter of rectangle is " + rectObj.GetPerimeter());
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Area of rectangle is " + rectObj.GetArea());
                            break;
                        }
                    case 7:
                        {
                            a = false;
                            break;
                        }
                }
            }


        }
    }

}
