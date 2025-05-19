namespace SimpleTextEditor_L4DC_124_
{
    partial class frmSimpleTextEditior
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.cFormattingCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabDisplay = new System.Windows.Forms.TabControl();
            this.Save = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.chkGenerate = new System.Windows.Forms.CheckBox();
            this.tpmenu = new System.Windows.Forms.ToolStrip();
            this.tsnew = new System.Windows.Forms.ToolStripButton();
            this.tsopen = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tscut = new System.Windows.Forms.ToolStripButton();
            this.tscopy = new System.Windows.Forms.ToolStripButton();
            this.tspaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboFontStyle = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsfontsize = new System.Windows.Forms.ToolStripComboBox();
            this.gpFindandReplace = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.tpmenu.SuspendLayout();
            this.gpFindandReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuFormat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuNew
            // 
            this.mnuNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnuNew.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources._13512;
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNew.Size = new System.Drawing.Size(146, 22);
            this.mnuNew.Text = "&New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources._25402;
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(146, 22);
            this.mnuOpen.Text = "&Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources._0_vdUY_dRmKtBvgYaM;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(146, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources.close_1_512;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources.exit_512;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(146, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUndo,
            this.mnuRedo,
            this.toolStripSeparator1,
            this.mnuCopy,
            this.mnuCut,
            this.mnuPaste,
            this.toolStripSeparator2,
            this.mnuFind});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuUndo
            // 
            this.mnuUndo.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources.action_undo_1_512;
            this.mnuUndo.Name = "mnuUndo";
            this.mnuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuUndo.Size = new System.Drawing.Size(164, 22);
            this.mnuUndo.Text = "&Undo";
            this.mnuUndo.Click += new System.EventHandler(this.mnuUndo_Click);
            // 
            // mnuRedo
            // 
            this.mnuRedo.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources.action_redo_1_512;
            this.mnuRedo.Name = "mnuRedo";
            this.mnuRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuRedo.Size = new System.Drawing.Size(164, 22);
            this.mnuRedo.Text = "&Redo";
            this.mnuRedo.Click += new System.EventHandler(this.mnuRedo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources.editor_copy_duplicate_files_512;
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuCopy.Size = new System.Drawing.Size(164, 22);
            this.mnuCopy.Text = "Co&py";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuCut
            // 
            this.mnuCut.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources.cut_512;
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuCut.Size = new System.Drawing.Size(164, 22);
            this.mnuCut.Text = "&Cut";
            this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources.GlyphIcons_Clipboard_512;
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuPaste.Size = new System.Drawing.Size(164, 22);
            this.mnuPaste.Text = "&Paste";
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuFind
            // 
            this.mnuFind.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources.find_replace_24px_131985191941577853;
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.Size = new System.Drawing.Size(164, 22);
            this.mnuFind.Text = "&Find and Replace";
            this.mnuFind.Click += new System.EventHandler(this.mnuFind_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cFormattingCodeToolStripMenuItem});
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(57, 20);
            this.mnuFormat.Text = "F&ormat";
            // 
            // cFormattingCodeToolStripMenuItem
            // 
            this.cFormattingCodeToolStripMenuItem.Name = "cFormattingCodeToolStripMenuItem";
            this.cFormattingCodeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cFormattingCodeToolStripMenuItem.Text = "C# Formatting Code";
            this.cFormattingCodeToolStripMenuItem.Click += new System.EventHandler(this.cFormattingCodeToolStripMenuItem_Click);
            // 
            // tabDisplay
            // 
            this.tabDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDisplay.Location = new System.Drawing.Point(0, 24);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.SelectedIndex = 0;
            this.tabDisplay.Size = new System.Drawing.Size(595, 471);
            this.tabDisplay.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabDisplay.TabIndex = 1;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // rtbShow
            // 
            this.rtbShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbShow.Location = new System.Drawing.Point(0, 68);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(595, 427);
            this.rtbShow.TabIndex = 2;
            this.rtbShow.Text = "";
            this.rtbShow.TextChanged += new System.EventHandler(this.rtbShow_TextChanged);
            this.rtbShow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbShow_KeyPress);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFind.Location = new System.Drawing.Point(6, 27);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(56, 13);
            this.lblFind.TabIndex = 3;
            this.lblFind.Text = "Find Word";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblReplace.Location = new System.Drawing.Point(6, 62);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(76, 13);
            this.lblReplace.TabIndex = 4;
            this.lblReplace.Text = "Replace Word";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(84, 24);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(395, 20);
            this.txtFind.TabIndex = 5;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(84, 62);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(394, 20);
            this.txtReplace.TabIndex = 6;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFind.Location = new System.Drawing.Point(489, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnReplace.Location = new System.Drawing.Point(489, 60);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 8;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // chkGenerate
            // 
            this.chkGenerate.AutoSize = true;
            this.chkGenerate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chkGenerate.Location = new System.Drawing.Point(489, 1);
            this.chkGenerate.Name = "chkGenerate";
            this.chkGenerate.Size = new System.Drawing.Size(95, 17);
            this.chkGenerate.TabIndex = 9;
            this.chkGenerate.Text = "Auto Generate";
            this.chkGenerate.UseVisualStyleBackColor = false;
            // 
            // tpmenu
            // 
            this.tpmenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tpmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsnew,
            this.tsopen,
            this.tsSave,
            this.toolStripSeparator,
            this.tscut,
            this.tscopy,
            this.tspaste,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.cboFontStyle,
            this.toolStripLabel2,
            this.tsfontsize});
            this.tpmenu.Location = new System.Drawing.Point(0, 43);
            this.tpmenu.Name = "tpmenu";
            this.tpmenu.Size = new System.Drawing.Size(595, 25);
            this.tpmenu.TabIndex = 10;
            this.tpmenu.Text = "toolStrip1";
            // 
            // tsnew
            // 
            this.tsnew.BackColor = System.Drawing.Color.White;
            this.tsnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsnew.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources._13512;
            this.tsnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsnew.Name = "tsnew";
            this.tsnew.Size = new System.Drawing.Size(23, 22);
            this.tsnew.Text = "&New";
            this.tsnew.Click += new System.EventHandler(this.tsnew_Click);
            // 
            // tsopen
            // 
            this.tsopen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tsopen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsopen.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources._25402;
            this.tsopen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsopen.Name = "tsopen";
            this.tsopen.Size = new System.Drawing.Size(23, 22);
            this.tsopen.Text = "&Open";
            this.tsopen.Click += new System.EventHandler(this.tsopen_Click);
            // 
            // tsSave
            // 
            this.tsSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSave.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources._0_vdUY_dRmKtBvgYaM;
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(23, 22);
            this.tsSave.Text = "&Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tscut
            // 
            this.tscut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tscut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tscut.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources.cut_512;
            this.tscut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscut.Name = "tscut";
            this.tscut.Size = new System.Drawing.Size(23, 22);
            this.tscut.Text = "C&ut";
            this.tscut.Click += new System.EventHandler(this.tscut_Click);
            // 
            // tscopy
            // 
            this.tscopy.BackColor = System.Drawing.Color.Magenta;
            this.tscopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tscopy.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources.editor_copy_duplicate_files_512;
            this.tscopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscopy.Name = "tscopy";
            this.tscopy.Size = new System.Drawing.Size(23, 22);
            this.tscopy.Text = "&Copy";
            this.tscopy.Click += new System.EventHandler(this.tscopy_Click);
            // 
            // tspaste
            // 
            this.tspaste.BackColor = System.Drawing.Color.Lime;
            this.tspaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspaste.Image = global::SimpleTextEditor_L4DC_124_.Properties.Resources.GlyphIcons_Clipboard_512;
            this.tspaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspaste.Name = "tspaste";
            this.tspaste.Size = new System.Drawing.Size(23, 22);
            this.tspaste.Text = "&Paste";
            this.tspaste.Click += new System.EventHandler(this.tspaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ActiveLinkColor = System.Drawing.Color.Orchid;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel1.Text = "Font Style Used";
            // 
            // cboFontStyle
            // 
            this.cboFontStyle.Name = "cboFontStyle";
            this.cboFontStyle.Size = new System.Drawing.Size(121, 25);
            this.cboFontStyle.SelectedIndexChanged += new System.EventHandler(this.cboFontStyle_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel2.Text = "Font Size Used";
            // 
            // tsfontsize
            // 
            this.tsfontsize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "24",
            "32",
            "48",
            "56",
            "64",
            "72"});
            this.tsfontsize.Name = "tsfontsize";
            this.tsfontsize.Size = new System.Drawing.Size(121, 25);
            this.tsfontsize.SelectedIndexChanged += new System.EventHandler(this.tsfontsize_SelectedIndexChanged);
            // 
            // gpFindandReplace
            // 
            this.gpFindandReplace.Controls.Add(this.lblReplace);
            this.gpFindandReplace.Controls.Add(this.lblFind);
            this.gpFindandReplace.Controls.Add(this.txtReplace);
            this.gpFindandReplace.Controls.Add(this.btnReplace);
            this.gpFindandReplace.Controls.Add(this.txtFind);
            this.gpFindandReplace.Controls.Add(this.btnFind);
            this.gpFindandReplace.Location = new System.Drawing.Point(0, 372);
            this.gpFindandReplace.Name = "gpFindandReplace";
            this.gpFindandReplace.Size = new System.Drawing.Size(614, 100);
            this.gpFindandReplace.TabIndex = 11;
            this.gpFindandReplace.TabStop = false;
            this.gpFindandReplace.Text = "Find And Replace";
            // 
            // frmSimpleTextEditior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(595, 495);
            this.Controls.Add(this.gpFindandReplace);
            this.Controls.Add(this.tpmenu);
            this.Controls.Add(this.chkGenerate);
            this.Controls.Add(this.rtbShow);
            this.Controls.Add(this.tabDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSimpleTextEditior";
            this.Text = "Simple Text Editor";
            this.Load += new System.EventHandler(this.frmSimpleTextEditior_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tpmenu.ResumeLayout(false);
            this.tpmenu.PerformLayout();
            this.gpFindandReplace.ResumeLayout(false);
            this.gpFindandReplace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
        private System.Windows.Forms.TabControl tabDisplay;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog Save;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem cFormattingCodeToolStripMenuItem;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.CheckBox chkGenerate;
        private System.Windows.Forms.ToolStrip tpmenu;
        private System.Windows.Forms.ToolStripButton tsnew;
        private System.Windows.Forms.ToolStripButton tsopen;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tscut;
        private System.Windows.Forms.ToolStripButton tscopy;
        private System.Windows.Forms.ToolStripButton tspaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboFontStyle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.GroupBox gpFindandReplace;
        private System.Windows.Forms.ToolStripComboBox tsfontsize;
    }
}

