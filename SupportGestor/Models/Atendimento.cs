
namespace SupportGestor.Models

{
    public class Atendimento
    {
        public int Id { get; set; }
        public string NomeAtendente{ get; set; }
        public string Cliente { get; set; }
        public string Problema { get; set; }
        public int NivelDificuldade { get; set; }

    }
}
