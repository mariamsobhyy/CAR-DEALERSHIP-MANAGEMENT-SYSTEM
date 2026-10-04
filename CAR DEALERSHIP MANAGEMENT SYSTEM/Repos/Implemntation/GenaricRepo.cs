using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Data;
using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Repos.Interface;
using Microsoft.EntityFrameworkCore;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Repos.Implemntation
{
    public class GenaricRepo <T> : IGenaricRepo<T> where T : class
    {
        private readonly AppDbContext _context;

        private readonly DbSet<T> _dbSet;


        public GenaricRepo( AppDbContext context)
        {
            _context = context;

            _dbSet = _context.Set<T>();
        }


        public ICollection<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
           
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
           
        }
    }
}
