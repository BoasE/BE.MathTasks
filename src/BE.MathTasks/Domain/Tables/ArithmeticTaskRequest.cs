using System;
using System.Collections.Generic;
using System.Linq;
using BE.MathTasks.Artihmetics;

namespace BE.MathTasks.Tables
{
    public sealed class ArithmeticTaskRequest
    {
        public ISet<int> Tables { get; }

        public bool AllowTimes1 { get; private set; } = true;
        public bool AllowTimes0 { get; private set; } = false;

        private ArithmeticTaskRequest()
        {
            Tables = new HashSet<int>();
        }

        private ArithmeticTaskRequest(IEnumerable<int> tables)
        {
            Tables = tables.ToHashSet();

            if (Tables.Any(x => x < 1 || x > 10))
            {
                throw new ArgumentException("Orders must be between 1 and 10", nameof(tables));
            }
        }

        public ArithmeticTaskRequest AddTable(int table)
        {
            Tables.Add(table);
            return this;
        }

        public ArithmeticTaskRequest PreventTimes1()
        {
            AllowTimes1 = false;
            return this;
        }


        #region factories

        public static ArithmeticTaskRequest All=> new(new HashSet<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});

        public static ArithmeticTaskRequest None => new ArithmeticTaskRequest();

        public static ArithmeticTaskRequest ForTable( int table) => new(new HashSet<int>() {table});

        public static ArithmeticTaskRequest ForTable(IEnumerable<int> table) => new(table);

        #endregion
    }
}