using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InitiativeApp.API.Dtos;
using InitiativeApp.API.Models;

namespace InitiativeApp.API.Data
{
	public interface IActionsRepository
	{
		Task<Actions> AddActions(ActionsDto action);
		Task<bool> DeleteAction(int id);
		Task<bool> SaveAll();
		Task<IEnumerable<Actions>> GetActions();
		Task<Actions> GetAction(int id);
	}
}