using SupportGestor.Models;
using System;
    

namespace SupportGestor.Services
{
    public interface IAtendimentoServices
    {
        Task<string> GetAtendimentoAsync(string atendimento);
        Task<AtendimentoModel> GetAtendimentoById(int id);
        Task<int> AddAtendimento(AtendimentoModel atendimento);
        Task<int> UpdateAtendimento(int id, string atendimento);
        Task<int> DeleteUsuario(AtendimentoModel atendimento);
        Task DeleteAtendimentoById(int id);

       
    }
}
