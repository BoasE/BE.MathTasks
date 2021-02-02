namespace BE.MathTasks.Extensions
{
    public static class NumberExtensions
    {
        public static int GetOnes(this int value)
        {
            return value.GetPlace(1);
        }

        public static int GetTens(this int value)
        {
            return value.GetPlace(10);
        }

        public static int GetHundreds(this int value)
        {
            return value.GetPlace(100);
        }
        private static int GetPlace(this int value, int place)
        {
            return (value % (place * 10) - value % place) / place;
        }
    }
}