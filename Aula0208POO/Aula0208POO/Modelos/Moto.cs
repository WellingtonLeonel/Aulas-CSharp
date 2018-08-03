using System;

namespace Aula0208POO.Modelos
{
    class Moto : veiculo, imotorizado
    {
        public int Velocidade { get; set; }

        public void acelerar()
        {
            Console.WriteLine("Levando a pizza...");
            Velocidade += 170;
        }

        public void frenar()
        {
            Console.WriteLine("chegando na casa do cliente...");
            Velocidade -= 40;
        }
    }
}
