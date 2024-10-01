using Npgsql;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupportGestor.Models

{
    [Table("atendimentos")]
    public class AtendimentoModel
    {
        [Key]
        public int id { get; set; }
        public string nome_atendente { get; set; } = string.Empty;
        public DateTime data_atendimento { get; set; }
        public string notas_atendimento { get; set; } = string.Empty;
        public string clientes { get; set; } = string.Empty;
        public string descricao_problema { get; set; } = string.Empty;
        public int nivel_dificuldade { get; set; }

    }
}
