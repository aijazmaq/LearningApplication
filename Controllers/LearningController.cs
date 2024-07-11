using LearningApplication.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearningController : ControllerBase
    {
        private readonly ILearningInterface _learningInterface1;

       public LearningController(ILearningInterface learningInterface)
        {
            _learningInterface1 = learningInterface;
        }


        [HttpPost ("GetCalculate")]
        public int GetCalculate(Learning learning)
        {
           return _learningInterface1.Multiply(learning);

        }
        
        [HttpPost("GetCalculate1")]
        public int GetCalculate1(Learning learning)
        {
            return _learningInterface1.Multiply(learning);

        }
    }
}
