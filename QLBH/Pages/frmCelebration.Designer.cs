
namespace QLBH.Pages
{
    partial class frmCelebration
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
            this.toolBars1 = new QLBH.Resources.ToolBars();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toolBars1
            // 
            this.toolBars1.BColorT1 = System.Drawing.Color.Empty;
            this.toolBars1.BColorT2 = System.Drawing.Color.Empty;
            this.toolBars1.BColorT3 = System.Drawing.Color.Empty;
            this.toolBars1.BColorT4 = System.Drawing.Color.Empty;
            this.toolBars1.BColorT5 = System.Drawing.Color.Empty;
            this.toolBars1.EnableT1 = true;
            this.toolBars1.EnableT2 = true;
            this.toolBars1.EnableT3 = true;
            this.toolBars1.EnableT4 = true;
            this.toolBars1.EnableT5 = true;
            this.toolBars1.FColorT1 = System.Drawing.Color.Empty;
            this.toolBars1.FColorT2 = System.Drawing.Color.Empty;
            this.toolBars1.FColorT3 = System.Drawing.Color.Empty;
            this.toolBars1.FColorT4 = System.Drawing.Color.Empty;
            this.toolBars1.FColorT5 = System.Drawing.Color.Empty;
            this.toolBars1.ImageT1 = null;
            this.toolBars1.ImageT2 = null;
            this.toolBars1.ImageT3 = null;
            this.toolBars1.ImageT4 = null;
            this.toolBars1.ImageT5 = null;
            this.toolBars1.Location = new System.Drawing.Point(186, 4);
            this.toolBars1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolBars1.Name = "toolBars1";
            this.toolBars1.Size = new System.Drawing.Size(554, 56);
            this.toolBars1.TabIndex = 1;
            this.toolBars1.TextT1 = "Thêm";
            this.toolBars1.TextT2 = "Sửa";
            this.toolBars1.TextT3 = "Xoá";
            this.toolBars1.TextT4 = "In";
            this.toolBars1.TextT5 = "Xuất Excel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "TỔ CHỨC";
            // 
            // frmCelebration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1021, 714);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolBars1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCelebration";
            this.Text = "Tổ chức";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Resources.ToolBars toolBars1;
        private System.Windows.Forms.Label label1;
    }
}