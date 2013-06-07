namespace AlgoritmoGenetico.MainWindow
{
    partial class VentanaPrincipal
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
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxPoblacion = new System.Windows.Forms.GroupBox();
            this.radioButtonPoblacion100 = new System.Windows.Forms.RadioButton();
            this.radioButtonPoblacion50 = new System.Windows.Forms.RadioButton();
            this.groupBoxSeleccion = new System.Windows.Forms.GroupBox();
            this.radioButtonSeleccionAzar = new System.Windows.Forms.RadioButton();
            this.radioButtonSeleccionElitista = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poblacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditarPoblacion50 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditarPoblacion100 = new System.Windows.Forms.ToolStripMenuItem();
            this.selecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditarSeleccionElitista = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditarSeleccionMedia = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desarrolladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxPoblacion.SuspendLayout();
            this.groupBoxSeleccion.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelPictureBox.Location = new System.Drawing.Point(12, 27);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(560, 565);
            this.panelPictureBox.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(677, 526);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Comenzar";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxPoblacion
            // 
            this.groupBoxPoblacion.Controls.Add(this.radioButtonPoblacion100);
            this.groupBoxPoblacion.Controls.Add(this.radioButtonPoblacion50);
            this.groupBoxPoblacion.Location = new System.Drawing.Point(609, 27);
            this.groupBoxPoblacion.Name = "groupBoxPoblacion";
            this.groupBoxPoblacion.Size = new System.Drawing.Size(200, 75);
            this.groupBoxPoblacion.TabIndex = 3;
            this.groupBoxPoblacion.TabStop = false;
            this.groupBoxPoblacion.Text = "Población";
            // 
            // radioButtonPoblacion100
            // 
            this.radioButtonPoblacion100.AutoSize = true;
            this.radioButtonPoblacion100.Checked = true;
            this.radioButtonPoblacion100.Location = new System.Drawing.Point(6, 42);
            this.radioButtonPoblacion100.Name = "radioButtonPoblacion100";
            this.radioButtonPoblacion100.Size = new System.Drawing.Size(93, 17);
            this.radioButtonPoblacion100.TabIndex = 1;
            this.radioButtonPoblacion100.TabStop = true;
            this.radioButtonPoblacion100.Text = "100 individuos";
            this.radioButtonPoblacion100.UseVisualStyleBackColor = true;
            this.radioButtonPoblacion100.CheckedChanged += new System.EventHandler(this.radioButtonPoblacion100_CheckedChanged);
            // 
            // radioButtonPoblacion50
            // 
            this.radioButtonPoblacion50.AutoSize = true;
            this.radioButtonPoblacion50.Location = new System.Drawing.Point(6, 19);
            this.radioButtonPoblacion50.Name = "radioButtonPoblacion50";
            this.radioButtonPoblacion50.Size = new System.Drawing.Size(87, 17);
            this.radioButtonPoblacion50.TabIndex = 0;
            this.radioButtonPoblacion50.Text = "50 individuos";
            this.radioButtonPoblacion50.UseVisualStyleBackColor = true;
            this.radioButtonPoblacion50.CheckedChanged += new System.EventHandler(this.radioButtonPoblacion50_CheckedChanged);
            // 
            // groupBoxSeleccion
            // 
            this.groupBoxSeleccion.Controls.Add(this.radioButtonSeleccionAzar);
            this.groupBoxSeleccion.Controls.Add(this.radioButtonSeleccionElitista);
            this.groupBoxSeleccion.Location = new System.Drawing.Point(609, 108);
            this.groupBoxSeleccion.Name = "groupBoxSeleccion";
            this.groupBoxSeleccion.Size = new System.Drawing.Size(200, 75);
            this.groupBoxSeleccion.TabIndex = 4;
            this.groupBoxSeleccion.TabStop = false;
            this.groupBoxSeleccion.Text = "Método de selección";
            // 
            // radioButtonSeleccionAzar
            // 
            this.radioButtonSeleccionAzar.AutoSize = true;
            this.radioButtonSeleccionAzar.Location = new System.Drawing.Point(6, 42);
            this.radioButtonSeleccionAzar.Name = "radioButtonSeleccionAzar";
            this.radioButtonSeleccionAzar.Size = new System.Drawing.Size(54, 17);
            this.radioButtonSeleccionAzar.TabIndex = 1;
            this.radioButtonSeleccionAzar.Text = "Media";
            this.radioButtonSeleccionAzar.UseVisualStyleBackColor = true;
            // 
            // radioButtonSeleccionElitista
            // 
            this.radioButtonSeleccionElitista.AutoSize = true;
            this.radioButtonSeleccionElitista.Checked = true;
            this.radioButtonSeleccionElitista.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSeleccionElitista.Name = "radioButtonSeleccionElitista";
            this.radioButtonSeleccionElitista.Size = new System.Drawing.Size(55, 17);
            this.radioButtonSeleccionElitista.TabIndex = 0;
            this.radioButtonSeleccionElitista.TabStop = true;
            this.radioButtonSeleccionElitista.Text = "Elitista";
            this.radioButtonSeleccionElitista.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Location = new System.Drawing.Point(609, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 75);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Población";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(93, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "100 individuos";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(87, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "50 individuos";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Location = new System.Drawing.Point(609, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 75);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Población";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(93, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "100 individuos";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(87, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "50 individuos";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poblacionToolStripMenuItem,
            this.selecciónToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // poblacionToolStripMenuItem
            // 
            this.poblacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEditarPoblacion50,
            this.toolStripEditarPoblacion100});
            this.poblacionToolStripMenuItem.Name = "poblacionToolStripMenuItem";
            this.poblacionToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.poblacionToolStripMenuItem.Text = "Población";
            // 
            // toolStripEditarPoblacion50
            // 
            this.toolStripEditarPoblacion50.Name = "toolStripEditarPoblacion50";
            this.toolStripEditarPoblacion50.Size = new System.Drawing.Size(92, 22);
            this.toolStripEditarPoblacion50.Text = "50";
            this.toolStripEditarPoblacion50.Click += new System.EventHandler(this.toolStripEditarPoblacion50_Click);
            // 
            // toolStripEditarPoblacion100
            // 
            this.toolStripEditarPoblacion100.Name = "toolStripEditarPoblacion100";
            this.toolStripEditarPoblacion100.Size = new System.Drawing.Size(92, 22);
            this.toolStripEditarPoblacion100.Text = "100";
            this.toolStripEditarPoblacion100.Click += new System.EventHandler(this.toolStripEditarPoblacion100_Click);
            // 
            // selecciónToolStripMenuItem
            // 
            this.selecciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEditarSeleccionElitista,
            this.toolStripEditarSeleccionMedia});
            this.selecciónToolStripMenuItem.Name = "selecciónToolStripMenuItem";
            this.selecciónToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.selecciónToolStripMenuItem.Text = "Selección";
            // 
            // toolStripEditarSeleccionElitista
            // 
            this.toolStripEditarSeleccionElitista.Name = "toolStripEditarSeleccionElitista";
            this.toolStripEditarSeleccionElitista.Size = new System.Drawing.Size(108, 22);
            this.toolStripEditarSeleccionElitista.Text = "Elitista";
            this.toolStripEditarSeleccionElitista.Click += new System.EventHandler(this.elitistaToolStripMenuItem_Click);
            // 
            // toolStripEditarSeleccionMedia
            // 
            this.toolStripEditarSeleccionMedia.Name = "toolStripEditarSeleccionMedia";
            this.toolStripEditarSeleccionMedia.Size = new System.Drawing.Size(108, 22);
            this.toolStripEditarSeleccionMedia.Text = "Media";
            this.toolStripEditarSeleccionMedia.Click += new System.EventHandler(this.mediaToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficaToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // gráficaToolStripMenuItem
            // 
            this.gráficaToolStripMenuItem.Name = "gráficaToolStripMenuItem";
            this.gráficaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.gráficaToolStripMenuItem.Text = "Gráfica";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desarrolladoresToolStripMenuItem,
            this.aplicacionToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // desarrolladoresToolStripMenuItem
            // 
            this.desarrolladoresToolStripMenuItem.Name = "desarrolladoresToolStripMenuItem";
            this.desarrolladoresToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.desarrolladoresToolStripMenuItem.Text = "Desarrolladores";
            // 
            // aplicacionToolStripMenuItem
            // 
            this.aplicacionToolStripMenuItem.Name = "aplicacionToolStripMenuItem";
            this.aplicacionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.aplicacionToolStripMenuItem.Text = "Aplicacion";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxSeleccion);
            this.Controls.Add(this.groupBoxPoblacion);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmo genético";
            this.groupBoxPoblacion.ResumeLayout(false);
            this.groupBoxPoblacion.PerformLayout();
            this.groupBoxSeleccion.ResumeLayout(false);
            this.groupBoxSeleccion.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPictureBox;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxPoblacion;
        private System.Windows.Forms.RadioButton radioButtonPoblacion100;
        private System.Windows.Forms.RadioButton radioButtonPoblacion50;
        private System.Windows.Forms.GroupBox groupBoxSeleccion;
        private System.Windows.Forms.RadioButton radioButtonSeleccionAzar;
        private System.Windows.Forms.RadioButton radioButtonSeleccionElitista;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desarrolladoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poblacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditarPoblacion50;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditarPoblacion100;
        private System.Windows.Forms.ToolStripMenuItem selecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditarSeleccionElitista;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditarSeleccionMedia;
    }
}

