using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
         string[] states = { "Select state",
                             "Connecticut", "Idaho",  "Kentucky", "Iowa", "Maine", "Maryland",
                             "Massachusetts", "Michigan", "New Hampshire", "New Jersey", "New York", "Oregon",
                             "Pennsylvania", "Rhode Island", "Vermont", "Wisconsin", "Wyoming"};
         statesComboBox.Items.AddRange(states);

         statesComboBox.SelectedIndex = 0;
      }



      private void statesComboBox_SelectionChangeCommitted(object sender, EventArgs e)
      {
         if (statesComboBox.SelectedIndex != 0)
         {
            //Remove item from combox and add to listbox
            string state = (string)statesComboBox.SelectedItem;
            statesComboBox.Items.Remove(state);
            statesListBox.Items.Add(state);
            statesListBox.SelectedItem = state;
            statesComboBox.SelectedIndex = 0;

            SelectState(state);

            if (statesComboBox.Items.Count == 1) 
            {
               MessageBox.Show("There are no more states in the ComboBox.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
      }

      private void SortStatesComboBox()
      {
         int numItems = statesComboBox.Items.Count;

         if (numItems > 1)
         //there is more than one state in the combobox
         {
            //extract the states into an array,
            //discarding the "Select state" entry
            string[] comboItems = new string[numItems - 1];

            string state;
            for (int i = 1; i < numItems; i++)
            {
               state = (string)statesComboBox.Items[i];
               comboItems[i - 1] = state;
            
            }
            //sort
            Array.Sort(comboItems);

            //put back into collection
            string[] firstItem = { "Select state" };
            comboItems = firstItem.Concat(comboItems).ToArray();
            statesComboBox.Items.Clear();
            statesComboBox.Items.AddRange(comboItems);
         }
      }

      //displays a state's information
      private void SelectState(string state)
      {
         if (state != null)
         //there is a state to display
         {
            //Retrieve image from resources and create a new bitmap
            //scaled from its size
            Image img = (Image)Properties.Resources.ResourceManager.GetObject(state.Replace(" ", "_"));
            const int NEW_WIDTH = 128;
            double heightScaleFactor = (double)NEW_WIDTH / img.Width;
            int newHeight = (int)(heightScaleFactor * img.Height);
            Bitmap newImage = new Bitmap(NEW_WIDTH, newHeight);

            //copy image to the new bitmap
            Graphics.FromImage(newImage).DrawImage(img, 0, 0, NEW_WIDTH, newHeight);
            pictureBox1.Image = newImage;

            //set the label
            displayStateLabel.Text = state;
         }
         else
         {
            displayStateLabel.Text = String.Empty;
            pictureBox1.Image = null;
            
         }
      }

      private void statesListBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         SelectState((string)statesListBox.SelectedItem);
      }

      private void putItBackToolStripMenuItem_Click(object sender, EventArgs e)
      {

         //remove selected item from ListBox and put it in ComboBox
         string state = (string)statesListBox.SelectedItem;
         statesListBox.Items.Remove(state);
         statesComboBox.Items.Add(state);
         SortStatesComboBox();

         statesComboBox.SelectedIndex = 0;

         //clear the label and picturebox
         pictureBox1.Image = null;


      }

      // http://stackoverflow.com/questions/376910/how-can-i-add-a-context-menu-to-a-listboxitem
      private void statesListBox_MouseUp(object sender, MouseEventArgs e)
      {
         //get the index of the listbox item that was clicked
         int index = statesListBox.IndexFromPoint(e.Location);

         statesListBox.ContextMenuStrip.Visible = false;

         if (
            // this was a right click
            e.Button == System.Windows.Forms.MouseButtons.Right &&

            //and an item in the listbox was actually clicked   
            index != ListBox.NoMatches &&

            //and the selected item was the one that was clicked
            statesListBox.SelectedIndex == index)

            //display the context menu
            statesListBox.ContextMenuStrip.Visible = true;
      }

      private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (statesListBox.SelectedIndex >= 0) 
         {
            statesListBox.Items.RemoveAt(statesListBox.SelectedIndex);
         }
      }

   }
}
