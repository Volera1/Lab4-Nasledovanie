
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Refull = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CountOf = new System.Windows.Forms.Label();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.Ochered = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Refull
            // 
            this.Refull.Location = new System.Drawing.Point(12, 12);
            this.Refull.Name = "Refull";
            this.Refull.Size = new System.Drawing.Size(412, 29);
            this.Refull.TabIndex = 0;
            this.Refull.Text = "Перезаполнить";
            this.Refull.UseVisualStyleBackColor = true;
            this.Refull.Click += new System.EventHandler(this.Refull_Click);
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(232, 187);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(192, 159);
            this.GetButton.TabIndex = 4;
            this.GetButton.Text = "Взять";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
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
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(232, 63);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(192, 107);
            this.txtOut.TabIndex = 10;
            this.txtOut.Text = "";
            // 
            // Ochered
            // 
            this.Ochered.Location = new System.Drawing.Point(24, 176);
            this.Ochered.Name = "Ochered";
            this.Ochered.Size = new System.Drawing.Size(181, 170);
            this.Ochered.TabIndex = 11;
            this.Ochered.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Список очереди:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ochered);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.CountOf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.Refull);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Avtomat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Refull;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CountOf;
        private System.Windows.Forms.RichTextBox txtOut;
        private System.Windows.Forms.RichTextBox Ochered;
        private System.Windows.Forms.Label label2;
    }
}

