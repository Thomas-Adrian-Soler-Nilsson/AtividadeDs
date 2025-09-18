using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3Ds
{
    internal class Pessoa
    {
        
            public double Altura;
            public string Sexo;


            public double PesoIdeal()
            {
                double pesoIdeal;

                // Verifica o sexo da pessoa para aplicar a fórmula correta
                if (Sexo.ToLower(System.Globalization.CultureInfo.CurrentCulture) == "homem")
                {
                    pesoIdeal = (72.7 * Altura) - 58;
                }
                else if (Sexo.ToLower(System.Globalization.CultureInfo.CurrentCulture) == "mulher")
                {
                    pesoIdeal = (62.1 * Altura) - 44.7;
                }
                else
                {
                    throw new Exception("Sexo inválido. Informe 'homem' ou 'mulher'.");
                }

                return pesoIdeal;
            }
    }
}
