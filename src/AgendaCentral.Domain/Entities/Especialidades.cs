using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaCentral.Domain.Enums;

namespace AgendaCentral.Domain.Entities
{
    public class Especialidades
    {
        public int EspecialidadeId { get; private set; }

        public string NomeEspecialidade { get; private set; }

        public Situacao SituacaoEspecialidade { get; private set; }


        public Especialidades()
        {
            SituacaoEspecialidade = Situacao.ativo;
        }
        public Especialidades(int especialidadeId, string nomeEspecialidade) : this()
        {
            EspecialidadeId = especialidadeId;
            NomeEspecialidade = nomeEspecialidade;
        }

        public void InativarEspecialidade ()
        {
                if(SituacaoEspecialidade  == Situacao.ativo){
                    SituacaoEspecialidade = Situacao.inativo;
                }else{
                    throw new Exception("Especialidade já inativada");
                }
        }

        public void AtivarEspecialidade ()
        {
                if(SituacaoEspecialidade  == Situacao.inativo){
                    SituacaoEspecialidade = Situacao.ativo;
                }else{
                    throw new Exception("Especialidade já ativada");
                }
        }

    }
}
