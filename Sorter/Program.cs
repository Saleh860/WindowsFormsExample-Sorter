namespace Sorter
{
    internal static class Program
    {
        private static Data data = new Data();
        public static Data getData()
        {
            return data;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Form2 form2 = new Form2();
            form2.Show();
            Application.Run(form2);
        }
    }
}