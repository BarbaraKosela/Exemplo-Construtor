using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Time
    {
        private string p1;
        private string p2;

        public string Nome { get; set; }
        public string Pais { get; set; }
        public int QuantidadeGols { get; set; }
        public int QuantidadeGolsLevados { get; set; }
        public int QuantidadeCartoesVermelhos { get;set; }
        public int QuantidadeSemiFinais { get; set; }
        public int QuantidadeVitorias { get; set; }
        public decimal Faturamento { get; set; }
        public int Substituicoes { get; set; }
        public string Serie { get; set; }
        public int QuantidadeDerrotas { get; set; }
        public int QuantidadeGolsContras { get; set; }

        public Time(string nome, string pais, string serie)
        {
            Nome = nome;
            Pais = pais;
            Serie = serie;
        }

        public Time(string p1, string p2)
        {

            this.p1 = p1;
            this.p2 = p2;
        }



        
    }
}
