using DoctorOnline.DAL.BaseRepository;
using DoctorOnline.DAL.Entities;

namespace DoctorOnline.DAL.Repositories.TestRepo
{
    public class TestRepository : BaseRepository<Test>, ITestsRepository
    {
        public TestRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
        }

        // Example For special funcion for test repositorys
        public IEnumerable<Test> SpecialMethod()
        {
            throw new NotImplementedException();
        }
    }
}
