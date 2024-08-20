namespace pratica_logica_de_programacao
{
    partial class FrmPesoPlaneta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesoPlaneta));
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMercurio = new System.Windows.Forms.RadioButton();
            this.btnVenus = new System.Windows.Forms.RadioButton();
            this.btnMarte = new System.Windows.Forms.RadioButton();
            this.btnJupiter = new System.Windows.Forms.RadioButton();
            this.btnSaturno = new System.Windows.Forms.RadioButton();
            this.btnUrano = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(44, 68);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(127, 31);
            this.txtPeso.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCalcular.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(233, 68);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(147, 31);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular Peso";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Peso na Terra(kg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione o Planeta:";
            // 
            // btnMercurio
            // 
            this.btnMercurio.AutoSize = true;
            this.btnMercurio.BackColor = System.Drawing.Color.Transparent;
            this.btnMercurio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMercurio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMercurio.Location = new System.Drawing.Point(32, 205);
            this.btnMercurio.Name = "btnMercurio";
            this.btnMercurio.Size = new System.Drawing.Size(96, 25);
            this.btnMercurio.TabIndex = 5;
            this.btnMercurio.TabStop = true;
            this.btnMercurio.Text = "Mercúrio";
            this.btnMercurio.UseVisualStyleBackColor = false;
            // 
            // btnVenus
            // 
            this.btnVenus.AutoSize = true;
            this.btnVenus.BackColor = System.Drawing.Color.Transparent;
            this.btnVenus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVenus.Location = new System.Drawing.Point(32, 251);
            this.btnVenus.Name = "btnVenus";
            this.btnVenus.Size = new System.Drawing.Size(75, 25);
            this.btnVenus.TabIndex = 6;
            this.btnVenus.TabStop = true;
            this.btnVenus.Text = "Vênus";
            this.btnVenus.UseVisualStyleBackColor = false;
            // 
            // btnMarte
            // 
            this.btnMarte.AutoSize = true;
            this.btnMarte.BackColor = System.Drawing.Color.Transparent;
            this.btnMarte.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMarte.Location = new System.Drawing.Point(174, 205);
            this.btnMarte.Name = "btnMarte";
            this.btnMarte.Size = new System.Drawing.Size(71, 25);
            this.btnMarte.TabIndex = 7;
            this.btnMarte.TabStop = true;
            this.btnMarte.Text = "Marte";
            this.btnMarte.UseVisualStyleBackColor = false;
            // 
            // btnJupiter
            // 
            this.btnJupiter.AutoSize = true;
            this.btnJupiter.BackColor = System.Drawing.Color.Transparent;
            this.btnJupiter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJupiter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJupiter.Location = new System.Drawing.Point(174, 251);
            this.btnJupiter.Name = "btnJupiter";
            this.btnJupiter.Size = new System.Drawing.Size(77, 25);
            this.btnJupiter.TabIndex = 8;
            this.btnJupiter.TabStop = true;
            this.btnJupiter.Text = "Júpiter";
            this.btnJupiter.UseVisualStyleBackColor = false;
            // 
            // btnSaturno
            // 
            this.btnSaturno.AutoSize = true;
            this.btnSaturno.BackColor = System.Drawing.Color.Transparent;
            this.btnSaturno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaturno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaturno.Location = new System.Drawing.Point(290, 205);
            this.btnSaturno.Name = "btnSaturno";
            this.btnSaturno.Size = new System.Drawing.Size(86, 25);
            this.btnSaturno.TabIndex = 9;
            this.btnSaturno.TabStop = true;
            this.btnSaturno.Text = "Saturno";
            this.btnSaturno.UseVisualStyleBackColor = false;
            // 
            // btnUrano
            // 
            this.btnUrano.AutoSize = true;
            this.btnUrano.BackColor = System.Drawing.Color.Transparent;
            this.btnUrano.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrano.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUrano.Location = new System.Drawing.Point(290, 251);
            this.btnUrano.Name = "btnUrano";
            this.btnUrano.Size = new System.Drawing.Size(74, 25);
            this.btnUrano.TabIndex = 10;
            this.btnUrano.TabStop = true;
            this.btnUrano.Text = "Urano";
            this.btnUrano.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(233, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(233, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmPesoPlaneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prática_Lógica_de_Programação.Properties.Resources.entender_o_universo_1024x576;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(414, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUrano);
            this.Controls.Add(this.btnSaturno);
            this.Controls.Add(this.btnJupiter);
            this.Controls.Add(this.btnMarte);
            this.Controls.Add(this.btnVenus);
            this.Controls.Add(this.btnMercurio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPeso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPesoPlaneta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo Peso Planeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton btnMercurio;
        private System.Windows.Forms.RadioButton btnVenus;
        private System.Windows.Forms.RadioButton btnMarte;
        private System.Windows.Forms.RadioButton btnJupiter;
        private System.Windows.Forms.RadioButton btnSaturno;
        private System.Windows.Forms.RadioButton btnUrano;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

