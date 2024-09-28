using SupportGestor.Models;
using System.Threading.Tasks;

namespace SupportGestor.ViewModels
{
    public class AtendimentoViewModel
    {
        public string Nome { get; set; }
        public string Cliente { get; set; }
        public string Problema { get; set; }
        public string NotasAtendimento { get; set; }
        public int NivelDificuldade { get; set; }

        public async Task Salvar()
        {
            var atendimento = new Atendimento
            {
                NomeAtendente = Nome,
                Cliente = Cliente,
                Problema = Problema,
                NivelDificuldade = NivelDificuldade
            };
        }
    }
}
