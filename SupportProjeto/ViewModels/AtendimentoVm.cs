using SupportGestor.Models;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;


namespace SupportGestor.ViewModels
{
    public class AtendimentoViewModel
    {
        public int AtendimentoId { get; set; }
        public string nome_atendente { get; set; } = string.Empty;
        public string clientes { get; set; } = string.Empty;
        public string descricao_problema { get; set; } = string.Empty;
        public string notas_atendimento { get; set; } = string.Empty;
        public int nivel_dificuldade { get; set; }

        public async Task Salvar()
        {
            var atendimento = new AtendimentoModel
            {
                nome_atendente = nome_atendente,
                clientes = clientes,
                notas_atendimento = notas_atendimento,
                descricao_problema = descricao_problema,
                nivel_dificuldade = nivel_dificuldade
            };
        }
    }
}
