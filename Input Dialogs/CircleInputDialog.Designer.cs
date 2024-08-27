namespace cadStart
{
    partial class CircleInputDialog
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
            this.lblCenterX = new System.Windows.Forms.Label();
            this.lblCenterY = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCenterX
            // 
            this.txtCenterX.Location = new System.Drawing.Point(120, 20);
            this.txtCenterX.Name = "txtCenterX";
            this.txtCenterX.Size = new System.Drawing.Size(100, 22);
            this.txtCenterX.TabIndex = 0;
            this.txtCenterX.TextChanged += new System.EventHandler(this.txtCenterX_TextChanged);
            // 
            // txtCenterY
            // 
            this.txtCenterY.Location = new System.Drawing.Point(120, 60);
            this.txtCenterY.Name = "txtCenterY";
            this.txtCenterY.Size = new System.Drawing.Size(100, 22);
            this.txtCenterY.TabIndex = 1;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(120, 100);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 2;
            // 
            // lblCenterX
            // 
            this.lblCenterX.AutoSize = true;
            this.lblCenterX.Location = new System.Drawing.Point(30, 20);
            this.lblCenterX.Name = "lblCenterX";
            this.lblCenterX.Size = new System.Drawing.Size(60, 16);
            this.lblCenterX.TabIndex = 3;
            this.lblCenterX.Text = "Center X:";
            // 
            // lblCenterY
            // 
            this.lblCenterY.AutoSize = true;
            this.lblCenterY.Location = new System.Drawing.Point(30, 60);
            this.lblCenterY.Name = "lblCenterY";
            this.lblCenterY.Size = new System.Drawing.Size(61, 16);
            this.lblCenterY.TabIndex = 4;
            this.lblCenterY.Text = "Center Y:";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(30, 100);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(53, 16);
            this.lblRadius.TabIndex = 5;
            this.lblRadius.Text = "Radius:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(30, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(145, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CircleInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 203);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.lblCenterY);
            this.Controls.Add(this.lblCenterX);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.txtCenterY);
            this.Controls.Add(this.txtCenterX);
            this.Name = "CircleInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Circle Input";
            this.Load += new System.EventHandler(this.CircleInputDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtCenterX;
        private System.Windows.Forms.TextBox txtCenterY;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblCenterX;
        private System.Windows.Forms.Label lblCenterY;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}