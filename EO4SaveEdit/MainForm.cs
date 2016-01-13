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

using EO4SaveEdit.Editors;
using EO4SaveEdit.Extensions;
using EO4SaveEdit.FileHandlers;

namespace EO4SaveEdit
{
    public partial class MainForm : Form
    {
        Version programVersion;
        SaveDataHandler saveDataHandler;
        List<IEditorControl> editorControls;

        public MainForm()
        {
            InitializeComponent();

            programVersion = new Version(Application.ProductVersion);

            editorControls = new List<IEditorControl>()
            {
                mapEditor1, optionEditor1, characterEditor1, guildCardEditor1, itemEditor1, gameDataEditor1
            };

            SetFormTitle();
            tsslStatus.Text = "Ready";

#if DEBUG
            //LoadData(@"E:\[SSD User Data]\Desktop\filer\UserSaveData\20150830021743_editor-test\00000ea6");
            //LoadData(@"E:\[SSD User Data]\Downloads\EOIV\save-test");
            //LoadData(@"E:\[SSD User Data]\Desktop\filer\UserSaveData\20150918205127\00000ea6");
            //LoadData(@"E:\[SSD User Data]\Desktop\filer\UserSaveData\20151006190604_editor-test\00000ea6");

            /*RomFSDataDumper.DumpItemData(
                @"E:\Translations\3DS Etrian Odyssey 4\Original & Dumps\original-jpn\Item\equipitemnametable.tbl",
                @"E:\Translations\3DS Etrian Odyssey 4\Original & Dumps\original-jpn\Item\equipitemtable.tbl",
                @"C:\Temp\equipitemnametable_jp.xml");

            RomFSDataDumper.DumpSkillData(
                @"E:\Translations\3DS Etrian Odyssey 4\Original & Dumps\original-jpn\Skill\playerskillnametable.tbl",
                @"E:\Translations\3DS Etrian Odyssey 4\Original & Dumps\original-jpn\Skill\playerskilltable.tbl",
                @"E:\Translations\3DS Etrian Odyssey 4\Original & Dumps\original-jpn\Skill\SkillTreeTable.tbl",
                @"C:\Temp\playerskillnametable_jp.xml");

            RomFSDataDumper.DumpTreasureMapData(
                @"E:\Translations\3DS Etrian Odyssey 4\Original & Dumps\original-jpn\Dungeon\HiddenTreasureName.tbl",
                @"C:\Temp\HiddenTreasureName_jp.xml");

            RomFSDataDumper.DumpUseItemData(
                @"E:\Translations\3DS Etrian Odyssey 4\Original & Dumps\original-jpn\Item\useitemnametable.tbl",
                @"C:\Temp\useitemnametable_jp.xml");*/
#endif
        }

        private void SetFormTitle()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendFormat("{0} v{1}.{2}", Application.ProductName, programVersion.Major, programVersion.Minor);
            if (programVersion.Build != 0) builder.AppendFormat(".{0}", programVersion.Build);
            if (saveDataHandler != null && saveDataHandler.IsDataLoaded) builder.AppendFormat(" - [{0}]", Properties.Settings.Default.LastFolder);

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
                LoadData(folderBrowserDialog1.SelectedPath);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
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
            builder.AppendLine(string.Format("{0} - https://github.com/xdanieldzd/", Assembly.GetExecutingAssembly().GetAttribute<AssemblyCopyrightAttribute>().Copyright));
            builder.AppendLine();
            builder.AppendLine("Thanks to various GBATemp users for feedback!");

            MessageBox.Show(builder.ToString(), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadData(string path)
        {
            foreach (Control editor in editorControls)
                editor.Enabled = false;

            saveDataHandler = new SaveDataHandler();
            if (!saveDataHandler.LoadDirectory(path))
            {
                MessageBox.Show("No compatible 'mori4*.sav' save files found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fileHeadersToolStripMenuItem.DropDownItems.Clear();
                fileHeadersToolStripMenuItem.DropDownItems.Add(dummyToolStripMenuItem);
                fileHeadersToolStripMenuItem.Enabled = false;
            }
            else
            {
                foreach (IEditorControl editor in editorControls)
                    editor.Initialize(saveDataHandler);

                saveToolStripMenuItem.Enabled = true;
                Properties.Settings.Default.LastFolder = path;

                fileHeadersToolStripMenuItem.DropDownItems.Clear();
                foreach (BaseMori4File file in saveDataHandler.DataFiles.OrderBy(x => x.Filename))
                {
                    fileHeadersToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem(Path.GetFileName(file.Filename), null, new EventHandler((s, e) =>
                    {
                        HeaderEditorDialog hed = new HeaderEditorDialog((s as ToolStripMenuItem).Tag as FileHeader);
                        hed.ShowDialog();
                    })) { Tag = file.FileHeader });
                }
                fileHeadersToolStripMenuItem.Enabled = true;

                SetFormTitle();
                tsslStatus.Text = "Data loaded!";
            }
        }

        private void SaveData()
        {
            if (saveDataHandler != null && saveDataHandler.IsDataLoaded)
            {
                saveDataHandler.Save();
                tsslStatus.Text = "Data saved!";
            }
        }
    }
}
