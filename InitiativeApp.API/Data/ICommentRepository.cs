using System.Collections.Generic;
using System.Threading.Tasks;
using InitiativeApp.API.Dtos;
using InitiativeApp.API.Models;

namespace InitiativeApp.API.Data
{
    public interface ICommentRepository
    {
        Task<Comment> AddComment(CommentsDto comment);
		Task<bool> DeleteComment(int id);
		Task<bool> SaveAll();
		Task<IEnumerable<Comment>> GetComments();
		Task<Comment> GetComment(int id);
    }
}