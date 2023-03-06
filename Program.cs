namespace Kassa_Systeem
{
    internal static class Program
    {
        public static MainForm MainForm { get; set; }


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           
            MainForm mainForm = new MainForm();
            Program.MainForm = mainForm;

            Application.Run(new LoginForm());

        }
    }
}