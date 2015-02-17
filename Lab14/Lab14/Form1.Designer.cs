namespace Lab14
{
    partial class Form1
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
         this.statesListBox = new System.Windows.Forms.ListBox();
         this.Popmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.putItBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.statesComboBox = new System.Windows.Forms.ComboBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.displayLabel = new System.Windows.Forms.Label();
         this.displayStateLabel = new System.Windows.Forms.Label();
         this.Popmenu.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // statesListBox
         // 
         this.statesListBox.ContextMenuStrip = this.Popmenu;
         this.statesListBox.FormattingEnabled = true;
         this.statesListBox.Location = new System.Drawing.Point(26, 94);
         this.statesListBox.Name = "statesListBox";
         this.statesListBox.Size = new System.Drawing.Size(139, 147);
         this.statesListBox.TabIndex = 0;
         this.statesListBox.SelectedIndexChanged += new System.EventHandler(this.statesListBox_SelectedIndexChanged);
         this.statesListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.statesListBox_MouseUp);
         // 
         // Popmenu
         // 
         this.Popmenu.BackColor = System.Drawing.Color.Red;
         this.Popmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.putItBackToolStripMenuItem,
            this.deleteToolStripMenuItem});
         this.Popmenu.Name = "Popmenu";
         this.Popmenu.Size = new System.Drawing.Size(153, 70);
         // 
         // putItBackToolStripMenuItem
         // 
         this.putItBackToolStripMenuItem.Name = "putItBackToolStripMenuItem";
         this.putItBackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.putItBackToolStripMenuItem.Text = "Put It Back";
         this.putItBackToolStripMenuItem.Click += new System.EventHandler(this.putItBackToolStripMenuItem_Click);
         // 
         // deleteToolStripMenuItem
         // 
         this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
         this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.deleteToolStripMenuItem.Text = "Delete";
         this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
         // 
         // statesComboBox
         // 
         this.statesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.statesComboBox.FormattingEnabled = true;
         this.statesComboBox.Location = new System.Drawing.Point(26, 41);
         this.statesComboBox.Name = "statesComboBox";
         this.statesComboBox.Size = new System.Drawing.Size(139, 21);
         this.statesComboBox.TabIndex = 1;
         this.statesComboBox.SelectionChangeCommitted += new System.EventHandler(this.statesComboBox_SelectionChangeCommitted);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Location = new System.Drawing.Point(208, 80);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(128, 78);
         this.pictureBox1.TabIndex = 3;
         this.pictureBox1.TabStop = false;
         // 
         // displayLabel
         // 
         this.displayLabel.AutoSize = true;
         this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.displayLabel.Location = new System.Drawing.Point(23, 12);
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(100, 15);
         this.displayLabel.TabIndex = 4;
         this.displayLabel.Text = "Select a State:";
         // 
         // displayStateLabel
         // 
         this.displayStateLabel.AutoSize = true;
         this.displayStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.displayStateLabel.Location = new System.Drawing.Point(205, 42);
         this.displayStateLabel.Name = "displayStateLabel";
         this.displayStateLabel.Size = new System.Drawing.Size(0, 17);
         this.displayStateLabel.TabIndex = 5;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(394, 262);
         this.Controls.Add(this.displayStateLabel);
         this.Controls.Add(this.displayLabel);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.statesComboBox);
         this.Controls.Add(this.statesListBox);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Popmenu.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox statesListBox;
        private System.Windows.Forms.ComboBox statesComboBox;
        private System.Windows.Forms.ContextMenuStrip Popmenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label displayStateLabel;
        private System.Windows.Forms.ToolStripMenuItem putItBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

