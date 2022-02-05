namespace AddTask
{
    public static class Calculator
    {
        public static int Add(int a, int b)
            => a + b;

        public static int Min(int a, int b)
            => a - b;

        public static int Multi(int a, int b)
            => checked(a * b);

        public static double Div(int a, int b)
            => a / b;

        public static int Rem(int a, int b)
            => a % b;
    }
}
