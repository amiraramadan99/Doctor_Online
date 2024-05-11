using DoctorOnline.BL.Dtos;

namespace DoctorOnline.BL.Services.TestService
{
    public interface ITestService
    {
        List<TestDto> GetAllTests();
        TestDto GetTestById(int id);
        void UpdateTest(TestDto test);
        void DeleteTest(int id);
    }
}
