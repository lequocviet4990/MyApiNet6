
using API.CORE.Entities;

namespace API.CORE
{
    public interface IActorRepository
    {
        Task  <List<Actor>> GetAll();
    }
}