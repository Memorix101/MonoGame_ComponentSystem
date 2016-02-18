using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoEngineEditor
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
               using (var game = new Game1())
               game.Run();

        }
    }
}
