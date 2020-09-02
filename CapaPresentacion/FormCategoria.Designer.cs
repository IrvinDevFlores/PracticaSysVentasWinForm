namespace CapaPresentacion
{
    partial class FormCategoria
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriasControl = new System.Windows.Forms.TabControl();
            this.TabListaCategorias = new System.Windows.Forms.TabPage();
            this.TabMantenimientoCategorias = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoriaBuscada = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dataListadoCategorias = new System.Windows.Forms.DataGridView();
            this.checkEliminar = new System.Windows.Forms.CheckBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.CategoriasControl.SuspendLayout();
            this.TabListaCategorias.SuspendLayout();
            this.TabMantenimientoCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam CLM", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorias";
            // 
            // CategoriasControl
            // 
            this.CategoriasControl.Controls.Add(this.TabListaCategorias);
            this.CategoriasControl.Controls.Add(this.TabMantenimientoCategorias);
            this.CategoriasControl.Location = new System.Drawing.Point(12, 53);
            this.CategoriasControl.Name = "CategoriasControl";
            this.CategoriasControl.SelectedIndex = 0;
            this.CategoriasControl.Size = new System.Drawing.Size(563, 332);
            this.CategoriasControl.TabIndex = 1;
            // 
            // TabListaCategorias
            // 
            this.TabListaCategorias.Controls.Add(this.labelTotal);
            this.TabListaCategorias.Controls.Add(this.checkEliminar);
            this.TabListaCategorias.Controls.Add(this.dataListadoCategorias);
            this.TabListaCategorias.Controls.Add(this.btnImprimir);
            this.TabListaCategorias.Controls.Add(this.btnEliminar);
            this.TabListaCategorias.Controls.Add(this.btnBuscar);
            this.TabListaCategorias.Controls.Add(this.txtCategoriaBuscada);
            this.TabListaCategorias.Controls.Add(this.label2);
            this.TabListaCategorias.Location = new System.Drawing.Point(4, 22);
            this.TabListaCategorias.Name = "TabListaCategorias";
            this.TabListaCategorias.Padding = new System.Windows.Forms.Padding(3);
            this.TabListaCategorias.Size = new System.Drawing.Size(555, 306);
            this.TabListaCategorias.TabIndex = 0;
            this.TabListaCategorias.Text = "Listado";
            this.TabListaCategorias.UseVisualStyleBackColor = true;
            // 
            // TabMantenimientoCategorias
            // 
            this.TabMantenimientoCategorias.Controls.Add(this.btnCancelar);
            this.TabMantenimientoCategorias.Controls.Add(this.btnEditar);
            this.TabMantenimientoCategorias.Controls.Add(this.btnGuardar);
            this.TabMantenimientoCategorias.Controls.Add(this.btnNuevo);
            this.TabMantenimientoCategorias.Controls.Add(this.txtDescripcion);
            this.TabMantenimientoCategorias.Controls.Add(this.txtNombre);
            this.TabMantenimientoCategorias.Controls.Add(this.txtIdCategoria);
            this.TabMantenimientoCategorias.Controls.Add(this.label5);
            this.TabMantenimientoCategorias.Controls.Add(this.label4);
            this.TabMantenimientoCategorias.Controls.Add(this.label3);
            this.TabMantenimientoCategorias.Location = new System.Drawing.Point(4, 22);
            this.TabMantenimientoCategorias.Name = "TabMantenimientoCategorias";
            this.TabMantenimientoCategorias.Padding = new System.Windows.Forms.Padding(3);
            this.TabMantenimientoCategorias.Size = new System.Drawing.Size(555, 306);
            this.TabMantenimientoCategorias.TabIndex = 1;
            this.TabMantenimientoCategorias.Text = "Mantenimiento";
            this.TabMantenimientoCategorias.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // txtCategoriaBuscada
            // 
            this.txtCategoriaBuscada.Location = new System.Drawing.Point(73, 21);
            this.txtCategoriaBuscada.Name = "txtCategoriaBuscada";
            this.txtCategoriaBuscada.Size = new System.Drawing.Size(149, 20);
            this.txtCategoriaBuscada.TabIndex = 1;
            this.txtCategoriaBuscada.TextChanged += new System.EventHandler(this.TxtCategoriaBuscada_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(230, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(311, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(392, 19);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // dataListadoCategorias
            // 
            this.dataListadoCategorias.AllowUserToAddRows = false;
            this.dataListadoCategorias.AllowUserToDeleteRows = false;
            this.dataListadoCategorias.AllowUserToOrderColumns = true;
            this.dataListadoCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListadoCategorias.Location = new System.Drawing.Point(6, 89);
            this.dataListadoCategorias.MultiSelect = false;
            this.dataListadoCategorias.Name = "dataListadoCategorias";
            this.dataListadoCategorias.ReadOnly = true;
            this.dataListadoCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoCategorias.Size = new System.Drawing.Size(543, 150);
            this.dataListadoCategorias.TabIndex = 5;
            this.dataListadoCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListadoCategorias_CellContentClick);
            this.dataListadoCategorias.DoubleClick += new System.EventHandler(this.DataListadoCategorias_DoubleClick);
            // 
            // checkEliminar
            // 
            this.checkEliminar.AutoSize = true;
            this.checkEliminar.Location = new System.Drawing.Point(7, 66);
            this.checkEliminar.Name = "checkEliminar";
            this.checkEliminar.Size = new System.Drawing.Size(62, 17);
            this.checkEliminar.TabIndex = 6;
            this.checkEliminar.Text = "Eliminar";
            this.checkEliminar.UseVisualStyleBackColor = true;
            this.checkEliminar.CheckedChanged += new System.EventHandler(this.CheckEliminar_CheckedChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(308, 66);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 13);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "Nombre";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descripcion";
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(100, 33);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(94, 20);
            this.txtIdCategoria.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(100, 96);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(210, 79);
            this.txtDescripcion.TabIndex = 5;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(72, 234);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(170, 234);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "&Guradar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(272, 234);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Ed&itar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(375, 234);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 435);
            this.Controls.Add(this.CategoriasControl);
            this.Controls.Add(this.label1);
            this.Name = "FormCategoria";
            this.Text = "FormCategoria";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            this.CategoriasControl.ResumeLayout(false);
            this.TabListaCategorias.ResumeLayout(false);
            this.TabListaCategorias.PerformLayout();
            this.TabMantenimientoCategorias.ResumeLayout(false);
            this.TabMantenimientoCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl CategoriasControl;
        private System.Windows.Forms.TabPage TabListaCategorias;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.CheckBox checkEliminar;
        private System.Windows.Forms.DataGridView dataListadoCategorias;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCategoriaBuscada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage TabMantenimientoCategorias;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip ttMensaje;
    }
}