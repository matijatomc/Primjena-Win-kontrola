using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace tomcMatijaPrimjenaWinKontrola
{
    public partial class FormaProgram : Form
    {
        public FormaProgram()
        {
            InitializeComponent();
        }

        private void btnRunProgram_Click(object sender, EventArgs e)
        {
            string odabir = cmbRunProgram.SelectedItem.ToString();
            if (odabir == "Paint")
            {
                Process.Start("mspaint.exe");
            }

            if (odabir == "Notepad")
            {
                Process.Start("notepad.exe");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (grbProgramControl.Visible == false)
            {
                grbProgramControl.Visible = true;
            } else
            {
                grbProgramControl.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProgramDescription.Clear();
            txtProgramName.Clear();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite drugi gumb.", "Obaveštenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaText form = new FormaText();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Da li ste sigurni da želite da zatvorite aplikaciju?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odgovor == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}
