namespace MultiReader.Application
{
    partial class Reader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lbpath = new System.Windows.Forms.Label();
            this.tbFileContent = new System.Windows.Forms.RichTextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.tbDateOfPublication = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameLabel2 = new System.Windows.Forms.Label();
            this.fileFormatLabel = new System.Windows.Forms.Label();
            this.fileFormatLabel2 = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.fileSizeLabel2 = new System.Windows.Forms.Label();
            this.creationTimeLabel = new System.Windows.Forms.Label();
            this.lastAccessTimeLabel = new System.Windows.Forms.Label();
            this.lastWriteTimeLabel = new System.Windows.Forms.Label();
            this.lastTimeWriteLabel2 = new System.Windows.Forms.Label();
            this.lastAccessTimeLabel2 = new System.Windows.Forms.Label();
            this.creationTimeLabel2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Metadata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbChecksum = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // tbFileContent
            // 
            this.tbFileContent.Location = new System.Drawing.Point(15, 27);
            this.tbFileContent.Name = "tbFileContent";
            this.tbFileContent.Size = new System.Drawing.Size(511, 574);
            this.tbFileContent.TabIndex = 2;
            this.tbFileContent.Text = "";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(533, 28);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 3;
            this.authorLabel.Text = "Author:";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(536, 42);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(201, 20);
            this.tbAuthor.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(533, 65);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Title:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(536, 81);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(201, 20);
            this.tbTitle.TabIndex = 6;
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(536, 120);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(201, 20);
            this.tbPublisher.TabIndex = 7;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(533, 104);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(50, 13);
            this.publisherLabel.TabIndex = 8;
            this.publisherLabel.Text = "Publisher";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(533, 143);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(69, 13);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Date of pub.:";
            // 
            // tbDateOfPublication
            // 
            this.tbDateOfPublication.Location = new System.Drawing.Point(536, 159);
            this.tbDateOfPublication.Name = "tbDateOfPublication";
            this.tbDateOfPublication.Size = new System.Drawing.Size(201, 20);
            this.tbDateOfPublication.TabIndex = 10;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(533, 182);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(49, 13);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "Book ID:";
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(536, 198);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(201, 20);
            this.tbBookID.TabIndex = 12;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileNameLabel.Location = new System.Drawing.Point(743, 28);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(65, 13);
            this.fileNameLabel.TabIndex = 13;
            this.fileNameLabel.Text = "File name:";
            // 
            // fileNameLabel2
            // 
            this.fileNameLabel2.AutoSize = true;
            this.fileNameLabel2.Location = new System.Drawing.Point(743, 44);
            this.fileNameLabel2.Name = "fileNameLabel2";
            this.fileNameLabel2.Size = new System.Drawing.Size(0, 13);
            this.fileNameLabel2.TabIndex = 14;
            // 
            // fileFormatLabel
            // 
            this.fileFormatLabel.AutoSize = true;
            this.fileFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileFormatLabel.Location = new System.Drawing.Point(743, 65);
            this.fileFormatLabel.Name = "fileFormatLabel";
            this.fileFormatLabel.Size = new System.Drawing.Size(70, 13);
            this.fileFormatLabel.TabIndex = 15;
            this.fileFormatLabel.Text = "File format:";
            // 
            // fileFormatLabel2
            // 
            this.fileFormatLabel2.AutoSize = true;
            this.fileFormatLabel2.Location = new System.Drawing.Point(743, 81);
            this.fileFormatLabel2.Name = "fileFormatLabel2";
            this.fileFormatLabel2.Size = new System.Drawing.Size(0, 13);
            this.fileFormatLabel2.TabIndex = 16;
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileSizeLabel.Location = new System.Drawing.Point(743, 104);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(77, 13);
            this.fileSizeLabel.TabIndex = 17;
            this.fileSizeLabel.Text = "File size [B]:";
            // 
            // fileSizeLabel2
            // 
            this.fileSizeLabel2.AutoSize = true;
            this.fileSizeLabel2.Location = new System.Drawing.Point(743, 120);
            this.fileSizeLabel2.Name = "fileSizeLabel2";
            this.fileSizeLabel2.Size = new System.Drawing.Size(0, 13);
            this.fileSizeLabel2.TabIndex = 18;
            // 
            // creationTimeLabel
            // 
            this.creationTimeLabel.AutoSize = true;
            this.creationTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.creationTimeLabel.Location = new System.Drawing.Point(743, 143);
            this.creationTimeLabel.Name = "creationTimeLabel";
            this.creationTimeLabel.Size = new System.Drawing.Size(85, 13);
            this.creationTimeLabel.TabIndex = 19;
            this.creationTimeLabel.Text = "Creation time:";
            // 
            // creationTimeLabel2
            // 
            this.creationTimeLabel2.AutoSize = true;
            this.creationTimeLabel2.Location = new System.Drawing.Point(743, 159);
            this.creationTimeLabel2.Name = "creationTimeLabel2";
            this.creationTimeLabel2.Size = new System.Drawing.Size(0, 13);
            this.creationTimeLabel2.TabIndex = 20;
            // 
            // lastAccessTimeLabel
            // 
            this.lastAccessTimeLabel.AutoSize = true;
            this.lastAccessTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastAccessTimeLabel.Location = new System.Drawing.Point(743, 182);
            this.lastAccessTimeLabel.Name = "lastAccessTimeLabel";
            this.lastAccessTimeLabel.Size = new System.Drawing.Size(79, 13);
            this.lastAccessTimeLabel.TabIndex = 21;
            this.lastAccessTimeLabel.Text = "Last access:";
            // 
            // lastAccessTimeLabel2
            // 
            this.lastAccessTimeLabel2.AutoSize = true;
            this.lastAccessTimeLabel2.Location = new System.Drawing.Point(743, 198);
            this.lastAccessTimeLabel2.Name = "lastAccessTimeLabel2";
            this.lastAccessTimeLabel2.Size = new System.Drawing.Size(0, 13);
            this.lastAccessTimeLabel2.TabIndex = 22;
            // 
            // lastWriteTimeLabel
            // 
            this.lastWriteTimeLabel.AutoSize = true;
            this.lastWriteTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastWriteTimeLabel.Location = new System.Drawing.Point(743, 221);
            this.lastWriteTimeLabel.Name = "lastWriteTimeLabel";
            this.lastWriteTimeLabel.Size = new System.Drawing.Size(66, 13);
            this.lastWriteTimeLabel.TabIndex = 23;
            this.lastWriteTimeLabel.Text = "Last write:";
            // 
            // lastTimeWriteLabel2
            // 
            this.lastTimeWriteLabel2.AutoSize = true;
            this.lastTimeWriteLabel2.Location = new System.Drawing.Point(743, 237);
            this.lastTimeWriteLabel2.Name = "lastTimeWriteLabel2";
            this.lastTimeWriteLabel2.Size = new System.Drawing.Size(0, 13);
            this.lastTimeWriteLabel2.TabIndex = 24;
            // 
            // label2 checksum
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(533, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "File checksum:";
            // 
            // lbChecksum
            // 
            this.lbChecksum.AutoSize = true;
            this.lbChecksum.Location = new System.Drawing.Point(533, 237);
            this.lbChecksum.Name = "lbChecksum";
            this.lbChecksum.Size = new System.Drawing.Size(0, 13);
            this.lbChecksum.TabIndex = 26;
            // 
            // label1 path
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(533, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "File path:";
            // 
            // label1 path
            // 
            this.lbpath.AutoSize = true;
            this.lbpath.Location = new System.Drawing.Point(533, 269);
            this.lbpath.Name = "lbpath";
            this.lbpath.Size = new System.Drawing.Size(0, 13);
            this.lbpath.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Metadata,
            this.Data});
            this.dataGridView1.Location = new System.Drawing.Point(533, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(564, 316);
            this.dataGridView1.TabIndex = 29;
            // 
            // Metadata
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Metadata.DefaultCellStyle = dataGridViewCellStyle1;
            this.Metadata.HeaderText = "Metadata";
            this.Metadata.Name = "Metadata";
            this.Metadata.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Metadata.Width = 180;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.Width = 370;
            // 
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 613);
            this.Controls.Add(this.lbChecksum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.creationTimeLabel2);
            this.Controls.Add(this.lastAccessTimeLabel2);
            this.Controls.Add(this.lastTimeWriteLabel2);
            this.Controls.Add(this.lastWriteTimeLabel);
            this.Controls.Add(this.lastAccessTimeLabel);
            this.Controls.Add(this.creationTimeLabel);
            this.Controls.Add(this.fileSizeLabel2);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.fileFormatLabel2);
            this.Controls.Add(this.fileFormatLabel);
            this.Controls.Add(this.fileNameLabel2);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.tbBookID);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.tbDateOfPublication);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.tbFileContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbpath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reader";
            this.Text = "MultiReader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.RichTextBox tbFileContent;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox tbDateOfPublication;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileNameLabel2;
        private System.Windows.Forms.Label fileFormatLabel;
        private System.Windows.Forms.Label fileFormatLabel2;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.Label fileSizeLabel2;
        private System.Windows.Forms.Label creationTimeLabel;
        private System.Windows.Forms.Label lastAccessTimeLabel;
        private System.Windows.Forms.Label lastWriteTimeLabel;
        private System.Windows.Forms.Label lastTimeWriteLabel2;
        private System.Windows.Forms.Label lastAccessTimeLabel2;
        private System.Windows.Forms.Label creationTimeLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metadata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbChecksum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbpath;
    }
}
