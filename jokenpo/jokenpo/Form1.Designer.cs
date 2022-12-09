namespace jokenpo
{
    partial class principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.rdoPedra = new System.Windows.Forms.RadioButton();
            this.rdoPapel = new System.Windows.Forms.RadioButton();
            this.rdoTesoura = new System.Windows.Forms.RadioButton();
            this.btnLancar = new System.Windows.Forms.Button();
            this.fechar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPontoPC = new System.Windows.Forms.TextBox();
            this.txtPontoPlayer = new System.Windows.Forms.TextBox();
            this.txtPontoEmpate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoPedra
            // 
            this.rdoPedra.AutoSize = true;
            this.rdoPedra.BackColor = System.Drawing.Color.Transparent;
            this.rdoPedra.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoPedra.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rdoPedra.Location = new System.Drawing.Point(262, 268);
            this.rdoPedra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoPedra.Name = "rdoPedra";
            this.rdoPedra.Size = new System.Drawing.Size(124, 34);
            this.rdoPedra.TabIndex = 0;
            this.rdoPedra.TabStop = true;
            this.rdoPedra.Text = "PEDRA";
            this.rdoPedra.UseVisualStyleBackColor = false;
            this.rdoPedra.CheckedChanged += new System.EventHandler(this.rdoPedra_CheckedChanged);
            // 
            // rdoPapel
            // 
            this.rdoPapel.AutoSize = true;
            this.rdoPapel.BackColor = System.Drawing.Color.Transparent;
            this.rdoPapel.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoPapel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rdoPapel.Location = new System.Drawing.Point(406, 268);
            this.rdoPapel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoPapel.Name = "rdoPapel";
            this.rdoPapel.Size = new System.Drawing.Size(124, 34);
            this.rdoPapel.TabIndex = 1;
            this.rdoPapel.TabStop = true;
            this.rdoPapel.Text = "PAPEL";
            this.rdoPapel.UseVisualStyleBackColor = false;
            // 
            // rdoTesoura
            // 
            this.rdoTesoura.AutoSize = true;
            this.rdoTesoura.BackColor = System.Drawing.Color.Transparent;
            this.rdoTesoura.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoTesoura.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rdoTesoura.Location = new System.Drawing.Point(549, 268);
            this.rdoTesoura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoTesoura.Name = "rdoTesoura";
            this.rdoTesoura.Size = new System.Drawing.Size(160, 34);
            this.rdoTesoura.TabIndex = 2;
            this.rdoTesoura.TabStop = true;
            this.rdoTesoura.Text = "TESOURA";
            this.rdoTesoura.UseVisualStyleBackColor = false;
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLancar.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLancar.ForeColor = System.Drawing.Color.Yellow;
            this.btnLancar.Location = new System.Drawing.Point(383, 362);
            this.btnLancar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(168, 60);
            this.btnLancar.TabIndex = 3;
            this.btnLancar.Text = "LANÇAR";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // fechar1
            // 
            this.fechar1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.fechar1.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fechar1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fechar1.Location = new System.Drawing.Point(764, 531);
            this.fechar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fechar1.Name = "fechar1";
            this.fechar1.Size = new System.Drawing.Size(111, 53);
            this.fechar1.TabIndex = 5;
            this.fechar1.Text = "FECHAR";
            this.fechar1.UseVisualStyleBackColor = false;
            this.fechar1.Click += new System.EventHandler(this.fechar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(29, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pontuação Player";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(645, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pontuação PC";
            // 
            // txtPontoPC
            // 
            this.txtPontoPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPontoPC.Location = new System.Drawing.Point(694, 475);
            this.txtPontoPC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPontoPC.Name = "txtPontoPC";
            this.txtPontoPC.Size = new System.Drawing.Size(114, 30);
            this.txtPontoPC.TabIndex = 9;
            this.txtPontoPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPontoPlayer
            // 
            this.txtPontoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPontoPlayer.Location = new System.Drawing.Point(118, 475);
            this.txtPontoPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPontoPlayer.Name = "txtPontoPlayer";
            this.txtPontoPlayer.Size = new System.Drawing.Size(114, 30);
            this.txtPontoPlayer.TabIndex = 8;
            this.txtPontoPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPontoEmpate
            // 
            this.txtPontoEmpate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPontoEmpate.Location = new System.Drawing.Point(406, 509);
            this.txtPontoEmpate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPontoEmpate.Name = "txtPontoEmpate";
            this.txtPontoEmpate.Size = new System.Drawing.Size(114, 30);
            this.txtPontoEmpate.TabIndex = 12;
            this.txtPontoEmpate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPontoEmpate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(324, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pontuação Empate";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(262, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 222);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(169, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(574, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cauã Rasquinho - N° 07  William Cellegin - N°31";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPontoEmpate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPontoPC);
            this.Controls.Add(this.txtPontoPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechar1);
            this.Controls.Add(this.btnLancar);
            this.Controls.Add(this.rdoTesoura);
            this.Controls.Add(this.rdoPapel);
            this.Controls.Add(this.rdoPedra);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdoPedra;
        private RadioButton rdoPapel;
        private RadioButton rdoTesoura;
        private Button btnLancar;
        private Button fechar1;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox txtPontoPC;
        public TextBox txtPontoPlayer;
        public TextBox txtPontoEmpate;
        private PictureBox pictureBox1;
        private Label label4;
    }
}