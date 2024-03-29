
namespace DiagramadorTPI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarArchivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.designer1 = new Dalssoft.DiagramNet.Designer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.abrirToolStrip = new System.Windows.Forms.ToolStripButton();
            this.guardarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.borrarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.agregarBoton = new System.Windows.Forms.ToolStripSplitButton();
            this.rectanguloToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.unirToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fondoToolStrip = new System.Windows.Forms.ToolStripButton();
            this.frenteToolStrip = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoMenu,
            this.guardarArchivoMenu,
            this.salirMenu});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirArchivoMenu
            // 
            this.abrirArchivoMenu.Name = "abrirArchivoMenu";
            this.abrirArchivoMenu.Size = new System.Drawing.Size(180, 22);
            this.abrirArchivoMenu.Text = "Abrir";
            this.abrirArchivoMenu.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarArchivoMenu
            // 
            this.guardarArchivoMenu.Name = "guardarArchivoMenu";
            this.guardarArchivoMenu.Size = new System.Drawing.Size(180, 22);
            this.guardarArchivoMenu.Text = "Guardar";
            this.guardarArchivoMenu.Click += new System.EventHandler(this.guardarArchivoMenu_Click);
            // 
            // salirMenu
            // 
            this.salirMenu.Name = "salirMenu";
            this.salirMenu.Size = new System.Drawing.Size(180, 22);
            this.salirMenu.Text = "Salir";
            this.salirMenu.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // designer1
            // 
            this.designer1.AutoScroll = true;
            this.designer1.BackColor = System.Drawing.SystemColors.Window;
            this.designer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designer1.Location = new System.Drawing.Point(0, 24);
            this.designer1.Name = "designer1";
            this.designer1.Size = new System.Drawing.Size(800, 426);
            this.designer1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStrip,
            this.guardarToolStrip,
            this.toolStripSeparator2,
            this.borrarToolStrip,
            this.toolStripSeparator1,
            this.agregarBoton,
            this.unirToolStrip,
            this.toolStripSeparator3,
            this.fondoToolStrip,
            this.frenteToolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // abrirToolStrip
            // 
            this.abrirToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStrip.Image")));
            this.abrirToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStrip.Name = "abrirToolStrip";
            this.abrirToolStrip.Size = new System.Drawing.Size(23, 22);
            this.abrirToolStrip.Text = "Abrir";
            this.abrirToolStrip.Click += new System.EventHandler(this.abrirToolStrip_Click_1);
            // 
            // guardarToolStrip
            // 
            this.guardarToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guardarToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStrip.Image")));
            this.guardarToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStrip.Name = "guardarToolStrip";
            this.guardarToolStrip.Size = new System.Drawing.Size(23, 22);
            this.guardarToolStrip.Text = "Guardar";
            this.guardarToolStrip.Click += new System.EventHandler(this.guardarToolStrip_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // borrarToolStrip
            // 
            this.borrarToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.borrarToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("borrarToolStrip.Image")));
            this.borrarToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.borrarToolStrip.Name = "borrarToolStrip";
            this.borrarToolStrip.Size = new System.Drawing.Size(23, 22);
            this.borrarToolStrip.Text = "Borrar";
            this.borrarToolStrip.Click += new System.EventHandler(this.borrarToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // agregarBoton
            // 
            this.agregarBoton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agregarBoton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectanguloToolStrip,
            this.circuloToolStrip});
            this.agregarBoton.Image = ((System.Drawing.Image)(resources.GetObject("agregarBoton.Image")));
            this.agregarBoton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.agregarBoton.Name = "agregarBoton";
            this.agregarBoton.Size = new System.Drawing.Size(32, 22);
            this.agregarBoton.Text = "Agregar Figura";
            
            // 
            // rectanguloToolStrip
            // 
            this.rectanguloToolStrip.Name = "rectanguloToolStrip";
            this.rectanguloToolStrip.Size = new System.Drawing.Size(180, 22);
            this.rectanguloToolStrip.Text = "Rectangulo";
            this.rectanguloToolStrip.Click += new System.EventHandler(this.rectanguloToolStrip_Click);
            // 
            // circuloToolStrip
            // 
            this.circuloToolStrip.Name = "circuloToolStrip";
            this.circuloToolStrip.Size = new System.Drawing.Size(180, 22);
            this.circuloToolStrip.Text = "Circulo";
            this.circuloToolStrip.Click += new System.EventHandler(this.circuloToolStrip_Click);
            // 
            // unirToolStrip
            // 
            this.unirToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.unirToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("unirToolStrip.Image")));
            this.unirToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.unirToolStrip.Name = "unirToolStrip";
            this.unirToolStrip.Size = new System.Drawing.Size(23, 22);
            this.unirToolStrip.Text = "Unir";
            this.unirToolStrip.Click += new System.EventHandler(this.unirToolStrip_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // fondoToolStrip
            // 
            this.fondoToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fondoToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("fondoToolStrip.Image")));
            this.fondoToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fondoToolStrip.Name = "fondoToolStrip";
            this.fondoToolStrip.Size = new System.Drawing.Size(23, 22);
            this.fondoToolStrip.Text = "Deshacer";
            this.fondoToolStrip.Click += new System.EventHandler(this.fondoToolStrip_Click);
            // 
            // frenteToolStrip
            // 
            this.frenteToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.frenteToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("frenteToolStrip.Image")));
            this.frenteToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.frenteToolStrip.Name = "frenteToolStrip";
            this.frenteToolStrip.Size = new System.Drawing.Size(23, 22);
            this.frenteToolStrip.Text = "Rehacer";
            this.frenteToolStrip.Click += new System.EventHandler(this.frenteToolStrip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.designer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoMenu;
        private System.Windows.Forms.ToolStripMenuItem guardarArchivoMenu;
        private System.Windows.Forms.ToolStripMenuItem salirMenu;
        private Dalssoft.DiagramNet.Designer designer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton abrirToolStrip;
        private System.Windows.Forms.ToolStripButton guardarToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton borrarToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton agregarBoton;
        private System.Windows.Forms.ToolStripMenuItem rectanguloToolStrip;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStrip;
        private System.Windows.Forms.ToolStripButton unirToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton fondoToolStrip;
        private System.Windows.Forms.ToolStripButton frenteToolStrip;
    }
}

