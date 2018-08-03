using System;

namespace Aula0208POO.Modelos
{
    class barco : veiculo, imotorizado
    {
        public int Velocidade { get; set; }

        public void acelerar()
        {
            Console.WriteLine("Acelerando...");
            Velocidade += 200;
        }

        public void frenar()
        {
            Console.WriteLine("Afundando...");
            Velocidade -= 5;
        }
    }
}
