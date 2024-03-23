namespace Notepad
{
    partial class frmNotepad
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
            this.mnu1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filePageSeup = new System.Windows.Forms.ToolStripMenuItem();
            this.filePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.munEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.editUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editCut = new System.Windows.Forms.ToolStripMenuItem();
            this.editCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.editPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.editDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.editFind = new System.Windows.Forms.ToolStripMenuItem();
            this.editFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.editReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.editGoTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.editSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.editTimedate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.formatWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.formatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.formatColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewStatusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.helpviewhelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.viewaboutnotedpad = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mnu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu1
            // 
            this.mnu1.BackColor = System.Drawing.Color.Lime;
            this.mnu1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.munEdit,
            this.mnuFormat,
            this.mnuView,
            this.mnuHelp});
            this.mnu1.Location = new System.Drawing.Point(0, 0);
            this.mnu1.Name = "mnu1";
            this.mnu1.Size = new System.Drawing.Size(1570, 40);
            this.mnu1.TabIndex = 0;
            this.mnu1.Text = "menuStrip1";
            this.mnu1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnu1_ItemClicked);
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNew,
            this.fileOpen,
            this.fileSave,
            this.fileSaveAs,
            this.toolStripSeparator1,
            this.filePageSeup,
            this.filePrint,
            this.toolStripSeparator2,
            this.fileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(64, 36);
            this.mnuFile.Text = "File";
            // 
            // fileNew
            // 
            this.fileNew.Name = "fileNew";
            this.fileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileNew.Size = new System.Drawing.Size(241, 36);
            this.fileNew.Text = "New";
            this.fileNew.Click += new System.EventHandler(this.fileNew_Click);
            // 
            // fileOpen
            // 
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileOpen.Size = new System.Drawing.Size(241, 36);
            this.fileOpen.Text = "Open";
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // fileSave
            // 
            this.fileSave.Name = "fileSave";
            this.fileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileSave.Size = new System.Drawing.Size(241, 36);
            this.fileSave.Text = "Save";
            this.fileSave.Click += new System.EventHandler(this.fileSave_Click);
            // 
            // fileSaveAs
            // 
            this.fileSaveAs.Name = "fileSaveAs";
            this.fileSaveAs.Size = new System.Drawing.Size(241, 36);
            this.fileSaveAs.Text = "Save As...";
            this.fileSaveAs.Click += new System.EventHandler(this.fileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
            // 
            // filePageSeup
            // 
            this.filePageSeup.Name = "filePageSeup";
            this.filePageSeup.Size = new System.Drawing.Size(241, 36);
            this.filePageSeup.Text = "Page Setup..";
            this.filePageSeup.Click += new System.EventHandler(this.filePageSeup_Click);
            // 
            // filePrint
            // 
            this.filePrint.Name = "filePrint";
            this.filePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.filePrint.Size = new System.Drawing.Size(241, 36);
            this.filePrint.Text = "Print...";
            this.filePrint.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // fileExit
            // 
            this.fileExit.Name = "fileExit";
            this.fileExit.Size = new System.Drawing.Size(241, 36);
            this.fileExit.Text = "Exit";
            this.fileExit.Click += new System.EventHandler(this.fileExit_Click);
            // 
            // munEdit
            // 
            this.munEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUndo,
            this.toolStripSeparator3,
            this.editCut,
            this.editCopy,
            this.editPaste,
            this.editDelete,
            this.toolStripSeparator4,
            this.editFind,
            this.editFindNext,
            this.editReplace,
            this.editGoTo,
            this.toolStripSeparator5,
            this.editSelectAll,
            this.editTimedate});
            this.munEdit.Name = "munEdit";
            this.munEdit.Size = new System.Drawing.Size(67, 36);
            this.munEdit.Text = "Edit";
            // 
            // editUndo
            // 
            this.editUndo.Name = "editUndo";
            this.editUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.editUndo.Size = new System.Drawing.Size(283, 36);
            this.editUndo.Text = "Undo";
            this.editUndo.Click += new System.EventHandler(this.editUndo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(280, 6);
            // 
            // editCut
            // 
            this.editCut.Name = "editCut";
            this.editCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.editCut.Size = new System.Drawing.Size(283, 36);
            this.editCut.Text = "Cut";
            this.editCut.Click += new System.EventHandler(this.editCut_Click);
            // 
            // editCopy
            // 
            this.editCopy.Name = "editCopy";
            this.editCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.editCopy.Size = new System.Drawing.Size(283, 36);
            this.editCopy.Text = "Copy";
            this.editCopy.Click += new System.EventHandler(this.editCopy_Click);
            // 
            // editPaste
            // 
            this.editPaste.Name = "editPaste";
            this.editPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.editPaste.Size = new System.Drawing.Size(283, 36);
            this.editPaste.Text = "Paste";
            this.editPaste.Click += new System.EventHandler(this.editPaste_Click);
            // 
            // editDelete
            // 
            this.editDelete.Name = "editDelete";
            this.editDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.editDelete.Size = new System.Drawing.Size(283, 36);
            this.editDelete.Text = "Delete";
            this.editDelete.Click += new System.EventHandler(this.editDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(280, 6);
            // 
            // editFind
            // 
            this.editFind.Name = "editFind";
            this.editFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.editFind.Size = new System.Drawing.Size(283, 36);
            this.editFind.Text = "Find..";
            // 
            // editFindNext
            // 
            this.editFindNext.Name = "editFindNext";
            this.editFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.editFindNext.Size = new System.Drawing.Size(283, 36);
            this.editFindNext.Text = "Find Next";
            // 
            // editReplace
            // 
            this.editReplace.Name = "editReplace";
            this.editReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.editReplace.Size = new System.Drawing.Size(283, 36);
            this.editReplace.Text = "Replace....";
            // 
            // editGoTo
            // 
            this.editGoTo.Name = "editGoTo";
            this.editGoTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.editGoTo.Size = new System.Drawing.Size(283, 36);
            this.editGoTo.Text = "Go To.....";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(280, 6);
            // 
            // editSelectAll
            // 
            this.editSelectAll.Name = "editSelectAll";
            this.editSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.editSelectAll.Size = new System.Drawing.Size(283, 36);
            this.editSelectAll.Text = "Select All";
            this.editSelectAll.Click += new System.EventHandler(this.editSelectAll_Click);
            // 
            // editTimedate
            // 
            this.editTimedate.Name = "editTimedate";
            this.editTimedate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.editTimedate.Size = new System.Drawing.Size(283, 36);
            this.editTimedate.Text = "Time/Date";
            this.editTimedate.Click += new System.EventHandler(this.editTimedate_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatWordWrap,
            this.formatFont,
            this.formatColor});
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(102, 36);
            this.mnuFormat.Text = "Format";
            this.mnuFormat.Click += new System.EventHandler(this.mnuFormat_Click);
            // 
            // formatWordWrap
            // 
            this.formatWordWrap.Name = "formatWordWrap";
            this.formatWordWrap.Size = new System.Drawing.Size(216, 36);
            this.formatWordWrap.Text = "Word Wrap";
            this.formatWordWrap.Click += new System.EventHandler(this.formatWordWrap_Click);
            // 
            // formatFont
            // 
            this.formatFont.Name = "formatFont";
            this.formatFont.Size = new System.Drawing.Size(216, 36);
            this.formatFont.Text = "Font...";
            this.formatFont.Click += new System.EventHandler(this.formatFont_Click);
            // 
            // formatColor
            // 
            this.formatColor.Name = "formatColor";
            this.formatColor.Size = new System.Drawing.Size(216, 36);
            this.formatColor.Text = "Color";
            this.formatColor.Click += new System.EventHandler(this.formatColor_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewStatusbar});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(78, 36);
            this.mnuView.Text = "View";
            // 
            // ViewStatusbar
            // 
            this.ViewStatusbar.Name = "ViewStatusbar";
            this.ViewStatusbar.Size = new System.Drawing.Size(208, 36);
            this.ViewStatusbar.Text = "Status  Bar";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpviewhelp,
            this.toolStripSeparator6,
            this.viewaboutnotedpad});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(77, 36);
            this.mnuHelp.Text = "Help";
            // 
            // helpviewhelp
            // 
            this.helpviewhelp.Name = "helpviewhelp";
            this.helpviewhelp.Size = new System.Drawing.Size(261, 36);
            this.helpviewhelp.Text = "View Help";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(258, 6);
            // 
            // viewaboutnotedpad
            // 
            this.viewaboutnotedpad.Name = "viewaboutnotedpad";
            this.viewaboutnotedpad.Size = new System.Drawing.Size(261, 36);
            this.viewaboutnotedpad.Text = "About Notepad";
            this.viewaboutnotedpad.Click += new System.EventHandler(this.viewaboutnotedpad_Click);
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(0, 40);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(1570, 615);
            this.txtBox.TabIndex = 1;
            this.txtBox.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // frmNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 655);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.mnu1);
            this.MainMenuStrip = this.mnu1;
            this.Name = "frmNotepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNotepad_FormClosed);
            this.Load += new System.EventHandler(this.frmNotepad_Load);
            this.mnu1.ResumeLayout(false);
            this.mnu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileNew;
        private System.Windows.Forms.ToolStripMenuItem fileOpen;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem filePageSeup;
        private System.Windows.Forms.ToolStripMenuItem filePrint;
        private System.Windows.Forms.ToolStripMenuItem fileExit;
        private System.Windows.Forms.ToolStripMenuItem munEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem editCut;
        private System.Windows.Forms.ToolStripMenuItem editCopy;
        private System.Windows.Forms.ToolStripMenuItem editPaste;
        private System.Windows.Forms.ToolStripMenuItem editDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem editFind;
        private System.Windows.Forms.ToolStripMenuItem editFindNext;
        private System.Windows.Forms.ToolStripMenuItem editReplace;
        private System.Windows.Forms.ToolStripMenuItem editGoTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem editSelectAll;
        private System.Windows.Forms.ToolStripMenuItem editTimedate;
        private System.Windows.Forms.ToolStripMenuItem formatWordWrap;
        private System.Windows.Forms.ToolStripMenuItem formatFont;
        private System.Windows.Forms.ToolStripMenuItem ViewStatusbar;
        private System.Windows.Forms.ToolStripMenuItem helpviewhelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem viewaboutnotedpad;
        private System.Windows.Forms.RichTextBox txtBox;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem formatColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Timer timer1;
    }
}

