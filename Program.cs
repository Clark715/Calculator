
// COLBY'S SIMPLE CALCULATOR APP //

namespace Calculator
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new CalcWindow());
        }

        // BOOLS FOR OPERATION - WILL BECOME TRUE WHEN CORRESPONDING BUTTON OR KEYPRESS IS PRESSED //
        public static bool addition = false;
        public static bool subtraction = false;
        public static bool multiplication = false;
        public static bool division = false;

        // NUMBERS BEING USED IN CONJUNCTION WITH OPERATORS - RECIEVED VIA USER INPUT //
        public static double num1 = 0;
        public static double num2 = 0;

        // FINAL RESULT PRESENTED IN NUMBOX WHEN USER USES EQUALS VIA BUTTON CLICK OR KEYPRESS //
        public static double numFinal = 0;

    }
}