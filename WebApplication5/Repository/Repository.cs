using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public class Repository<T> where T : BaseEntity, new()
    {
        private readonly List<T> _entities;

        public Repository()
        {
            _entities = new List<T>();
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public T FindById(int id) 
        {
            return _entities.FirstOrDefault(x => x.Id == id);
        }

        public List<T> GetAll()
        {
            return _entities;
        }
    }
}
