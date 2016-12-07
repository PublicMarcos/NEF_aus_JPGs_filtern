namespace NEF_Filter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.SearchPathButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(12, 25);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(29, 13);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "Pfad";
            // 
            // PathTextBox
            // 
            this.PathTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PathTextBox.Location = new System.Drawing.Point(47, 22);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(301, 20);
            this.PathTextBox.TabIndex = 1;
            // 
            // SearchPathButton
            // 
            this.SearchPathButton.Location = new System.Drawing.Point(354, 20);
            this.SearchPathButton.Name = "SearchPathButton";
            this.SearchPathButton.Size = new System.Drawing.Size(79, 23);
            this.SearchPathButton.TabIndex = 2;
            this.SearchPathButton.Text = "Durchsuchen";
            this.SearchPathButton.UseVisualStyleBackColor = true;
            this.SearchPathButton.Click += new System.EventHandler(this.SearchPathButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Enabled = false;
            this.FilterButton.Location = new System.Drawing.Point(439, 20);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(79, 23);
            this.FilterButton.TabIndex = 3;
            this.FilterButton.Text = "Filtern";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 61);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.SearchPathButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.PathLabel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "NEF aus JPG filtern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button SearchPathButton;
        private System.Windows.Forms.Button FilterButton;
    }
}

