using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa_Veiculo.Modelo
{
    public class Validacao: absPropriedades
    {
        public Validacao(String km, String combustivel, String consumoVeiculo) : base (km, combustivel, consumoVeiculo)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";

            try
            {
                this.numeroKm = Convert.ToDouble(this.Km);
                this.numeroCombustivel = Convert.ToDouble(this.Combustivel);
                this.numeroConsumoVeiculo = Convert.ToDouble(this.ConsumoVeiculo);
            }
            catch (FormatException e)
            {
                this.mensagem = "Erro - Digite apenas números (ex. 2,0)";
            }
        }
    }
}
