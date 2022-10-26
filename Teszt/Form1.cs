using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teszt
{
    public partial class Form_Nyito : Form
    {
        public Form_Nyito()
        {
            InitializeComponent();
        }

        private void button_Udvozol_Click(object sender, EventArgs e)
        {
            //-- Ellenőizzük, adott-e meg nevet
            if (String.IsNullOrEmpty(nev1.Text))
            {
                MessageBox.Show("Nem adta meg a nevét!","Hiányzó adat",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (azon_szam==null)
            {
                MessageBox.Show("Nem adta meg az azonosítóját!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(szul_datum.Text))
            {
                MessageBox.Show("Nem adta meg a születési dátumot!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(szulet_hely.Text))
            {
                MessageBox.Show("Nem adta meg a születési helyét!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!angol.Checked && !nemet.Checked && !francia.Checked && !olasz.Checked)
            {
                MessageBox.Show("Nem jelölt be beszélni kívánt nyelvet!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Minden mezőt sikeresen kitöltött! ");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
