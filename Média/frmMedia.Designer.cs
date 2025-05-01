namespace Média
{
    partial class frmMedia
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
            this.numN1 = new System.Windows.Forms.NumericUpDown();
            this.numN2 = new System.Windows.Forms.NumericUpDown();
            this.numN3 = new System.Windows.Forms.NumericUpDown();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN3)).BeginInit();
            this.SuspendLayout();
            // 
            // numN1
            // 
            this.numN1.Location = new System.Drawing.Point(28, 28);
            this.numN1.Name = "numN1";
            this.numN1.Size = new System.Drawing.Size(120, 20);
            this.numN1.TabIndex = 0;
            // 
            // numN2
            // 
            this.numN2.Location = new System.Drawing.Point(28, 97);
            this.numN2.Name = "numN2";
            this.numN2.Size = new System.Drawing.Size(120, 20);
            this.numN2.TabIndex = 1;
            // 
            // numN3
            // 
            this.numN3.Location = new System.Drawing.Point(28, 155);
            this.numN3.Name = "numN3";
            this.numN3.Size = new System.Drawing.Size(120, 20);
            this.numN3.TabIndex = 2;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(148, 360);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 3;
            this.btCalcular.Text = "button1";
            this.btCalcular.UseVisualStyleBackColor = true;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(167, 279);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(35, 13);
            this.lblMedia.TabIndex = 4;
            this.lblMedia.Text = "label1";
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 502);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.numN3);
            this.Controls.Add(this.numN2);
            this.Controls.Add(this.numN1);
            this.Name = "frmMedia";
            this.Text = "Media";
            ((System.ComponentModel.ISupportInitialize)(this.numN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numN1;
        private System.Windows.Forms.NumericUpDown numN2;
        private System.Windows.Forms.NumericUpDown numN3;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lblMedia;
    }
}

