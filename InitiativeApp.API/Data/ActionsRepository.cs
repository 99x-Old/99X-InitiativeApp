using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InitiativeApp.API.Dtos;
using InitiativeApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InitiativeApp.API.Data
{
	public class ActionsRepository : IActionsRepository
	{
		private readonly DataContext _context;
		private readonly IMapper _mapper;

		public ActionsRepository(DataContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<Actions> AddActions(ActionsDto actionDto)
		{
			var mapped = _mapper.Map<Actions>(actionDto);
			await _context.Actions.AddAsync(mapped);
			await _context.SaveChangesAsync();
			return mapped;
		}

		public async Task<bool> DeleteAction(int id)
		{
			var deleteAction = await _context.Actions.Include(c => c.Comments).FirstOrDefaultAsync(a=>a.ActionId == id);
			_context.Actions.Remove(deleteAction);
			return await _context.SaveChangesAsync() > 0;
		}

		public async Task<Actions> GetAction(int id)
		{
			var actionItem = await _context.Actions.Include(c => c.Comments).FirstOrDefaultAsync(a=>a.ActionId == id);
			return actionItem;
		}

		public async Task<IEnumerable<Actions>> GetActions()
		{
			var actionItems = await _context.Actions.Include(c => c.Comments).ToListAsync();
			return actionItems;
		}

		public async Task<bool> SaveAll()
		{
			return await _context.SaveChangesAsync() > 0;
		}
	}
}