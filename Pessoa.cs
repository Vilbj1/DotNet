using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendoIMC
{
    public class Pessoa
    {
        //criação dos atributos
        public required string nome;

        public double peso;

        public double altura;

        //Métodos

        public double imc()
        {
            return peso/(altura * altura);
        }

        public string Situation(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }

            if (imc < 25)
            {
                return "Peso normal";
            }
            
            if (imc < 30)
            {
                return "Acima do peso";
            }
            return "Obeso";
        }

        //mensagem

        public void resultado()
        {
            double obterImc = imc();

            string obterSituacao = Situation(obterImc);

            Console.WriteLine(nome + " está com o imc de " + obterImc + " e está " + obterSituacao);
        }
    }
}
