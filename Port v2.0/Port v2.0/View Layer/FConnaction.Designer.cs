namespace Port_v2._0
{
    partial class FConnaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConnaction));
            this.label1 = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.BCon = new System.Windows.Forms.Button();
            this.DataBaseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ServerName";
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(103, 6);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(100, 20);
            this.ServerName.TabIndex = 6;
            // 
            // BCon
            // 
            this.BCon.Location = new System.Drawing.Point(70, 92);
            this.BCon.Name = "BCon";
            this.BCon.Size = new System.Drawing.Size(75, 23);
            this.BCon.TabIndex = 11;
            this.BCon.Text = "Connect";
            this.BCon.UseVisualStyleBackColor = true;
            this.BCon.Click += new System.EventHandler(this.BCon_Click);
            // 
            // DataBaseName
            // 
            this.DataBaseName.Location = new System.Drawing.Point(103, 45);
            this.DataBaseName.Name = "DataBaseName";
            this.DataBaseName.Size = new System.Drawing.Size(100, 20);
            this.DataBaseName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DataBase Name";
            // 
            // FConnaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 127);
            this.Controls.Add(this.BCon);
            this.Controls.Add(this.DataBaseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FConnaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.Button BCon;
        private System.Windows.Forms.TextBox DataBaseName;
        private System.Windows.Forms.Label label2;
    }
}