namespace Painter
{
   partial class PainterForm
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
         this.pnlCanvas = new System.Windows.Forms.Panel();
         this.grpColor = new System.Windows.Forms.GroupBox();
         this.rbtBlack = new System.Windows.Forms.RadioButton();
         this.rbtRed = new System.Windows.Forms.RadioButton();
         this.rbtBlue = new System.Windows.Forms.RadioButton();
         this.rbtGreen = new System.Windows.Forms.RadioButton();
         this.grpSize = new System.Windows.Forms.GroupBox();
         this.rbtSmall = new System.Windows.Forms.RadioButton();
         this.rbtMedium = new System.Windows.Forms.RadioButton();
         this.rbtLarge = new System.Windows.Forms.RadioButton();
         this.grpColor.SuspendLayout();
         this.grpSize.SuspendLayout();
         this.SuspendLayout();
         // 
         // pnlCanvas
         // 
         this.pnlCanvas.BackColor = System.Drawing.Color.White;
         this.pnlCanvas.Location = new System.Drawing.Point(128, 12);
         this.pnlCanvas.Name = "pnlCanvas";
         this.pnlCanvas.Size = new System.Drawing.Size(241, 278);
         this.pnlCanvas.TabIndex = 0;
         this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown);
         this.pnlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseMove);
         this.pnlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseUp);
         // 
         // grpColor
         // 
         this.grpColor.Controls.Add(this.rbtBlack);
         this.grpColor.Controls.Add(this.rbtRed);
         this.grpColor.Controls.Add(this.rbtBlue);
         this.grpColor.Controls.Add(this.rbtGreen);
         this.grpColor.Location = new System.Drawing.Point(12, 12);
         this.grpColor.Name = "grpColor";
         this.grpColor.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.grpColor.Size = new System.Drawing.Size(92, 127);
         this.grpColor.TabIndex = 0;
         this.grpColor.TabStop = false;
         this.grpColor.Text = "Color";
         // 
         // rbtBlack
         // 
         this.rbtBlack.AutoSize = true;
         this.rbtBlack.Location = new System.Drawing.Point(18, 100);
         this.rbtBlack.Name = "rbtBlack";
         this.rbtBlack.Size = new System.Drawing.Size(53, 19);
         this.rbtBlack.TabIndex = 3;
         this.rbtBlack.TabStop = true;
         this.rbtBlack.Text = "Black";
         this.rbtBlack.UseVisualStyleBackColor = true;
         this.rbtBlack.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
         // 
         // rbtRed
         // 
         this.rbtRed.AutoSize = true;
         this.rbtRed.Checked = true;
         this.rbtRed.Location = new System.Drawing.Point(18, 24);
         this.rbtRed.Name = "rbtRed";
         this.rbtRed.Size = new System.Drawing.Size(45, 19);
         this.rbtRed.TabIndex = 0;
         this.rbtRed.TabStop = true;
         this.rbtRed.Text = "Red";
         this.rbtRed.UseVisualStyleBackColor = true;
         this.rbtRed.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
         // 
         // rbtBlue
         // 
         this.rbtBlue.AutoSize = true;
         this.rbtBlue.Location = new System.Drawing.Point(18, 49);
         this.rbtBlue.Name = "rbtBlue";
         this.rbtBlue.Size = new System.Drawing.Size(48, 19);
         this.rbtBlue.TabIndex = 1;
         this.rbtBlue.TabStop = true;
         this.rbtBlue.Text = "Blue";
         this.rbtBlue.UseVisualStyleBackColor = true;
         this.rbtBlue.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
         // 
         // rbtGreen
         // 
         this.rbtGreen.AutoSize = true;
         this.rbtGreen.Location = new System.Drawing.Point(18, 74);
         this.rbtGreen.Name = "rbtGreen";
         this.rbtGreen.Size = new System.Drawing.Size(56, 19);
         this.rbtGreen.TabIndex = 2;
         this.rbtGreen.TabStop = true;
         this.rbtGreen.Text = "Green";
         this.rbtGreen.UseVisualStyleBackColor = true;
         this.rbtGreen.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
         // 
         // grpSize
         // 
         this.grpSize.Controls.Add(this.rbtSmall);
         this.grpSize.Controls.Add(this.rbtMedium);
         this.grpSize.Controls.Add(this.rbtLarge);
         this.grpSize.Location = new System.Drawing.Point(12, 149);
         this.grpSize.Name = "grpSize";
         this.grpSize.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.grpSize.Size = new System.Drawing.Size(92, 115);
         this.grpSize.TabIndex = 4;
         this.grpSize.TabStop = false;
         this.grpSize.Text = "Size";
         // 
         // rbtSmall
         // 
         this.rbtSmall.AutoSize = true;
         this.rbtSmall.Checked = true;
         this.rbtSmall.Location = new System.Drawing.Point(18, 24);
         this.rbtSmall.Name = "rbtSmall";
         this.rbtSmall.Size = new System.Drawing.Size(54, 19);
         this.rbtSmall.TabIndex = 0;
         this.rbtSmall.TabStop = true;
         this.rbtSmall.Text = "Small";
         this.rbtSmall.UseVisualStyleBackColor = true;
         this.rbtSmall.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
         // 
         // rbtMedium
         // 
         this.rbtMedium.AutoSize = true;
         this.rbtMedium.Location = new System.Drawing.Point(18, 49);
         this.rbtMedium.Name = "rbtMedium";
         this.rbtMedium.Size = new System.Drawing.Size(73, 19);
         this.rbtMedium.TabIndex = 1;
         this.rbtMedium.TabStop = true;
         this.rbtMedium.Text = " Medium";
         this.rbtMedium.UseVisualStyleBackColor = true;
         this.rbtMedium.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
         // 
         // rbtLarge
         // 
         this.rbtLarge.AutoSize = true;
         this.rbtLarge.Location = new System.Drawing.Point(18, 74);
         this.rbtLarge.Name = "rbtLarge";
         this.rbtLarge.Size = new System.Drawing.Size(54, 19);
         this.rbtLarge.TabIndex = 2;
         this.rbtLarge.TabStop = true;
         this.rbtLarge.Text = "Large";
         this.rbtLarge.UseVisualStyleBackColor = true;
         this.rbtLarge.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
         // 
         // PainterForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(381, 302);
         this.Controls.Add(this.grpSize);
         this.Controls.Add(this.grpColor);
         this.Controls.Add(this.pnlCanvas);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "PainterForm";
         this.Text = "Painter";
         this.grpColor.ResumeLayout(false);
         this.grpColor.PerformLayout();
         this.grpSize.ResumeLayout(false);
         this.grpSize.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel pnlCanvas;
      private System.Windows.Forms.GroupBox grpColor;
      private System.Windows.Forms.RadioButton rbtBlack;
      private System.Windows.Forms.RadioButton rbtRed;
      private System.Windows.Forms.RadioButton rbtBlue;
      private System.Windows.Forms.RadioButton rbtGreen;
      private System.Windows.Forms.GroupBox grpSize;
      private System.Windows.Forms.RadioButton rbtSmall;
      private System.Windows.Forms.RadioButton rbtMedium;
      private System.Windows.Forms.RadioButton rbtLarge;
   }
}

