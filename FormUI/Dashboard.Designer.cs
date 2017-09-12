namespace FormUI
{
    partial class Dashboard
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
            this.doorsFoundListBox = new System.Windows.Forms.ListBox();
            this.matcodText = new System.Windows.Forms.TextBox();
            this.matcodLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doorsFoundListBox
            // 
            this.doorsFoundListBox.FormattingEnabled = true;
            this.doorsFoundListBox.ItemHeight = 24;
            this.doorsFoundListBox.Location = new System.Drawing.Point(34, 123);
            this.doorsFoundListBox.Name = "doorsFoundListBox";
            this.doorsFoundListBox.Size = new System.Drawing.Size(374, 364);
            this.doorsFoundListBox.TabIndex = 0;
            // 
            // matcodText
            // 
            this.matcodText.Location = new System.Drawing.Point(152, 32);
            this.matcodText.Name = "matcodText";
            this.matcodText.Size = new System.Drawing.Size(256, 30);
            this.matcodText.TabIndex = 1;
            // 
            // matcodLabel
            // 
            this.matcodLabel.AutoSize = true;
            this.matcodLabel.Location = new System.Drawing.Point(44, 38);
            this.matcodLabel.Name = "matcodLabel";
            this.matcodLabel.Size = new System.Drawing.Size(71, 24);
            this.matcodLabel.TabIndex = 2;
            this.matcodLabel.Text = "Matcod";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(152, 77);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 40);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 530);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.matcodLabel);
            this.Controls.Add(this.matcodText);
            this.Controls.Add(this.doorsFoundListBox);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox doorsFoundListBox;
        private System.Windows.Forms.TextBox matcodText;
        private System.Windows.Forms.Label matcodLabel;
        private System.Windows.Forms.Button searchButton;
    }
}

