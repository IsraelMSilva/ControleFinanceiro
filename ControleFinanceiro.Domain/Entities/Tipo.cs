using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public abstract class Tipo
    {
        public virtual Guid Id { get; set; }

        public virtual string? Descricao { get; set; }

    }
}
