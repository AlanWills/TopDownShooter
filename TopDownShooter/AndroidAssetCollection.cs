using System.Collections.Generic;
using CelesteEngine;
using Microsoft.Xna.Framework.Content;
using System.IO;
using System.Linq;

namespace TopDownShooter
{
    public class AndroidAssetCollection : IAssetCollection
    {
        /// <summary>
        /// A custom function to obtain all of the data paths from the inputted directory.
        /// Needs to be implemented because different platforms handle files differently, but also allows us to screen certain ones if necessary.
        /// </summary>
        /// <param name="content">The ContentManager we will use to load our content</param>
        /// <param name="directoryPath">The path of the directory containing the assets we wish to load</param>
        /// <returns>Returns the list of all assets we wish to load relative to the directoryPath and including extensions</returns>
        public List<string> GetAllDataFilesInDirectory(ContentManager content, string directoryPath)
        {
            List<string> files = new List<string>();

            // Assets compiled into .apk?  May just need to fall back on ContentManager
            //string currentFolder = "/data/data/TopDownShooter.TopDownShooter/files";
            //var dirs = Directory.EnumerateDirectories(currentFolder).ToList();
            //List<string> filesList = Directory.EnumerateFiles(currentFolder, "*", SearchOption.AllDirectories).ToList<string>();
            //if (Directory.Exists(directoryPath))
            //{
            //    files.AddRange(Directory.GetFiles(directoryPath, "*.xnb", SearchOption.AllDirectories));
            //}

            return files;
        }
    }
}