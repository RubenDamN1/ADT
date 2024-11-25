namespace EjercicioADT1_1
{
    partial class Form1
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
            gbArchivo = new GroupBox();
            tbNombre = new TextBox();
            tbRuta = new TextBox();
            lbNombre = new Label();
            lbRuta = new Label();
            lbFrase = new Label();
            btGrabar = new Button();
            btLimpiar = new Button();
            btFinalizar = new Button();
            tbFrase = new TextBox();
            gbArchivo.SuspendLayout();
            SuspendLayout();
            // 
            // gbArchivo
            // 
            gbArchivo.Controls.Add(tbNombre);
            gbArchivo.Controls.Add(tbRuta);
            gbArchivo.Controls.Add(lbNombre);
            gbArchivo.Controls.Add(lbRuta);
            gbArchivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbArchivo.Location = new Point(81, 36);
            gbArchivo.Name = "gbArchivo";
            gbArchivo.Size = new Size(663, 158);
            gbArchivo.TabIndex = 0;
            gbArchivo.TabStop = false;
            gbArchivo.Text = "Archivo de Datos";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(186, 95);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(362, 23);
            tbNombre.TabIndex = 3;
            // 
            // tbRuta
            // 
            tbRuta.Location = new Point(186, 40);
            tbRuta.Name = "tbRuta";
            tbRuta.Size = new Size(362, 23);
            tbRuta.TabIndex = 2;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(34, 103);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(116, 15);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Nombre del fichero";
            lbNombre.Click += label2_Click;
            // 
            // lbRuta
            // 
            lbRuta.AutoSize = true;
            lbRuta.Location = new Point(34, 40);
            lbRuta.Name = "lbRuta";
            lbRuta.Size = new Size(99, 15);
            lbRuta.TabIndex = 0;
            lbRuta.Text = " Ruta del fichero";
            // 
            // lbFrase
            // 
            lbFrase.AutoSize = true;
            lbFrase.Location = new Point(120, 303);
            lbFrase.Name = "lbFrase";
            lbFrase.Size = new Size(34, 15);
            lbFrase.TabIndex = 1;
            lbFrase.Text = "Frase";
            // 
            // btGrabar
            // 
            btGrabar.Location = new Point(120, 383);
            btGrabar.Name = "btGrabar";
            btGrabar.Size = new Size(75, 23);
            btGrabar.TabIndex = 2;
            btGrabar.Text = "Grabar";
            btGrabar.UseVisualStyleBackColor = true;
            btGrabar.Click += btGrabar_Click;
            // 
            // btLimpiar
            // 
            btLimpiar.Location = new Point(362, 383);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(75, 23);
            btLimpiar.TabIndex = 3;
            btLimpiar.Text = "Limpiar";
            btLimpiar.UseVisualStyleBackColor = true;
            btLimpiar.Click += btLimpiar_Click;
            // 
            // btFinalizar
            // 
            btFinalizar.Location = new Point(652, 383);
            btFinalizar.Name = "btFinalizar";
            btFinalizar.Size = new Size(75, 23);
            btFinalizar.TabIndex = 4;
            btFinalizar.Text = "Finalizar";
            btFinalizar.UseVisualStyleBackColor = true;
            btFinalizar.Click += btFinalizar_Click;
            // 
            // tbFrase
            // 
            tbFrase.Location = new Point(207, 295);
            tbFrase.Name = "tbFrase";
            tbFrase.Size = new Size(422, 23);
            tbFrase.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbFrase);
            Controls.Add(btFinalizar);
            Controls.Add(btLimpiar);
            Controls.Add(btGrabar);
            Controls.Add(lbFrase);
            Controls.Add(gbArchivo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ejemplo de grabacion de ficheros";
            gbArchivo.ResumeLayout(false);
            gbArchivo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbArchivo;
        private TextBox tbNombre;
        private TextBox tbRuta;
        private Label lbNombre;
        private Label lbRuta;
        private Label lbFrase;
        private Button btGrabar;
        private Button btLimpiar;
        private Button btFinalizar;
        private TextBox tbFrase;
    }
}
