﻿namespace Primo_y_Fibonacci
{
    partial class Busqueda_Inventario
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GrdBusquedaInventario = new System.Windows.Forms.DataGridView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdBusquedaInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(530, 433);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(77, 31);
            this.BtnCancelar.TabIndex = 35;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // GrdBusquedaInventario
            // 
            this.GrdBusquedaInventario.AllowUserToAddRows = false;
            this.GrdBusquedaInventario.AllowUserToDeleteRows = false;
            this.GrdBusquedaInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdBusquedaInventario.Location = new System.Drawing.Point(10, 40);
            this.GrdBusquedaInventario.Margin = new System.Windows.Forms.Padding(1);
            this.GrdBusquedaInventario.Name = "GrdBusquedaInventario";
            this.GrdBusquedaInventario.ReadOnly = true;
            this.GrdBusquedaInventario.RowHeadersWidth = 102;
            this.GrdBusquedaInventario.RowTemplate.Height = 40;
            this.GrdBusquedaInventario.Size = new System.Drawing.Size(624, 391);
            this.GrdBusquedaInventario.TabIndex = 34;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(90, 7);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(295, 20);
            this.TxtBuscar.TabIndex = 33;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(27, 11);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(61, 13);
            this.lblbuscar.TabIndex = 32;
            this.lblbuscar.Text = "BUSCAR:";
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.Location = new System.Drawing.Point(420, 433);
            this.BtnSeleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(99, 31);
            this.BtnSeleccionar.TabIndex = 31;
            this.BtnSeleccionar.Text = "SELECCIONAR";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // Busqueda_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(639, 477);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.GrdBusquedaInventario);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.BtnSeleccionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Busqueda_Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda_Inventario";
            this.Load += new System.EventHandler(this.Busqueda_Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdBusquedaInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridView GrdBusquedaInventario;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button BtnSeleccionar;
    }
}