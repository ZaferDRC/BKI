using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel2_2
{
    internal class VisibleS
    {
        public void ShowControl(Control lbl1, Control lbl2, Control lbl3, Control lbl4 , PictureBox picture1,PictureBox picture2,PictureBox picture3, PictureBox picture4)
        {
            lbl1.Visible     = true;
            lbl2.Visible     = true;
            lbl3.Visible     = true;
            lbl4.Visible     = true;
            picture1.Visible = true;
            picture2.Visible = true;
            picture3.Visible = true;
            picture4.Visible = true;
        }

        public void HideControl(Control lbl1, Control lbl2, Control lbl3, Control lbl4, PictureBox picture1, PictureBox picture2, PictureBox picture3, PictureBox picture4)
        {
            lbl1.Visible     = false;
            lbl2.Visible     = false;
            lbl3.Visible     = false;
            lbl4.Visible     = false;
            picture1.Visible = false;
            picture2.Visible = false;
            picture3.Visible = false;
            picture4.Visible = false;
        }

        public void HideThePicture(PictureBox picture1, PictureBox picture2, PictureBox picture3, PictureBox picture4)
        {
            picture1.Visible = false;
            picture2.Visible = false;
            picture3.Visible = false;
            picture4.Visible = false;
        }

        public void ShowControlOnePicture(Control lbl1,Control lbl2, Control lbl3, Control lbl4, PictureBox picture1)
        {
            lbl1.Visible     = true;
            lbl2.Visible     = true;
            lbl3.Visible     = true;
            lbl4.Visible     = true;
            picture1.Visible = true;
        }
    }
}
