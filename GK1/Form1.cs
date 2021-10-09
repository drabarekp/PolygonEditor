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
        
        public Form1()
        {
            InitializeComponent();
            painter = new PresentationPainter();
        }

        private void mainPicture_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            painter.DrawPresentation(Presentation, graphics);
        }
    }
}
