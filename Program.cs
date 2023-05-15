using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis que irão armazenar o peso e a altura
            double peso, altura, imc;

            try
            {
                //informando o usuário o valor que será obtido
                Console.WriteLine("Informe o seu peso em kg:");
                //obtendo o peso
                peso = ObterValor();

                //informando o usuário o valor que será obtido
                Console.WriteLine("Informe a sua altura em m:");
                //obtendo a altura
                altura = ObterValor();

                //calculando o imc
                imc = peso / (altura * altura);

                //informando o usuário resultado
                Console.WriteLine("\nO IMC é {0}", imc);
            }
            catch (Exception ex)
            {
                //Se ocorrer um erro, o usuário é informado.
                Console.WriteLine("\nOcorreu o erro: {0}", ex.Message);
            }

            Console.WriteLine("\nPressione qualquer tecla para finalizar a aplicação...");
            Console.ReadKey();
        }

        static double ObterValor()
        {
            try
            {
                //um valor é obtido no console
                var valor = Console.ReadLine();

                //o valor obtido é convertido para double antes de retorná-lo
                return Convert.ToDouble(valor);
            }
            catch (FormatException)
            {
                //caso ocorra um erro durante a conversão
                Console.WriteLine("\nValor informado erroneamente, o informe novamente:");//o \n pula uma linha

                //O valor é obtido novamente
                return ObterValor();
            }
            catch (Exception ex)
            {
                //caso ocorre outro tipo de erro
                // ele é retornado para o método chamador
                throw ex;
            }
        }
    }
}
