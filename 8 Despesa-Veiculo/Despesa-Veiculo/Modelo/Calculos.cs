using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa_Veiculo.Modelo
{
    public class Calculos: absPropriedades
    {
        public Calculos(Double numeroKm, Double numeroCombustivel, Double numeroConsumoVeiculo) : base(numeroKm, numeroCombustivel, numeroConsumoVeiculo)
        {
            Executar();
        }

        public override void Executar()
        {
            this.numeroKm = numeroKm / numeroConsumoVeiculo;
            this.numeroCombustivel = numeroKm * numeroCombustivel;
            this.resposta = "O consumo de combustível no dia foi de: \n" + numeroKm.ToString("#0.00") + " km/l"+
                "\n\nO valor gasto de combustível no dia foi de: \n" + "R$" + numeroCombustivel.ToString("#0.00");
            
        }
    }
}
