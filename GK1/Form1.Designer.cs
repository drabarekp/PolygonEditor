
namespace GK1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.buttonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.moveShapebutton = new System.Windows.Forms.Button();
            this.buttonChangeCircleRadius = new System.Windows.Forms.Button();
            this.buttonRemoveVertex = new System.Windows.Forms.Button();
            this.buttonAddMiddleVertex = new System.Windows.Forms.Button();
            this.buttonAddCircle = new System.Windows.Forms.Button();
            this.buttonAddPolygon = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonRemoveRelation = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonParallelRel = new System.Windows.Forms.Button();
            this.buttonRelEdgeParallelToCircle = new System.Windows.Forms.Button();
            this.buttonSet2EdgesLen = new System.Windows.Forms.Button();
            this.buttonRelSetEdgeLength = new System.Windows.Forms.Button();
            this.buttonSetCircleRadius = new System.Windows.Forms.Button();
            this.buttonSetCircleCenter = new System.Windows.Forms.Button();
            this.buttonEndSpecial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            this.buttonsLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPicture
            // 
            this.mainPicture.Location = new System.Drawing.Point(0, 0);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(1000, 1000);
            this.mainPicture.TabIndex = 0;
            this.mainPicture.TabStop = false;
            this.mainPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPicture_Paint);
            this.mainPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPicture_MouseClick_1);
            this.mainPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPicture_MouseDown);
            this.mainPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPicture_MouseMove);
            this.mainPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPicture_MouseUp);
            // 
            // buttonsLayoutPanel
            // 
            this.buttonsLayoutPanel.ColumnCount = 2;
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsLayoutPanel.Controls.Add(this.moveShapebutton, 1, 2);
            this.buttonsLayoutPanel.Controls.Add(this.buttonChangeCircleRadius, 0, 2);
            this.buttonsLayoutPanel.Controls.Add(this.buttonRemoveVertex, 1, 1);
            this.buttonsLayoutPanel.Controls.Add(this.buttonAddMiddleVertex, 0, 1);
            this.buttonsLayoutPanel.Controls.Add(this.buttonAddCircle, 0, 0);
            this.buttonsLayoutPanel.Controls.Add(this.buttonAddPolygon, 0, 0);
            this.buttonsLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.buttonsLayoutPanel.Location = new System.Drawing.Point(1020, 39);
            this.buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            this.buttonsLayoutPanel.RowCount = 3;
            this.buttonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsLayoutPanel.Size = new System.Drawing.Size(250, 269);
            this.buttonsLayoutPanel.TabIndex = 1;
            // 
            // moveShapebutton
            // 
            this.moveShapebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveShapebutton.Location = new System.Drawing.Point(145, 198);
            this.moveShapebutton.Margin = new System.Windows.Forms.Padding(20);
            this.moveShapebutton.Name = "moveShapebutton";
            this.moveShapebutton.Size = new System.Drawing.Size(85, 51);
            this.moveShapebutton.TabIndex = 5;
            this.moveShapebutton.Text = "Move Shape";
            this.moveShapebutton.UseVisualStyleBackColor = true;
            this.moveShapebutton.Click += new System.EventHandler(this.moveShapebutton_Click);
            // 
            // buttonChangeCircleRadius
            // 
            this.buttonChangeCircleRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonChangeCircleRadius.Location = new System.Drawing.Point(20, 198);
            this.buttonChangeCircleRadius.Margin = new System.Windows.Forms.Padding(20);
            this.buttonChangeCircleRadius.Name = "buttonChangeCircleRadius";
            this.buttonChangeCircleRadius.Size = new System.Drawing.Size(85, 51);
            this.buttonChangeCircleRadius.TabIndex = 4;
            this.buttonChangeCircleRadius.Text = "Change Radius";
            this.buttonChangeCircleRadius.UseVisualStyleBackColor = true;
            this.buttonChangeCircleRadius.Click += new System.EventHandler(this.buttonChangeCircleRadius_Click);
            // 
            // buttonRemoveVertex
            // 
            this.buttonRemoveVertex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveVertex.Location = new System.Drawing.Point(145, 109);
            this.buttonRemoveVertex.Margin = new System.Windows.Forms.Padding(20);
            this.buttonRemoveVertex.Name = "buttonRemoveVertex";
            this.buttonRemoveVertex.Size = new System.Drawing.Size(85, 49);
            this.buttonRemoveVertex.TabIndex = 3;
            this.buttonRemoveVertex.Text = "Remove Vertex";
            this.buttonRemoveVertex.UseVisualStyleBackColor = true;
            this.buttonRemoveVertex.Click += new System.EventHandler(this.buttonRemoveVertex_Click);
            // 
            // buttonAddMiddleVertex
            // 
            this.buttonAddMiddleVertex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddMiddleVertex.Location = new System.Drawing.Point(20, 109);
            this.buttonAddMiddleVertex.Margin = new System.Windows.Forms.Padding(20);
            this.buttonAddMiddleVertex.Name = "buttonAddMiddleVertex";
            this.buttonAddMiddleVertex.Size = new System.Drawing.Size(85, 49);
            this.buttonAddMiddleVertex.TabIndex = 2;
            this.buttonAddMiddleVertex.Text = "Add Middle Vertex";
            this.buttonAddMiddleVertex.UseVisualStyleBackColor = true;
            this.buttonAddMiddleVertex.Click += new System.EventHandler(this.buttonAddMiddleVertex_Click);
            // 
            // buttonAddCircle
            // 
            this.buttonAddCircle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddCircle.Location = new System.Drawing.Point(20, 20);
            this.buttonAddCircle.Margin = new System.Windows.Forms.Padding(20);
            this.buttonAddCircle.Name = "buttonAddCircle";
            this.buttonAddCircle.Size = new System.Drawing.Size(85, 49);
            this.buttonAddCircle.TabIndex = 1;
            this.buttonAddCircle.Text = "Add Circle";
            this.buttonAddCircle.UseVisualStyleBackColor = true;
            this.buttonAddCircle.Click += new System.EventHandler(this.buttonAddCircle_Click);
            // 
            // buttonAddPolygon
            // 
            this.buttonAddPolygon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddPolygon.Location = new System.Drawing.Point(145, 20);
            this.buttonAddPolygon.Margin = new System.Windows.Forms.Padding(20);
            this.buttonAddPolygon.Name = "buttonAddPolygon";
            this.buttonAddPolygon.Size = new System.Drawing.Size(85, 49);
            this.buttonAddPolygon.TabIndex = 0;
            this.buttonAddPolygon.Text = "Add Polygon";
            this.buttonAddPolygon.UseVisualStyleBackColor = true;
            this.buttonAddPolygon.Click += new System.EventHandler(this.buttonAddPolygon_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(145, 113);
            this.button2.Margin = new System.Windows.Forms.Padding(20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1282, 1053);
            this.button3.TabIndex = 2;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveRelation
            // 
            this.buttonRemoveRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveRelation.Location = new System.Drawing.Point(188, 293);
            this.buttonRemoveRelation.Margin = new System.Windows.Forms.Padding(20);
            this.buttonRemoveRelation.Name = "buttonRemoveRelation";
            this.buttonRemoveRelation.Size = new System.Drawing.Size(128, 52);
            this.buttonRemoveRelation.TabIndex = 0;
            this.buttonRemoveRelation.Text = "Remove Relation";
            this.buttonRemoveRelation.UseVisualStyleBackColor = true;
            this.buttonRemoveRelation.Click += new System.EventHandler(this.buttonRemoveRelation_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonParallelRel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonRelEdgeParallelToCircle, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonSet2EdgesLen, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonRelSetEdgeLength, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSetCircleRadius, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonRemoveRelation, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonSetCircleCenter, 0, 2);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1020, 484);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 365);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // buttonParallelRel
            // 
            this.buttonParallelRel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonParallelRel.Location = new System.Drawing.Point(188, 202);
            this.buttonParallelRel.Margin = new System.Windows.Forms.Padding(20);
            this.buttonParallelRel.Name = "buttonParallelRel";
            this.buttonParallelRel.Size = new System.Drawing.Size(128, 51);
            this.buttonParallelRel.TabIndex = 5;
            this.buttonParallelRel.Text = "Add Parallel Relation";
            this.buttonParallelRel.UseVisualStyleBackColor = true;
            this.buttonParallelRel.Click += new System.EventHandler(this.buttonParallelRel_Click);
            // 
            // buttonRelEdgeParallelToCircle
            // 
            this.buttonRelEdgeParallelToCircle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRelEdgeParallelToCircle.Location = new System.Drawing.Point(188, 111);
            this.buttonRelEdgeParallelToCircle.Margin = new System.Windows.Forms.Padding(20);
            this.buttonRelEdgeParallelToCircle.Name = "buttonRelEdgeParallelToCircle";
            this.buttonRelEdgeParallelToCircle.Size = new System.Drawing.Size(128, 51);
            this.buttonRelEdgeParallelToCircle.TabIndex = 3;
            this.buttonRelEdgeParallelToCircle.Text = "Add Tangency Relation";
            this.buttonRelEdgeParallelToCircle.UseVisualStyleBackColor = true;
            this.buttonRelEdgeParallelToCircle.Click += new System.EventHandler(this.buttonRelEdgeParallelToCircle_Click);
            // 
            // buttonSet2EdgesLen
            // 
            this.buttonSet2EdgesLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSet2EdgesLen.Location = new System.Drawing.Point(20, 111);
            this.buttonSet2EdgesLen.Margin = new System.Windows.Forms.Padding(20);
            this.buttonSet2EdgesLen.Name = "buttonSet2EdgesLen";
            this.buttonSet2EdgesLen.Size = new System.Drawing.Size(128, 51);
            this.buttonSet2EdgesLen.TabIndex = 2;
            this.buttonSet2EdgesLen.Text = "Add Equal Lengths Relation";
            this.buttonSet2EdgesLen.UseVisualStyleBackColor = true;
            this.buttonSet2EdgesLen.Click += new System.EventHandler(this.buttonSet2EdgesLen_Click);
            // 
            // buttonRelSetEdgeLength
            // 
            this.buttonRelSetEdgeLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRelSetEdgeLength.Location = new System.Drawing.Point(188, 20);
            this.buttonRelSetEdgeLength.Margin = new System.Windows.Forms.Padding(20);
            this.buttonRelSetEdgeLength.Name = "buttonRelSetEdgeLength";
            this.buttonRelSetEdgeLength.Size = new System.Drawing.Size(128, 51);
            this.buttonRelSetEdgeLength.TabIndex = 1;
            this.buttonRelSetEdgeLength.Text = "Add Constant Length Relation";
            this.buttonRelSetEdgeLength.UseVisualStyleBackColor = true;
            this.buttonRelSetEdgeLength.Click += new System.EventHandler(this.buttonRelSetEdgeLength_Click);
            // 
            // buttonSetCircleRadius
            // 
            this.buttonSetCircleRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetCircleRadius.Location = new System.Drawing.Point(20, 20);
            this.buttonSetCircleRadius.Margin = new System.Windows.Forms.Padding(20);
            this.buttonSetCircleRadius.Name = "buttonSetCircleRadius";
            this.buttonSetCircleRadius.Size = new System.Drawing.Size(128, 51);
            this.buttonSetCircleRadius.TabIndex = 0;
            this.buttonSetCircleRadius.Text = "Add Set Circle Radius Relation";
            this.buttonSetCircleRadius.UseVisualStyleBackColor = true;
            this.buttonSetCircleRadius.Click += new System.EventHandler(this.buttonSetCircleRadius_Click);
            // 
            // buttonSetCircleCenter
            // 
            this.buttonSetCircleCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetCircleCenter.Location = new System.Drawing.Point(20, 202);
            this.buttonSetCircleCenter.Margin = new System.Windows.Forms.Padding(20);
            this.buttonSetCircleCenter.Name = "buttonSetCircleCenter";
            this.buttonSetCircleCenter.Size = new System.Drawing.Size(128, 51);
            this.buttonSetCircleCenter.TabIndex = 4;
            this.buttonSetCircleCenter.Text = "Add Fixed Center Relation";
            this.buttonSetCircleCenter.UseVisualStyleBackColor = true;
            this.buttonSetCircleCenter.Click += new System.EventHandler(this.buttonSetCircleCenter_Click);
            // 
            // buttonEndSpecial
            // 
            this.buttonEndSpecial.Location = new System.Drawing.Point(1040, 345);
            this.buttonEndSpecial.Name = "buttonEndSpecial";
            this.buttonEndSpecial.Size = new System.Drawing.Size(210, 29);
            this.buttonEndSpecial.TabIndex = 4;
            this.buttonEndSpecial.Text = "End Special Action";
            this.buttonEndSpecial.UseVisualStyleBackColor = true;
            this.buttonEndSpecial.Click += new System.EventHandler(this.buttonEndSpecial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 1053);
            this.Controls.Add(this.buttonEndSpecial);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.buttonsLayoutPanel);
            this.Controls.Add(this.mainPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            this.buttonsLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPicture;
        private System.Windows.Forms.TableLayoutPanel buttonsLayoutPanel;
        private System.Windows.Forms.Button moveShapebutton;
        private System.Windows.Forms.Button buttonChangeCircleRadius;
        private System.Windows.Forms.Button buttonRemoveVertex;
        private System.Windows.Forms.Button buttonAddMiddleVertex;
        private System.Windows.Forms.Button buttonAddCircle;
        private System.Windows.Forms.Button buttonAddPolygon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonRemoveRelation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonRelEdgeParallelToCircle;
        private System.Windows.Forms.Button buttonSet2EdgesLen;
        private System.Windows.Forms.Button buttonRelSetEdgeLength;
        private System.Windows.Forms.Button buttonSetCircleRadius;
        private System.Windows.Forms.Button buttonEndSpecial;
        private System.Windows.Forms.Button buttonSetCircleCenter;
        private System.Windows.Forms.Button buttonParallelRel;
    }
}

