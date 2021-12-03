
namespace Lab4_Nasledovanie
{
    partial class Form1
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
            this.Refull = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountOf = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Refull
            // 
            this.Refull.Location = new System.Drawing.Point(33, 12);
            this.Refull.Name = "Refull";
            this.Refull.Size = new System.Drawing.Size(413, 29);
            this.Refull.TabIndex = 0;
            this.Refull.Text = "Перезаполнить";
            this.Refull.UseVisualStyleBackColor = true;
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(267, 152);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(157, 207);
            this.GetButton.TabIndex = 4;
            this.GetButton.Text = "Взять";
            this.GetButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(33, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 207);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "Деревьев:\r\nКустов:\r\nЦветов:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CountOf
            // 
            this.CountOf.AutoSize = true;
            this.CountOf.Location = new System.Drawing.Point(119, 63);
            this.CountOf.Name = "CountOf";
            this.CountOf.Size = new System.Drawing.Size(17, 60);
            this.CountOf.TabIndex = 9;
            this.CountOf.Text = "0\r\n0\r\n0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(359, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(125, 120);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 388);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CountOf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.Refull);
            this.Name = "Form1";
            this.Text = "Avtomat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Refull;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CountOf;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

