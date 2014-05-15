namespace sxengen_gui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("AUDIO");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("MISC");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("file.sxen", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fileTreeView = new System.Windows.Forms.TreeView();
            this.tabConsole = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.textBox_Length = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Album = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Genre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_package = new System.Windows.Forms.Button();
            this.button_addmisc = new System.Windows.Forms.Button();
            this.button_addaudio = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileAudio = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "&File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "&Edit";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "&View";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(676, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fileTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabConsole);
            this.splitContainer1.Size = new System.Drawing.Size(676, 314);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 1;
            // 
            // fileTreeView
            // 
            this.fileTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileTreeView.Location = new System.Drawing.Point(0, 0);
            this.fileTreeView.Name = "fileTreeView";
            treeNode1.Name = "AUDIO_NODE";
            treeNode1.Text = "AUDIO";
            treeNode2.Name = "MISC_NODE";
            treeNode2.Text = "MISC";
            treeNode3.Name = "FILE_NODE";
            treeNode3.Text = "file.sxen";
            this.fileTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.fileTreeView.Size = new System.Drawing.Size(225, 314);
            this.fileTreeView.TabIndex = 0;
            this.fileTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabConsole
            // 
            this.tabConsole.Controls.Add(this.tabMain);
            this.tabConsole.Controls.Add(this.tabPage2);
            this.tabConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConsole.Location = new System.Drawing.Point(0, 0);
            this.tabConsole.Name = "tabConsole";
            this.tabConsole.SelectedIndex = 0;
            this.tabConsole.Size = new System.Drawing.Size(447, 314);
            this.tabConsole.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.textBox_Length);
            this.tabMain.Controls.Add(this.label7);
            this.tabMain.Controls.Add(this.textBox_Comment);
            this.tabMain.Controls.Add(this.label6);
            this.tabMain.Controls.Add(this.textBox_Album);
            this.tabMain.Controls.Add(this.label5);
            this.tabMain.Controls.Add(this.textBox_Genre);
            this.tabMain.Controls.Add(this.label4);
            this.tabMain.Controls.Add(this.textBox_Year);
            this.tabMain.Controls.Add(this.label3);
            this.tabMain.Controls.Add(this.textBox_Author);
            this.tabMain.Controls.Add(this.label2);
            this.tabMain.Controls.Add(this.textBox_Name);
            this.tabMain.Controls.Add(this.label1);
            this.tabMain.Controls.Add(this.button_package);
            this.tabMain.Controls.Add(this.button_addmisc);
            this.tabMain.Controls.Add(this.button_addaudio);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(439, 288);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // textBox_Length
            // 
            this.textBox_Length.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Length.Location = new System.Drawing.Point(333, 92);
            this.textBox_Length.Name = "textBox_Length";
            this.textBox_Length.Size = new System.Drawing.Size(98, 20);
            this.textBox_Length.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Length";
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Comment.Location = new System.Drawing.Point(63, 144);
            this.textBox_Comment.Multiline = true;
            this.textBox_Comment.Name = "textBox_Comment";
            this.textBox_Comment.Size = new System.Drawing.Size(368, 109);
            this.textBox_Comment.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Comment";
            // 
            // textBox_Album
            // 
            this.textBox_Album.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Album.Location = new System.Drawing.Point(63, 118);
            this.textBox_Album.Name = "textBox_Album";
            this.textBox_Album.Size = new System.Drawing.Size(368, 20);
            this.textBox_Album.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Album";
            // 
            // textBox_Genre
            // 
            this.textBox_Genre.Location = new System.Drawing.Point(186, 92);
            this.textBox_Genre.Name = "textBox_Genre";
            this.textBox_Genre.Size = new System.Drawing.Size(98, 20);
            this.textBox_Genre.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Genre";
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(63, 92);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(72, 20);
            this.textBox_Year.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year";
            // 
            // textBox_Author
            // 
            this.textBox_Author.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Author.Location = new System.Drawing.Point(63, 66);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(368, 20);
            this.textBox_Author.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Author";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Name.Location = new System.Drawing.Point(63, 40);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(368, 20);
            this.textBox_Name.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // button_package
            // 
            this.button_package.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_package.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_package.Location = new System.Drawing.Point(358, 259);
            this.button_package.Name = "button_package";
            this.button_package.Size = new System.Drawing.Size(75, 23);
            this.button_package.TabIndex = 2;
            this.button_package.Text = "Package!";
            this.button_package.UseVisualStyleBackColor = true;
            this.button_package.Click += new System.EventHandler(this.button_package_Click);
            // 
            // button_addmisc
            // 
            this.button_addmisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addmisc.Location = new System.Drawing.Point(87, 6);
            this.button_addmisc.Name = "button_addmisc";
            this.button_addmisc.Size = new System.Drawing.Size(75, 23);
            this.button_addmisc.TabIndex = 1;
            this.button_addmisc.Text = "Add Misc";
            this.button_addmisc.UseVisualStyleBackColor = true;
            this.button_addmisc.Click += new System.EventHandler(this.button_addmisc_Click);
            // 
            // button_addaudio
            // 
            this.button_addaudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addaudio.Location = new System.Drawing.Point(6, 6);
            this.button_addaudio.Name = "button_addaudio";
            this.button_addaudio.Size = new System.Drawing.Size(75, 23);
            this.button_addaudio.TabIndex = 0;
            this.button_addaudio.Text = "Add Audio";
            this.button_addaudio.UseVisualStyleBackColor = true;
            this.button_addaudio.Click += new System.EventHandler(this.button_addaudio_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(439, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Console";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "SXEN Package Format (*.sxen)|*.sxen";
            this.saveFileDialog.Title = "Choose where to save the package file.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 336);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "sxengen_gui by iDestyKK";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabConsole.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView fileTreeView;
        private System.Windows.Forms.TabControl tabConsole;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_addmisc;
        private System.Windows.Forms.Button button_addaudio;
        private System.Windows.Forms.OpenFileDialog openFileAudio;
        private System.Windows.Forms.Button button_package;
        private System.Windows.Forms.TextBox textBox_Length;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Comment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Album;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Genre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

