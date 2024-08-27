namespace cadStart
{
    partial class LineInputDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartX = new System.Windows.Forms.TextBox();
            this.StartY = new System.Windows.Forms.TextBox();
            this.EndX = new System.Windows.Forms.TextBox();
            this.EndY = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Point X-Y";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Point X-Y";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StartX
            // 
            this.StartX.Location = new System.Drawing.Point(12, 28);
            this.StartX.Name = "StartX";
            this.StartX.Size = new System.Drawing.Size(100, 22);
            this.StartX.TabIndex = 2;
            this.StartX.TextChanged += new System.EventHandler(this.StartX_TextChanged);
            // 
            // StartY
            // 
            this.StartY.Location = new System.Drawing.Point(118, 28);
            this.StartY.Name = "StartY";
            this.StartY.Size = new System.Drawing.Size(100, 22);
            this.StartY.TabIndex = 3;
            // 
            // EndX
            // 
            this.EndX.Location = new System.Drawing.Point(257, 28);
            this.EndX.Name = "EndX";
            this.EndX.Size = new System.Drawing.Size(100, 22);
            this.EndX.TabIndex = 4;
            // 
            // EndY
            // 
            this.EndY.Location = new System.Drawing.Point(363, 28);
            this.EndY.Name = "EndY";
            this.EndY.Size = new System.Drawing.Size(100, 22);
            this.EndY.TabIndex = 5;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(12, 59);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(93, 59);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // LineInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 94);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.EndY);
            this.Controls.Add(this.EndX);
            this.Controls.Add(this.StartY);
            this.Controls.Add(this.StartX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LineInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Line Input";
            this.Load += new System.EventHandler(this.LineInputDialog_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StartX;
        private System.Windows.Forms.TextBox StartY;
        private System.Windows.Forms.TextBox EndX;
        private System.Windows.Forms.TextBox EndY;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cancel;
    }
}