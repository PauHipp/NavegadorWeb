namespace NavegadorWeb
{
    partial class Form1
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
            this.comboBox_PaginasWeb = new System.Windows.Forms.ComboBox();
            this.button_ir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nAVEGARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaAdelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaAtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_PaginasWeb
            // 
            this.comboBox_PaginasWeb.FormattingEnabled = true;
            this.comboBox_PaginasWeb.Location = new System.Drawing.Point(64, 52);
            this.comboBox_PaginasWeb.Name = "comboBox_PaginasWeb";
            this.comboBox_PaginasWeb.Size = new System.Drawing.Size(510, 28);
            this.comboBox_PaginasWeb.TabIndex = 0;
            this.comboBox_PaginasWeb.SelectedIndexChanged += new System.EventHandler(this.comboBox_PaginasWeb_SelectedIndexChanged);
            // 
            // button_ir
            // 
            this.button_ir.BackColor = System.Drawing.Color.LightPink;
            this.button_ir.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button_ir.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ir.Location = new System.Drawing.Point(594, 44);
            this.button_ir.Name = "button_ir";
            this.button_ir.Size = new System.Drawing.Size(164, 38);
            this.button_ir.TabIndex = 1;
            this.button_ir.Text = "IR";
            this.button_ir.UseVisualStyleBackColor = false;
            this.button_ir.Click += new System.EventHandler(this.button_ir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nAVEGARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // nAVEGARToolStripMenuItem
            // 
            this.nAVEGARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.haciaAdelanteToolStripMenuItem,
            this.haciaAtrasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.nAVEGARToolStripMenuItem.Name = "nAVEGARToolStripMenuItem";
            this.nAVEGARToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.nAVEGARToolStripMenuItem.Text = "NAVEGAR";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // haciaAdelanteToolStripMenuItem
            // 
            this.haciaAdelanteToolStripMenuItem.Name = "haciaAdelanteToolStripMenuItem";
            this.haciaAdelanteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.haciaAdelanteToolStripMenuItem.Text = "Hacia Adelante";
            this.haciaAdelanteToolStripMenuItem.Click += new System.EventHandler(this.haciaAdelanteToolStripMenuItem_Click);
            // 
            // haciaAtrasToolStripMenuItem
            // 
            this.haciaAtrasToolStripMenuItem.Name = "haciaAtrasToolStripMenuItem";
            this.haciaAtrasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.haciaAtrasToolStripMenuItem.Text = "Hacia Atras";
            this.haciaAtrasToolStripMenuItem.Click += new System.EventHandler(this.haciaAtrasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // webView2
            // 
            this.webView2.AllowExternalDrop = true;
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Location = new System.Drawing.Point(64, 115);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(960, 519);
            this.webView2.Source = new System.Uri("https://www.bing.com/?setlang=es", System.UriKind.Absolute);
            this.webView2.TabIndex = 4;
            this.webView2.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1116, 749);
            this.Controls.Add(this.webView2);
            this.Controls.Add(this.button_ir);
            this.Controls.Add(this.comboBox_PaginasWeb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_PaginasWeb;
        private System.Windows.Forms.Button button_ir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nAVEGARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaAdelanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaAtrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
    }
}

