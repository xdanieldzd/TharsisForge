using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

using EO4SaveEdit.Extensions;
using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit
{
    public partial class MainForm : Form
    {
        Version programVersion;
        List<BaseMori4File> dataFiles;

        public MainForm()
        {
            InitializeComponent();

            programVersion = new Version(Application.ProductVersion);

            SetFormTitle();
            tsslStatus.Text = "Ready";

#if DEBUG
            //LoadSaveData(@"E:\[SSD User Data]\Desktop\filer\UserSaveData\20150830021743_editor-test\00000ea6");
            //LoadSaveData(@"E:\[SSD User Data]\Downloads\EOIV\save-test");
            LoadSaveData(@"E:\[SSD User Data]\Desktop\filer\UserSaveData\20150918205127\00000ea6");

            /*RomFSDataDumper.DumpItemData(
                @"E:\[SSD User Data]\Downloads\EOIV\romfs\Item\equipitemnametable.tbl",
                @"E:\[SSD User Data]\Downloads\EOIV\romfs\Item\equipitemtable.tbl",
                @"C:\Temp\equipitemnametable.xml");*/

            /*RomFSDataDumper.DumpSkillData(
                @"E:\[SSD User Data]\Downloads\EOIV\romfs\Skill\playerskillnametable.tbl",
                @"E:\[SSD User Data]\Downloads\EOIV\romfs\Skill\playerskilltable.tbl",
                @"E:\[SSD User Data]\Downloads\EOIV\romfs\Skill\SkillTreeTable.tbl",
                @"C:\Temp\playerskillnametable.xml");*/

            /*RomFSDataDumper.DumpTreasureMapData(
                @"E:\[SSD User Data]\Downloads\EOIV\romfs\Dungeon\HiddenTreasureName.tbl",
                @"C:\Temp\HiddenTreasureName.xml");*/

            /*RomFSDataDumper.DumpUseItemData(
                @"E:\[SSD User Data]\Downloads\EOIV\romfs\Item\useitemnametable.tbl",
                @"C:\Temp\useitemnametable.xml");*/
#else
            // TEMP TEMP
            tabControl1.TabPages.Remove(tpCharas);
            tabControl1.TabPages.Remove(tpMaps);
            tabControl1.TabPages.Remove(tpGameData);
#endif
        }

        private void SetFormTitle()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendFormat("{0} v{1}.{2}", Application.ProductName, programVersion.Major, programVersion.Minor);
            if (programVersion.Build != 0) builder.AppendFormat(".{0}", programVersion.Build);
            if (dataFiles != null && dataFiles.Count != 0) builder.AppendFormat(" - [{0}]", Properties.Settings.Default.LastFolder);

            this.Text = builder.ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select folder with 'mori4*.sav' save files.";
            folderBrowserDialog1.SelectedPath = Properties.Settings.Default.LastFolder;
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadSaveData(folderBrowserDialog1.SelectedPath);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataFiles == null || dataFiles.Count == 0) return;

            foreach (BaseMori4File file in dataFiles)
            {
                using (FileStream stream = new FileStream(file.Filename, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    file.WriteToStream(stream);
                }

                tsslStatus.Text = "Data saved!";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendFormat("{0} v{1}.{2}", Application.ProductName, programVersion.Major, programVersion.Minor);
            if (programVersion.Build != 0) builder.AppendFormat(".{0}", programVersion.Build);
            builder.Append(" - ");
            builder.AppendLine(Assembly.GetExecutingAssembly().GetAttribute<AssemblyDescriptionAttribute>().Description);
            builder.AppendLine();
            builder.AppendFormat("{0} - https://github.com/xdanieldzd/ ", Assembly.GetExecutingAssembly().GetAttribute<AssemblyCopyrightAttribute>().Copyright);

            MessageBox.Show(builder.ToString(), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadSaveData(string path)
        {
            mapEditor1.Initialize(null);
            optionEditor1.Initialize(null);
            characterEditor1.Initialize(null);
            guildCardEditor1.Initialize(null);

            dataFiles = new List<BaseMori4File>();

            foreach (string file in Directory.EnumerateFiles(path))
            {
                using (FileStream stream = new FileStream(file, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    BinaryReader reader = new BinaryReader(stream);

                    string signature = Encoding.ASCII.GetString(reader.ReadBytes(8));
                    stream.Seek(0, SeekOrigin.Begin);

                    switch (signature)
                    {
                        case Mori4Option.ExpectedFileSignature: dataFiles.Add(new Mori4Option(stream)); break;
                        case Mori4Map.ExpectedFileSignature: dataFiles.Add(new Mori4Map(stream)); break;
                        case Mori4Game.ExpectedFileSignature: dataFiles.Add(new Mori4Game(stream)); break;
                        case Mori4GdCard.ExpectedFileSignature: dataFiles.Add(new Mori4GdCard(stream)); break;
                    }
                }
            }

            if (dataFiles.Count == 0)
            {
                MessageBox.Show("No compatible 'mori4*.sav' save files found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mapEditor1.Initialize(dataFiles.FirstOrDefault(x => x is Mori4Map) as Mori4Map);
                optionEditor1.Initialize(dataFiles.FirstOrDefault(x => x is Mori4Option) as Mori4Option);
                characterEditor1.Initialize(dataFiles.FirstOrDefault(x => x is Mori4Game) as Mori4Game);
                guildCardEditor1.Initialize(dataFiles.FirstOrDefault(x => x is Mori4GdCard) as Mori4GdCard);
                itemEditor1.Initialize(dataFiles.FirstOrDefault(x => x is Mori4Game) as Mori4Game);
                gameDataEditor1.Initialize(dataFiles.FirstOrDefault(x => x is Mori4Game) as Mori4Game);

                saveToolStripMenuItem.Enabled = true;
                Properties.Settings.Default.LastFolder = path;

                SetFormTitle();
                tsslStatus.Text = "Data loaded!";
            }
        }
    }
}
