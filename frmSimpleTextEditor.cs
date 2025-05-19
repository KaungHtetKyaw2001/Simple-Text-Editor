using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SimpleTextEditor_L4DC_124_
{
    public partial class frmSimpleTextEditior : Form
    {
        public string FindID;
        public string ReplaceID;
        public string ID;
        dsTextEditiorTableAdapters.FindAndReplaceTableAdapter fnr = new dsTextEditiorTableAdapters.FindAndReplaceTableAdapter();
        dsTextEditiorTableAdapters.FilesTableAdapter ft = new dsTextEditiorTableAdapters.FilesTableAdapter();
        dsTextEditiorTableAdapters.FileDetailInformationTableAdapter fdit = new dsTextEditiorTableAdapters.FileDetailInformationTableAdapter();
        int NoofTags = 1;
        public frmSimpleTextEditior()
        {
            InitializeComponent();
        }
        private RichTextBox GetOpenRichTextBox()
        {
            RichTextBox rtb = null;
            TabPage tp = tabDisplay.SelectedTab;
            if (tp != null)
            {
                rtb = tp.Controls[0] as RichTextBox;
            }
            return rtb;
        }
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnuUndo_Click(object sender, EventArgs e)
        {
            GetOpenRichTextBox().Undo();
            rtbShow.Undo();
        }
        private void mnuRedo_Click(object sender, EventArgs e)
        {
            GetOpenRichTextBox().Redo();
            rtbShow.Redo();
        }
        private void mnuNew_Click(object sender, EventArgs e)
        {
            try
            {
                tpmenu.Visible = true;
                rtbShow.Hide();
                RichTextBox rt = new RichTextBox();
                NoofTags = NoofTags + 1;
                TabPage newpage = new TabPage("Untitled" + NoofTags);
                tabDisplay.TabPages.Add(newpage);
                tabDisplay.SelectTab(NoofTags - 1);
                tabDisplay.SelectedTab.Controls.Add(rt);
                rt.AcceptsTab = true;
                rt.Dock = DockStyle.Fill;
                rt.BackColor = Color.White;
                rt.ForeColor = Color.Black;
                rt.Multiline = true;
                rt.Font = new Font(this.Font.FontFamily, this.FontHeight + 2, FontStyle.Regular);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Null Pages are not allowed","Null page is not accepted",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Hide();
                frmSimpleTextEditior fste = new frmSimpleTextEditior();
                fste.ShowDialog();

            }
        }
        private void mnuOpen_Click(object sender, EventArgs e)
        {
            Stream myStream;
            RichTextBox rtb = new RichTextBox();
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream=ofd.OpenFile()) !=null)
                {
                    string Filename = ofd.FileName;
                    string text = File.ReadAllText(Filename);
                    GetOpenRichTextBox().Text = text;
                    tabDisplay.SelectedTab.Text = Path.GetFileName(ofd.FileName);
                }
            }

        }
        private void AutoID()
        {
            
            DataTable dt = new DataTable();
            dt = ft.GetData();
            if (dt.Rows.Count == 0)
            {
                ID = "U_00001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                string oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt16(oldid.Substring(2, 5));
                if (newid >= 1 && newid <= 9)
                {
                    ID = "U_0000" + (newid + 1);
                }
            }
        }
        private void mnuSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(tabDisplay.SelectedTab.Text))
            {
                StreamWriter sw = new StreamWriter(tabDisplay.SelectedTab.Text);
                sw.Write(tabDisplay.SelectedTab.Text);
                sw.Close();
            }
            else
            {
                Save.Title = "Save File Page...";
                Save.ShowDialog();
                string filename,FileLocation;
                filename = Save.FileName;
                FileLocation = filename;
                StreamWriter SaveAs = new StreamWriter(filename);
                SaveAs.Write(tabDisplay.SelectedTab.Text);
                SaveAs.Close();
                tabDisplay.SelectedTab.Text = filename;
                ft.Insert(ID,frmLogin.uid,filename,FileLocation);
                fdit.Insert(ID,FindID,ReplaceID);
            }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Do not leave with the Leave path. Please choose at least a path","Save Error for Empty Path",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void mnuFind_Click(object sender, EventArgs e)
        {
            lblFind.Visible = true;
            lblReplace.Visible = true;
            txtFind.Visible = true;
            txtReplace.Visible = true;
            btnFind.Visible = true;
            btnReplace.Visible = true;
            gpFindandReplace.Visible = true;
        }
        private void frmSimpleTextEditior_Load(object sender, EventArgs e)
        {
            RichTextBox rt = new RichTextBox();
            TabPage newpage = new TabPage("Untitled" + NoofTags);
            tabDisplay.TabPages.Add(newpage);
            tabDisplay.SelectTab(NoofTags - 1);
            tabDisplay.SelectedTab.Controls.Add(rt);
            rt.AcceptsTab = true;
            rt.Dock = DockStyle.Fill;
            rt.BackColor = Color.White;
            rt.ForeColor = Color.Black;
            rt.Multiline = true;
            rt.Font = new Font(this.Font.FontFamily, this.FontHeight + 2, FontStyle.Regular);
            tabDisplay.SelectedTab.BackColor = Color.LightGray;
            rtbShow.Hide();
            this.Text = "Welcome " + frmLogin.uname;
            lblFind.Visible = false;
            lblReplace.Visible = false;
            btnFind.Visible = false;
            btnReplace.Visible = false;
            txtFind.Visible = false;
            txtReplace.Visible = false;
            chkGenerate.Visible = false;
            gpFindandReplace.Visible = false;
            tpmenu.Visible = false;
            foreach (FontFamily Fonts in FontFamily.Families)
            {
                cboFontStyle.Items.Add(Fonts.Name.ToString());
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to close the form?", "Close form", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            TabPage ct = tabDisplay.SelectedTab;
            tabDisplay.TabPages.Remove(ct);
            
            
        }
        private void rtbShow_TextChanged(object sender, EventArgs e)
        {
            string pattern = "";
            string[] keywords =
            {
                "bool","int","string","class","public","foreach","private","void"
            };
            foreach (var item in keywords)
            {
                pattern += item + "|";
            }
            Regex R = new Regex(pattern);
            int index = rtbShow.SelectionStart;
            foreach (Match m in R.Matches(rtbShow.Text))
            {
                rtbShow.Select(m.Index, m.Value.Length);
                rtbShow.SelectionColor = Color.Blue;
                rtbShow.SelectionStart = index;
            }
            rtbShow.SelectionColor = Color.Black;
        }
        private void cFormattingCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tpmenu.Visible = true;
            chkGenerate.Visible = true;
            rtbShow.Show();
            RichTextBox rt = new RichTextBox();
            tabDisplay.SelectedTab.Controls.Add(rt);
            rt.AcceptsTab = true;
            rt.Dock = DockStyle.Fill;
            rt.BackColor = Color.White;
            rt.ForeColor = Color.Black;
            rt.Multiline = true;
            rt.Font = new Font(this.Font.FontFamily, this.FontHeight + 2, FontStyle.Regular);
        }
        private void mnuCopy_Click(object sender, EventArgs e)
        {
            GetOpenRichTextBox().Copy();
            rtbShow.Copy();
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            GetOpenRichTextBox().Cut();
            rtbShow.Cut();
        }
        private void mnuPaste_Click(object sender, EventArgs e)
        {   
            GetOpenRichTextBox().Paste();
            rtbShow.Paste();   
        }

        private void rtbShow_KeyPress(object sender, KeyPressEventArgs e)
        {   
            string s = e.KeyChar.ToString();
            int sel = rtbShow.SelectionStart;
            if (chkGenerate.Checked==true)
            {
                switch (s)
                {
                    case "(": rtbShow.Text = rtbShow.Text.Insert(sel, "()");
                        e.Handled = true;
                        rtbShow.SelectionStart = sel + 1;
                        break;

                    case "{" :
                        string t="{}";
                        rtbShow.Text=rtbShow.Text.Insert(sel,"{}");
                        e.Handled=true;
                        rtbShow.SelectionStart=sel + t.Length-1;
                        //conkey = true;
                        break;

                    case "[": rtbShow.Text = rtbShow.Text.Insert(sel, "[]");
                        e.Handled = true;
                        rtbShow.SelectionStart = sel + 1;
                        break;

                    case "<": rtbShow.Text = rtbShow.Text.Insert(sel, "<>");
                        e.Handled = true;
                        rtbShow.SelectionStart = sel + 1;
                        break;
                   
                    case "\"": rtbShow.Text=rtbShow.Text.Insert(sel,"\"\"");
                        e.Handled=true;
                        rtbShow.SelectionStart=sel+1;
                        break;
                        
                }
            }
        }

      
        private void btnFind_Click(object sender, EventArgs e)
        {
            int start = 0;
            int end = rtbShow.Text.LastIndexOf(txtFind.Text);
            if (txtFind.Text=="")
            {
                MessageBox.Show("Please Enter Find Data", "Enter the word", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (rtbShow.Text=="")
            {
                MessageBox.Show("No Words are found in the box", "Find", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                while (start<end)
                {
                    rtbShow.Find(txtFind.Text, start, rtbShow.TextLength, RichTextBoxFinds.MatchCase);
                    rtbShow.SelectionBackColor = Color.LightBlue;
                    start = rtbShow.Text.IndexOf(txtFind.Text, start) + 1;
                    rtbShow.SelectAll();
                }
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            rtbShow.SelectAll();
            rtbShow.SelectionBackColor = Color.Cyan;
            try
            {
                string search = txtFind.Text.Trim();
                string replace = txtReplace.Text.Trim();
                if (search=="")
                {
                    MessageBox.Show("Please Enter The Replace Word", "Type the Replace word", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string newtext = rtbShow.Text.Replace(search, replace);
                    rtbShow.Text = newtext;
                    rtbShow.SelectAll();
                    fnr.Insert(ID, ID, search, replace);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                 rtbShow.Font = new Font(cboFontStyle.Text, rtbShow.Font.Size);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsnew_Click(object sender, EventArgs e)
        {
            try
            {
                rtbShow.Hide();
                RichTextBox rt = new RichTextBox();
                NoofTags = NoofTags + 1;
                TabPage newpage = new TabPage("Untitled" + NoofTags);
                tabDisplay.TabPages.Add(newpage);
                tabDisplay.SelectTab(NoofTags - 1);
                tabDisplay.SelectedTab.Controls.Add(rt);
                rt.AcceptsTab = true;
                rt.Dock = DockStyle.Fill;
                rt.BackColor = Color.Black;
                rt.ForeColor = Color.Cyan;
                rt.Multiline = true;
                rt.Font = new Font(this.Font.FontFamily, this.FontHeight + 2, FontStyle.Regular);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Null Pages are not allowed", "Null page is not accepted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                frmSimpleTextEditior fste = new frmSimpleTextEditior();
                fste.ShowDialog();
            }
        }

        private void tsopen_Click(object sender, EventArgs e)
        {
            Stream myStream;
            RichTextBox rtb = new RichTextBox();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = ofd.OpenFile()) != null)
                {
                    string Filename = ofd.FileName;
                    string text = File.ReadAllText(Filename);
                    GetOpenRichTextBox().Text = text;
                    tabDisplay.SelectedTab.Text = Path.GetFileName(ofd.FileName);
                }
            }
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(tabDisplay.SelectedTab.Text))
                {
                    StreamWriter sw = new StreamWriter(tabDisplay.SelectedTab.Text);
                    sw.Write(tabDisplay.SelectedTab.Text);
                    sw.Close();
                }
                else
                {
                    Save.Title = "Save File Page...";
                    Save.ShowDialog();
                    string filename;
                    filename = Save.FileName;
                    StreamWriter SaveAs = new StreamWriter(filename);
                    SaveAs.Write(tabDisplay.SelectedTab.Text);
                    SaveAs.Close();
                    tabDisplay.SelectedTab.Text = filename;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Do not leave with the empty path. Please choose at least a path", "Save Error for Empty Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void tscut_Click(object sender, EventArgs e)
        {
            GetOpenRichTextBox().Cut();
            rtbShow.Cut();
        }

        private void tscopy_Click(object sender, EventArgs e)
        {
            GetOpenRichTextBox().Copy();
            rtbShow.Copy();
        }

        private void tspaste_Click(object sender, EventArgs e)
        {
            GetOpenRichTextBox().Paste();
            rtbShow.Paste(); 
        }

        private void tsfontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                rtbShow.Font = new Font(cboFontStyle.Font.FontFamily, float.Parse(tsfontsize.SelectedItem.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
