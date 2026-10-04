using CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Data;

namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.Repos.Interface
{
    public interface IGenaricRepo <T> where T : class
    {
          ICollection<T> GetAll();
          T GetById(int id);

          void Add(T entity);
          void Update(T entity);
          void Delete(T entity);

    }
}
