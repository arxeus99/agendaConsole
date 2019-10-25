using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void dibujar()
        {
            Console.WriteLine("------AGENDA------");
            Console.WriteLine("1.Create event");
            Console.WriteLine("2.Finish event");
            Console.WriteLine("3.Show three fisrts events");
            Console.WriteLine("4.Show all the events");
            Console.WriteLine("5.Exit");
            Console.WriteLine("-------------------");
        }

        static void mostrarEventos(List<String> l)
        {
            foreach(String s in l)
            {
                Console.WriteLine((l.IndexOf(s)+1)+". "+s);
            }
        }

        static void mostrarEventos(List<String> l, int n)
        {
            for(int i = 0; i<n; i++)
            {
                try
                {
                    Console.WriteLine((i+1)+". "+l[i]);
                }
                catch (Exception)
                {
                    Console.WriteLine("No more events");
                }
            }
        }

        static void borrarEvento(List<String> l, int n)
        {
            try
            {
                l.RemoveAt(n - 1);
            }catch(Exception)
            {
                Console.WriteLine("EVENT NON-EXISTENT");
            }
        }
        static void Main(string[] args)
        {
            List<String> agenda = new List<string>();
            int decision = 0;
            Boolean correcto;
            do
            {
                correcto = false;
                dibujar();
                while(correcto == false)
                {
                    try
                    {
                        decision = Convert.ToInt32(Console.ReadLine());
                        correcto = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("PLEASE WRITE A NUMBER");
                    }

                }
                switch (decision)
                {
                    case 1:
                        {
                            Console.WriteLine("Write the event's name");
                            agenda.Add(Console.ReadLine());
                            break;
                        }
                    case 2:
                        {
                            mostrarEventos(agenda);
                            if (agenda.Count < 1)
                            {
                                Console.WriteLine("There's no events in the agenda");
                            }
                            else
                            {
                                Console.WriteLine("Write wich event you want to finish");
                                try
                                {
                                    int numero = Convert.ToInt32(Console.ReadLine());
                                    borrarEvento(agenda, numero);
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Three fisrts events:");
                            mostrarEventos(agenda, 3);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Events:");
                            mostrarEventos(agenda);
                            break;
                        }
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            } while (decision != 5);
        }
    }
}
