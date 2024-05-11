using DoctorOnline.BL.Dtos;
using DoctorOnline.DAL.Repositories.TestRepo;

namespace DoctorOnline.BL.Services.TestService
{
    public class TestService : ITestService
    {
        private ITestsRepository _testRepository;
        public TestService(ITestsRepository testsRepository)
        {
            _testRepository = testsRepository;
        }
        public void DeleteTest(int id)
        {
            var testEntity = _testRepository.GetById(id);
            _testRepository.Delete(testEntity);
        }

        public List<TestDto> GetAllTests()
        {
            var tests = _testRepository.GetAll()
                .Select(t => new TestDto { Id = t.Id, Name = t.Name })
                .ToList();

            return tests;
        }

        public TestDto GetTestById(int id)
        {
            var test = _testRepository.GetById(id);
            return new TestDto { Id = test.Id, Name = test.Name };
        }

        public void UpdateTest(TestDto test)
        {
            var testEnity = _testRepository.GetById(test.Id);
            testEnity.Name = test.Name;

            _testRepository.Update(testEnity);
        }
    }
}
