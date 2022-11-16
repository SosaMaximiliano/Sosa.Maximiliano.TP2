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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartida));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNombreJ1 = new System.Windows.Forms.Label();
            this.lblNombreJ2 = new System.Windows.Forms.Label();
            this.lblMano = new System.Windows.Forms.Label();
            this.lblPuntosJ1 = new System.Windows.Forms.Label();
            this.lblPuntosJ2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(181, 276);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(318, 131);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(181, 276);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(430, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // FrmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 449);
            this.Controls.Add(this.lblPuntosJ2);
            this.Controls.Add(this.lblPuntosJ1);
            this.Controls.Add(this.lblMano);
            this.Controls.Add(this.lblNombreJ2);
            this.Controls.Add(this.lblNombreJ1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FrmPartida";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
        private Label lblNombreJ1;
        private Label lblNombreJ2;
        private Label lblMano;
        private Label lblPuntosJ1;
        private Label lblPuntosJ2;
    }
}