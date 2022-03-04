
namespace Iskola
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
            this.btnTörlés = new System.Windows.Forms.Button();
            this.btnMentés = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTörlés
            // 
            this.btnTörlés.Location = new System.Drawing.Point(12, 367);
            this.btnTörlés.Name = "btnTörlés";
            this.btnTörlés.Size = new System.Drawing.Size(75, 23);
            this.btnTörlés.TabIndex = 0;
            this.btnTörlés.Text = "Törlés";
            this.btnTörlés.UseVisualStyleBackColor = true;
            this.btnTörlés.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMentés
            // 
            this.btnMentés.Location = new System.Drawing.Point(144, 367);
            this.btnMentés.Name = "btnMentés";
            this.btnMentés.Size = new System.Drawing.Size(75, 23);
            this.btnMentés.TabIndex = 1;
            this.btnMentés.Text = "Mentés";
            this.btnMentés.UseVisualStyleBackColor = true;
            this.btnMentés.Click += new System.EventHandler(this.btnMentés_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 349);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 396);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMentés);
            this.Controls.Add(this.btnTörlés);
            this.Name = "Form1";
            this.Text = "Iskola GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTörlés;
        private System.Windows.Forms.Button btnMentés;
        private System.Windows.Forms.ListBox listBox1;
    }
}

