using SupportGestor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupportGestor.Services
{
    public interface IAtendimentoServices
    {
        Task<List<AtendimentoModel>> GetAllAtendimentosAsync();
        Task<AtendimentoModel> GetAtendimentoByIdAsync(int id);
        Task AddAtendimentoAsync(AtendimentoModel atendimento);
        Task UpdateAtendimentoAsync(AtendimentoModel atendimento);
        Task DeleteAtendimentoAsync(int id);
        
    }
}
