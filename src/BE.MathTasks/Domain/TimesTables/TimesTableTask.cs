using System;
using System.Diagnostics;
using BE.MathTasks.Artihmetics;

namespace BE.MathTasks.TimesTables
{
    [DebuggerDisplay("{A}*{B}")]
    public sealed class TimesTableTask : MathTask, IEquatable<TimesTableTask>
    {
        public int A { get; }

        public int B { get; }

        public int Solution { get; }

        public TimesTableTask(int a, int b)
        {
            A = a;
            B = b;
            Solution = a * b;
        }

        #region equals

        public bool Equals(TimesTableTask? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return A == other.A && B == other.B;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is TimesTableTask other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A, B);
        }

        public static bool operator ==(TimesTableTask? left, TimesTableTask? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TimesTableTask? left, TimesTableTask? right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}