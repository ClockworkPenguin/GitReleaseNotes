﻿using System.IO;

namespace GitReleaseNotes
{
    class FileSystem : IFileSystem
    {
        public void WriteAllText(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }
    }
}