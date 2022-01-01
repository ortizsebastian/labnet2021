using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        //Pasar el metodo AddBus/AddCab a Logic
        //Agregar validaciones para ingresos vacios o de letras

        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 *Ingresar Transporte.");
                Console.WriteLine("2 *Listar Transportes.");
                Console.WriteLine("3 *Finalizar.");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddTransport();
                        break;
                    case 2:
                        ListTransport();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Incorrecto!");
                        Console.ReadKey();
                        break;
                }
            }
        }
     
        static void ListTransport()
        {          
            Console.Clear();

            Logic logic = new Logic();

            List<Bus> busList = new List<Bus>(logic.GetBusList());
            List<Cab> cabList = new List<Cab>(logic.GetCabList());

            if(busList.Count == 0 && cabList.Count == 0)
            {
                Console.WriteLine("Sin transportes para listar!");
                Console.ReadKey();
            }

            foreach (var item in busList)
            {
                int arg = busList.IndexOf(busList.Single(x => x == item));
                Console.WriteLine(string.Format("*Omnibus: {0}", arg + 1));

                Console.WriteLine(string.Format("Pasajeros: {0}",item.Passengers));
                Console.WriteLine(string.Format("Marca: {0}\n",item.TradeMark));
            }
            
            foreach (var item in cabList)
            {
                int arg = cabList.IndexOf(cabList.Single(x => x == item));
                Console.WriteLine(string.Format("\n*Taxi: {0}", arg + 1));

                Console.WriteLine(string.Format("Pasajeros: {0}", item.Passengers));
                Console.WriteLine(string.Format("Marca: {0}", item.TradeMark));
            }
            Console.ReadKey();
        }

        static void AddTransport()
        {
            Console.Clear();
            Console.WriteLine("Ingresar tipo de transporte.\n");
            Console.WriteLine("1 *Omnibus.");
            Console.WriteLine("2 *Taxi.");
            Console.WriteLine("3 *Volver.");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: AddBus();
                    break;

                case 2: AddCab();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Incorrecto!");
                    Console.ReadKey();
                    break;
            }
        }

        static void AddBus()
        {
            Console.Clear();
            Logic logic = new Logic();
            List<Bus> busList = new List<Bus>(logic.GetBusList());
            if (busList.Count == 5)
            {
                Console.WriteLine("Cantidad total de Omnibus alcanzada.");
                Console.ReadKey();
            }

            Console.WriteLine("Ingresar cantidad de Pasajeros.");
            int passengers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngresar la Marca del omnibus.");
            string tradeMark = Console.ReadLine();
            logic.AddBus(new Bus(passengers, tradeMark));

            Console.Clear();
            Console.WriteLine("Ingreso completado correctamente!");
            Console.ReadKey();
            MainMenu();
        }

        static void AddCab()
        {
            Console.Clear();
            Logic logic = new Logic();
            List<Cab> cabList = new List<Cab>(logic.GetCabList());
            if (cabList.Count == 5)
            {
                Console.WriteLine("Cantidad total de Taxis alcanzada.");
                Console.ReadKey();
                MainMenu();
            }

            Console.WriteLine("Ingresar cantidad de Pasajeros.");
            int passengers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngresar la Marca del taxi.");
            string tradeMark = Console.ReadLine();
            logic.AddCab(new Cab(passengers, tradeMark));

            Console.Clear();
            Console.WriteLine("Ingreso completado correctamente!");
            Console.ReadKey();
            MainMenu();
        }
    }
}
