using System.Security.Cryptography.X509Certificates;

namespace FazendoIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciar objeto para o imc
            Pessoa a = new()
            {
                nome = "Vilberto",
                peso = 90,
                altura = 1.63,
            };
            a.resultado();
        }
    }
}