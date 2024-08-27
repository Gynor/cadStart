namespace cadStart
{
    partial class ArcInputDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCenterX = new System.Windows.Forms.TextBox();
            this.txtCenterY = new System.Windows.Forms.TextBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtStartAngle = new System.Windows.Forms.TextBox();
            this.txtSweepAngle = new System.Windows.Forms.TextBox();
            this.lblCenterX = new System.Windows.Forms.Label();
            this.lblCenterY = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblStartAngle = new System.Windows.Forms.Label();
            this.lblSweepAngle = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCenterX
            // 
            this.txtCenterX.Location = new System.Drawing.Point(126, 20);
            this.txtCenterX.Name = "txtCenterX";
            this.txtCenterX.Size = new System.Drawing.Size(100, 22);
            this.txtCenterX.TabIndex = 0;
            // 
            // txtCenterY
            // 
            this.txtCenterY.Location = new System.Drawing.Point(126, 60);
            this.txtCenterY.Name = "txtCenterY";
            this.txtCenterY.Size = new System.Drawing.Size(100, 22);
            this.txtCenterY.TabIndex = 1;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(126, 100);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 2;
            // 
            // txtStartAngle
            // 
            this.txtStartAngle.Location = new System.Drawing.Point(126, 140);
            this.txtStartAngle.Name = "txtStartAngle";
            this.txtStartAngle.Size = new System.Drawing.Size(100, 22);
            this.txtStartAngle.TabIndex = 3;
            // 
            // txtSweepAngle
            // 
            this.txtSweepAngle.Location = new System.Drawing.Point(126, 180);
            this.txtSweepAngle.Name = "txtSweepAngle";
            this.txtSweepAngle.Size = new System.Drawing.Size(100, 22);
            this.txtSweepAngle.TabIndex = 4;
            // 
            // lblCenterX
            // 
            this.lblCenterX.AutoSize = true;
            this.lblCenterX.Location = new System.Drawing.Point(30, 20);
            this.lblCenterX.Name = "lblCenterX";
            this.lblCenterX.Size = new System.Drawing.Size(60, 16);
            this.lblCenterX.TabIndex = 5;
            this.lblCenterX.Text = "Center X:";
            // 
            // lblCenterY
            // 
            this.lblCenterY.AutoSize = true;
            this.lblCenterY.Location = new System.Drawing.Point(30, 60);
            this.lblCenterY.Name = "lblCenterY";
            this.lblCenterY.Size = new System.Drawing.Size(61, 16);
            this.lblCenterY.TabIndex = 6;
            this.lblCenterY.Text = "Center Y:";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(30, 100);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(53, 16);
            this.lblRadius.TabIndex = 7;
            this.lblRadius.Text = "Radius:";
            // 
            // lblStartAngle
            // 
            this.lblStartAngle.AutoSize = true;
            this.lblStartAngle.Location = new System.Drawing.Point(30, 140);
            this.lblStartAngle.Name = "lblStartAngle";
            this.lblStartAngle.Size = new System.Drawing.Size(75, 16);
            this.lblStartAngle.TabIndex = 8;
            this.lblStartAngle.Text = "Start Angle:";
            // 
            // lblSweepAngle
            // 
            this.lblSweepAngle.AutoSize = true;
            this.lblSweepAngle.Location = new System.Drawing.Point(30, 180);
            this.lblSweepAngle.Name = "lblSweepAngle";
            this.lblSweepAngle.Size = new System.Drawing.Size(90, 16);
            this.lblSweepAngle.TabIndex = 9;
            this.lblSweepAngle.Text = "Sweep Angle:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(30, 220);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(145, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ArcInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 263);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSweepAngle);
            this.Controls.Add(this.lblStartAngle);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.lblCenterY);
            this.Controls.Add(this.lblCenterX);
            this.Controls.Add(this.txtSweepAngle);
            this.Controls.Add(this.txtStartAngle);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.txtCenterY);
            this.Controls.Add(this.txtCenterX);
            this.Name = "ArcInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Arc Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtCenterX;
        private System.Windows.Forms.TextBox txtCenterY;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtStartAngle;
        private System.Windows.Forms.TextBox txtSweepAngle;
        private System.Windows.Forms.Label lblCenterX;
        private System.Windows.Forms.Label lblCenterY;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblStartAngle;
        private System.Windows.Forms.Label lblSweepAngle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}
