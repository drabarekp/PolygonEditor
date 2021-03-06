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
        // Presentation - stores the state of the simulation, info about shapes' position etc.
        public Presentation Presentation { get; set; }
        // painter - responsible for painting graphic images
        private PresentationPainter painter;
        // manager - takes care of mouse actions, passes them to special manager objects
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
            e.Graphics.DrawImage(bitmap, new Point(0, 0));
        }

        private void buttonAddPolygon_Click(object sender, EventArgs e)
        {
            manager.AddPolygonButtonClicked();
        }

        private void mainPicture_MouseClick_1(object sender, MouseEventArgs e) { }

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

        private void buttonRemoveVertex_Click(object sender, EventArgs e)
        {
            manager.RemoveVertexButtonClicked();
        }

        private void buttonChangeCircleRadius_Click(object sender, EventArgs e)
        {
            manager.ChangeRadiusClicked();
        }

        private void moveShapebutton_Click(object sender, EventArgs e)
        {
            manager.MoveShapeButtonClicked();
        }

        private void buttonRelSetEdgeLength_Click(object sender, EventArgs e)
        {
            manager.SetEdgeLegthClicked();
        }

        private void buttonEndSpecial_Click(object sender, EventArgs e)
        {
            manager.EndSpecialAction();
        }

        private void buttonSetCircleRadius_Click(object sender, EventArgs e)
        {
            manager.SetCircleRadiusClicked();
        }

        private void buttonSet2EdgesLen_Click(object sender, EventArgs e)
        {
            manager.SetEqalsLengthsClicked();
        }

        private void buttonRelEdgeParallelToCircle_Click(object sender, EventArgs e)
        {
            manager.TangencyRelationClicked();
        }

        private void buttonSetCircleCenter_Click(object sender, EventArgs e)
        {
            manager.SetCircleCenterClicked();
        }

        private void buttonParallelRel_Click(object sender, EventArgs e)
        {
            manager.ParallelRelationClicked();
        }

        private void buttonRemoveRelation_Click(object sender, EventArgs e)
        {
            manager.RemoveRelationClicked();
        }
    }
}
