using System;
using System.Security.Principal;
using BE.MathTasks.Artihmetics;

namespace Domain.Tests.ArithmeticTaskPoolTests
{
    public sealed class WhenGettingATask
    {
        private AThousandPool GetSut()
        {
            return new AThousandPool();
        }

        public void Test()
        {
            var pool = GetSut();
            pool.Resolve(new ArithmeticTaskRequest());
        }
    }
}