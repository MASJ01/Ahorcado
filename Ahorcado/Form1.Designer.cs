namespace Ahorcado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl = new System.Windows.Forms.Label();
            this.fichas_abecedario1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fl_palabras = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BTN_INICIAR = new System.Windows.Forms.PictureBox();
            this.pic_ahorcado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_MENSAJE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_VIDAS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_INICIAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ahorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Lime;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(238, 85);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(151, 20);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Adivina la palabra";
            // 
            // fichas_abecedario1
            // 
            this.fichas_abecedario1.BackColor = System.Drawing.Color.Red;
            this.fichas_abecedario1.Location = new System.Drawing.Point(93, 108);
            this.fichas_abecedario1.Name = "fichas_abecedario1";
            this.fichas_abecedario1.Size = new System.Drawing.Size(467, 281);
            this.fichas_abecedario1.TabIndex = 2;
            // 
            // fl_palabras
            // 
            this.fl_palabras.BackgroundImage = global::Ahorcado.Properties.Resources.kratos;
            this.fl_palabras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fl_palabras.Location = new System.Drawing.Point(144, 395);
            this.fl_palabras.Name = "fl_palabras";
            this.fl_palabras.Size = new System.Drawing.Size(939, 167);
            this.fl_palabras.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ahorcado.Properties.Resources.God_of_War;
            this.pictureBox2.Location = new System.Drawing.Point(12, 349);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // BTN_INICIAR
            // 
            this.BTN_INICIAR.BackgroundImage = global::Ahorcado.Properties.Resources.jugar;
            this.BTN_INICIAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_INICIAR.Image = global::Ahorcado.Properties.Resources.jugar;
            this.BTN_INICIAR.Location = new System.Drawing.Point(12, 12);
            this.BTN_INICIAR.Name = "BTN_INICIAR";
            this.BTN_INICIAR.Size = new System.Drawing.Size(467, 50);
            this.BTN_INICIAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTN_INICIAR.TabIndex = 0;
            this.BTN_INICIAR.TabStop = false;
            this.BTN_INICIAR.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pic_ahorcado
            // 
            this.pic_ahorcado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_ahorcado.Location = new System.Drawing.Point(649, 108);
            this.pic_ahorcado.Name = "pic_ahorcado";
            this.pic_ahorcado.Size = new System.Drawing.Size(231, 190);
            this.pic_ahorcado.TabIndex = 4;
            this.pic_ahorcado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "PUNTUACION:";
            // 
            // LBL_MENSAJE
            // 
            this.LBL_MENSAJE.AutoSize = true;
            this.LBL_MENSAJE.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MENSAJE.Location = new System.Drawing.Point(413, 203);
            this.LBL_MENSAJE.Name = "LBL_MENSAJE";
            this.LBL_MENSAJE.Size = new System.Drawing.Size(372, 73);
            this.LBL_MENSAJE.TabIndex = 6;
            this.LBL_MENSAJE.Text = "Game Over";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Fuchsia;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(831, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "VIDAS ";
            // 
            // TXT_VIDAS
            // 
            this.TXT_VIDAS.Location = new System.Drawing.Point(911, 26);
            this.TXT_VIDAS.Name = "TXT_VIDAS";
            this.TXT_VIDAS.Size = new System.Drawing.Size(114, 20);
            this.TXT_VIDAS.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ahorcado.Properties.Resources.God_of_War1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 563);
            this.Controls.Add(this.TXT_VIDAS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL_MENSAJE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_ahorcado);
            this.Controls.Add(this.fl_palabras);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.fichas_abecedario1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.BTN_INICIAR);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_INICIAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ahorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BTN_INICIAR;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.FlowLayoutPanel fichas_abecedario1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel fl_palabras;
        private System.Windows.Forms.PictureBox pic_ahorcado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_MENSAJE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_VIDAS;
    }
}

