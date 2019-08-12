namespace GUI
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.label1 = new System.Windows.Forms.Label();
            this.bttnMinimize = new System.Windows.Forms.Button();
            this.bttnClose = new System.Windows.Forms.Button();
            this.bttn2 = new System.Windows.Forms.Button();
            this.bttn4 = new System.Windows.Forms.Button();
            this.bttn3 = new System.Windows.Forms.Button();
            this.bttn1 = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(361, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUIZ - GAME";
            // 
            // bttnMinimize
            // 
            this.bttnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.bttnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnMinimize.BackgroundImage")));
            this.bttnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnMinimize.FlatAppearance.BorderSize = 0;
            this.bttnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMinimize.Location = new System.Drawing.Point(820, 23);
            this.bttnMinimize.Name = "bttnMinimize";
            this.bttnMinimize.Size = new System.Drawing.Size(49, 35);
            this.bttnMinimize.TabIndex = 8;
            this.bttnMinimize.UseVisualStyleBackColor = false;
            this.bttnMinimize.Click += new System.EventHandler(this.BttnMinimize_Click);
            // 
            // bttnClose
            // 
            this.bttnClose.BackColor = System.Drawing.Color.Transparent;
            this.bttnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnClose.BackgroundImage")));
            this.bttnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnClose.FlatAppearance.BorderSize = 0;
            this.bttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnClose.Location = new System.Drawing.Point(867, 23);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(49, 35);
            this.bttnClose.TabIndex = 9;
            this.bttnClose.UseVisualStyleBackColor = false;
            this.bttnClose.Click += new System.EventHandler(this.BttnClose_Click);
            // 
            // bttn2
            // 
            this.bttn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.bttn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn2.ForeColor = System.Drawing.Color.White;
            this.bttn2.Location = new System.Drawing.Point(475, 374);
            this.bttn2.Name = "bttn2";
            this.bttn2.Size = new System.Drawing.Size(394, 65);
            this.bttn2.TabIndex = 10;
            this.bttn2.Text = "Alternativa B";
            this.bttn2.UseVisualStyleBackColor = false;
            // 
            // bttn4
            // 
            this.bttn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.bttn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn4.ForeColor = System.Drawing.Color.White;
            this.bttn4.Location = new System.Drawing.Point(475, 505);
            this.bttn4.Name = "bttn4";
            this.bttn4.Size = new System.Drawing.Size(394, 65);
            this.bttn4.TabIndex = 11;
            this.bttn4.Text = "Alternativa D";
            this.bttn4.UseVisualStyleBackColor = false;
            // 
            // bttn3
            // 
            this.bttn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.bttn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn3.ForeColor = System.Drawing.Color.White;
            this.bttn3.Location = new System.Drawing.Point(67, 505);
            this.bttn3.Name = "bttn3";
            this.bttn3.Size = new System.Drawing.Size(394, 65);
            this.bttn3.TabIndex = 12;
            this.bttn3.Text = "Alternativa C";
            this.bttn3.UseVisualStyleBackColor = false;
            // 
            // bttn1
            // 
            this.bttn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.bttn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn1.ForeColor = System.Drawing.Color.White;
            this.bttn1.Location = new System.Drawing.Point(67, 374);
            this.bttn1.Name = "bttn1";
            this.bttn1.Size = new System.Drawing.Size(394, 65);
            this.bttn1.TabIndex = 13;
            this.bttn1.Text = "Alternativa A";
            this.bttn1.UseVisualStyleBackColor = false;
            // 
            // mainLabel
            // 
            this.mainLabel.AllowDrop = true;
            this.mainLabel.AutoEllipsis = true;
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.mainLabel.Location = new System.Drawing.Point(193, 209);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(570, 99);
            this.mainLabel.TabIndex = 14;
            this.mainLabel.Text = "Aqui fica aquele texto da pergunta marota, \r\nque é muito massa, tipo essa. \r\nVocê" +
    " prefere morrer ou sentar na cabess ?";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.label3.Location = new System.Drawing.Point(95, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 74);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rodada:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRound
            // 
            this.lblRound.AllowDrop = true;
            this.lblRound.AutoEllipsis = true;
            this.lblRound.BackColor = System.Drawing.Color.Transparent;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.lblRound.Location = new System.Drawing.Point(207, 59);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(29, 74);
            this.lblRound.TabIndex = 18;
            this.lblRound.Text = "0";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 687);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.bttn1);
            this.Controls.Add(this.bttn3);
            this.Controls.Add(this.bttn4);
            this.Controls.Add(this.bttn2);
            this.Controls.Add(this.bttnClose);
            this.Controls.Add(this.bttnMinimize);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnMinimize;
        private System.Windows.Forms.Button bttnClose;
        private System.Windows.Forms.Button bttn2;
        private System.Windows.Forms.Button bttn4;
        private System.Windows.Forms.Button bttn3;
        private System.Windows.Forms.Button bttn1;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRound;
    }
}