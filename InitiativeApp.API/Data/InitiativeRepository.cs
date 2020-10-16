using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InitiativeApp.API.Dtos;
using InitiativeApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InitiativeApp.API.Data
{
	public class InitiativeRepository : IInitiativeRepository
	{
		private readonly DataContext _context;
		private readonly IMapper _mapper;

		public InitiativeRepository (DataContext context,IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<Initiative> AddInitiative(InitiativeForListDto initiativeDto)
		{
			var mapped=_mapper.Map<Initiative>(initiativeDto);
			await _context.Initiatives.AddAsync(mapped);
            await _context.SaveChangesAsync();
			return mapped;
		}

		public async Task<bool> DeleteInitiative(int id)
		{
			var deleteInitiative = await _context.Initiatives.Include(m => m.Meetings).Include(r => r.ReviewCycles).FirstOrDefaultAsync(a=>a.InitiativeId == id);
			_context.Initiatives.Remove(deleteInitiative);
			return await _context.SaveChangesAsync() > 0;
		}

		public async Task<Initiative> GetInitiative(int id)
		{
			var initiative = await _context.Initiatives.Include(m => m.Meetings).Include(r => r.ReviewCycles).FirstOrDefaultAsync(u => u.InitiativeId == id);
			return initiative;
		}

		public async Task<IEnumerable<Initiative>> GetInitiatives()
		{
			var initiatives = await _context.Initiatives.Include(m => m.Meetings).Include(r => r.ReviewCycles).ToListAsync();
			return initiatives;
		}

		public async Task<bool> SaveAll()
		{
			return await _context.SaveChangesAsync() > 0;
		}
	}
}