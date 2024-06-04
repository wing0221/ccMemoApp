namespace memoapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NotepadTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            NotepadMenuStrip = new ToolStripMenuItem();
            NewToolStripMenuItem = new ToolStripMenuItem();
            ReadToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            NotepadOpenFileDialog = new OpenFileDialog();
            NotepadSaveFileDialog = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // NotepadTextBox
            // 
            NotepadTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NotepadTextBox.Location = new Point(1, 43);
            NotepadTextBox.Multiline = true;
            NotepadTextBox.Name = "NotepadTextBox";
            NotepadTextBox.ScrollBars = ScrollBars.Both;
            NotepadTextBox.Size = new Size(1472, 853);
            NotepadTextBox.TabIndex = 0;
            NotepadTextBox.WordWrap = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { NotepadMenuStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1458, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // NotepadMenuStrip
            // 
            NotepadMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { NewToolStripMenuItem, ReadToolStripMenuItem, SaveToolStripMenuItem });
            NotepadMenuStrip.Name = "NotepadMenuStrip";
            NotepadMenuStrip.Size = new Size(102, 36);
            NotepadMenuStrip.Text = "ファイル";
            // 
            // NewToolStripMenuItem
            // 
            NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            NewToolStripMenuItem.Size = new Size(243, 44);
            NewToolStripMenuItem.Text = "新規作成";
            NewToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            // 
            // ReadToolStripMenuItem
            // 
            ReadToolStripMenuItem.Name = "ReadToolStripMenuItem";
            ReadToolStripMenuItem.Size = new Size(243, 44);
            ReadToolStripMenuItem.Text = "読み込み";
            ReadToolStripMenuItem.Click += ReadToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(243, 44);
            SaveToolStripMenuItem.Text = "保存";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // NotepadOpenFileDialog
            // 
            NotepadOpenFileDialog.FileName = "openFileDialog1";
            NotepadOpenFileDialog.FileOk += NotepadOpenFileDialog_FileOk;
            // 
            // NotepadSaveFileDialog
            // 
            NotepadSaveFileDialog.Filter = "テキストファイル|*.txt|すべてのファイル|*.*";
            NotepadSaveFileDialog.FileOk += NotepadSaveFileDialog_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 892);
            Controls.Add(NotepadTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "メモ帳";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NotepadTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem NotepadMenuStrip;
        private ToolStripMenuItem NewToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem ReadToolStripMenuItem;
        private OpenFileDialog NotepadOpenFileDialog;
        private SaveFileDialog NotepadSaveFileDialog;
    }
}
