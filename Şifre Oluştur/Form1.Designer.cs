namespace Şifre_Oluştur
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
            this.txtPassEntry = new System.Windows.Forms.TextBox();
            this.txtPassOutput = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassEntry
            // 
            this.txtPassEntry.Location = new System.Drawing.Point(12, 12);
            this.txtPassEntry.Name = "txtPassEntry";
            this.txtPassEntry.Size = new System.Drawing.Size(548, 20);
            this.txtPassEntry.TabIndex = 0;
            // 
            // txtPassOutput
            // 
            this.txtPassOutput.Location = new System.Drawing.Point(12, 38);
            this.txtPassOutput.Multiline = true;
            this.txtPassOutput.Name = "txtPassOutput";
            this.txtPassOutput.Size = new System.Drawing.Size(548, 324);
            this.txtPassOutput.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(13, 369);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(547, 49);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 445);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtPassOutput);
            this.Controls.Add(this.txtPassEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassEntry;
        private System.Windows.Forms.TextBox txtPassOutput;
        private System.Windows.Forms.Button btnGenerate;
    }
}

