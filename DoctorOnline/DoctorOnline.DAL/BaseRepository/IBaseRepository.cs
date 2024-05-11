namespace DoctorOnline.DAL.BaseRepository
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        T Add(T item);
        T Update(T item);
        void Delete(T item);
    }
}
