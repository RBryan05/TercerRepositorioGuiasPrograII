﻿namespace Capa_Desconectada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObtenerTipados = new System.Windows.Forms.Button();
            this.dgvTipado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCustomerIDNoTipado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtenerNoTipado = new System.Windows.Forms.Button();
            this.dgvNoTipado = new System.Windows.Forms.DataGridView();
            this.txtCustomerIdTipado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarNoTipado = new System.Windows.Forms.Button();
            this.btnBuscarTipado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarTipado);
            this.groupBox1.Controls.Add(this.txtCustomerIdTipado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnObtenerTipados);
            this.groupBox1.Controls.Add(this.dgvTipado);
            this.groupBox1.Location = new System.Drawing.Point(599, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 600);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataSet Tipado";
            // 
            // btnObtenerTipados
            // 
            this.btnObtenerTipados.Location = new System.Drawing.Point(25, 360);
            this.btnObtenerTipados.Name = "btnObtenerTipados";
            this.btnObtenerTipados.Size = new System.Drawing.Size(494, 42);
            this.btnObtenerTipados.TabIndex = 2;
            this.btnObtenerTipados.Text = "Obtener Tipados";
            this.btnObtenerTipados.UseVisualStyleBackColor = true;
            this.btnObtenerTipados.Click += new System.EventHandler(this.btnObtenerTipados_Click);
            // 
            // dgvTipado
            // 
            this.dgvTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipado.Location = new System.Drawing.Point(25, 35);
            this.dgvTipado.Name = "dgvTipado";
            this.dgvTipado.RowHeadersWidth = 62;
            this.dgvTipado.RowTemplate.Height = 28;
            this.dgvTipado.Size = new System.Drawing.Size(494, 297);
            this.dgvTipado.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarNoTipado);
            this.groupBox2.Controls.Add(this.txtCustomerIDNoTipado);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnObtenerNoTipado);
            this.groupBox2.Controls.Add(this.dgvNoTipado);
            this.groupBox2.Location = new System.Drawing.Point(27, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 600);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSet no Tipado";
            // 
            // txtCustomerIDNoTipado
            // 
            this.txtCustomerIDNoTipado.Location = new System.Drawing.Point(233, 428);
            this.txtCustomerIDNoTipado.Name = "txtCustomerIDNoTipado";
            this.txtCustomerIDNoTipado.Size = new System.Drawing.Size(174, 26);
            this.txtCustomerIDNoTipado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "CustomerID";
            // 
            // btnObtenerNoTipado
            // 
            this.btnObtenerNoTipado.Location = new System.Drawing.Point(17, 360);
            this.btnObtenerNoTipado.Name = "btnObtenerNoTipado";
            this.btnObtenerNoTipado.Size = new System.Drawing.Size(494, 42);
            this.btnObtenerNoTipado.TabIndex = 1;
            this.btnObtenerNoTipado.Text = "Obtener no Tipados";
            this.btnObtenerNoTipado.UseVisualStyleBackColor = true;
            this.btnObtenerNoTipado.Click += new System.EventHandler(this.btnObtenerNoTipado_Click);
            // 
            // dgvNoTipado
            // 
            this.dgvNoTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoTipado.Location = new System.Drawing.Point(17, 35);
            this.dgvNoTipado.Name = "dgvNoTipado";
            this.dgvNoTipado.RowHeadersWidth = 62;
            this.dgvNoTipado.RowTemplate.Height = 28;
            this.dgvNoTipado.Size = new System.Drawing.Size(494, 297);
            this.dgvNoTipado.TabIndex = 0;
            // 
            // txtCustomerIdTipado
            // 
            this.txtCustomerIdTipado.Location = new System.Drawing.Point(239, 428);
            this.txtCustomerIdTipado.Name = "txtCustomerIdTipado";
            this.txtCustomerIdTipado.Size = new System.Drawing.Size(174, 26);
            this.txtCustomerIdTipado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "CustomerID";
            // 
            // btnBuscarNoTipado
            // 
            this.btnBuscarNoTipado.Location = new System.Drawing.Point(136, 477);
            this.btnBuscarNoTipado.Name = "btnBuscarNoTipado";
            this.btnBuscarNoTipado.Size = new System.Drawing.Size(271, 42);
            this.btnBuscarNoTipado.TabIndex = 4;
            this.btnBuscarNoTipado.Text = "Buscar cliente";
            this.btnBuscarNoTipado.UseVisualStyleBackColor = true;
            this.btnBuscarNoTipado.Click += new System.EventHandler(this.btnBuscarNoTipado_Click);
            // 
            // btnBuscarTipado
            // 
            this.btnBuscarTipado.Location = new System.Drawing.Point(142, 477);
            this.btnBuscarTipado.Name = "btnBuscarTipado";
            this.btnBuscarTipado.Size = new System.Drawing.Size(271, 42);
            this.btnBuscarTipado.TabIndex = 5;
            this.btnBuscarTipado.Text = "Buscar cliente";
            this.btnBuscarTipado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoTipado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNoTipado;
        private System.Windows.Forms.Button btnObtenerTipados;
        private System.Windows.Forms.DataGridView dgvTipado;
        private System.Windows.Forms.Button btnObtenerNoTipado;
        private System.Windows.Forms.TextBox txtCustomerIDNoTipado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerIdTipado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarTipado;
        private System.Windows.Forms.Button btnBuscarNoTipado;
    }
}

