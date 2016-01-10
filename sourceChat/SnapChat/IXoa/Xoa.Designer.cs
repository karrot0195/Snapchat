namespace IXoa
{
    partial class Xoa
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
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnxoa
            // 
            this.btnxoa.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnxoa.Location = new System.Drawing.Point(236, 10);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(12, 12);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(194, 20);
            this.txtnhap.TabIndex = 2;
            // 
            // Xoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 47);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txtnhap);
            this.Name = "Xoa";
            this.Text = "Xóa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtnhap;
    }
}