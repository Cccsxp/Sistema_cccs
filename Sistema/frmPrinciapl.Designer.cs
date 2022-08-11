namespace Sistema
{
    partial class frmPrinciapl
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.MenuCerrarSesion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.sunMenuConsultarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguración = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(314, 157);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(334, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // MenuCerrarSesion
            // 
            this.MenuCerrarSesion.Name = "MenuCerrarSesion";
            this.MenuCerrarSesion.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuConfiguración,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrar,
            this.sunMenuConsultarUsuarios});
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(163, 20);
            this.menuUsuarios.Text = "Administración de usuarios";
            // 
            // subMenuRegistrar
            // 
            this.subMenuRegistrar.Name = "subMenuRegistrar";
            this.subMenuRegistrar.Size = new System.Drawing.Size(125, 22);
            this.subMenuRegistrar.Text = "Registrar";
            this.subMenuRegistrar.Click += new System.EventHandler(this.subMenuRegistrar_Click);
            // 
            // sunMenuConsultarUsuarios
            // 
            this.sunMenuConsultarUsuarios.Name = "sunMenuConsultarUsuarios";
            this.sunMenuConsultarUsuarios.Size = new System.Drawing.Size(180, 22);
            this.sunMenuConsultarUsuarios.Text = "Consultar";
            this.sunMenuConsultarUsuarios.Click += new System.EventHandler(this.sunMenuConsultarUsuarios_Click);
            // 
            // menuConfiguración
            // 
            this.menuConfiguración.Name = "menuConfiguración";
            this.menuConfiguración.Size = new System.Drawing.Size(95, 20);
            this.menuConfiguración.Text = "Configuración";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // frmPrinciapl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtNombre);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrinciapl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrinciapl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrinciapl_FormClosed);
            this.Load += new System.EventHandler(this.frmPrinciapl_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ContextMenuStrip MenuCerrarSesion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem subMenuRegistrar;
        private System.Windows.Forms.ToolStripMenuItem sunMenuConsultarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguración;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}