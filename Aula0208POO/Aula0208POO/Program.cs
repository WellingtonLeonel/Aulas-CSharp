using Aula0208POO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208POO
{
    class Program
    {
        static void Main(string[] args)
        {
            carro car = new carro();
            car.modelo = "ferrari";
            car.acelerar();

            Executatestemotor(car);
            Console.ReadKey();
        }

            static void Executatestemotor(imotorizado vec)
            {
                Console.WriteLine("velocidade atual: " + vec.Velocidade);
                vec.acelerar();
                vec.acelerar();
                vec.acelerar();
                Console.WriteLine("velocidade atual :" + vec.Velocidade);
                vec.frenar();
                vec.frenar();
                Console.WriteLine("velocidade atual :" + vec.Velocidade);

            }
        }
      
        
        
       }

    
