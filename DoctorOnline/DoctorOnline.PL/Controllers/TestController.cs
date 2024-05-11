using DoctorOnline.BL.Services.TestService;
using Microsoft.AspNetCore.Mvc;

namespace DoctorOnline.PL.Controllers
{
    public class TestController : Controller
    {
        private ITestService _testService;
        public TestController(ITestService testService)
        {
            _testService = testService;
        }
        public IActionResult Index()
        {
            var allTests = _testService.GetAllTests();
            return View(allTests);
        }

        [HttpGet]
        public IActionResult Find(int id)
        {
            var test = _testService.GetTestById(id);
            return View("FindTest", test);
        }
    }
}
