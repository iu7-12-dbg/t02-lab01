namespace Lab1
{
    partial class MainForm
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
            this.edtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtComp = new System.Windows.Forms.TextBox();
            this.btnDist = new System.Windows.Forms.Button();
            this.edtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходная строка";
            // 
            // edtSource
            // 
            this.edtSource.Location = new System.Drawing.Point(135, 7);
            this.edtSource.Name = "edtSource";
            this.edtSource.Size = new System.Drawing.Size(215, 20);
            this.edtSource.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сравниваемая строка";
            // 
            // edtComp
            // 
            this.edtComp.Location = new System.Drawing.Point(135, 33);
            this.edtComp.Name = "edtComp";
            this.edtComp.Size = new System.Drawing.Size(215, 20);
            this.edtComp.TabIndex = 3;
            // 
            // btnDist
            // 
            this.btnDist.Location = new System.Drawing.Point(12, 71);
            this.btnDist.Name = "btnDist";
            this.btnDist.Size = new System.Drawing.Size(126, 23);
            this.btnDist.TabIndex = 4;
            this.btnDist.Text = "Найти расстояние";
            this.btnDist.UseVisualStyleBackColor = true;
            this.btnDist.Click += new System.EventHandler(this.btnDist_Click);
            // 
            // edtResult
            // 
            this.edtResult.BackColor = System.Drawing.SystemColors.Window;
            this.edtResult.Location = new System.Drawing.Point(159, 71);
            this.edtResult.Name = "edtResult";
            this.edtResult.ReadOnly = true;
            this.edtResult.Size = new System.Drawing.Size(191, 20);
            this.edtResult.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 108);
            this.Controls.Add(this.edtResult);
            this.Controls.Add(this.btnDist);
            this.Controls.Add(this.edtComp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtSource);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расстояние Левенштейна";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtComp;
        private System.Windows.Forms.Button btnDist;
        private System.Windows.Forms.TextBox edtResult;
    }
}

