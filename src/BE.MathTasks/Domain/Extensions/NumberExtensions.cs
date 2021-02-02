namespace BE.MathTasks.Extensions
{
    public static class NumberExtensions
    {
        public static int GetOnes(this double value) => value.GetPlace(1);

        public static int GetOnes(this int value) => value.GetPlace(1);

        public static int GetTens(this double value) => value.GetPlace(10);

        public static int GetTens(this int value) => value.GetPlace(10);

        public static int GetHundreds(this double value) => value.GetPlace(100);

        public static int GetHundreds(this int value) => value.GetPlace(100);

        private static int GetPlace(this double doubValue, int place)
        {
            int value = (int) doubValue;
            return (value % (place * 10) - value % place) / place;
        }

        private static int GetPlace(this int value, int place)
        {
            return (value % (place * 10) - value % place) / place;
        }
    }
}