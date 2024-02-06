
namespace Fiche2
{
    partial class Fprincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rt_texte = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_open = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.open_file = new System.Windows.Forms.OpenFileDialog();
            this.save_file = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rt_texte
            // 
            this.rt_texte.Location = new System.Drawing.Point(0, 27);
            this.rt_texte.Name = "rt_texte";
            this.rt_texte.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rt_texte.Size = new System.Drawing.Size(800, 423);
            this.rt_texte.TabIndex = 0;
            this.rt_texte.Text = "";
            this.rt_texte.TextChanged += new System.EventHandler(this.rt_texte_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_fichier});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_fichier
            // 
            this.m_fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_new,
            this.mi_open,
            this.mi_save,
            this.mi_saveas,
            this.toolStripSeparator1,
            this.mi_exit});
            this.m_fichier.Name = "m_fichier";
            this.m_fichier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.m_fichier.Size = new System.Drawing.Size(54, 20);
            this.m_fichier.Text = "&Fichier";
            this.m_fichier.Click += new System.EventHandler(this.m_fichier_Click);
            // 
            // mi_new
            // 
            this.mi_new.Name = "mi_new";
            this.mi_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mi_new.Size = new System.Drawing.Size(207, 22);
            this.mi_new.Text = "&Nouveau";
            this.mi_new.Click += new System.EventHandler(this.mi_new_Click);
            // 
            // mi_open
            // 
            this.mi_open.Name = "mi_open";
            this.mi_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mi_open.Size = new System.Drawing.Size(207, 22);
            this.mi_open.Text = "&Ouvrir";
            this.mi_open.Click += new System.EventHandler(this.mi_open_Click);
            // 
            // mi_save
            // 
            this.mi_save.Name = "mi_save";
            this.mi_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mi_save.Size = new System.Drawing.Size(207, 22);
            this.mi_save.Text = "Enregi&strer";
            this.mi_save.Click += new System.EventHandler(this.mi_save_Click);
            // 
            // mi_saveas
            // 
            this.mi_saveas.Name = "mi_saveas";
            this.mi_saveas.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mi_saveas.Size = new System.Drawing.Size(207, 22);
            this.mi_saveas.Text = "En&registrer sous...";
            this.mi_saveas.Click += new System.EventHandler(this.mi_saveas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // mi_exit
            // 
            this.mi_exit.Name = "mi_exit";
            this.mi_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mi_exit.Size = new System.Drawing.Size(207, 22);
            this.mi_exit.Text = "&Quitter";
            this.mi_exit.Click += new System.EventHandler(this.mi_exit_Click);
            // 
            // open_file
            // 
            this.open_file.FileName = "openFileDialog1";
            this.open_file.FileOk += new System.ComponentModel.CancelEventHandler(this.open_file_FileOk);
            // 
            // save_file
            // 
            this.save_file.FileOk += new System.ComponentModel.CancelEventHandler(this.save_file_FileOk);
            // 
            // Fprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rt_texte);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fprincipal";
            this.Text = "MyNotepad™";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_texte;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_fichier;
        private System.Windows.Forms.ToolStripMenuItem mi_open;
        private System.Windows.Forms.ToolStripMenuItem mi_saveas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mi_exit;
        private System.Windows.Forms.OpenFileDialog open_file;
        private System.Windows.Forms.SaveFileDialog save_file;
        private System.Windows.Forms.ToolStripMenuItem mi_new;
        private System.Windows.Forms.ToolStripMenuItem mi_save;
    }
}

