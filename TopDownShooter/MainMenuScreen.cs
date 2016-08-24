using CelesteEngine;
using System.IO;

namespace TopDownShooter
{
    public class MainMenuScreen : MenuScreen
    {
        public MainMenuScreen() :
            base(Path.Combine("Screens", "MainMenuScreen"))
        {

        }
    }
}