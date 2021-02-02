using System;
using System.Security.Cryptography;

namespace BE.MathTasks.Extensions
{
    public sealed class RandomNumbers
    {
        private readonly RandomNumberGenerator rng = new RNGCryptoServiceProvider();
        
        public int Next(int maxValue)
        {
            return Next(0, maxValue);
        }

        public int Next(int minValue, int maxValue)
        {
            if (minValue > maxValue) throw new ArgumentOutOfRangeException();

            return (int) Math.Floor(minValue + ((double) maxValue + 1 - minValue) * NextDouble());
        }

        public double NextDouble()
        {
            var data = new byte[sizeof(uint)];
            rng.GetBytes(data);
            var randUint = BitConverter.ToUInt32(data, 0);
            return randUint / (uint.MaxValue + 1.0);
        }

    }
}