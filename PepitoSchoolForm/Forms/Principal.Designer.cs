
namespace PepitoSchool.Forms.Forms
{
    partial class Principal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmsDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCarnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porApellidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsDataGridView.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.cmsDataGridView;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(642, 221);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // cmsDataGridView
            // 
            this.cmsDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.promedioToolStripMenuItem});
            this.cmsDataGridView.Name = "cmsDataGridView";
            this.cmsDataGridView.Size = new System.Drawing.Size(181, 92);
            this.cmsDataGridView.Click += new System.EventHandler(this.cmsDataGridView_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar ";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.modificarToolStripMenuItem.Text = "Modificar ";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // promedioToolStripMenuItem
            // 
            this.promedioToolStripMenuItem.Name = "promedioToolStripMenuItem";
            this.promedioToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.promedioToolStripMenuItem.Text = "Promedio";
            this.promedioToolStripMenuItem.Click += new System.EventHandler(this.promedioToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEstudianteToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // agregarEstudianteToolStripMenuItem
            // 
            this.agregarEstudianteToolStripMenuItem.Name = "agregarEstudianteToolStripMenuItem";
            this.agregarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.agregarEstudianteToolStripMenuItem.Text = "Agregar Estudiante";
            this.agregarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.agregarEstudianteToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCarnetToolStripMenuItem,
            this.porNombresToolStripMenuItem,
            this.porApellidosToolStripMenuItem});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // porCarnetToolStripMenuItem
            // 
            this.porCarnetToolStripMenuItem.Name = "porCarnetToolStripMenuItem";
            this.porCarnetToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.porCarnetToolStripMenuItem.Text = "Por Carnet";
            this.porCarnetToolStripMenuItem.Click += new System.EventHandler(this.porCarnetToolStripMenuItem_Click_1);
            // 
            // porNombresToolStripMenuItem
            // 
            this.porNombresToolStripMenuItem.Name = "porNombresToolStripMenuItem";
            this.porNombresToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.porNombresToolStripMenuItem.Text = "Por Nombres";
            this.porNombresToolStripMenuItem.Click += new System.EventHandler(this.porNombresToolStripMenuItem_Click);
            // 
            // porApellidosToolStripMenuItem
            // 
            this.porApellidosToolStripMenuItem.Name = "porApellidosToolStripMenuItem";
            this.porApellidosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.porApellidosToolStripMenuItem.Text = "Por Apellidos";
            this.porApellidosToolStripMenuItem.Click += new System.EventHandler(this.porApellidosToolStripMenuItem_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(333, 1);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(231, 23);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.Visible = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(570, 0);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(26, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "🔎";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Visible = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsDataGridView.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDataGridView;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCarnetToolStripMenuItem;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.ToolStripMenuItem porNombresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porApellidosToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}