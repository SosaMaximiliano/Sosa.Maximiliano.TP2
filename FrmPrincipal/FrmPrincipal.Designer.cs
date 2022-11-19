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
            this.idSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreJugador1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreJugador2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ganador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIniciarJuego = new System.Windows.Forms.Button();
            this.numeroSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugador1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdbRojo = new System.Windows.Forms.RadioButton();
            this.rdbVerde = new System.Windows.Forms.RadioButton();
            this.rdbAzul = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalas)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.idSalaDataGridViewTextBoxColumn,
            this.NombreJugador1,
            this.NombreJugador2,
            this.Ganador,
            this.manoDataGridViewTextBoxColumn});
            this.dgSalas.DataSource = this.salaBindingSource;
            this.dgSalas.Location = new System.Drawing.Point(187, 25);
            this.dgSalas.Name = "dgSalas";
            this.dgSalas.ReadOnly = true;
            this.dgSalas.RowTemplate.Height = 25;
            this.dgSalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSalas.Size = new System.Drawing.Size(543, 371);
            this.dgSalas.TabIndex = 1;
            this.dgSalas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSalas_CellDoubleClick);
            // 
            // idSalaDataGridViewTextBoxColumn
            // 
            this.idSalaDataGridViewTextBoxColumn.DataPropertyName = "IdSala";
            this.idSalaDataGridViewTextBoxColumn.HeaderText = "IdSala";
            this.idSalaDataGridViewTextBoxColumn.Name = "idSalaDataGridViewTextBoxColumn";
            this.idSalaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NombreJugador1
            // 
            this.NombreJugador1.DataPropertyName = "NombreJugador1";
            this.NombreJugador1.HeaderText = "Jugador 1";
            this.NombreJugador1.Name = "NombreJugador1";
            this.NombreJugador1.ReadOnly = true;
            // 
            // NombreJugador2
            // 
            this.NombreJugador2.DataPropertyName = "NombreJugador2";
            this.NombreJugador2.HeaderText = "Jugador 2";
            this.NombreJugador2.Name = "NombreJugador2";
            this.NombreJugador2.ReadOnly = true;
            // 
            // Ganador
            // 
            this.Ganador.DataPropertyName = "Ganador";
            this.Ganador.HeaderText = "Ganador";
            this.Ganador.Name = "Ganador";
            this.Ganador.ReadOnly = true;
            // 
            // manoDataGridViewTextBoxColumn
            // 
            this.manoDataGridViewTextBoxColumn.DataPropertyName = "Mano";
            this.manoDataGridViewTextBoxColumn.HeaderText = "Manos";
            this.manoDataGridViewTextBoxColumn.Name = "manoDataGridViewTextBoxColumn";
            this.manoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.BackgroundImage = global::Vista.Properties.Resources.Dice2;
            this.btnIniciarJuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarJuego.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarJuego.Location = new System.Drawing.Point(32, 43);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(56, 56);
            this.btnIniciarJuego.TabIndex = 2;
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
            // jugador1DataGridViewTextBoxColumn
            // 
            this.jugador1DataGridViewTextBoxColumn.DataPropertyName = "Jugador1";
            this.jugador1DataGridViewTextBoxColumn.HeaderText = "Jugador1";
            this.jugador1DataGridViewTextBoxColumn.Name = "jugador1DataGridViewTextBoxColumn";
            // 
            // rdbRojo
            // 
            this.rdbRojo.AutoSize = true;
            this.rdbRojo.Location = new System.Drawing.Point(6, 19);
            this.rdbRojo.Name = "rdbRojo";
            this.rdbRojo.Size = new System.Drawing.Size(76, 19);
            this.rdbRojo.TabIndex = 3;
            this.rdbRojo.TabStop = true;
            this.rdbRojo.Text = "Paño rojo";
            this.rdbRojo.UseVisualStyleBackColor = true;
            this.rdbRojo.Click += new System.EventHandler(this.rdbRojo_Click);
            // 
            // rdbVerde
            // 
            this.rdbVerde.AutoSize = true;
            this.rdbVerde.Location = new System.Drawing.Point(6, 47);
            this.rdbVerde.Name = "rdbVerde";
            this.rdbVerde.Size = new System.Drawing.Size(84, 19);
            this.rdbVerde.TabIndex = 4;
            this.rdbVerde.TabStop = true;
            this.rdbVerde.Text = "Paño verde";
            this.rdbVerde.UseVisualStyleBackColor = true;
            this.rdbVerde.Click += new System.EventHandler(this.rdbVerde_Click);
            // 
            // rdbAzul
            // 
            this.rdbAzul.AutoSize = true;
            this.rdbAzul.Location = new System.Drawing.Point(6, 75);
            this.rdbAzul.Name = "rdbAzul";
            this.rdbAzul.Size = new System.Drawing.Size(76, 19);
            this.rdbAzul.TabIndex = 5;
            this.rdbAzul.TabStop = true;
            this.rdbAzul.Text = "Paño azul";
            this.rdbAzul.UseVisualStyleBackColor = true;
            this.rdbAzul.Click += new System.EventHandler(this.rdbAzul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAzul);
            this.groupBox1.Controls.Add(this.rdbRojo);
            this.groupBox1.Controls.Add(this.rdbVerde);
            this.groupBox1.Location = new System.Drawing.Point(32, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "CREAR PARTIDA";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIniciarJuego);
            this.Controls.Add(this.dgSalas);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TORNEO DE GENERALA";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource salaBindingSource;
        private DataGridView dgSalas;
        private Button btnIniciarJuego;
        private DataGridViewTextBoxColumn numeroSalaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jugador1DataGridViewTextBoxColumn;
        private RadioButton rdbRojo;
        private RadioButton rdbVerde;
        private RadioButton rdbAzul;
        private GroupBox groupBox1;
        private Label label1;
        private DataGridViewTextBoxColumn numeroSalaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idSalaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NombreJugador1;
        private DataGridViewTextBoxColumn NombreJugador2;
        private DataGridViewTextBoxColumn Ganador;
        private DataGridViewTextBoxColumn manoDataGridViewTextBoxColumn;
    }
}