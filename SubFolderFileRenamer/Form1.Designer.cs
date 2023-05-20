namespace SubFolderFileRenamer
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
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_OldString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NewString = new System.Windows.Forms.TextBox();
            this.b_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Path
            // 
            this.tb_Path.Location = new System.Drawing.Point(75, 24);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(713, 20);
            this.tb_Path.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "OldName";
            // 
            // tb_OldString
            // 
            this.tb_OldString.Location = new System.Drawing.Point(75, 50);
            this.tb_OldString.Name = "tb_OldString";
            this.tb_OldString.Size = new System.Drawing.Size(173, 20);
            this.tb_OldString.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NewName";
            // 
            // tb_NewString
            // 
            this.tb_NewString.Location = new System.Drawing.Point(75, 76);
            this.tb_NewString.Name = "tb_NewString";
            this.tb_NewString.Size = new System.Drawing.Size(173, 20);
            this.tb_NewString.TabIndex = 4;
            // 
            // b_Start
            // 
            this.b_Start.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.b_Start.Location = new System.Drawing.Point(0, 126);
            this.b_Start.Name = "b_Start";
            this.b_Start.Size = new System.Drawing.Size(800, 35);
            this.b_Start.TabIndex = 6;
            this.b_Start.Text = "Rename Given Folders SubFolderAndFile";
            this.b_Start.UseVisualStyleBackColor = true;
            this.b_Start.Click += new System.EventHandler(this.b_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 161);
            this.Controls.Add(this.b_Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_NewString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_OldString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Path);
            this.Name = "Form1";
            this.Text = "Rename Given Folders SubFolderAndFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_OldString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_NewString;
        private System.Windows.Forms.Button b_Start;
    }
}

