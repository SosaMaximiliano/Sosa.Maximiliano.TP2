namespace FrmPrincipal
{
    partial class FrmPartida
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnCancelarPartida = new System.Windows.Forms.Button();
            this.lblNombreJ1 = new System.Windows.Forms.Label();
            this.lblNombreJ2 = new System.Windows.Forms.Label();
            this.lblMano = new System.Windows.Forms.Label();
            this.lblPuntosJ1 = new System.Windows.Forms.Label();
            this.lblPuntosJ2 = new System.Windows.Forms.Label();
            this.lblGanador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(31, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(181, 306);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(318, 131);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(181, 306);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // btnCancelarPartida
            // 
            this.btnCancelarPartida.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelarPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarPartida.CausesValidation = false;
            this.btnCancelarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarPartida.Font = new System.Drawing.Font("Book Antiqua", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarPartida.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelarPartida.Location = new System.Drawing.Point(430, 15);
            this.btnCancelarPartida.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelarPartida.Name = "btnCancelarPartida";
            this.btnCancelarPartida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelarPartida.Size = new System.Drawing.Size(70, 70);
            this.btnCancelarPartida.TabIndex = 2;
            this.btnCancelarPartida.Text = "X";
            this.btnCancelarPartida.UseVisualStyleBackColor = false;
            this.btnCancelarPartida.Click += new System.EventHandler(this.btnCancelarPartida_Click);
            // 
            // lblNombreJ1
            // 
            this.lblNombreJ1.AutoSize = true;
            this.lblNombreJ1.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreJ1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreJ1.ForeColor = System.Drawing.Color.PowderBlue;
            this.lblNombreJ1.Location = new System.Drawing.Point(31, 96);
            this.lblNombreJ1.Name = "lblNombreJ1";
            this.lblNombreJ1.Size = new System.Drawing.Size(114, 29);
            this.lblNombreJ1.TabIndex = 3;
            this.lblNombreJ1.Text = "Jugador 1";
            // 
            // lblNombreJ2
            // 
            this.lblNombreJ2.AutoSize = true;
            this.lblNombreJ2.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreJ2.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreJ2.ForeColor = System.Drawing.Color.PowderBlue;
            this.lblNombreJ2.Location = new System.Drawing.Point(318, 96);
            this.lblNombreJ2.Name = "lblNombreJ2";
            this.lblNombreJ2.Size = new System.Drawing.Size(118, 29);
            this.lblNombreJ2.TabIndex = 4;
            this.lblNombreJ2.Text = "Jugador 2";
            // 
            // lblMano
            // 
            this.lblMano.AutoSize = true;
            this.lblMano.BackColor = System.Drawing.Color.Transparent;
            this.lblMano.Font = new System.Drawing.Font("Bahnschrift", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMano.ForeColor = System.Drawing.Color.PowderBlue;
            this.lblMano.Location = new System.Drawing.Point(31, 37);
            this.lblMano.Name = "lblMano";
            this.lblMano.Size = new System.Drawing.Size(139, 48);
            this.lblMano.TabIndex = 5;
            this.lblMano.Text = "MANO:";
            this.lblMano.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPuntosJ1
            // 
            this.lblPuntosJ1.AutoSize = true;
            this.lblPuntosJ1.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntosJ1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPuntosJ1.ForeColor = System.Drawing.Color.PowderBlue;
            this.lblPuntosJ1.Location = new System.Drawing.Point(174, 96);
            this.lblPuntosJ1.Name = "lblPuntosJ1";
            this.lblPuntosJ1.Size = new System.Drawing.Size(26, 29);
            this.lblPuntosJ1.TabIndex = 6;
            this.lblPuntosJ1.Text = "0";
            // 
            // lblPuntosJ2
            // 
            this.lblPuntosJ2.AutoSize = true;
            this.lblPuntosJ2.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntosJ2.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPuntosJ2.ForeColor = System.Drawing.Color.PowderBlue;
            this.lblPuntosJ2.Location = new System.Drawing.Point(462, 96);
            this.lblPuntosJ2.Name = "lblPuntosJ2";
            this.lblPuntosJ2.Size = new System.Drawing.Size(26, 29);
            this.lblPuntosJ2.TabIndex = 7;
            this.lblPuntosJ2.Text = "0";
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGanador.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGanador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGanador.Location = new System.Drawing.Point(31, 15);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(0, 65);
            this.lblGanador.TabIndex = 8;
            // 
            // FrmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.pañoAzul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 467);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.lblPuntosJ2);
            this.Controls.Add(this.lblPuntosJ1);
            this.Controls.Add(this.lblMano);
            this.Controls.Add(this.lblNombreJ2);
            this.Controls.Add(this.lblNombreJ1);
            this.Controls.Add(this.btnCancelarPartida);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FrmPartida";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPartida_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button btnCancelarPartida;
        private Label lblNombreJ1;
        private Label lblNombreJ2;
        private Label lblMano;
        private Label lblPuntosJ1;
        private Label lblPuntosJ2;
        private Label lblGanador;
    }
}