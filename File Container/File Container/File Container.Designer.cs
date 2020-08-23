namespace File_Container
{
    partial class File_Container
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
            this.buttonChooseFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChooseContainer = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChooseFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonChooseFiles
            // 
            this.buttonChooseFiles.Location = new System.Drawing.Point(246, 6);
            this.buttonChooseFiles.Name = "buttonChooseFiles";
            this.buttonChooseFiles.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseFiles.TabIndex = 8;
            this.buttonChooseFiles.Text = "Файл(ы)";
            this.buttonChooseFiles.UseVisualStyleBackColor = true;
            this.buttonChooseFiles.Click += new System.EventHandler(this.buttonChooseFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите объекты для упаковки:";
            // 
            // buttonChooseContainer
            // 
            this.buttonChooseContainer.Location = new System.Drawing.Point(246, 64);
            this.buttonChooseContainer.Name = "buttonChooseContainer";
            this.buttonChooseContainer.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseContainer.TabIndex = 11;
            this.buttonChooseContainer.Text = "Обзор";
            this.buttonChooseContainer.UseVisualStyleBackColor = true;
            this.buttonChooseContainer.Click += new System.EventHandler(this.buttonChooseContainer_Click);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Location = new System.Drawing.Point(246, 35);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFile.TabIndex = 12;
            this.buttonAddFile.Text = "Файл(ы)";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Выберите контейнер для распаковки:";
            // 
            // buttonChooseFolder
            // 
            this.buttonChooseFolder.Location = new System.Drawing.Point(337, 6);
            this.buttonChooseFolder.Name = "buttonChooseFolder";
            this.buttonChooseFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseFolder.TabIndex = 14;
            this.buttonChooseFolder.Text = "Папка";
            this.buttonChooseFolder.UseVisualStyleBackColor = true;
            this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Выберите объекты для добавления:";
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.Location = new System.Drawing.Point(337, 35);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFolder.TabIndex = 16;
            this.buttonAddFolder.Text = "Папка";
            this.buttonAddFolder.UseVisualStyleBackColor = true;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddFolder_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 93);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(398, 141);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // File_Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(444, 246);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonAddFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonChooseFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddFile);
            this.Controls.Add(this.buttonChooseContainer);
            this.Controls.Add(this.buttonChooseFiles);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "File_Container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Container";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChooseFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChooseContainer;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonChooseFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddFolder;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}