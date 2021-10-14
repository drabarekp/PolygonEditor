using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK1
{
    public partial class Form1 : Form
    {
        public Presentation Presentation { get; set; }
        private PresentationPainter painter;
        private PresentationManager manager;
        
        
        public Form1()
        {
            InitializeComponent();
            Presentation = new Presentation("test");
            painter = new PresentationPainter();
            manager = new PresentationManager(Presentation);
        }

        private void mainPicture_Paint(object sender, PaintEventArgs e)
        {
            
            var bitmap = new Bitmap(Presentation.Size.X, Presentation.Size.Y);
            var graphics = Graphics.FromImage(bitmap);
            painter.DrawPresentation(Presentation, graphics, bitmap);
            //...
            e.Graphics.DrawImage(bitmap, new Point(0, 0));
        }

        private void buttonAddPolygon_Click(object sender, EventArgs e)
        {
            manager.AddPolygonButtonClicked();
        }

        private void mainPicture_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void mainPicture_MouseDown(object sender, MouseEventArgs e)
        {
            manager.Clicked(e.X, e.Y);
            mainPicture.Refresh();
        }

        private void mainPicture_MouseUp(object sender, MouseEventArgs e)
        {
            manager.MouseUp();
        }

        private void mainPicture_MouseMove(object sender, MouseEventArgs e)
        {
            manager.MouseMove(e.X, e.Y);
            mainPicture.Refresh();
        }

        private void buttonAddCircle_Click(object sender, EventArgs e)
        {
            manager.AddCircleButtonClicked();
        }

        private void buttonAddMiddleVertex_Click(object sender, EventArgs e)
        {
            manager.AddMiddleVertexPointClicked();
        }
    }
}
