using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InitiativeApp.API.Dtos;
using InitiativeApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InitiativeApp.API.Data
{
	public class UserRepository : IUserRepository
	{
		private readonly DataContext _context;
		private readonly IMapper _mapper;
		
		public UserRepository(DataContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<User> AddUser(UserForListDto userDto)
		{
			var mapped = _mapper.Map<User>(userDto);
			await _context.Users.AddAsync(mapped);
			await _context.SaveChangesAsync();
			return mapped;
		}

		public async Task<bool> DeleteUser(int id)
		{
			var deleteUser = await _context.Users.FirstOrDefaultAsync(a => a.Id == id);
			_context.Users.Remove(deleteUser);
			return await _context.SaveChangesAsync() > 0;
		}

		public async Task<User> GetUser(int id)
		{
			var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
			return user;
		}

		public async Task<IEnumerable<User>> GetUsers()
		{
			var users = await _context.Users.ToListAsync();
			return users;
		}

		public async Task<bool> SaveAll()
		{
			return await _context.SaveChangesAsync() > 0;
		}
	}
}