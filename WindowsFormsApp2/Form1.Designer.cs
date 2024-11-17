namespace WindowsFormsApp2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.csvfoldername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pdffoldername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.brousescv = new System.Windows.Forms.Button();
            this.brousepdf = new System.Windows.Forms.Button();
            this.textcsv = new System.Windows.Forms.TextBox();
            this.textpdf = new System.Windows.Forms.TextBox();
            this.btnextractcsv = new System.Windows.Forms.Button();
            this.btnextractpdf = new System.Windows.Forms.Button();
            this.btnbrouse = new System.Windows.Forms.Button();
            this.textFolder = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.csvfoldername);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pdffoldername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.brousescv);
            this.panel1.Controls.Add(this.brousepdf);
            this.panel1.Controls.Add(this.textcsv);
            this.panel1.Controls.Add(this.textpdf);
            this.panel1.Controls.Add(this.btnextractcsv);
            this.panel1.Controls.Add(this.btnextractpdf);
            this.panel1.Controls.Add(this.btnbrouse);
            this.panel1.Controls.Add(this.textFolder);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 296);
            this.panel1.TabIndex = 1;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Write a Folder name";
            // 
            // csvfoldername
            // 
            this.csvfoldername.Location = new System.Drawing.Point(372, 203);
            this.csvfoldername.Name = "csvfoldername";
            this.csvfoldername.Size = new System.Drawing.Size(168, 20);
            this.csvfoldername.TabIndex = 16;
            this.csvfoldername.TextChanged += new System.EventHandler(this.csvfoldername_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Write a Folder name";
            // 
            // pdffoldername
            // 
            this.pdffoldername.Location = new System.Drawing.Point(372, 141);
            this.pdffoldername.Name = "pdffoldername";
            this.pdffoldername.Size = new System.Drawing.Size(168, 20);
            this.pdffoldername.TabIndex = 14;
            this.pdffoldername.TextChanged += new System.EventHandler(this.pdffoldername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select a Path to be extracted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select a Path to be extracted";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select a Folder to be extracted";
            // 
            // brousescv
            // 
            this.brousescv.Location = new System.Drawing.Point(546, 201);
            this.brousescv.Name = "brousescv";
            this.brousescv.Size = new System.Drawing.Size(75, 23);
            this.brousescv.TabIndex = 10;
            this.brousescv.Text = "...";
            this.brousescv.UseVisualStyleBackColor = true;
            this.brousescv.Click += new System.EventHandler(this.brousescv_Click);
            // 
            // brousepdf
            // 
            this.brousepdf.Location = new System.Drawing.Point(546, 141);
            this.brousepdf.Name = "brousepdf";
            this.brousepdf.Size = new System.Drawing.Size(75, 23);
            this.brousepdf.TabIndex = 9;
            this.brousepdf.Text = "...";
            this.brousepdf.UseVisualStyleBackColor = true;
            this.brousepdf.Click += new System.EventHandler(this.brousepdf_Click);
            // 
            // textcsv
            // 
            this.textcsv.Location = new System.Drawing.Point(40, 203);
            this.textcsv.Name = "textcsv";
            this.textcsv.Size = new System.Drawing.Size(308, 20);
            this.textcsv.TabIndex = 8;
            // 
            // textpdf
            // 
            this.textpdf.Location = new System.Drawing.Point(40, 141);
            this.textpdf.Name = "textpdf";
            this.textpdf.Size = new System.Drawing.Size(308, 20);
            this.textpdf.TabIndex = 7;
            // 
            // btnextractcsv
            // 
            this.btnextractcsv.Location = new System.Drawing.Point(627, 200);
            this.btnextractcsv.Name = "btnextractcsv";
            this.btnextractcsv.Size = new System.Drawing.Size(75, 23);
            this.btnextractcsv.TabIndex = 6;
            this.btnextractcsv.Text = "ExtractCSV";
            this.btnextractcsv.UseVisualStyleBackColor = true;
            this.btnextractcsv.Click += new System.EventHandler(this.btnextractcsv_Click);
            // 
            // btnextractpdf
            // 
            this.btnextractpdf.Location = new System.Drawing.Point(627, 141);
            this.btnextractpdf.Name = "btnextractpdf";
            this.btnextractpdf.Size = new System.Drawing.Size(75, 23);
            this.btnextractpdf.TabIndex = 5;
            this.btnextractpdf.Text = "ExtractPDF";
            this.btnextractpdf.UseVisualStyleBackColor = true;
            this.btnextractpdf.Click += new System.EventHandler(this.btnextractpdf_Click);
            // 
            // btnbrouse
            // 
            this.btnbrouse.Location = new System.Drawing.Point(548, 77);
            this.btnbrouse.Name = "btnbrouse";
            this.btnbrouse.Size = new System.Drawing.Size(75, 23);
            this.btnbrouse.TabIndex = 4;
            this.btnbrouse.Text = "...";
            this.btnbrouse.UseVisualStyleBackColor = true;
            this.btnbrouse.Click += new System.EventHandler(this.btnbrouse_Click);
            // 
            // textFolder
            // 
            this.textFolder.Location = new System.Drawing.Point(234, 80);
            this.textFolder.Name = "textFolder";
            this.textFolder.Size = new System.Drawing.Size(308, 20);
            this.textFolder.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(789, 387);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnextractpdf;
        private System.Windows.Forms.Button btnbrouse;
        private System.Windows.Forms.TextBox textFolder;
        private System.Windows.Forms.Button btnextractcsv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brousescv;
        private System.Windows.Forms.Button brousepdf;
        private System.Windows.Forms.TextBox textcsv;
        private System.Windows.Forms.TextBox textpdf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox csvfoldername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pdffoldername;
    }
}

