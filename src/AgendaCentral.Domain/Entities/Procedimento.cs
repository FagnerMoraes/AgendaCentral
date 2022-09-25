using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaCentral.Domain.Enums;

namespace AgendaCentral.Domain.Entities
{
    public class Procedimento
    {
        public int ProcedimentoId { get; private set; }

        public GrupoProcedimento GrupoProcedimento { get; private set; }

        public string? NomeProcedimento { get; private set; }

        public Situacao SituacaoProcedimento { get; private set; }
    }
}
