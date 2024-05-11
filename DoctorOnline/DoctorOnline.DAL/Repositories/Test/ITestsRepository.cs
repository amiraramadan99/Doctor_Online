using DoctorOnline.DAL.BaseRepository;
using DoctorOnline.DAL.Entities;

namespace DoctorOnline.DAL.Repositories.TestRepo
{
    public interface ITestsRepository : IBaseRepository<Test>
    {
        IEnumerable<Test> SpecialMethod();
    }
}
