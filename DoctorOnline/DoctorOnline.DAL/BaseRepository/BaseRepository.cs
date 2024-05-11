namespace DoctorOnline.DAL.BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private ApplicationDbContext _dbContext;
        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public T Add(T item)
        {
            _dbContext.Set<T>().Add(item);
            _dbContext.SaveChanges();
            return item;
        }

        public void Delete(T item)
        {
            _dbContext.Set<T>().Remove(item);
            _dbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public T Update(T item)
        {
            _dbContext.Set<T>().Update(item);
            _dbContext.SaveChanges();
            return item;
        }
    }
}
