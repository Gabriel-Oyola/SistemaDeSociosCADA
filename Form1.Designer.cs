
namespace SistemaDeSociosCADA
{
    partial class FrmSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSocios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNacimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCarnet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPlatea = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.dgSocios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistemas de socios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(262, 133);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(122, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(390, 133);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(122, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido:";
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.Location = new System.Drawing.Point(518, 133);
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(122, 20);
            this.txtNacimiento.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "F de nacimiento:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(646, 133);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(60, 20);
            this.txtEdad.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(643, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Edad:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(262, 189);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(122, 20);
            this.txtDocumento.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Documento:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(390, 189);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(316, 20);
            this.txtDomicilio.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Domicilio:";
            // 
            // cbCarnet
            // 
            this.cbCarnet.FormattingEnabled = true;
            this.cbCarnet.Location = new System.Drawing.Point(263, 246);
            this.cbCarnet.Name = "cbCarnet";
            this.cbCarnet.Size = new System.Drawing.Size(121, 21);
            this.cbCarnet.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(266, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Carnet:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(393, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Platea:";
            // 
            // cbPlatea
            // 
            this.cbPlatea.FormattingEnabled = true;
            this.cbPlatea.Location = new System.Drawing.Point(390, 246);
            this.cbPlatea.Name = "cbPlatea";
            this.cbPlatea.Size = new System.Drawing.Size(121, 21);
            this.cbPlatea.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(522, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(519, 246);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 18;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(596, 70);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(122, 20);
            this.txtBuscar.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(595, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Buscar:";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(724, 68);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 22;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(646, 244);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 23;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(727, 244);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 24;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // dgSocios
            // 
            this.dgSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSocios.Location = new System.Drawing.Point(12, 272);
            this.dgSocios.Name = "dgSocios";
            this.dgSocios.Size = new System.Drawing.Size(790, 210);
            this.dgSocios.TabIndex = 25;
            // 
            // FrmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(811, 487);
            this.Controls.Add(this.dgSocios);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbPlatea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbCarnet);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSocios";
            this.Text = "SOCIOS";
            this.Load += new System.EventHandler(this.FrmSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCarnet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPlatea;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.DataGridView dgSocios;
    }
}

