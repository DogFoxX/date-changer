
namespace date_changer
{
    partial class OverWriteForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.titlePnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.titlePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(0, 6);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(83, 15);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Date Changer";
            // 
            // titlePnl
            // 
            this.titlePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.titlePnl.Controls.Add(this.titleLbl);
            this.titlePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePnl.Location = new System.Drawing.Point(0, 0);
            this.titlePnl.Name = "titlePnl";
            this.titlePnl.Size = new System.Drawing.Size(320, 28);
            this.titlePnl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirm overwrite?";
            // 
            // yesBtn
            // 
            this.yesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.yesBtn.FlatAppearance.BorderSize = 0;
            this.yesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.yesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.yesBtn.ForeColor = System.Drawing.Color.White;
            this.yesBtn.Location = new System.Drawing.Point(132, 95);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(85, 25);
            this.yesBtn.TabIndex = 15;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.noBtn.FlatAppearance.BorderSize = 0;
            this.noBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.noBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.noBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.noBtn.ForeColor = System.Drawing.Color.White;
            this.noBtn.Location = new System.Drawing.Point(223, 95);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(85, 25);
            this.noBtn.TabIndex = 16;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // OverWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(320, 132);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titlePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OverWriteForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OverWriteForm";
            this.titlePnl.ResumeLayout(false);
            this.titlePnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel titlePnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
    }
}