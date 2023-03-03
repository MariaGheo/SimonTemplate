namespace SimonSays
{
    partial class SpeedScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.speedTitleLabel = new System.Windows.Forms.Label();
            this.slowButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.fastButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // speedTitleLabel
            // 
            this.speedTitleLabel.AutoSize = true;
            this.speedTitleLabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedTitleLabel.ForeColor = System.Drawing.Color.White;
            this.speedTitleLabel.Location = new System.Drawing.Point(28, 50);
            this.speedTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedTitleLabel.Name = "speedTitleLabel";
            this.speedTitleLabel.Size = new System.Drawing.Size(239, 32);
            this.speedTitleLabel.TabIndex = 1;
            this.speedTitleLabel.Text = "Choose a Speed!";
            // 
            // slowButton
            // 
            this.slowButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.slowButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.slowButton.FlatAppearance.BorderSize = 0;
            this.slowButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.slowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.slowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slowButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slowButton.ForeColor = System.Drawing.Color.White;
            this.slowButton.Location = new System.Drawing.Point(105, 115);
            this.slowButton.Name = "slowButton";
            this.slowButton.Size = new System.Drawing.Size(84, 32);
            this.slowButton.TabIndex = 19;
            this.slowButton.Tag = "3";
            this.slowButton.Text = "Slow";
            this.slowButton.UseVisualStyleBackColor = false;
            this.slowButton.Click += new System.EventHandler(this.anyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.mediumButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mediumButton.FlatAppearance.BorderSize = 0;
            this.mediumButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.ForeColor = System.Drawing.Color.White;
            this.mediumButton.Location = new System.Drawing.Point(105, 153);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(84, 32);
            this.mediumButton.TabIndex = 20;
            this.mediumButton.Tag = "2";
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.anyButton_Click);
            // 
            // fastButton
            // 
            this.fastButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.fastButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fastButton.FlatAppearance.BorderSize = 0;
            this.fastButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.fastButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.fastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fastButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastButton.ForeColor = System.Drawing.Color.White;
            this.fastButton.Location = new System.Drawing.Point(105, 191);
            this.fastButton.Name = "fastButton";
            this.fastButton.Size = new System.Drawing.Size(84, 32);
            this.fastButton.TabIndex = 21;
            this.fastButton.Tag = "1";
            this.fastButton.Text = "Fast";
            this.fastButton.UseVisualStyleBackColor = false;
            this.fastButton.Click += new System.EventHandler(this.anyButton_Click);
            // 
            // SpeedScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.fastButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.slowButton);
            this.Controls.Add(this.speedTitleLabel);
            this.Name = "SpeedScreen";
            this.Size = new System.Drawing.Size(301, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedTitleLabel;
        private System.Windows.Forms.Button slowButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button fastButton;
    }
}
