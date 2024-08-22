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
            this.select.Location = new System.Drawing.Point(832, 12);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(68, 27);
            this.select.TabIndex = 2;
            this.select.Text = "select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // cadMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 814);
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
    }
}

