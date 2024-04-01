namespace CRUD_Depositos_0._1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.DataFacturas = new System.Windows.Forms.DataGridView();
            this.depositosDataSet = new CRUD_Depositos_0._1.DepositosDataSet();
            this.facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasTableAdapter = new CRUD_Depositos_0._1.DepositosDataSetTableAdapters.FacturasTableAdapter();
            this.facturasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DataDepoNacion = new System.Windows.Forms.DataGridView();
            this.depNacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depNacionTableAdapter = new CRUD_Depositos_0._1.DepositosDataSetTableAdapters.DepNacionTableAdapter();
            this.fechaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nTransacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TBFiltrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataDepoNacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depNacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargar Datos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DataFacturas
            // 
            this.DataFacturas.AutoGenerateColumns = false;
            this.DataFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.numeroReservaDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.agenciaDataGridViewTextBoxColumn,
            this.motivoDataGridViewTextBoxColumn,
            this.nFacturaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.DataFacturas.DataSource = this.facturasBindingSource;
            this.DataFacturas.Location = new System.Drawing.Point(452, 58);
            this.DataFacturas.Name = "DataFacturas";
            this.DataFacturas.Size = new System.Drawing.Size(743, 380);
            this.DataFacturas.TabIndex = 2;
            this.DataFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // depositosDataSet
            // 
            this.depositosDataSet.DataSetName = "DepositosDataSet";
            this.depositosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturasBindingSource
            // 
            this.facturasBindingSource.DataMember = "Facturas";
            this.facturasBindingSource.DataSource = this.depositosDataSet;
            // 
            // facturasTableAdapter
            // 
            this.facturasTableAdapter.ClearBeforeFill = true;
            // 
            // facturasBindingSource1
            // 
            this.facturasBindingSource1.DataMember = "Facturas";
            this.facturasBindingSource1.DataSource = this.depositosDataSet;
            // 
            // DataDepoNacion
            // 
            this.DataDepoNacion.AutoGenerateColumns = false;
            this.DataDepoNacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDepoNacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn1,
            this.montoDataGridViewTextBoxColumn1,
            this.nTransacDataGridViewTextBoxColumn,
            this.motivoDataGridViewTextBoxColumn1});
            this.DataDepoNacion.DataSource = this.depNacionBindingSource;
            this.DataDepoNacion.Location = new System.Drawing.Point(3, 58);
            this.DataDepoNacion.Name = "DataDepoNacion";
            this.DataDepoNacion.Size = new System.Drawing.Size(443, 380);
            this.DataDepoNacion.TabIndex = 3;
            // 
            // depNacionBindingSource
            // 
            this.depNacionBindingSource.DataMember = "DepNacion";
            this.depNacionBindingSource.DataSource = this.depositosDataSet;
            // 
            // depNacionTableAdapter
            // 
            this.depNacionTableAdapter.ClearBeforeFill = true;
            // 
            // fechaDataGridViewTextBoxColumn1
            // 
            this.fechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.Name = "fechaDataGridViewTextBoxColumn1";
            // 
            // montoDataGridViewTextBoxColumn1
            // 
            this.montoDataGridViewTextBoxColumn1.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn1.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn1.Name = "montoDataGridViewTextBoxColumn1";
            // 
            // nTransacDataGridViewTextBoxColumn
            // 
            this.nTransacDataGridViewTextBoxColumn.DataPropertyName = "NTransac";
            this.nTransacDataGridViewTextBoxColumn.HeaderText = "NTransac";
            this.nTransacDataGridViewTextBoxColumn.Name = "nTransacDataGridViewTextBoxColumn";
            // 
            // motivoDataGridViewTextBoxColumn1
            // 
            this.motivoDataGridViewTextBoxColumn1.DataPropertyName = "Motivo";
            this.motivoDataGridViewTextBoxColumn1.HeaderText = "Motivo";
            this.motivoDataGridViewTextBoxColumn1.Name = "motivoDataGridViewTextBoxColumn1";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // numeroReservaDataGridViewTextBoxColumn
            // 
            this.numeroReservaDataGridViewTextBoxColumn.DataPropertyName = "NumeroReserva";
            this.numeroReservaDataGridViewTextBoxColumn.HeaderText = "NumeroReserva";
            this.numeroReservaDataGridViewTextBoxColumn.Name = "numeroReservaDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // agenciaDataGridViewTextBoxColumn
            // 
            this.agenciaDataGridViewTextBoxColumn.DataPropertyName = "Agencia";
            this.agenciaDataGridViewTextBoxColumn.HeaderText = "Agencia";
            this.agenciaDataGridViewTextBoxColumn.Name = "agenciaDataGridViewTextBoxColumn";
            // 
            // motivoDataGridViewTextBoxColumn
            // 
            this.motivoDataGridViewTextBoxColumn.DataPropertyName = "Motivo";
            this.motivoDataGridViewTextBoxColumn.HeaderText = "Motivo";
            this.motivoDataGridViewTextBoxColumn.Name = "motivoDataGridViewTextBoxColumn";
            // 
            // nFacturaDataGridViewTextBoxColumn
            // 
            this.nFacturaDataGridViewTextBoxColumn.DataPropertyName = "NFactura";
            this.nFacturaDataGridViewTextBoxColumn.HeaderText = "NFactura";
            this.nFacturaDataGridViewTextBoxColumn.Name = "nFacturaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Guardar Modificaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filtrar";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(368, 6);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(663, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TBFiltrar
            // 
            this.TBFiltrar.Location = new System.Drawing.Point(530, 9);
            this.TBFiltrar.Name = "TBFiltrar";
            this.TBFiltrar.Size = new System.Drawing.Size(127, 20);
            this.TBFiltrar.TabIndex = 10;
            this.TBFiltrar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 450);
            this.Controls.Add(this.TBFiltrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataDepoNacion);
            this.Controls.Add(this.DataFacturas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataDepoNacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depNacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataFacturas;
        private DepositosDataSet depositosDataSet;
        private System.Windows.Forms.BindingSource facturasBindingSource;
        private DepositosDataSetTableAdapters.FacturasTableAdapter facturasTableAdapter;
        private System.Windows.Forms.BindingSource facturasBindingSource1;
        private System.Windows.Forms.DataGridView DataDepoNacion;
        private System.Windows.Forms.BindingSource depNacionBindingSource;
        private DepositosDataSetTableAdapters.DepNacionTableAdapter depNacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTransacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TBFiltrar;
    }
}

