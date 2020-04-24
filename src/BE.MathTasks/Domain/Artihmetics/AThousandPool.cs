using System;
using System.Collections.Generic;
using System.Linq;

namespace BE.MathTasks.Artihmetics
{
    public sealed class AThousandPool : IArithmeticTaskPool
    {
        public Range NumberRange { get; }

        public int TotalTasks => tasks.Count;

        private readonly IReadOnlyCollection<ArithmeticTask> tasks;

        public AThousandPool()
        {
            NumberRange = new Range(0,1000);
            tasks = Generate().ToList();
        }

        private IEnumerable<ArithmeticTask> Generate()
        {
            for (int firstArgument = NumberRange.Start.Value; firstArgument <= NumberRange.End.Value; firstArgument++)
            for (int secondArgument = NumberRange.Start.Value; secondArgument <= NumberRange.End.Value; secondArgument++)
            {
                yield return Create(firstArgument, secondArgument, ArithmeticOperators.Addition, firstArgument + secondArgument);

                if (secondArgument <= firstArgument)
                    yield return Create(firstArgument, secondArgument, ArithmeticOperators.Subtraction, firstArgument - secondArgument);

                yield return Create(firstArgument, secondArgument, ArithmeticOperators.Multiplication, firstArgument * secondArgument);

                if (secondArgument > 0)
                    yield return Create(firstArgument, secondArgument, ArithmeticOperators.Divison, firstArgument / secondArgument);
            }
        }

        private ArithmeticTask Create(int firstArgument, int secondArgument, ArithmeticOperators ops, int solution)
        {
            return new ArithmeticTask(firstArgument, secondArgument, ops);
        }

        public List<ArithmeticTask> Resolve(ArithmeticTaskRequest request)
        {
            throw new NotImplementedException();
        }
    }
}