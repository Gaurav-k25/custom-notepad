using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frmNotepad : Form
    {
        public frmNotepad()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private void editUndo_Click(object sender, EventArgs e)
        {
            txtBox.Undo();
        }

        private void editCut_Click(object sender, EventArgs e)
        {
            txtBox.Cut();
        }

        private void editCopy_Click(object sender, EventArgs e)
        {
            txtBox.Copy();
        }

        private void editPaste_Click(object sender, EventArgs e)
        {
            txtBox.Paste();
        }



        private void mnuFormat_Click(object sender, EventArgs e)
        {

        }

        private void formatWordWrap_Click(object sender, EventArgs e)
        {
            if (txtBox.WordWrap == false)
            {
                txtBox.WordWrap = true;
                formatWordWrap.Checked = true;
            }
            else
            {
                txtBox.WordWrap = false;
                formatWordWrap.Checked = false;
            }
        }

        private void formatFont_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            txtBox.Font = fontDialog.Font;
        }

        private void formatColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            txtBox.ForeColor = colorDialog.Color;
        }

        private void fileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            txtBox.LoadFile(openFileDialog.FileName);

        }

        private void fileSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            txtBox.SaveFile(saveFileDialog.FileName);

           

        }

        private void fileSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            txtBox.SaveFile(saveFileDialog.FileName);

            MessageBox.Show("File Saved Successfully", "Notepad");

        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void filePageSeup_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }

        private void editTimedate_Click(object sender, EventArgs e)
        {
            txtBox.Text += " " + DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToShortDateString();
        }

        private void fileNew_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                DialogResult dr = MessageBox.Show("Do you want to save the chnages?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    fileSave_Click(sender, e);
                }
                else if (dr == DialogResult.No)
                {
                    txtBox.Text = "";
                }
                else if (dr == DialogResult.Cancel)
                {

                }
            }
        }

        private void editSelectAll_Click(object sender, EventArgs e)
        {
            txtBox.SelectAll();
        }

        private void editDelete_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void mnu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            txtBox.WordWrap = false;
        }

        private void viewaboutnotedpad_Click(object sender, EventArgs e)
        {
            frmNotepadHelp f = new frmNotepadHelp();
            f.ShowDialog();
        }

        private void frmNotepad_Load(object sender, EventArgs e)
        {
        
        }
        private void Close_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                DialogResult dr = MessageBox.Show("Do you want to save the chnages?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    fileSave_Click(sender, e);
                }
                else if (dr == DialogResult.No)
                {
                    txtBox.Text = "";
                }
                else if (dr == DialogResult.Cancel)
                {

                }

            }
        }

        private void frmNotepad_FormClosed(object sender, FormClosedEventArgs e)
        {
           if(txtBox.Text!="")
            {
                DialogResult pr = MessageBox.Show("Do You Want to save or not Program", "Notepad", MessageBoxButtons.YesNoCancel);

                if(pr==DialogResult.Yes)
                {
                    fileSave_Click(sender, e);
                }
                else if(pr==DialogResult.No)
                {
                    txtBox.Text = "";
                }
                else if(pr==DialogResult.Cancel)
                {

                }
           }
        }
    }
}
