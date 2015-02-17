namespace Lab_13___GUI_Menu_Test
{
   partial class frmMain
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
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.timesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.courierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.comicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
         this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
         this.lblTodaysDate = new System.Windows.Forms.Label();
         this.lblDueDate = new System.Windows.Forms.Label();
         this.txtTodaysDate = new System.Windows.Forms.TextBox();
         this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusDummy = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
         this.menuStrip1.SuspendLayout();
         this.statusStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(368, 24);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
         this.aboutToolStripMenuItem.Text = "About";
         this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
         this.exitToolStripMenuItem.Text = "Exit";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
         // 
         // formatToolStripMenuItem
         // 
         this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesNewRomanToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.toolStripMenuItem1});
         this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
         this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
         this.formatToolStripMenuItem.Text = "Format";
         // 
         // timesNewRomanToolStripMenuItem
         // 
         this.timesNewRomanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem});
         this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
         this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.timesNewRomanToolStripMenuItem.Text = "Color";
         // 
         // blackToolStripMenuItem
         // 
         this.blackToolStripMenuItem.Checked = true;
         this.blackToolStripMenuItem.CheckOnClick = true;
         this.blackToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
         this.blackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.blackToolStripMenuItem.Text = "Black";
         this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
         // 
         // blueToolStripMenuItem
         // 
         this.blueToolStripMenuItem.CheckOnClick = true;
         this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
         this.blueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.blueToolStripMenuItem.Text = "Blue";
         this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
         // 
         // redToolStripMenuItem
         // 
         this.redToolStripMenuItem.CheckOnClick = true;
         this.redToolStripMenuItem.Name = "redToolStripMenuItem";
         this.redToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.redToolStripMenuItem.Text = "Red";
         this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
         // 
         // greenToolStripMenuItem
         // 
         this.greenToolStripMenuItem.CheckOnClick = true;
         this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
         this.greenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.greenToolStripMenuItem.Text = "Green";
         this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
         // 
         // fontToolStripMenuItem
         // 
         this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesToolStripMenuItem,
            this.courierToolStripMenuItem,
            this.comicToolStripMenuItem,
            this.toolStripMenuItem2,
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem});
         this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
         this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.fontToolStripMenuItem.Text = "Font";
         this.fontToolStripMenuItem.Click += new System.EventHandler(this.courierToolStripMenuItem_Click);
         // 
         // timesToolStripMenuItem
         // 
         this.timesToolStripMenuItem.Checked = true;
         this.timesToolStripMenuItem.CheckOnClick = true;
         this.timesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         this.timesToolStripMenuItem.Name = "timesToolStripMenuItem";
         this.timesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
         this.timesToolStripMenuItem.Text = "Times New Roman";
         this.timesToolStripMenuItem.Click += new System.EventHandler(this.timesToolStripMenuItem_Click);
         // 
         // courierToolStripMenuItem
         // 
         this.courierToolStripMenuItem.CheckOnClick = true;
         this.courierToolStripMenuItem.Name = "courierToolStripMenuItem";
         this.courierToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
         this.courierToolStripMenuItem.Text = "Courier";
         this.courierToolStripMenuItem.Click += new System.EventHandler(this.courierToolStripMenuItem_Click);
         // 
         // comicToolStripMenuItem
         // 
         this.comicToolStripMenuItem.CheckOnClick = true;
         this.comicToolStripMenuItem.Name = "comicToolStripMenuItem";
         this.comicToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
         this.comicToolStripMenuItem.Text = "Comic Sans";
         this.comicToolStripMenuItem.Click += new System.EventHandler(this.comicToolStripMenuItem_Click);
         // 
         // toolStripMenuItem2
         // 
         this.toolStripMenuItem2.Name = "toolStripMenuItem2";
         this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 6);
         // 
         // boldToolStripMenuItem
         // 
         this.boldToolStripMenuItem.CheckOnClick = true;
         this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
         this.boldToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
         this.boldToolStripMenuItem.Text = "Bold";
         this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
         // 
         // italicToolStripMenuItem
         // 
         this.italicToolStripMenuItem.CheckOnClick = true;
         this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
         this.italicToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
         this.italicToolStripMenuItem.Text = "Italic";
         this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
         // 
         // toolStripMenuItem1
         // 
         this.toolStripMenuItem1.Name = "toolStripMenuItem1";
         this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
         // 
         // lblTodaysDate
         // 
         this.lblTodaysDate.AutoSize = true;
         this.lblTodaysDate.Location = new System.Drawing.Point(12, 44);
         this.lblTodaysDate.Name = "lblTodaysDate";
         this.lblTodaysDate.Size = new System.Drawing.Size(73, 13);
         this.lblTodaysDate.TabIndex = 1;
         this.lblTodaysDate.Text = "Today\'s Date:";
         // 
         // lblDueDate
         // 
         this.lblDueDate.AutoSize = true;
         this.lblDueDate.Location = new System.Drawing.Point(29, 74);
         this.lblDueDate.Name = "lblDueDate";
         this.lblDueDate.Size = new System.Drawing.Size(56, 13);
         this.lblDueDate.TabIndex = 2;
         this.lblDueDate.Text = "Due Date:";
         // 
         // txtTodaysDate
         // 
         this.txtTodaysDate.Location = new System.Drawing.Point(112, 40);
         this.txtTodaysDate.Name = "txtTodaysDate";
         this.txtTodaysDate.Size = new System.Drawing.Size(200, 20);
         this.txtTodaysDate.TabIndex = 3;
         // 
         // dtpDueDate
         // 
         this.dtpDueDate.Location = new System.Drawing.Point(112, 74);
         this.dtpDueDate.Name = "dtpDueDate";
         this.dtpDueDate.Size = new System.Drawing.Size(200, 20);
         this.dtpDueDate.TabIndex = 4;
         this.dtpDueDate.ValueChanged += new System.EventHandler(this.dtpDueDate_ValueChanged);
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusDummy,
            this.toolStripStatusLabel2});
         this.statusStrip1.Location = new System.Drawing.Point(0, 163);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(368, 26);
         this.statusStrip1.TabIndex = 5;
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 21);
         this.toolStripStatusLabel1.Text = "Current";
         // 
         // toolStripStatusDummy
         // 
         this.toolStripStatusDummy.Name = "toolStripStatusDummy";
         this.toolStripStatusDummy.Size = new System.Drawing.Size(266, 21);
         this.toolStripStatusDummy.Spring = true;
         // 
         // toolStripStatusLabel2
         // 
         this.toolStripStatusLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
         this.toolStripStatusLabel2.Size = new System.Drawing.Size(40, 21);
         this.toolStripStatusLabel2.Text = "Due";
         // 
         // frmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(368, 189);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.dtpDueDate);
         this.Controls.Add(this.txtTodaysDate);
         this.Controls.Add(this.lblDueDate);
         this.Controls.Add(this.lblTodaysDate);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "frmMain";
         this.Text = "Menu Test";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
      private System.Windows.Forms.Label lblTodaysDate;
      private System.Windows.Forms.Label lblDueDate;
      private System.Windows.Forms.TextBox txtTodaysDate;
      private System.Windows.Forms.DateTimePicker dtpDueDate;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDummy;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
      private System.Windows.Forms.ToolStripMenuItem timesToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem courierToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem comicToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
      private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
   }
}

