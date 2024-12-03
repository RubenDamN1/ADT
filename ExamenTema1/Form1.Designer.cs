namespace ExamenTema1
{
    partial class FormularioJuegos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btJuegos = new System.Windows.Forms.Button();
            this.tbJuegos = new System.Windows.Forms.TextBox();
            this.lvFaciles = new System.Windows.Forms.ListView();
            this.colTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDificultad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPuntuacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMedios = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDificiles = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbPuntuacionMinima = new System.Windows.Forms.NumericUpDown();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btAniadirCarrito = new System.Windows.Forms.Button();
            this.lvCarrito = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTotal = new System.Windows.Forms.Label();
            this.btExportar = new System.Windows.Forms.Button();
            this.lbFaciles = new System.Windows.Forms.Label();
            this.lbMedios = new System.Windows.Forms.Label();
            this.lbDificiles = new System.Windows.Forms.Label();
            this.tbLista = new System.Windows.Forms.TextBox();
            this.btImportarLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbPuntuacionMinima)).BeginInit();
            this.SuspendLayout();
            // 
            // btJuegos
            // 
            this.btJuegos.Location = new System.Drawing.Point(175, 27);
            this.btJuegos.Name = "btJuegos";
            this.btJuegos.Size = new System.Drawing.Size(116, 23);
            this.btJuegos.TabIndex = 0;
            this.btJuegos.Text = "Cargar juegos";
            this.btJuegos.UseVisualStyleBackColor = true;
            // 
            // tbJuegos
            // 
            this.tbJuegos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJuegos.Location = new System.Drawing.Point(314, 29);
            this.tbJuegos.Name = "tbJuegos";
            this.tbJuegos.Size = new System.Drawing.Size(438, 20);
            this.tbJuegos.TabIndex = 1;
            // 
            // lvFaciles
            // 
            this.lvFaciles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvFaciles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitulo,
            this.colDificultad,
            this.colPuntuacion,
            this.colPrecio});
            this.lvFaciles.FullRowSelect = true;
            this.lvFaciles.GridLines = true;
            this.lvFaciles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFaciles.HideSelection = false;
            this.lvFaciles.Location = new System.Drawing.Point(13, 87);
            this.lvFaciles.Margin = new System.Windows.Forms.Padding(4);
            this.lvFaciles.Name = "lvFaciles";
            this.lvFaciles.Size = new System.Drawing.Size(340, 234);
            this.lvFaciles.TabIndex = 7;
            this.lvFaciles.UseCompatibleStateImageBehavior = false;
            this.lvFaciles.View = System.Windows.Forms.View.Details;
            // 
            // colTitulo
            // 
            this.colTitulo.Text = "Título";
            this.colTitulo.Width = 150;
            // 
            // colDificultad
            // 
            this.colDificultad.Text = "Dificultad";
            // 
            // colPuntuacion
            // 
            this.colPuntuacion.Text = "Puntuación";
            this.colPuntuacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPuntuacion.Width = 70;
            // 
            // colPrecio
            // 
            this.colPrecio.Text = "Precio";
            // 
            // lvMedios
            // 
            this.lvMedios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMedios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMedios.FullRowSelect = true;
            this.lvMedios.GridLines = true;
            this.lvMedios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMedios.HideSelection = false;
            this.lvMedios.Location = new System.Drawing.Point(361, 87);
            this.lvMedios.Margin = new System.Windows.Forms.Padding(4);
            this.lvMedios.Name = "lvMedios";
            this.lvMedios.Size = new System.Drawing.Size(340, 234);
            this.lvMedios.TabIndex = 8;
            this.lvMedios.UseCompatibleStateImageBehavior = false;
            this.lvMedios.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Título";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dificultad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Puntuación";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            // 
            // lvDificiles
            // 
            this.lvDificiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDificiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvDificiles.FullRowSelect = true;
            this.lvDificiles.GridLines = true;
            this.lvDificiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDificiles.HideSelection = false;
            this.lvDificiles.Location = new System.Drawing.Point(709, 87);
            this.lvDificiles.Margin = new System.Windows.Forms.Padding(4);
            this.lvDificiles.Name = "lvDificiles";
            this.lvDificiles.Size = new System.Drawing.Size(340, 234);
            this.lvDificiles.TabIndex = 9;
            this.lvDificiles.UseCompatibleStateImageBehavior = false;
            this.lvDificiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Título";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Dificultad";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Puntuación";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Precio";
            // 
            // tbPuntuacionMinima
            // 
            this.tbPuntuacionMinima.Location = new System.Drawing.Point(776, 29);
            this.tbPuntuacionMinima.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbPuntuacionMinima.Name = "tbPuntuacionMinima";
            this.tbPuntuacionMinima.Size = new System.Drawing.Size(49, 20);
            this.tbPuntuacionMinima.TabIndex = 10;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(552, 328);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 11;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            // 
            // btAniadirCarrito
            // 
            this.btAniadirCarrito.Location = new System.Drawing.Point(426, 328);
            this.btAniadirCarrito.Name = "btAniadirCarrito";
            this.btAniadirCarrito.Size = new System.Drawing.Size(105, 23);
            this.btAniadirCarrito.TabIndex = 12;
            this.btAniadirCarrito.Text = "Añadir al carrito";
            this.btAniadirCarrito.UseVisualStyleBackColor = true;
            // 
            // lvCarrito
            // 
            this.lvCarrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCarrito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvCarrito.FullRowSelect = true;
            this.lvCarrito.GridLines = true;
            this.lvCarrito.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCarrito.HideSelection = false;
            this.lvCarrito.Location = new System.Drawing.Point(361, 405);
            this.lvCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.lvCarrito.MultiSelect = false;
            this.lvCarrito.Name = "lvCarrito";
            this.lvCarrito.Size = new System.Drawing.Size(340, 201);
            this.lvCarrito.TabIndex = 13;
            this.lvCarrito.UseCompatibleStateImageBehavior = false;
            this.lvCarrito.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Título";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Dificultad";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Puntuación";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 70;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Precio";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(459, 622);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(72, 25);
            this.lbTotal.TabIndex = 14;
            this.lbTotal.Text = "Total:";
            // 
            // btExportar
            // 
            this.btExportar.Location = new System.Drawing.Point(481, 659);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(107, 23);
            this.btExportar.TabIndex = 15;
            this.btExportar.Text = "Exportar lista";
            this.btExportar.UseVisualStyleBackColor = true;
            // 
            // lbFaciles
            // 
            this.lbFaciles.AutoSize = true;
            this.lbFaciles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFaciles.Location = new System.Drawing.Point(9, 63);
            this.lbFaciles.Name = "lbFaciles";
            this.lbFaciles.Size = new System.Drawing.Size(66, 20);
            this.lbFaciles.TabIndex = 16;
            this.lbFaciles.Text = "Fáciles";
            // 
            // lbMedios
            // 
            this.lbMedios.AutoSize = true;
            this.lbMedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedios.Location = new System.Drawing.Point(357, 63);
            this.lbMedios.Name = "lbMedios";
            this.lbMedios.Size = new System.Drawing.Size(138, 20);
            this.lbMedios.TabIndex = 17;
            this.lbMedios.Text = "Dificultad media";
            // 
            // lbDificiles
            // 
            this.lbDificiles.AutoSize = true;
            this.lbDificiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDificiles.Location = new System.Drawing.Point(705, 63);
            this.lbDificiles.Name = "lbDificiles";
            this.lbDificiles.Size = new System.Drawing.Size(72, 20);
            this.lbDificiles.TabIndex = 18;
            this.lbDificiles.Text = "Difíciles";
            // 
            // tbLista
            // 
            this.tbLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLista.Location = new System.Drawing.Point(387, 369);
            this.tbLista.Name = "tbLista";
            this.tbLista.Size = new System.Drawing.Size(409, 20);
            this.tbLista.TabIndex = 20;
            // 
            // btImportarLista
            // 
            this.btImportarLista.Location = new System.Drawing.Point(248, 367);
            this.btImportarLista.Name = "btImportarLista";
            this.btImportarLista.Size = new System.Drawing.Size(116, 23);
            this.btImportarLista.TabIndex = 19;
            this.btImportarLista.Text = "Importar lista";
            this.btImportarLista.UseVisualStyleBackColor = true;
            // 
            // FormularioJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 695);
            this.Controls.Add(this.tbLista);
            this.Controls.Add(this.btImportarLista);
            this.Controls.Add(this.lbDificiles);
            this.Controls.Add(this.lbMedios);
            this.Controls.Add(this.lbFaciles);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lvCarrito);
            this.Controls.Add(this.btAniadirCarrito);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.tbPuntuacionMinima);
            this.Controls.Add(this.lvDificiles);
            this.Controls.Add(this.lvMedios);
            this.Controls.Add(this.lvFaciles);
            this.Controls.Add(this.tbJuegos);
            this.Controls.Add(this.btJuegos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormularioJuegos";
            this.Text = "Selección de juegos de mesa";
            ((System.ComponentModel.ISupportInitialize)(this.tbPuntuacionMinima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btJuegos;
        private System.Windows.Forms.TextBox tbJuegos;
        private System.Windows.Forms.ListView lvFaciles;
        private System.Windows.Forms.ColumnHeader colTitulo;
        private System.Windows.Forms.ColumnHeader colDificultad;
        private System.Windows.Forms.ColumnHeader colPuntuacion;
        private System.Windows.Forms.ColumnHeader colPrecio;
        private System.Windows.Forms.ListView lvMedios;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvDificiles;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.NumericUpDown tbPuntuacionMinima;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btAniadirCarrito;
        private System.Windows.Forms.ListView lvCarrito;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.Label lbFaciles;
        private System.Windows.Forms.Label lbMedios;
        private System.Windows.Forms.Label lbDificiles;
        private System.Windows.Forms.TextBox tbLista;
        private System.Windows.Forms.Button btImportarLista;
    }
}

