namespace Buscaminas
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
            this.tablero_layout = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFacil = new System.Windows.Forms.Button();
            this.btnDificil = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablero_layout
            // 
            this.tablero_layout.AutoSize = true;
            this.tablero_layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablero_layout.ColumnCount = 2;
            this.tablero_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablero_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablero_layout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tablero_layout.Location = new System.Drawing.Point(198, 84);
            this.tablero_layout.Name = "tablero_layout";
            this.tablero_layout.RowCount = 2;
            this.tablero_layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablero_layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablero_layout.Size = new System.Drawing.Size(0, 0);
            this.tablero_layout.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcion1ToolStripMenuItem,
            this.mnuAcercaDe});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // opcion1ToolStripMenuItem
            // 
            this.opcion1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicoToolStripMenuItem,
            this.medioToolStripMenuItem,
            this.dificilToolStripMenuItem});
            this.opcion1ToolStripMenuItem.Name = "opcion1ToolStripMenuItem";
            this.opcion1ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.opcion1ToolStripMenuItem.Text = "Nivel";
            // 
            // basicoToolStripMenuItem
            // 
            this.basicoToolStripMenuItem.Name = "basicoToolStripMenuItem";
            this.basicoToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.basicoToolStripMenuItem.Text = "Basico";
            // 
            // medioToolStripMenuItem
            // 
            this.medioToolStripMenuItem.Name = "medioToolStripMenuItem";
            this.medioToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.medioToolStripMenuItem.Text = "Medio";
            // 
            // dificilToolStripMenuItem
            // 
            this.dificilToolStripMenuItem.Name = "dificilToolStripMenuItem";
            this.dificilToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.dificilToolStripMenuItem.Text = "Dificil";
            // 
            // mnuAcercaDe
            // 
            this.mnuAcercaDe.Name = "mnuAcercaDe";
            this.mnuAcercaDe.Size = new System.Drawing.Size(138, 22);
            this.mnuAcercaDe.Text = "Acerca de ...";
            this.mnuAcercaDe.Click += new System.EventHandler(this.mnuAcercaDe_Click);
            // 
            // btnFacil
            // 
            this.btnFacil.Location = new System.Drawing.Point(42, 28);
            this.btnFacil.Name = "btnFacil";
            this.btnFacil.Size = new System.Drawing.Size(75, 23);
            this.btnFacil.TabIndex = 2;
            this.btnFacil.Text = "Facil";
            this.btnFacil.UseVisualStyleBackColor = true;
            this.btnFacil.Click += new System.EventHandler(this.click_btnFacil);
            // 
            // btnDificil
            // 
            this.btnDificil.Location = new System.Drawing.Point(123, 28);
            this.btnDificil.Name = "btnDificil";
            this.btnDificil.Size = new System.Drawing.Size(75, 23);
            this.btnDificil.TabIndex = 3;
            this.btnDificil.Text = "Dificil";
            this.btnDificil.UseVisualStyleBackColor = true;
            this.btnDificil.Click += new System.EventHandler(this.click_btnDificil);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 661);
            this.Controls.Add(this.btnDificil);
            this.Controls.Add(this.btnFacil);
            this.Controls.Add(this.tablero_layout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablero_layout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercaDe;
        private System.Windows.Forms.Button btnFacil;
        private System.Windows.Forms.Button btnDificil;
        private System.Windows.Forms.ToolStripMenuItem basicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificilToolStripMenuItem;
      
    }
}

