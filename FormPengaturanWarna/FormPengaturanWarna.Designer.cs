
namespace FormPengaturanWarna
{
    partial class FormPengaturanWarna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelInputData = new System.Windows.Forms.Label();
            this.TextBoxInputData = new System.Windows.Forms.TextBox();
            this.ButtonProses = new System.Windows.Forms.Button();
            this.LabelHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelInputData
            // 
            this.LabelInputData.AutoSize = true;
            this.LabelInputData.Location = new System.Drawing.Point(25, 22);
            this.LabelInputData.Name = "LabelInputData";
            this.LabelInputData.Size = new System.Drawing.Size(86, 20);
            this.LabelInputData.TabIndex = 0;
            this.LabelInputData.Text = "Input Data :";
            // 
            // TextBoxInputData
            // 
            this.TextBoxInputData.Location = new System.Drawing.Point(25, 54);
            this.TextBoxInputData.Name = "TextBoxInputData";
            this.TextBoxInputData.Size = new System.Drawing.Size(501, 27);
            this.TextBoxInputData.TabIndex = 1;
            // 
            // ButtonProses
            // 
            this.ButtonProses.Location = new System.Drawing.Point(25, 101);
            this.ButtonProses.Name = "ButtonProses";
            this.ButtonProses.Size = new System.Drawing.Size(94, 29);
            this.ButtonProses.TabIndex = 2;
            this.ButtonProses.Text = "Proses";
            this.ButtonProses.UseVisualStyleBackColor = true;
            this.ButtonProses.Click += new System.EventHandler(this.ButtonProses_Click);
            // 
            // LabelHasil
            // 
            this.LabelHasil.AutoSize = true;
            this.LabelHasil.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelHasil.Location = new System.Drawing.Point(18, 157);
            this.LabelHasil.Name = "LabelHasil";
            this.LabelHasil.Size = new System.Drawing.Size(145, 46);
            this.LabelHasil.TabIndex = 3;
            this.LabelHasil.Text = "[EMPTY]";
            // 
            // FormPengaturanWarna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 276);
            this.Controls.Add(this.LabelHasil);
            this.Controls.Add(this.ButtonProses);
            this.Controls.Add(this.TextBoxInputData);
            this.Controls.Add(this.LabelInputData);
            this.Name = "FormPengaturanWarna";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelInputData;
        private System.Windows.Forms.TextBox TextBoxInputData;
        private System.Windows.Forms.Button ButtonProses;
        private System.Windows.Forms.Label LabelHasil;
    }
}

