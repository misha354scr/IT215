namespace KeyDemo
{
   partial class KeyDemo
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
         this.charLabel = new System.Windows.Forms.Label();
         this.keyInfoLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // charLabel
         // 
         this.charLabel.AutoSize = true;
         this.charLabel.Location = new System.Drawing.Point(24, 21);
         this.charLabel.Name = "charLabel";
         this.charLabel.Size = new System.Drawing.Size(69, 13);
         this.charLabel.TabIndex = 0;
         this.charLabel.Text = "Key Pressed:";
         // 
         // keyInfoLabel
         // 
         this.keyInfoLabel.AutoSize = true;
         this.keyInfoLabel.Location = new System.Drawing.Point(24, 72);
         this.keyInfoLabel.Name = "keyInfoLabel";
         this.keyInfoLabel.Size = new System.Drawing.Size(55, 78);
         this.keyInfoLabel.TabIndex = 1;
         this.keyInfoLabel.Text = "Alt:\r\nShift:\r\nCtrl:\r\nKeyCode:\r\nKeyData:\r\nKeyValue:";
         // 
         // KeyDemo
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 262);
         this.Controls.Add(this.keyInfoLabel);
         this.Controls.Add(this.charLabel);
         this.Name = "KeyDemo";
         this.Text = "Key Demo";
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDemo_KeyDown);
         this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyDemo_KeyPress);
         this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDemo_KeyUp);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label charLabel;
      private System.Windows.Forms.Label keyInfoLabel;
   }
}

