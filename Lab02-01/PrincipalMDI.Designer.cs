
namespace Lab02_01
{
    partial class PrincipalMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.informacionDelSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(139, 22);
            this.mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(139, 22);
            this.mnuManCategorias.Text = "Categorias";
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(139, 22);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(139, 22);
            this.mnuManClientes.Text = "Clientes";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentaToolStripMenuItem,
            this.registrarCompraToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // registrarVentaToolStripMenuItem
            // 
            this.registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            this.registrarVentaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.registrarVentaToolStripMenuItem.Text = "Registrar Venta";
            // 
            // registrarCompraToolStripMenuItem
            // 
            this.registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            this.registrarCompraToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.registrarCompraToolStripMenuItem.Text = "Registrar Compra";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeVentasToolStripMenuItem,
            this.reporteDeComprasToolStripMenuItem,
            this.inventarioProductosToolStripMenuItem,
            this.reporteProveedoresToolStripMenuItem,
            this.reporteUsuariosToolStripMenuItem,
            this.reporteClientesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de ventas";
            // 
            // reporteDeComprasToolStripMenuItem
            // 
            this.reporteDeComprasToolStripMenuItem.Name = "reporteDeComprasToolStripMenuItem";
            this.reporteDeComprasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.reporteDeComprasToolStripMenuItem.Text = "Reporte de compras";
            // 
            // inventarioProductosToolStripMenuItem
            // 
            this.inventarioProductosToolStripMenuItem.Name = "inventarioProductosToolStripMenuItem";
            this.inventarioProductosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.inventarioProductosToolStripMenuItem.Text = "Inventario productos";
            this.inventarioProductosToolStripMenuItem.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // reporteProveedoresToolStripMenuItem
            // 
            this.reporteProveedoresToolStripMenuItem.Name = "reporteProveedoresToolStripMenuItem";
            this.reporteProveedoresToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.reporteProveedoresToolStripMenuItem.Text = "Reporte proveedores";
            // 
            // reporteUsuariosToolStripMenuItem
            // 
            this.reporteUsuariosToolStripMenuItem.Name = "reporteUsuariosToolStripMenuItem";
            this.reporteUsuariosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.reporteUsuariosToolStripMenuItem.Text = "Reporte usuarios";
            // 
            // reporteClientesToolStripMenuItem
            // 
            this.reporteClientesToolStripMenuItem.Name = "reporteClientesToolStripMenuItem";
            this.reporteClientesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.reporteClientesToolStripMenuItem.Text = "Reporte clientes";
            // 
            // informacionDelSistemaToolStripMenuItem
            // 
            this.informacionDelSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.informacionDelSistemaToolStripMenuItem.Name = "informacionDelSistemaToolStripMenuItem";
            this.informacionDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.informacionDelSistemaToolStripMenuItem.Text = "Informacion del sistema";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(180, 22);
            this.mnuSalir.Text = "Salir del sistema";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click_1);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    }
}