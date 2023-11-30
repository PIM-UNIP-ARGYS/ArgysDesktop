using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgysDesktop.Dtos
{
    public class PessoaDto
    {
        public string Uuid { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Ctps { get; set; }
        public string Cpf { get; set; }
        public string PisNis { get; set; }
        public string TituloEleitor { get; set; }
        public string DataNascimento { get; set; }
    }
}
