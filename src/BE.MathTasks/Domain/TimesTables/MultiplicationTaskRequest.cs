using System;
using System.Collections.Generic;
using System.Linq;

namespace BE.MathTasks.TimesTables
{
    public sealed class MultiplicationTaskRequest
    {
        public ISet<int> Tables { get; }

        public bool AllowTimes1 { get; private set; } = true;

        public static MultiplicationTaskRequest All => new MultiplicationTaskRequest(new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

        public static MultiplicationTaskRequest None => new MultiplicationTaskRequest();

        public static MultiplicationTaskRequest ForTable(int table)
        {
            return new MultiplicationTaskRequest(new HashSet<int>() { table });
        }

        public static MultiplicationTaskRequest ForTable(IEnumerable<int> table)
        {
            return new MultiplicationTaskRequest(table);
        }

        private MultiplicationTaskRequest()
        {
            Tables = new HashSet<int>();
        }

        private MultiplicationTaskRequest(IEnumerable<int> tables)
        {
            Tables = tables.ToHashSet();

            if (Tables.Any(x => x < 1 || x > 10))
            {
                throw new ArgumentException("Orders must be between 1 and 10", nameof(tables));
            }
        }

        public MultiplicationTaskRequest AddTable(int table)
        {
            Tables.Add(table);
            return this;
        }

        public MultiplicationTaskRequest PreventTimes1()
        {
            AllowTimes1 = false;
            return this;
        }
    }
}