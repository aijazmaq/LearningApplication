using LearningApplication.Services.Interface;

namespace LearningApplication.Services.Implement
{
    public class LearningService : ILearningInterface
    {
        public int Addtion(Learning learning)
        {
            return learning.Value1 + learning.Value2;
        }

        public int Multiply(Learning learning)
        {
            return learning.Value1 * learning.Value2;
        }


    }
}
