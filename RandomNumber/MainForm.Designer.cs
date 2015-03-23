namespace RandomNumber
{
    partial class RandomGenerator
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
            this.NormalButton = new System.Windows.Forms.Button();
            this.PoissonButton = new System.Windows.Forms.Button();
            this.lambdaTextBox = new System.Windows.Forms.TextBox();
            this.lambdaLabel = new System.Windows.Forms.Label();
            this.jumlahTextBox = new System.Windows.Forms.TextBox();
            this.jumlahLabel = new System.Windows.Forms.Label();
            this.meanTextBox = new System.Windows.Forms.TextBox();
            this.deviasiTextBox = new System.Windows.Forms.TextBox();
            this.meanLabel = new System.Windows.Forms.Label();
            this.deviasiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NormalButton
            // 
            this.NormalButton.Location = new System.Drawing.Point(121, 91);
            this.NormalButton.Name = "NormalButton";
            this.NormalButton.Size = new System.Drawing.Size(75, 23);
            this.NormalButton.TabIndex = 0;
            this.NormalButton.Text = "Normal";
            this.NormalButton.UseVisualStyleBackColor = true;
            this.NormalButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PoissonButton
            // 
            this.PoissonButton.Location = new System.Drawing.Point(354, 38);
            this.PoissonButton.Name = "PoissonButton";
            this.PoissonButton.Size = new System.Drawing.Size(75, 23);
            this.PoissonButton.TabIndex = 1;
            this.PoissonButton.Text = "Poisson";
            this.PoissonButton.UseVisualStyleBackColor = true;
            this.PoissonButton.Click += new System.EventHandler(this.PoissonButton_Click);
            // 
            // lambdaTextBox
            // 
            this.lambdaTextBox.Location = new System.Drawing.Point(309, 11);
            this.lambdaTextBox.Name = "lambdaTextBox";
            this.lambdaTextBox.Size = new System.Drawing.Size(120, 20);
            this.lambdaTextBox.TabIndex = 2;
            // 
            // lambdaLabel
            // 
            this.lambdaLabel.AutoSize = true;
            this.lambdaLabel.Location = new System.Drawing.Point(260, 14);
            this.lambdaLabel.Name = "lambdaLabel";
            this.lambdaLabel.Size = new System.Drawing.Size(45, 13);
            this.lambdaLabel.TabIndex = 3;
            this.lambdaLabel.Text = "Lambda";
            // 
            // jumlahTextBox
            // 
            this.jumlahTextBox.Location = new System.Drawing.Point(76, 11);
            this.jumlahTextBox.Name = "jumlahTextBox";
            this.jumlahTextBox.Size = new System.Drawing.Size(120, 20);
            this.jumlahTextBox.TabIndex = 4;
            // 
            // jumlahLabel
            // 
            this.jumlahLabel.AutoSize = true;
            this.jumlahLabel.Location = new System.Drawing.Point(24, 14);
            this.jumlahLabel.Name = "jumlahLabel";
            this.jumlahLabel.Size = new System.Drawing.Size(35, 13);
            this.jumlahLabel.TabIndex = 5;
            this.jumlahLabel.Text = "Count";
            // 
            // meanTextBox
            // 
            this.meanTextBox.Location = new System.Drawing.Point(76, 38);
            this.meanTextBox.Name = "meanTextBox";
            this.meanTextBox.Size = new System.Drawing.Size(120, 20);
            this.meanTextBox.TabIndex = 6;
            // 
            // deviasiTextBox
            // 
            this.deviasiTextBox.Location = new System.Drawing.Point(76, 65);
            this.deviasiTextBox.Name = "deviasiTextBox";
            this.deviasiTextBox.Size = new System.Drawing.Size(120, 20);
            this.deviasiTextBox.TabIndex = 7;
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Location = new System.Drawing.Point(24, 43);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(34, 13);
            this.meanLabel.TabIndex = 8;
            this.meanLabel.Text = "Mean";
            // 
            // deviasiLabel
            // 
            this.deviasiLabel.AutoSize = true;
            this.deviasiLabel.Location = new System.Drawing.Point(24, 68);
            this.deviasiLabel.Name = "deviasiLabel";
            this.deviasiLabel.Size = new System.Drawing.Size(42, 13);
            this.deviasiLabel.TabIndex = 9;
            this.deviasiLabel.Text = "Deviasi";
            // 
            // RandomGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 127);
            this.Controls.Add(this.deviasiLabel);
            this.Controls.Add(this.meanLabel);
            this.Controls.Add(this.deviasiTextBox);
            this.Controls.Add(this.meanTextBox);
            this.Controls.Add(this.jumlahLabel);
            this.Controls.Add(this.jumlahTextBox);
            this.Controls.Add(this.lambdaLabel);
            this.Controls.Add(this.lambdaTextBox);
            this.Controls.Add(this.PoissonButton);
            this.Controls.Add(this.NormalButton);
            this.Name = "RandomGenerator";
            this.Text = "Random Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NormalButton;
        private System.Windows.Forms.Button PoissonButton;
        private System.Windows.Forms.TextBox lambdaTextBox;
        private System.Windows.Forms.Label lambdaLabel;
        private System.Windows.Forms.TextBox jumlahTextBox;
        private System.Windows.Forms.Label jumlahLabel;
        private System.Windows.Forms.TextBox meanTextBox;
        private System.Windows.Forms.TextBox deviasiTextBox;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label deviasiLabel;
    }
}

