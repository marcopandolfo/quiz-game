namespace GUI
{
    partial class Questions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questions));
            this.bttnMinimize = new System.Windows.Forms.Button();
            this.bttnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnCadastrar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlternativeA = new System.Windows.Forms.TextBox();
            this.txtAlternativeD = new System.Windows.Forms.TextBox();
            this.txtAlternativeB = new System.Windows.Forms.TextBox();
            this.txtAlternativeC = new System.Windows.Forms.TextBox();
            this.txtBoxQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bttnMinimize
            // 
            this.bttnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.bttnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnMinimize.BackgroundImage")));
            this.bttnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnMinimize.FlatAppearance.BorderSize = 0;
            this.bttnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMinimize.Location = new System.Drawing.Point(820, 12);
            this.bttnMinimize.Name = "bttnMinimize";
            this.bttnMinimize.Size = new System.Drawing.Size(49, 35);
            this.bttnMinimize.TabIndex = 9;
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
            this.bttnClose.Location = new System.Drawing.Point(871, 12);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(49, 35);
            this.bttnClose.TabIndex = 10;
            this.bttnClose.UseVisualStyleBackColor = false;
            this.bttnClose.Click += new System.EventHandler(this.BttnClose_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(84, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Digite a questão que deseja cadastrar: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.label3.Location = new System.Drawing.Point(263, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "Registre sua Questão";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnCadastrar
            // 
            this.bttnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.bttnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCadastrar.ForeColor = System.Drawing.Color.White;
            this.bttnCadastrar.Location = new System.Drawing.Point(185, 616);
            this.bttnCadastrar.Name = "bttnCadastrar";
            this.bttnCadastrar.Size = new System.Drawing.Size(338, 43);
            this.bttnCadastrar.TabIndex = 18;
            this.bttnCadastrar.Text = "Cadastrar";
            this.bttnCadastrar.UseVisualStyleBackColor = false;
            this.bttnCadastrar.Click += new System.EventHandler(this.bttnCadastrar_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.bttnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancelar.ForeColor = System.Drawing.Color.White;
            this.bttnCancelar.Location = new System.Drawing.Point(529, 616);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(338, 43);
            this.bttnCancelar.TabIndex = 19;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(84, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Digite as alternativas da questão:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAlternativeA
            // 
            this.txtAlternativeA.BackColor = System.Drawing.Color.Green;
            this.txtAlternativeA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlternativeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlternativeA.ForeColor = System.Drawing.Color.White;
            this.txtAlternativeA.Location = new System.Drawing.Point(90, 290);
            this.txtAlternativeA.Multiline = true;
            this.txtAlternativeA.Name = "txtAlternativeA";
            this.txtAlternativeA.Size = new System.Drawing.Size(351, 80);
            this.txtAlternativeA.TabIndex = 22;
            this.txtAlternativeA.Text = "Alternativa Certa";
            // 
            // txtAlternativeD
            // 
            this.txtAlternativeD.BackColor = System.Drawing.Color.Red;
            this.txtAlternativeD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlternativeD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlternativeD.ForeColor = System.Drawing.Color.White;
            this.txtAlternativeD.Location = new System.Drawing.Point(518, 403);
            this.txtAlternativeD.Multiline = true;
            this.txtAlternativeD.Name = "txtAlternativeD";
            this.txtAlternativeD.Size = new System.Drawing.Size(351, 80);
            this.txtAlternativeD.TabIndex = 23;
            this.txtAlternativeD.Text = "Alternativa Errada";
            // 
            // txtAlternativeB
            // 
            this.txtAlternativeB.BackColor = System.Drawing.Color.Red;
            this.txtAlternativeB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlternativeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlternativeB.ForeColor = System.Drawing.Color.White;
            this.txtAlternativeB.Location = new System.Drawing.Point(516, 290);
            this.txtAlternativeB.Multiline = true;
            this.txtAlternativeB.Name = "txtAlternativeB";
            this.txtAlternativeB.Size = new System.Drawing.Size(351, 80);
            this.txtAlternativeB.TabIndex = 24;
            this.txtAlternativeB.Text = "Alternativa Errada";
            // 
            // txtAlternativeC
            // 
            this.txtAlternativeC.BackColor = System.Drawing.Color.Red;
            this.txtAlternativeC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlternativeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlternativeC.ForeColor = System.Drawing.Color.White;
            this.txtAlternativeC.Location = new System.Drawing.Point(90, 403);
            this.txtAlternativeC.Multiline = true;
            this.txtAlternativeC.Name = "txtAlternativeC";
            this.txtAlternativeC.Size = new System.Drawing.Size(351, 80);
            this.txtAlternativeC.TabIndex = 25;
            this.txtAlternativeC.Text = "Alternativa Errada";
            // 
            // txtBoxQuestion
            // 
            this.txtBoxQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.txtBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQuestion.Location = new System.Drawing.Point(90, 108);
            this.txtBoxQuestion.Multiline = true;
            this.txtBoxQuestion.Name = "txtBoxQuestion";
            this.txtBoxQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxQuestion.Size = new System.Drawing.Size(779, 125);
            this.txtBoxQuestion.TabIndex = 26;
            this.txtBoxQuestion.Text = "Aqui fica aquele texto da pergunta marota, \r\nque é muito massa, tipo essa. \r\nVocê" +
    " prefere morrer ou sentar na cabess ?";
            this.txtBoxQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(84, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 31);
            this.label2.TabIndex = 27;
            this.label2.Text = "Defina a categoria da questão:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Historia",
            "Arte e Literatura",
            "Geografia",
            "Ciencia e Natureza",
            "Entreterimento"});
            this.comboCategory.Location = new System.Drawing.Point(576, 527);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(291, 32);
            this.comboCategory.TabIndex = 28;
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 687);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxQuestion);
            this.Controls.Add(this.txtAlternativeC);
            this.Controls.Add(this.txtAlternativeB);
            this.Controls.Add(this.txtAlternativeD);
            this.Controls.Add(this.txtAlternativeA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnClose);
            this.Controls.Add(this.bttnMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Questions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnMinimize;
        private System.Windows.Forms.Button bttnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnCadastrar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlternativeA;
        private System.Windows.Forms.TextBox txtAlternativeD;
        private System.Windows.Forms.TextBox txtAlternativeB;
        private System.Windows.Forms.TextBox txtAlternativeC;
        private System.Windows.Forms.TextBox txtBoxQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCategory;
    }
}