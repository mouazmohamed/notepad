using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiche2
{
    public partial class Fprincipal : Form
    {
        public Fprincipal()
        {
            InitializeComponent();
            mi_exit.Click += mi_exit_Click;
        }

        private void Mi_save_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Mi_open_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void M_fichier_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Mi_saveas_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Mi_new_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void m_fichier_Click(object sender, EventArgs e)
        {}

        private void mi_open_Click(object sender, EventArgs e)
        {
            if(open_file.ShowDialog()==DialogResult.OK)
            {
                rt_texte.LoadFile(open_file.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void mi_saveas_Click(object sender, EventArgs e)
        {
            if (save_file.ShowDialog() == DialogResult.OK)
            {
                rt_texte.SaveFile(save_file.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void mi_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rt_texte_TextChanged(object sender, EventArgs e)
        {}

        private void open_file_FileOk(object sender, CancelEventArgs e)
        {
            rt_texte.LoadFile(open_file.FileName, RichTextBoxStreamType.PlainText);
        }

        private void save_file_FileOk(object sender, CancelEventArgs e)
        {
             rt_texte.SaveFile(save_file.FileName, RichTextBoxStreamType.PlainText);
        }

        private void mi_new_Click(object sender, EventArgs e)
        {
            Fprincipal fp = new Fprincipal();
            fp.Show();
        }

        private void mi_save_Click(object sender, EventArgs e)
        {
            string savefile = save_file.FileName;
        }
    }
}