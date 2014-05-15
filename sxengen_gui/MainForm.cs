using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sxengen_gui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            fileTreeView.ExpandAll();
        }

        static List<string> audiofilepath_list = new List<string>(0);
        static List<string> miscfilepath_list = new List<string>(0);
        static List<string> audiofilename_list = new List<string>(0);
        static List<string> miscfilename_list = new List<string>(0);

        void updateTreeview()
        {
            fileTreeView.Nodes["FILE_NODE"].Nodes["AUDIO_NODE"].Nodes.Clear();
            //Add in Audio Nodes
            for (int i = 0; i < audiofilepath_list.Count; i++)
            {
                fileTreeView.Nodes["FILE_NODE"].Nodes["AUDIO_NODE"].Nodes.Add("AUDIO" + i.ToString(), audiofilename_list[i]);
            }

            fileTreeView.Nodes["FILE_NODE"].Nodes["MISC_NODE"].Nodes.Clear();
            //Add in Misc Nodes
            for (int i = 0; i < miscfilepath_list.Count; i++)
            {
                fileTreeView.Nodes["FILE_NODE"].Nodes["MISC_NODE"].Nodes.Add("MISC" + i.ToString(), miscfilename_list[i]);
            }
            fileTreeView.ExpandAll();
        }

        void addAudioSlot(string full_path, string file_name)
        {
            audiofilepath_list.Add(full_path);
            audiofilename_list.Add(file_name);
            updateTreeview();
        }

        void addMiscSlot(string full_path, string file_name)
        {
            miscfilepath_list.Add(full_path);
            miscfilename_list.Add(file_name);
            updateTreeview();
        }

        void writePackageFile(string filename)
        {
            StreamWriter fp;
            fp = new StreamWriter(filename);
            fp.WriteLine("[INFORMATION]");
            fp.WriteLine("\tname = " + textBox_Name.Text);
            fp.WriteLine("\tauthor = " + textBox_Author.Text);
            fp.WriteLine("\tyear = " + textBox_Year.Text);
            fp.WriteLine("\tlength = " + textBox_Length.Text);
            fp.WriteLine("\tgenre = " + textBox_Genre.Text);
            fp.WriteLine("\talbum = " + textBox_Album.Text);
            fp.WriteLine("\tcomment = " + textBox_Comment.Text);
            fp.WriteLine("[AUDIO]");
            for (int i = 0; i < audiofilepath_list.Count; i++)
            {
                fp.WriteLine("\tfile = " + audiofilepath_list[i]);
            }
            fp.WriteLine("[MISC]");
            for (int i = 0; i < miscfilepath_list.Count; i++)
            {
                fp.WriteLine("\tfile = " + miscfilepath_list[i]);
            }
            fp.Close();
        }

        private void button_addaudio_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileAudio.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (File.Exists(openFileAudio.FileName))
                {
                    addAudioSlot(openFileAudio.FileName, Path.GetFileName(openFileAudio.FileName));
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button_addmisc_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileAudio.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (File.Exists(openFileAudio.FileName))
                {
                    addMiscSlot(openFileAudio.FileName, Path.GetFileName(openFileAudio.FileName));
                }
            }
        }

        private void button_package_Click(object sender, EventArgs e)
        {
            //First off, write the text file to read data from.
            DialogResult sf = saveFileDialog.ShowDialog();

            if (sf == DialogResult.OK)
            {
                writePackageFile("data_txt.ini");
    
                // Open the C++ Version of sxengen.
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "sxengen.exe";
                try
                    {
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        exeProcess.WaitForExit();
                    }
                }
                catch
                {
                    //Log I think...
                }

                File.Move("pak.sxen", saveFileDialog.FileName);
            }
            //Delete the temp file.
            File.Delete("data_txt.ini");
        }
    }
}
