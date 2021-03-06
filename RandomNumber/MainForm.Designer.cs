﻿namespace RandomNumber
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
            this.muTextBox = new System.Windows.Forms.TextBox();
            this.sigmaTextBox = new System.Windows.Forms.TextBox();
            this.MuLabel = new System.Windows.Forms.Label();
            this.sigmaLabel = new System.Windows.Forms.Label();
            this.logNormButton = new System.Windows.Forms.Button();
            this.meanEksTextBox = new System.Windows.Forms.TextBox();
            this.meanLabelEks = new System.Windows.Forms.Label();
            this.EksButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.PoissonButton.Location = new System.Drawing.Point(354, 91);
            this.PoissonButton.Name = "PoissonButton";
            this.PoissonButton.Size = new System.Drawing.Size(75, 23);
            this.PoissonButton.TabIndex = 1;
            this.PoissonButton.Text = "Poisson";
            this.PoissonButton.UseVisualStyleBackColor = true;
            this.PoissonButton.Click += new System.EventHandler(this.PoissonButton_Click);
            // 
            // lambdaTextBox
            // 
            this.lambdaTextBox.Location = new System.Drawing.Point(309, 65);
            this.lambdaTextBox.Name = "lambdaTextBox";
            this.lambdaTextBox.Size = new System.Drawing.Size(120, 20);
            this.lambdaTextBox.TabIndex = 2;
            // 
            // lambdaLabel
            // 
            this.lambdaLabel.AutoSize = true;
            this.lambdaLabel.Location = new System.Drawing.Point(252, 68);
            this.lambdaLabel.Name = "lambdaLabel";
            this.lambdaLabel.Size = new System.Drawing.Size(45, 13);
            this.lambdaLabel.TabIndex = 3;
            this.lambdaLabel.Text = "Lambda";
            // 
            // jumlahTextBox
            // 
            this.jumlahTextBox.Location = new System.Drawing.Point(194, 12);
            this.jumlahTextBox.Name = "jumlahTextBox";
            this.jumlahTextBox.Size = new System.Drawing.Size(120, 20);
            this.jumlahTextBox.TabIndex = 4;
            // 
            // jumlahLabel
            // 
            this.jumlahLabel.AutoSize = true;
            this.jumlahLabel.Location = new System.Drawing.Point(142, 15);
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
            // muTextBox
            // 
            this.muTextBox.Location = new System.Drawing.Point(76, 146);
            this.muTextBox.Name = "muTextBox";
            this.muTextBox.Size = new System.Drawing.Size(120, 20);
            this.muTextBox.TabIndex = 10;
            // 
            // sigmaTextBox
            // 
            this.sigmaTextBox.Location = new System.Drawing.Point(76, 173);
            this.sigmaTextBox.Name = "sigmaTextBox";
            this.sigmaTextBox.Size = new System.Drawing.Size(120, 20);
            this.sigmaTextBox.TabIndex = 11;
            // 
            // MuLabel
            // 
            this.MuLabel.AutoSize = true;
            this.MuLabel.Location = new System.Drawing.Point(27, 152);
            this.MuLabel.Name = "MuLabel";
            this.MuLabel.Size = new System.Drawing.Size(22, 13);
            this.MuLabel.TabIndex = 12;
            this.MuLabel.Text = "Mu";
            // 
            // sigmaLabel
            // 
            this.sigmaLabel.AutoSize = true;
            this.sigmaLabel.Location = new System.Drawing.Point(27, 179);
            this.sigmaLabel.Name = "sigmaLabel";
            this.sigmaLabel.Size = new System.Drawing.Size(36, 13);
            this.sigmaLabel.TabIndex = 13;
            this.sigmaLabel.Text = "Sigma";
            // 
            // logNormButton
            // 
            this.logNormButton.Location = new System.Drawing.Point(121, 200);
            this.logNormButton.Name = "logNormButton";
            this.logNormButton.Size = new System.Drawing.Size(75, 23);
            this.logNormButton.TabIndex = 14;
            this.logNormButton.Text = "LogNormal";
            this.logNormButton.UseVisualStyleBackColor = true;
            this.logNormButton.Click += new System.EventHandler(this.logNormButton_Click);
            // 
            // meanEksTextBox
            // 
            this.meanEksTextBox.Location = new System.Drawing.Point(309, 145);
            this.meanEksTextBox.Name = "meanEksTextBox";
            this.meanEksTextBox.Size = new System.Drawing.Size(120, 20);
            this.meanEksTextBox.TabIndex = 15;
            // 
            // meanLabelEks
            // 
            this.meanLabelEks.AutoSize = true;
            this.meanLabelEks.Location = new System.Drawing.Point(263, 152);
            this.meanLabelEks.Name = "meanLabelEks";
            this.meanLabelEks.Size = new System.Drawing.Size(34, 13);
            this.meanLabelEks.TabIndex = 16;
            this.meanLabelEks.Text = "Mean";
            // 
            // EksButton
            // 
            this.EksButton.Location = new System.Drawing.Point(354, 179);
            this.EksButton.Name = "EksButton";
            this.EksButton.Size = new System.Drawing.Size(75, 23);
            this.EksButton.TabIndex = 17;
            this.EksButton.Text = "Exponential";
            this.EksButton.UseVisualStyleBackColor = true;
            this.EksButton.Click += new System.EventHandler(this.EksButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "*required";
            // 
            // RandomGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EksButton);
            this.Controls.Add(this.meanLabelEks);
            this.Controls.Add(this.meanEksTextBox);
            this.Controls.Add(this.logNormButton);
            this.Controls.Add(this.sigmaLabel);
            this.Controls.Add(this.MuLabel);
            this.Controls.Add(this.sigmaTextBox);
            this.Controls.Add(this.muTextBox);
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
        private System.Windows.Forms.TextBox muTextBox;
        private System.Windows.Forms.TextBox sigmaTextBox;
        private System.Windows.Forms.Label MuLabel;
        private System.Windows.Forms.Label sigmaLabel;
        private System.Windows.Forms.Button logNormButton;
        private System.Windows.Forms.TextBox meanEksTextBox;
        private System.Windows.Forms.Label meanLabelEks;
        private System.Windows.Forms.Button EksButton;
        private System.Windows.Forms.Label label1;
    }
}

