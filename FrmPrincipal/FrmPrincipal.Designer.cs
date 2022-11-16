namespace FrmPrincipal
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.salaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgSalas = new System.Windows.Forms.DataGridView();
            this.btnIniciarJuego = new System.Windows.Forms.Button();
            this.numeroSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreJugador1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreJugador2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugador1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugador2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // salaBindingSource
            // 
            this.salaBindingSource.DataSource = typeof(Entidades.Sala);
            // 
            // dgSalas
            // 
            this.dgSalas.AutoGenerateColumns = false;
            this.dgSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroSalaDataGridViewTextBoxColumn,
            this.nombreJugador1DataGridViewTextBoxColumn,
            this.nombreJugador2DataGridViewTextBoxColumn,
            this.ganadorDataGridViewTextBoxColumn,
            this.jugador1DataGridViewTextBoxColumn,
            this.jugador2DataGridViewTextBoxColumn});
            this.dgSalas.DataSource = this.salaBindingSource;
            this.dgSalas.Location = new System.Drawing.Point(93, 25);
            this.dgSalas.Name = "dgSalas";
            this.dgSalas.RowTemplate.Height = 25;
            this.dgSalas.Size = new System.Drawing.Size(574, 371);
            this.dgSalas.TabIndex = 1;
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.Location = new System.Drawing.Point(12, 25);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(75, 66);
            this.btnIniciarJuego.TabIndex = 2;
            this.btnIniciarJuego.Text = "Iniciar Juego";
            this.btnIniciarJuego.UseVisualStyleBackColor = true;
            this.btnIniciarJuego.Click += new System.EventHandler(this.btnIniciarJuego_Click);
            // 
            // numeroSalaDataGridViewTextBoxColumn
            // 
            this.numeroSalaDataGridViewTextBoxColumn.DataPropertyName = "NumeroSala";
            this.numeroSalaDataGridViewTextBoxColumn.HeaderText = "NumeroSala";
            this.numeroSalaDataGridViewTextBoxColumn.Name = "numeroSalaDataGridViewTextBoxColumn";
            this.numeroSalaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreJugador1DataGridViewTextBoxColumn
            // 
            this.nombreJugador1DataGridViewTextBoxColumn.DataPropertyName = "NombreJugador1";
            this.nombreJugador1DataGridViewTextBoxColumn.HeaderText = "NombreJugador1";
            this.nombreJugador1DataGridViewTextBoxColumn.Name = "nombreJugador1DataGridViewTextBoxColumn";
            this.nombreJugador1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreJugador2DataGridViewTextBoxColumn
            // 
            this.nombreJugador2DataGridViewTextBoxColumn.DataPropertyName = "NombreJugador2";
            this.nombreJugador2DataGridViewTextBoxColumn.HeaderText = "NombreJugador2";
            this.nombreJugador2DataGridViewTextBoxColumn.Name = "nombreJugador2DataGridViewTextBoxColumn";
            this.nombreJugador2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ganadorDataGridViewTextBoxColumn
            // 
            this.ganadorDataGridViewTextBoxColumn.DataPropertyName = "Ganador";
            this.ganadorDataGridViewTextBoxColumn.HeaderText = "Ganador";
            this.ganadorDataGridViewTextBoxColumn.Name = "ganadorDataGridViewTextBoxColumn";
            // 
            // jugador1DataGridViewTextBoxColumn
            // 
            this.jugador1DataGridViewTextBoxColumn.DataPropertyName = "Jugador1";
            this.jugador1DataGridViewTextBoxColumn.HeaderText = "Jugador1";
            this.jugador1DataGridViewTextBoxColumn.Name = "jugador1DataGridViewTextBoxColumn";
            // 
            // jugador2DataGridViewTextBoxColumn
            // 
            this.jugador2DataGridViewTextBoxColumn.DataPropertyName = "Jugador2";
            this.jugador2DataGridViewTextBoxColumn.HeaderText = "Jugador2";
            this.jugador2DataGridViewTextBoxColumn.Name = "jugador2DataGridViewTextBoxColumn";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.btnIniciarJuego);
            this.Controls.Add(this.dgSalas);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource salaBindingSource;
        private DataGridView dgSalas;
        private Button btnIniciarJuego;
        private DataGridViewTextBoxColumn numeroSalaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreJugador1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreJugador2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ganadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jugador1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jugador2DataGridViewTextBoxColumn;
    }
}