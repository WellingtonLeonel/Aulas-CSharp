using System;

namespace Aula0208POO.Modelos
{
    class carro : veiculo, imotorizado
    {
        public int Velocidade { get; set; }

        public void acelerar()
        {
            Console.WriteLine("Pisando no pedal...");
            Velocidade += 5;

         
        }

        public void frenar()
        {
            Console.WriteLine("Pisando no pedal (FREIO)...");
            Velocidade -= 3;
        }
    }
}
