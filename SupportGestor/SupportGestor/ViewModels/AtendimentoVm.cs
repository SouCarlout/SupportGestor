using SupportGestor.Models;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SupportGestor.ViewModels
{
    public class AtendimentoViewModel
    {
        public string Nome { get; set; } = string.Empty;
        public string Cliente { get; set; } = string.Empty;
        public string Problema { get; set; } = string.Empty;
        public string NotasAtendimento { get; set; } = string.Empty;
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
