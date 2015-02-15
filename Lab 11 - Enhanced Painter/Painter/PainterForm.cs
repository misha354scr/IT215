// Fig 14.38: PainterForm.cs
// Using the mouse to draw on a Form.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Painter
{
   // creates a Form that is a drawing surface
   public partial class PainterForm : Form
   {
      bool shouldPaint = false; // determines whether to paint
      Color color = Color.Red; //the color being drawn

      //the size of the circles being drawn
      private enum Size { Small = 2, Medium = 4, Large = 6 };
      private Size size = Size.Small;

      // default constructor
      public PainterForm()
      {
         InitializeComponent();
      } // end constructor



      private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
      {
         // indicate that user released the mouse button
         shouldPaint = false;
      }

      private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
      {
         // indicate that user is dragging the mouse
         shouldPaint = true;
      }

      private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
      {
         if (shouldPaint) // check if mouse button is being pressed
         {
            // draw a circle where the mouse pointer is present
            using (Graphics graphics = pnlCanvas.CreateGraphics())
            {
               graphics.FillEllipse(
                  new SolidBrush(color), e.X, e.Y, (int)size, (int)size);
            } // end using; calls graphics.Dispose()
         } // end if
      }

      private void rbt_CheckedChanged(object sender, EventArgs e)
      {
         //Pick color
         if (sender == rbtRed) 
         {
            color = Color.Red;
         }
         
         if (sender == rbtBlue) 
         {
            color = Color.Blue;
         }
         
         if (sender == rbtGreen) 
         {
            color = Color.Green;
         }

         if (sender == rbtBlack)
         {
            color = Color.Black;
         }


         //Pick size
         if (sender == rbtSmall)
         {
            size = Size.Small;
         }

         if (sender == rbtMedium) 
         {
            size = Size.Medium;
         }

         if (sender == rbtLarge) 
         {
            size = Size.Large;
         }
      }
   } // end class PainterForm
} // end namespace Painter

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/