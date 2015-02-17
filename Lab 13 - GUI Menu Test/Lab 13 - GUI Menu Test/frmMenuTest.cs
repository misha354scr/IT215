using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab_13___GUI_Menu_Test
{
   public partial class frmMain : Form
   {
      private const string DT_FORMAT = "MM/dd/yyyy h:mm tt"; //the date-time format

      public frmMain()
      {
         InitializeComponent();
         toolStripStatusDummy.Alignment = ToolStripItemAlignment.Right;

         //Set the current date-time
         toolStripStatusLabel1.Text = DateTime.Now.ToString(DT_FORMAT);
         txtTodaysDate.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");

         //set the due date
         toolStripStatusLabel2.Text = DateTime.Now.ToString(DT_FORMAT);
         this.Refresh();
      }

      private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Menu Example\nAuthor: Mike Zhukovskiy\n\u00a9 2015", "About",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      private void exitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void dtpDueDate_ValueChanged(object sender, EventArgs e)
      {
         txtTodaysDate.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");
         toolStripStatusLabel1.Text = DateTime.Now.ToString(DT_FORMAT);
         toolStripStatusLabel2.Text = dtpDueDate.Value.ToString(DT_FORMAT);
      }


      // reset checkmarks for Color ToolStripMenuItems
      private void ClearColor()
      {
         // clear all checkmarks
         Debug.WriteLine("ClearColor called");
         blackToolStripMenuItem.Checked = false;
         blueToolStripMenuItem.Checked = false;
         redToolStripMenuItem.Checked = false;
         greenToolStripMenuItem.Checked = false;
      } // end method ClearColor

      // update Menu state and color display black
      private void blackToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // reset checkmarks for Color ToolStripMenuItems
         ClearColor();

         // set color to Black
         toolStripStatusLabel2.ForeColor = Color.Black;
         blackToolStripMenuItem.Checked = true;
      } // end method blackToolStripMenuItem_Click

      // update Menu state and color display blue
      private void blueToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // reset checkmarks for Color ToolStripMenuItems
         ClearColor();

         // set color to Blue
         toolStripStatusLabel2.ForeColor = Color.Blue;
         blueToolStripMenuItem.Checked = true;
      } // end method blueToolStripMenuItem_Click

      // update Menu state and color display red
      private void redToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // reset checkmarks for Color ToolStripMenuItems
         ClearColor();

         // set color to Red
         toolStripStatusLabel2.ForeColor = Color.Red;
         redToolStripMenuItem.Checked = true;
      } // end method redToolStripMenuItem_Click

      // update Menu state and color display green
      private void greenToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // reset checkmarks for Color ToolStripMenuItems
         ClearColor();

         // set color to Green
         toolStripStatusLabel2.ForeColor = Color.Green;
         greenToolStripMenuItem.Checked = true;
      }

      // reset checkmarks for Font ToolStripMenuItems
      private void ClearFont()
      {
         // clear all checkmarks
         timesToolStripMenuItem.Checked = false;
         courierToolStripMenuItem.Checked = false;
         comicToolStripMenuItem.Checked = false;
      } // end method ClearFont

      // update Menu state and set Font to Times New Roman
      private void timesToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // reset checkmarks for Font ToolStripMenuItems
         ClearFont();

         // set Times New Roman font
         timesToolStripMenuItem.Checked = true;
         toolStripStatusLabel2.Font = new Font("Times New Roman", 14,
            toolStripStatusLabel2.Font.Style);
      } // end method timesToolStripMenuItem_Click

      // update Menu state and set Font to Courier
      private void courierToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // reset checkmarks for Font ToolStripMenuItems
         ClearFont();

         // set Courier font
         courierToolStripMenuItem.Checked = true;
         toolStripStatusLabel2.Font = new Font("Courier", 14,
            toolStripStatusLabel2.Font.Style);
      } // end method courierToolStripMenuItem_Click

      // update Menu state and set Font to Comic Sans MS
      private void comicToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // reset checkmarks for Font ToolStripMenuItems
         ClearFont();

         // set Comic Sans font
         comicToolStripMenuItem.Checked = true;
         toolStripStatusLabel2.Font = new Font("Comic Sans MS", 14,
            toolStripStatusLabel2.Font.Style);
      } // end method comicToolStripMenuItem_Click

      // toggle checkmark and toggle bold style
      private void boldToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // use Xor to toggle bold, keep all other styles
         toolStripStatusLabel2.Font = new Font(toolStripStatusLabel2.Font,
            toolStripStatusLabel2.Font.Style ^ FontStyle.Bold);
      } // end method boldToolStripMenuItem_Click

      // toggle checkmark and toggle italic style
      private void italicToolStripMenuItem_Click(
         object sender, EventArgs e)
      {

         // use Xor to toggle italic, keep all other styles
         toolStripStatusLabel2.Font = new Font(toolStripStatusLabel2.Font,
            toolStripStatusLabel2.Font.Style ^ FontStyle.Italic);
      } // end method italicToolStripMenuItem_Click

   }
}
