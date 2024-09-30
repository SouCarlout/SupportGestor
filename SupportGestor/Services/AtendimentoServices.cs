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
        public async Task<List<Atendimento>> GetAllAtendimentosAsync()
        {
            return await _context.Atendimentos.ToListAsync();
        }

        public async Task<Atendimento> GetAtendimentoByIdAsync(int id)
        {
            return await _context.Atendimentos.FindAsync(id);
        }

        public async Task AddAtendimentoAsync(Atendimento Atendimento)
        {
            _context.Atendimentos.Add(Atendimento);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAtendimentoAsync(Atendimento Atendimento)
        {
            _context.Atendimentos.Update(Atendimento);
            await _context.SaveChangesAsync();
        }
    }
}
