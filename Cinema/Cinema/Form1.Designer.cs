namespace Cinema
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComboFilme = new System.Windows.Forms.ComboBox();
            this.ComboSemana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.comboSala = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboFilme
            // 
            this.ComboFilme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboFilme.FormattingEnabled = true;
            this.ComboFilme.Items.AddRange(new object[] {
            "Os vingadores",
            "Tubarão",
            "Jurassic Park",
            "Titanic"});
            this.ComboFilme.Location = new System.Drawing.Point(87, 90);
            this.ComboFilme.Name = "ComboFilme";
            this.ComboFilme.Size = new System.Drawing.Size(420, 39);
            this.ComboFilme.TabIndex = 0;
            // 
            // ComboSemana
            // 
            this.ComboSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboSemana.FormattingEnabled = true;
            this.ComboSemana.Items.AddRange(new object[] {
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sábado",
            "Domingo"});
            this.ComboSemana.Location = new System.Drawing.Point(96, 352);
            this.ComboSemana.Name = "ComboSemana";
            this.ComboSemana.Size = new System.Drawing.Size(256, 32);
            this.ComboSemana.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filmes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dia da semana";
            // 
            // btnCalculo
            // 
            this.btnCalculo.BackColor = System.Drawing.Color.White;
            this.btnCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculo.ForeColor = System.Drawing.Color.Blue;
            this.btnCalculo.Location = new System.Drawing.Point(664, 263);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(192, 121);
            this.btnCalculo.TabIndex = 4;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = false;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(624, 90);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(248, 35);
            this.txtResultado.TabIndex = 5;
            // 
            // comboSala
            // 
            this.comboSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSala.FormattingEnabled = true;
            this.comboSala.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboSala.Location = new System.Drawing.Point(87, 219);
            this.comboSala.Name = "comboSala";
            this.comboSala.Size = new System.Drawing.Size(157, 32);
            this.comboSala.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(617, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total a pagar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::Cinema.Properties.Resources.depositphotos_52519061_stock_illustration_cinema_concept_illustration;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSala);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboSemana);
            this.Controls.Add(this.ComboFilme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboFilme;
        private System.Windows.Forms.ComboBox ComboSemana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ComboBox comboSala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

