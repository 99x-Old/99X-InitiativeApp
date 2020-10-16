using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InitiativeApp.API.Dtos;
using InitiativeApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InitiativeApp.API.Data
{
	public class CommentRepository : ICommentRepository
	{
		private readonly DataContext _context;
		private readonly IMapper _mapper;
		public CommentRepository(DataContext context,IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<Comment> AddComment(CommentsDto commentDto)
		{
			var mapped = _mapper.Map<Comment>(commentDto);
			await _context.Comments.AddAsync(mapped);
			await _context.SaveChangesAsync();
			return mapped;
		}

		public async Task<bool> DeleteComment(int id)
		{
			var deleteComment = await _context.Comments.FirstOrDefaultAsync(c=>c.CommentId == id);
			_context.Comments.Remove(deleteComment);
			return await _context.SaveChangesAsync() > 0;
		}

		public async Task<Comment> GetComment(int id)
		{
			var comment = await _context.Comments.FirstOrDefaultAsync(c=>c.CommentId == id);
			return comment;
		}

		public async Task<IEnumerable<Comment>> GetComments()
		{
			var comments = await _context.Comments.ToListAsync();
			return comments;
		}

		public async Task<bool> SaveAll()
		{
			return await _context.SaveChangesAsync() > 0;
		}
	}
}