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
            this.bttnB = new System.Windows.Forms.Button();
            this.bttnD = new System.Windows.Forms.Button();
            this.bttnC = new System.Windows.Forms.Button();
            this.bttnA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Fira Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(361, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 35);
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
            this.bttnMinimize.Location = new System.Drawing.Point(843, 23);
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
            this.bttnClose.Location = new System.Drawing.Point(903, 23);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(49, 35);
            this.bttnClose.TabIndex = 9;
            this.bttnClose.UseVisualStyleBackColor = false;
            this.bttnClose.Click += new System.EventHandler(this.BttnClose_Click);
            // 
            // bttnB
            // 
            this.bttnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.bttnB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnB.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnB.ForeColor = System.Drawing.Color.White;
            this.bttnB.Location = new System.Drawing.Point(486, 317);
            this.bttnB.Name = "bttnB";
            this.bttnB.Size = new System.Drawing.Size(394, 43);
            this.bttnB.TabIndex = 10;
            this.bttnB.Text = "Alternativa B";
            this.bttnB.UseVisualStyleBackColor = false;
            // 
            // bttnD
            // 
            this.bttnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.bttnD.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnD.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnD.ForeColor = System.Drawing.Color.White;
            this.bttnD.Location = new System.Drawing.Point(486, 449);
            this.bttnD.Name = "bttnD";
            this.bttnD.Size = new System.Drawing.Size(394, 43);
            this.bttnD.TabIndex = 11;
            this.bttnD.Text = "Alternativa D";
            this.bttnD.UseVisualStyleBackColor = false;
            // 
            // bttnC
            // 
            this.bttnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.bttnC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnC.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnC.ForeColor = System.Drawing.Color.White;
            this.bttnC.Location = new System.Drawing.Point(78, 449);
            this.bttnC.Name = "bttnC";
            this.bttnC.Size = new System.Drawing.Size(394, 43);
            this.bttnC.TabIndex = 12;
            this.bttnC.Text = "Alternativa C";
            this.bttnC.UseVisualStyleBackColor = false;
            // 
            // bttnA
            // 
            this.bttnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.bttnA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnA.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnA.ForeColor = System.Drawing.Color.White;
            this.bttnA.Location = new System.Drawing.Point(78, 317);
            this.bttnA.Name = "bttnA";
            this.bttnA.Size = new System.Drawing.Size(394, 43);
            this.bttnA.TabIndex = 13;
            this.bttnA.Text = "Alternativa A";
            this.bttnA.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Fira Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.label2.Location = new System.Drawing.Point(109, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(746, 105);
            this.label2.TabIndex = 14;
            this.label2.Text = "Aqui fica aquele texto da pergunta marota, \r\nque é muito massa, tipo essa. \r\nVocê" +
    " prefere morrer ou sentar na cabess ?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnA);
            this.Controls.Add(this.bttnC);
            this.Controls.Add(this.bttnD);
            this.Controls.Add(this.bttnB);
            this.Controls.Add(this.bttnClose);
            this.Controls.Add(this.bttnMinimize);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnMinimize;
        private System.Windows.Forms.Button bttnClose;
        private System.Windows.Forms.Button bttnB;
        private System.Windows.Forms.Button bttnD;
        private System.Windows.Forms.Button bttnC;
        private System.Windows.Forms.Button bttnA;
        private System.Windows.Forms.Label label2;
    }
}