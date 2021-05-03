using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicis_II
{
    public partial class Empleats : Form
    {
        public Empleats()
        {
            InitializeComponent();
        }
        //declarem le variables
        becaris becari;
        obrers obrer;
        qualificats qualificat;
        //medore per calcular ma mitjana
        public void notes()
        {
            text_final.Text = ((numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value) / 3).ToString();
        }
        //metedo per buidad els textob, radios, combos, i masqued
        public void reiniciar(GroupBox gbox)
        {
            foreach (Control ctrl in gbox.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.Text = null;
                }
                if (ctrl is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)ctrl;
                    radioButton.Checked = false;
                }
                if (ctrl is ComboBox){
                    ComboBox combo = (ComboBox)ctrl;
                    combo.Text = null;
                }
                if (ctrl is MaskedTextBox)
                {
                    MaskedTextBox marked = (MaskedTextBox)ctrl;
                    marked.Text = null;
                }
            }
        }
        //medode del becari
        public void v_becari()
        {
            becari=new becaris();
            if ((radio_ua.Checked || radio_upv.Checked) && !String.IsNullOrWhiteSpace(text_carrera.Text) && !String.IsNullOrWhiteSpace(text_departament.Text))
            {
                becari.Carrera = text_carrera.Text;
                becari.Curs = numeric_curs.Value;
                becari.Departament = text_departament.Text;
                becari.Nom = text_nom.Text;
                becari.Cognom = text_cog.Text;
                becari.Sou = text_sou.Text;
                becari.Dni = masked_dni.Text;
                becari.quatrimestres(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value);
                if (radio_ua.Checked)
                {
                    becari.universitat("UA");
                }
                else
                {
                    becari.universitat("UPC");
                }
                notes();
                becari.mitjana(decimal.Parse(text_final.Text));
                ListViewItem item_b = new ListViewItem("Becari");
                item_b.SubItems.Add(text_nom.Text + " " + text_cog.Text);
                listView1.Items.Add(item_b);
                reiniciar(groupBox_becar);
                reiniciar(groupBox_emple);
                groupBox_becar.Visible = false;
                butt_afegir.Enabled = true;
                butto_acceptar.Enabled = false;
            }
            else
            {
                MessageBox.Show("T'has deixat una casell per omplir", "ERROR");
            }
        }
        //metodoa de obrer
        public void v_obrer()
        {
            obrer = new obrers();
            if (!String.IsNullOrWhiteSpace(text_hores.Text) && !String.IsNullOrWhiteSpace(comboBox_desti.Text) && !String.IsNullOrWhiteSpace(text_preu.Text))
            {
                obrer.Nom = text_nom.Text;
                obrer.Cognom = text_cog.Text;
                obrer.Sou = text_sou.Text;
                obrer.Dni = masked_dni.Text;
                obrer.Desti = comboBox_desti.Text;
                obrer.Hores_extra = text_hores.Text;
                obrer.Preu_hores_extres = text_preu.Text;
                ListViewItem item_o = new ListViewItem("Obrer");
                item_o.SubItems.Add(text_nom.Text + " " + text_cog.Text);
                listView1.Items.Add(item_o);
                reiniciar(groupBox_obrer);
                reiniciar(groupBox_emple);
                groupBox_obrer.Visible = false;
                butt_afegir.Enabled = true;
                butto_acceptar.Enabled = false;
            }
            else
            {
                MessageBox.Show("T'has deixat una casell per omplir", "ERROR");
            }
        }
        //metode del qualificat
        public void v_qualificat()
        {
            qualificat = new qualificats();
            if (!String.IsNullOrWhiteSpace(text_tito.Text) && !String.IsNullOrWhiteSpace(text_plu.Text) && !String.IsNullOrWhiteSpace(text_quali_departament.Text))
            {
                qualificat.Nom = text_nom.Text;
                qualificat.Cognom = text_cog.Text;
                qualificat.Sou = text_sou.Text;
                qualificat.Dni = masked_dni.Text;
                qualificat.Departament = text_quali_departament.Text;
                qualificat.Plus = text_plu.Text;
                qualificat.Titol = text_tito.Text;
                ListViewItem item_q = new ListViewItem("Qualificat");
                item_q.SubItems.Add(text_nom.Text + " " + text_cog.Text);
                listView1.Items.Add(item_q);
                reiniciar(groupBox_quali);
                reiniciar(groupBox_emple);
                groupBox_quali.Visible = false;
                butt_afegir.Enabled = true;
                butto_acceptar.Enabled = false;
            }
            else
            {
                MessageBox.Show("T'has deixat una casell per omplir", "ERROR");
            }
        }
        //boto dret
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {//si hi han elements activa, si no desactiva
            if (listView1.SelectedItems.Count >= 1)
            {
                eliminaSeleccionatsToolStripMenuItem.Enabled = true;
                eliminarTotsToolStripMenuItem.Enabled = true;
            }
            else
            {
                eliminaSeleccionatsToolStripMenuItem.Enabled = false;
                eliminarTotsToolStripMenuItem.Enabled = false;
            }
        }
        //quan selecciones el list
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si no hi ha elemet no fa ser, si si, mira de quin tipus es i mostra la informacio 
            if (listView1.SelectedItems.Count >= 1)
            {
               if (listView1.SelectedItems[0].SubItems[0].Text == "Becari")
                {
                    label1.Text = becari.info();
                    return;
                }
               if (listView1.SelectedItems[0].SubItems[0].Text == "Obrer")
               {
                   label1.Text = obrer.info();
                   return;
               }
               if (listView1.SelectedItems[0].SubItems[0].Text == "Qualificat")
               {
                   label1.Text = qualificat.info();
                   return;
               }
            }
        }
        //botot accemta
        private void button1_Click(object sender, EventArgs e)
        {
            // de pen de quin tipus siga el combo box cria un o altre metode
            if (combo_emple.Text == "Becari")
            {
                v_becari();
                return;
            }
            if (combo_emple.Text == "Obrer")
            {
                v_obrer();
                return;
            }
            if (combo_emple.Text == "Qualificat")
            {
                v_qualificat();
                return;
            }
        }
        //boto afegir
        private void butt_afegir_Click(object sender, EventArgs e)
        {
            // combprava si esta buit el texts
            if (!String.IsNullOrWhiteSpace(text_nom.Text) && !String.IsNullOrWhiteSpace(text_cog.Text) && !String.IsNullOrWhiteSpace(text_sou.Text) && masked_dni.MaskFull)
            {
                if(!String.IsNullOrWhiteSpace(combo_emple.Text))
                {
                    butt_afegir.Enabled = false;
                    butto_acceptar.Enabled = true;
                    // de pen de quin tipus siga el combo box activa o desactiva el gropu gox
                    double num = 0.0;
                    if ((double.TryParse(text_sou.Text, out num) == true))
                    {
                        butt_afegir.Enabled = false;
                        if (combo_emple.Text == "Becari")
                        {
                            groupBox_becar.Visible=true;
                            groupBox_obrer.Visible = false;
                            groupBox_quali.Visible = false;
                            return;
                        }
                        if (combo_emple.Text == "Obrer")
                        {
                            groupBox_obrer.Visible = true; 
                            groupBox_becar.Visible = false;
                            groupBox_quali.Visible = false;
                            return;
                        }
                        if (combo_emple.Text == "Qualificat")
                        {
                            groupBox_quali.Visible = true;
                            groupBox_obrer.Visible = false;
                            groupBox_becar.Visible = false;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Els sou ha de ser numeric", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("No has definit quin treballador es", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("T'has deixat una casells per omplir", "ERROR");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            notes();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            notes();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            notes();
        }
        //boto cancelar
        private void butt_cancelar_Click(object sender, EventArgs e)
        {
            butt_afegir.Enabled = true;
            butto_acceptar.Enabled = false;
            reiniciar(groupBox_becar);
            reiniciar(groupBox_obrer);
            reiniciar(groupBox_emple);
            reiniciar(groupBox_quali);
            this.errorProvider1.Clear();
            groupBox_becar.Visible = false;
            groupBox_obrer.Visible = false;
            groupBox_quali.Visible = false;
        }
        //eliminar seleccionat
        private void eliminaSeleccionatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //recerro tos els items seleccionats, i els va eleminat un a un
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[i]);
            }
        }
        // eliminar tots
        private void eliminarTotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count >= 1)
            {
                listView1.Items.Clear();
            }
        }
        //eixir
        private void button_eixir_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Vas a tancar l'aplicacio, estas segur??", "Tancar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //tanca
                this.Close();
            }
        }

        private void masked_dni_Leave(object sender, EventArgs e)
        {
            // si esta buit entra i activa l'error
            if (String.IsNullOrEmpty(masked_dni.Text) == true)
            {
                this.errorProvider1.SetError(this.masked_dni, "DNI buit");
            }
            else
            {
                //introduiem en un string el dni i les lletres
                String dni = masked_dni.Text;
                String lletra = "TRWAGMYFPDXBNJZSQVHLCKE";
                //fem un arra de les lletres
                char[] char_lletra = lletra.ToCharArray();
                //fem les operacion i comparem lletres, i si son correctes metejem el error, si no el posem
                if (char_lletra[(Convert.ToInt32(dni.Substring(0, 8)) % 23)] != Convert.ToChar(dni.Substring(9)))
                {
                    this.errorProvider1.SetError(this.masked_dni, "Lletra o DNI erroni");
                }
                else
                {
                    this.errorProvider1.Clear();
                }
            }
        }
    }
}
