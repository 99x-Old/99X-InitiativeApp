using System.Collections.Generic;
using System.Threading.Tasks;
using InitiativeApp.API.Dtos;
using InitiativeApp.API.Models;

namespace InitiativeApp.API.Data
{
    public interface IInitiativeRepository
    {
        Task<Initiative> AddInitiative(InitiativeForListDto initiative);
		Task<bool>  DeleteInitiative(int id);
		 Task<bool> SaveAll();
		 Task<IEnumerable<Initiative>> GetInitiatives();
		 Task<Initiative> GetInitiative(int id);
	}
}