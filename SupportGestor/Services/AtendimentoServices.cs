using Microsoft.EntityFrameworkCore;
using SupportGestor.Data;
using SupportGestor.Models;

namespace SupportGestor.Services
{
    public class AtendimentoServices
    {
        private readonly AppDbContext _context;

        public AtendimentoServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<AtendimentoModel>> GetAllAtendimentosAsync()
        {
            return await _context.Atendimentos.ToListAsync();
        }

        public async Task<AtendimentoModel> GetAtendimentoByIdAsync(int id)
        {
            return await _context.Atendimentos.FindAsync(id);
        }

        public async Task AddAtendimentoAsync(AtendimentoModel Atendimento)
        {
            _context.Atendimentos.Add(Atendimento);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAtendimentoAsync(AtendimentoModel Atendimento)
        {
            _context.Atendimentos.Update(Atendimento);
            await _context.SaveChangesAsync();
        }
    }
}
