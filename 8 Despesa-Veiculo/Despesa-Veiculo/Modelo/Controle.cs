using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa_Veiculo.Modelo
{
    public class Controle: absPropriedades
    {
        public Controle(String km, String combustivel, String consumoVeiculo) : base(km, combustivel, consumoVeiculo)
        {
           Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";

            absPropriedades validacao = new Validacao(this.Km, this.Combustivel, this.ConsumoVeiculo);

            if(validacao.mensagem.Equals(""))
            {
                absPropriedades calculos = new Calculos(validacao.numeroKm, validacao.numeroCombustivel, validacao.numeroConsumoVeiculo);
                this.resposta = calculos.ToString();
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }    
}
