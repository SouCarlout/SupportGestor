using SupportGestor.Models;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SupportGestor.ViewModels
{
    public class AtendimentoViewModel
    {
        public int AtendimentoId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cliente { get; set; } = string.Empty;
        public string Problema { get; set; } = string.Empty;
        public string NotasAtendimento { get; set; } = string.Empty;
        public int NivelDificuldade { get; set; }

        public async Task Salvar()
        {
            var atendimento = new AtendimentoModel
            {
                NomeAtendente = Nome,
                Cliente = Cliente,
                NotasAtendimento = NotasAtendimento,
                Problema = Problema,
                NivelDificuldade = NivelDificuldade
            };
        }
    }
}
