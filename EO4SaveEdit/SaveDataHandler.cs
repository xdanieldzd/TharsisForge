using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit
{
    public class SaveDataHandler
    {
        public List<BaseMori4File> DataFiles { get; private set; }

        public Mori4Game GameDataFile { get { return (DataFiles.FirstOrDefault(x => x is Mori4Game && !x.Filename.Contains("bk.sav")) as Mori4Game); } }
        public Mori4Game GameDataBackupFile { get { return (DataFiles.FirstOrDefault(x => x is Mori4Game && x.Filename.Contains("bk.sav")) as Mori4Game); } }
        public Mori4Map MapDatafile { get { return (DataFiles.FirstOrDefault(x => x is Mori4Map) as Mori4Map); } }
        public Mori4Option OptionDataFile { get { return (DataFiles.FirstOrDefault(x => x is Mori4Option) as Mori4Option); } }
        public Mori4GdCard GuildCardDataFile { get { return (DataFiles.FirstOrDefault(x => x is Mori4GdCard) as Mori4GdCard); } }

        public bool IsDataLoaded { get { return (DataFiles != null && DataFiles.Count != 0); } }

        public event EventHandler SaveSucceededEvent;

        public SaveDataHandler()
        {
            DataFiles = new List<BaseMori4File>();
        }

        public bool LoadDirectory(string directory)
        {
            foreach (string file in Directory.EnumerateFiles(directory))
            {
                using (FileStream stream = new FileStream(file, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    BinaryReader reader = new BinaryReader(stream);

                    string signature = Encoding.ASCII.GetString(reader.ReadBytes(8));
                    stream.Seek(0, SeekOrigin.Begin);

                    switch (signature)
                    {
                        case Mori4Option.ExpectedFileSignature: DataFiles.Add(new Mori4Option(stream)); break;
                        case Mori4Map.ExpectedFileSignature: DataFiles.Add(new Mori4Map(stream)); break;
                        case Mori4Game.ExpectedFileSignature: DataFiles.Add(new Mori4Game(stream)); break;
                        case Mori4GdCard.ExpectedFileSignature: DataFiles.Add(new Mori4GdCard(stream)); break;
                    }
                }
            }

            return IsDataLoaded;
        }

        public void Save()
        {
            foreach (BaseMori4File file in DataFiles)
            {
                using (FileStream stream = new FileStream(file.Filename, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    file.WriteToStream(stream);
                }
            }

            EventHandler handler = SaveSucceededEvent;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
    }
}
