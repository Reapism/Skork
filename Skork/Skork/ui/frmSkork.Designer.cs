namespace Skork
{
    partial class frmSkork
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
            this.grpCode = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.picSyntax = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.grpCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSyntax)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCode
            // 
            this.grpCode.Controls.Add(this.richTextBox1);
            this.grpCode.Controls.Add(this.picSyntax);
            this.grpCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpCode.Location = new System.Drawing.Point(0, 25);
            this.grpCode.Name = "grpCode";
            this.grpCode.Size = new System.Drawing.Size(327, 414);
            this.grpCode.TabIndex = 1;
            this.grpCode.TabStop = false;
            this.grpCode.Text = "groupBox1";
            // 
            // grpOutput
            // 
            this.grpOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpOutput.Location = new System.Drawing.Point(367, 25);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(367, 414);
            this.grpOutput.TabIndex = 2;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "groupBox2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(734, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // picSyntax
            // 
            this.picSyntax.BackColor = System.Drawing.Color.Red;
            this.picSyntax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSyntax.Location = new System.Drawing.Point(3, 16);
            this.picSyntax.Name = "picSyntax";
            this.picSyntax.Size = new System.Drawing.Size(321, 395);
            this.picSyntax.TabIndex = 0;
            this.picSyntax.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(244, 364);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // frmSkork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpCode);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmSkork";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSkork_Load);
            this.grpCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSyntax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.GroupBox grpCode;
        internal System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox picSyntax;
    }
}

