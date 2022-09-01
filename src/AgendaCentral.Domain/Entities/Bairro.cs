using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaCentral.Domain.Enums;

namespace AgendaCentral.Domain.Entities
{
    public class Bairro
    {
        

        public int BairroId { get; private set; }
        public string BairroNome { get; private set; }
        public Situacao SituacaoBairro { get; private set; }


        public Bairro()
        {
            SituacaoBairro = Situacao.ativo;
        }        
        public Bairro(int bairroId, string bairroNome) : this()
        {
            BairroId = bairroId;
            BairroNome = bairroNome;
        }

            public void InativarBairro (){
                if(SituacaoBairro  == Situacao.ativo){
                    SituacaoBairro = Situacao.inativo;
                }else{
                    throw new Exception("Bairro já inativado");
                }
            }

            public void AtivarBairro (){
                if(SituacaoBairro  == Situacao.inativo){
                    SituacaoBairro = Situacao.ativo;
                }else{
                    throw new Exception("Bairro já ativado");
                }
            }
    }
}