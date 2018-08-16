using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesa_Veiculo.Modelo
{
    public abstract class absPropriedades: intMetodos
    {
        public String mensagem;
        public String resposta;
        private String km;
        private String combustivel;
        private String consumoVeiculo;
        public Double numeroKm;
        public Double numeroCombustivel;
        public Double numeroConsumoVeiculo;

        #region - Encapsulamento
        protected string Km { get => km; set => km = value; }
        protected string Combustivel { get => combustivel; set => combustivel = value; }
        protected string ConsumoVeiculo { get => consumoVeiculo; set => consumoVeiculo = value; }
        #endregion

        //Construtor Validacao e Controle
        public absPropriedades(String km, String combustivel, String consumovec)
        {
            this.Km = km;
            this.Combustivel = combustivel;
            this.ConsumoVeiculo = consumovec;
        }

        //Construtor Cálculos
        public absPropriedades(Double numeroKm, Double numeroCombustivel, Double numeroConsumoVeiculo)
        {
            this.numeroKm = numeroKm;
            this.numeroCombustivel = numeroCombustivel;
            this.numeroConsumoVeiculo = numeroConsumoVeiculo;
        }

        public virtual void Executar()
        {
        }

        public override string ToString()
        {
            return this.resposta;
        }           
    }
}
