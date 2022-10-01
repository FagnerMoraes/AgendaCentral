using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaCentral.Domain.Enums;

namespace AgendaCentral.Domain.Entities
{
    public class Logradouro
    {
        

        public int LogradouroId { get; private set; }
        public string? LogradouroNome { get; private set; }

        public Situacao SituacaoLogradouro { get; private set; }

        public Logradouro()
        {
            SituacaoLogradouro = Situacao.ativo;
        }
        public Logradouro(int logradouroId, string logradouroNome) : this()
        {
            LogradouroId = logradouroId;
            LogradouroNome = logradouroNome;
        }
        
        public void InativarLogradouro ()
        {
                if(SituacaoLogradouro  == Situacao.ativo){
                    SituacaoLogradouro = Situacao.inativo;
                }else{
                    throw new Exception("Logradouro já inativada");
                }
        }

        public void AtivarEspecialidade ()
        {
                if(SituacaoLogradouro  == Situacao.inativo){
                    SituacaoLogradouro = Situacao.ativo;
                }else{
                    throw new Exception("Logradouro já ativada");
                }
        }

    }
}