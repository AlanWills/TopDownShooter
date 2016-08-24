using Microsoft.Xna.Framework.Content;
using System.IO;

namespace TopDownShooter
{
    public static class ExtensionFunctions
    {
        public static string FullRootDirectory(this ContentManager content)
        {
            return new DirectoryInfo(content.RootDirectory).FullName;
        }
    }
}