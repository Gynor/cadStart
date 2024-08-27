namespace cadStart
{
    partial class cadMain
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
            this.components = new System.ComponentModel.Container();
            this.line = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.select = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.ManualLine = new System.Windows.Forms.Button();
            this.ManualCircle = new System.Windows.Forms.Button();
            this.ManualArc = new System.Windows.Forms.Button();
            this.ManualPoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(12, 12);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(68, 27);
            this.line.TabIndex = 0;
            this.line.Text = "line";
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(12, 45);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(68, 27);
            this.point.TabIndex = 1;
            this.point.Text = "point";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 0;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 0;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // select
            // 
            this.select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.select.Location = new System.Drawing.Point(832, 12);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(68, 27);
            this.select.TabIndex = 2;
            this.select.Text = "select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // circle
            // 
            this.circle.Location = new System.Drawing.Point(12, 78);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(68, 27);
            this.circle.TabIndex = 3;
            this.circle.Text = "circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // ManualLine
            // 
            this.ManualLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManualLine.Location = new System.Drawing.Point(832, 45);
            this.ManualLine.Name = "ManualLine";
            this.ManualLine.Size = new System.Drawing.Size(68, 27);
            this.ManualLine.TabIndex = 4;
            this.ManualLine.Text = "Line XY";
            this.ManualLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManualLine.UseVisualStyleBackColor = true;
            this.ManualLine.Click += new System.EventHandler(this.ManualLine_Click);
            // 
            // ManualCircle
            // 
            this.ManualCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManualCircle.Location = new System.Drawing.Point(832, 78);
            this.ManualCircle.Name = "ManualCircle";
            this.ManualCircle.Size = new System.Drawing.Size(68, 27);
            this.ManualCircle.TabIndex = 4;
            this.ManualCircle.Text = "Circle R";
            this.ManualCircle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManualCircle.UseVisualStyleBackColor = true;
            this.ManualCircle.Click += new System.EventHandler(this.ManualCircle_Click);
            // 
            // ManualArc
            // 
            this.ManualArc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManualArc.Location = new System.Drawing.Point(832, 111);
            this.ManualArc.Name = "ManualArc";
            this.ManualArc.Size = new System.Drawing.Size(68, 27);
            this.ManualArc.TabIndex = 5;
            this.ManualArc.Text = "Arc";
            this.ManualArc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManualArc.UseVisualStyleBackColor = true;
            this.ManualArc.Click += new System.EventHandler(this.ManualArc_Click);
            // 
            // ManualPoint
            // 
            this.ManualPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManualPoint.Location = new System.Drawing.Point(832, 144);
            this.ManualPoint.Name = "ManualPoint";
            this.ManualPoint.Size = new System.Drawing.Size(68, 27);
            this.ManualPoint.TabIndex = 6;
            this.ManualPoint.Text = "Point XY";
            this.ManualPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManualPoint.UseVisualStyleBackColor = true;
            this.ManualPoint.Click += new System.EventHandler(this.ManualPoint_Click);
            // 
            // cadMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 814);
            this.Controls.Add(this.ManualPoint);
            this.Controls.Add(this.ManualArc);
            this.Controls.Add(this.ManualCircle);
            this.Controls.Add(this.ManualLine);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.select);
            this.Controls.Add(this.point);
            this.Controls.Add(this.line);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cadMain";
            this.Text = "cadMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button point;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button ManualLine;
        private System.Windows.Forms.Button ManualCircle;
        private System.Windows.Forms.Button ManualArc;
        private System.Windows.Forms.Button ManualPoint;
    }
}

