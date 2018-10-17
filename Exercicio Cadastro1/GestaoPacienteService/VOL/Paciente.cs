using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPacienteService.VOL
{
    public class PacienteResultado
    {
        public string Mensagem { get; }
        public bool Sucesso { get; }

        public Paciente Paciente{ get; }

        public PacienteResultado(Paciente paciente, bool sucesso, string mensagem)
        {
            this.Paciente = paciente;
            this.Mensagem = mensagem;
            Sucesso = sucesso;
        }
    }

    public class Paciente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Responsavel { get; set; }
    }
}
