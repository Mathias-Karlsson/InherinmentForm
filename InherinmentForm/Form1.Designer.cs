namespace InherinmentForm
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
            this.cbNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSpecies = new System.Windows.Forms.Label();
            this.lbCanFly = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbNames
            // 
            this.cbNames.FormattingEnabled = true;
            this.cbNames.Location = new System.Drawing.Point(107, 12);
            this.cbNames.Name = "cbNames";
            this.cbNames.Size = new System.Drawing.Size(94, 21);
            this.cbNames.TabIndex = 0;
            this.cbNames.SelectedIndexChanged += new System.EventHandler(this.cbNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Art:";
            // 
            // lbSpecies
            // 
            this.lbSpecies.AutoSize = true;
            this.lbSpecies.Location = new System.Drawing.Point(104, 45);
            this.lbSpecies.Name = "lbSpecies";
            this.lbSpecies.Size = new System.Drawing.Size(0, 13);
            this.lbSpecies.TabIndex = 3;
            // 
            // lbCanFly
            // 
            this.lbCanFly.AutoSize = true;
            this.lbCanFly.Location = new System.Drawing.Point(37, 82);
            this.lbCanFly.Name = "lbCanFly";
            this.lbCanFly.Size = new System.Drawing.Size(0, 13);
            this.lbCanFly.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 313);
            this.Controls.Add(this.lbCanFly);
            this.Controls.Add(this.lbSpecies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNames);
            this.Name = "Form1";
            this.Text = "Animals";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSpecies;
        private System.Windows.Forms.Label lbCanFly;
    }
}

