using Microsoft.EntityFrameworkCore;
using SupportGestor.Data;
using SupportGestor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupportGestor.Services
{
    public class AtendimentoServices : IAtendimentoServices
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

        public async Task AddAtendimentoAsync(AtendimentoModel atendimento)
        {
            _context.Atendimentos.Add(atendimento);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAtendimentoAsync(AtendimentoModel atendimento)
        {
            _context.Atendimentos.Update(atendimento);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAtendimentoAsync(int id) {
           var atendimento = await _context.Atendimentos.FindAsync(id);
            if(atendimento != null)
            {
                _context.Atendimentos.Remove(atendimento);
                await _context.SaveChangesAsync();
            }
        }
    }
}
