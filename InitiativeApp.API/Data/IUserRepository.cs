using System.Collections.Generic;
using System.Threading.Tasks;
using InitiativeApp.API.Dtos;
using InitiativeApp.API.Models;

namespace InitiativeApp.API.Data
{
	public interface IUserRepository
	{
		Task<User> AddUser(UserForListDto user);
		Task<bool> DeleteUser(int id);
		Task<bool> SaveAll();
		Task<IEnumerable<User>> GetUsers();
		Task<User> GetUser(int id);
	}
}