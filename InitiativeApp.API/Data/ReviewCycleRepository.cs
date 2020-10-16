using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InitiativeApp.API.Dtos;
using InitiativeApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InitiativeApp.API.Data
{
	public class ReviewCycleRepository : IReviewCycleRepository
	{
		private readonly DataContext _context;
		private readonly IMapper _mapper;
		public ReviewCycleRepository(DataContext context,IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<ReviewCycle> AddReviewCycle(ReviewCycleDto reviewCycleDto)
		{
			var mapped = _mapper.Map<ReviewCycle>(reviewCycleDto);
			await _context.ReviewCycles.AddAsync(mapped);
			await _context.SaveChangesAsync();
			return mapped;
		}

		public async Task<bool> DeleteReviewCycle(int id)
		{
			var deleteReviewCycle = await _context.ReviewCycles.FirstOrDefaultAsync(m=>m.ReviewCycleId == id);
			_context.ReviewCycles.Remove(deleteReviewCycle);
			return await _context.SaveChangesAsync() > 0;
		}

		public async Task<ReviewCycle> GetReviewCycle(int id)
		{
			var reviewCycle = await _context.ReviewCycles.FirstOrDefaultAsync(m=>m.ReviewCycleId == id);
			return reviewCycle;
		}

		public async Task<IEnumerable<ReviewCycle>> GetReviewCycles()
		{
			var reviewCycles = await _context.ReviewCycles.ToListAsync();
			return reviewCycles;
		}

		public async Task<bool> SaveAll()
		{
			return await _context.SaveChangesAsync() > 0;
		}
	}
}