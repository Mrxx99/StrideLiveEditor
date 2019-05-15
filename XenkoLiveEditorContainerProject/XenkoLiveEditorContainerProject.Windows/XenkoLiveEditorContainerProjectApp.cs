using System;
using Xenko.Engine;
using XenkoLiveEditor;

namespace XenkoLiveEditorContainerProject
{
    class XenkoLiveEditorContainerProjectApp
    {
        [STAThread]
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
#if DEBUG
                var window = new LiveEditorMainWindow(game);
                window.Show();
#endif
                game.Run();
#if DEBUG
                if (window != null)
                    window.Close();
#endif
            }
        }
    }
}
