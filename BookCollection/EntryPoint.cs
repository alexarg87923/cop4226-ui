
/* 
  Group Project - Phase 2

  Made By:
  Dominick Diaz
  Alex Arguelles
  Sebastian Matta
  Orestes Soler
 
 */

namespace BookCollection
{
    internal static class EntryPoint
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new BookManagement());
        }
    }
}