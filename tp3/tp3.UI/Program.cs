using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp3.Entities;
using tp3.Logic;

namespace tp3.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1* Customers.");
                Console.WriteLine("2* Employees.");
                Console.WriteLine("0* Exit.");
                int option = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        MenuCustomers();
                        break;
                    case 2:
                        MenuEmployees();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }

        static void MenuCustomers()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1* Add.");
                Console.WriteLine("2* Update (Address).");
                Console.WriteLine("3* Delete.");
                Console.WriteLine("4* List.");
                Console.WriteLine("0* Back to main menu.");
                int option = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Update();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4:
                        GetList();
                        break;
                    case 0:
                        MainMenu();
                        break;
                    default:
                        break;
                }
            }
        }

        static void MenuEmployees()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1* Add.");
                Console.WriteLine("2* Update (First name).");
                Console.WriteLine("3* Delete.");
                Console.WriteLine("4* List.");
                Console.WriteLine("0* Back to main menu.");
                int option = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Update();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4:
                        GetList();
                        break;
                    case 0:
                        MainMenu();
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Falta desarrollar los metodos encargados de llamar a la logica.
        /// </summary>

        static void Add()
        {

        }
        static void Update()
        {

        }
        static void Delete()
        {

        }
        static void GetList()
        {

        }
    }
}
