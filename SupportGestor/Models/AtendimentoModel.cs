using Npgsql;

namespace SupportGestor.Models

{
    public class AtendimentoModel
    {
        public int AtendimentoId { get; set; }
        public string NomeAtendente{ get; set; } = string.Empty;
        public DateTime DataAtendimento { get; set; }
        public string NotasAtendimento { get; set; } = string.Empty;
        public string Cliente { get; set; } = string.Empty;
        public string Problema { get; set; } = string.Empty;
        public int NivelDificuldade { get; set; }

    }
}
