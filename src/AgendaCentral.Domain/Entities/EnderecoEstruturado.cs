using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaCentral.Domain.Enums;
using AgendaCentral.Domain.Entities;

namespace AgendaCentral.Domain.Entities
{
    public class EnderecoEstruturado
    {
        

        public int EnredecoId { get; private set; }
        public Logradouro? Logradouro { get; private set; }
        public Bairro? Bairro { get; private set; }
        public string? NumeroEndereco { get; set; }
        public string? ComplementoEndereco { get; private set; }

        public Situacao  SituacaoEndereco { get; private set; }


        public EnderecoEstruturado()
    {
        SituacaoEndereco = Situacao.ativo;
    }
    
    public EnderecoEstruturado(int enredecoId,
                               Logradouro logradouro,
                               Bairro bairro,
                               string numeroEndereco,
                               string complementoEndereco) : this()
        {
            EnredecoId = enredecoId;
            Logradouro = logradouro;
            Bairro = bairro;
            NumeroEndereco = numeroEndereco;
            ComplementoEndereco = complementoEndereco;
        }

    public void InativarEndereco (){
                if(SituacaoEndereco  == Situacao.ativo){
                    SituacaoEndereco = Situacao.inativo;
                }else{
                    throw new Exception("Endereco já inativado");
                }
            }

    public void AtivarEndereco (){
                if(SituacaoEndereco  == Situacao.inativo){
                    SituacaoEndereco = Situacao.ativo;
                }else{
                    throw new Exception("Endereco já ativado");
                }
            }


    }

    
    
}
