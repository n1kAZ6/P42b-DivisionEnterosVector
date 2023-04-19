using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P42b_DivisionEnterosVector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                short posicion;
                int numeroDividir;
                string terminarAplicacion;
                do
                {
                    Random azar = new Random();
                    int[] vNum = new int[20];

                    for (int i = 0; i < vNum.Length; i++)
                        vNum[i] = azar.Next(101);
          
                    Console.Write("Que posición del vector quiere ver (escribe \"fin\" para terminar) [{0}..{1}] : ", 0, vNum.Length-1);
                    terminarAplicacion = Console.ReadLine();

                    if (terminarAplicacion.ToLower()!="fin")
                    {
                        posicion = short.Parse(terminarAplicacion);
                        Console.WriteLine("{0}) {1}", posicion, vNum[posicion]);
                        Console.Write("Por que número lo quiere dividir?: ");
                        terminarAplicacion = Console.ReadLine();

                        if(terminarAplicacion.ToLower() != "fin")
                        {
                            numeroDividir = int.Parse(terminarAplicacion);
                            Console.WriteLine("{0} / {1} = {2}", vNum[posicion], numeroDividir, (vNum[posicion] / numeroDividir));
                        }
                        
                    }

                } while (terminarAplicacion.ToLower() != "fin");
                
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("[ERROR] {0}",e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("[ERROR] {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("[ERROR] {0}", e.Message);
            }

            Console.WriteLine("Introduce una tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
