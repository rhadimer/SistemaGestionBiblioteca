using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.RASMicroSystem.SistemaGestionBiblioteca
{
    public partial class FormEjemplares : Form
    {
        public string valorTextBox1;
        public string valorTextBox2;
        public string valorTextBox3;
        public string valorTextBox4;
        public string valorTextBox5;
        public string valorTextBox6;
        public string valorTextBox7;
        public string valorTextBox8;
        public string valorTextBox9;
        public string valorTextBox10;
        public string valorTextBox11;
        public string valorTextBox12;
        public string valorTextBox13;
        public string valorTextBox14;
        public string valorTextBox15;
        public string valorTextBox16;
  

        public FormEjemplares()
        {
            InitializeComponent();
        }

 

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            valorTextBox1 = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            valorTextBox2 = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            valorTextBox3 = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            valorTextBox4 = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            valorTextBox5 = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            valorTextBox6 = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            valorTextBox7 = textBox7.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            valorTextBox8 = textBox8.Text;
        }

        private void textBox_9_TextChanged(object sender, EventArgs e)
        {
            valorTextBox9 = textBox_9.Text;
        }

        private void textBox_10_TextChanged(object sender, EventArgs e)
        {
            valorTextBox10 = textBox_10.Text;
        }

        private void textBox_11_TextChanged(object sender, EventArgs e)
        {
            valorTextBox11 = textBox_11.Text;
        }

        private void textBox_12_TextChanged(object sender, EventArgs e)
        {
            valorTextBox12 = textBox_12.Text;
        }

        private void textBox_13_TextChanged(object sender, EventArgs e)
        {
            valorTextBox13 = textBox_13.Text;
        }

        private void textBox_14_TextChanged(object sender, EventArgs e)
        {
            valorTextBox14 = textBox_14.Text;
        }

        private void textBox_15_TextChanged(object sender, EventArgs e)
        {
            valorTextBox15 = textBox_15.Text;
        }

        private void textBox_16_TextChanged(object sender, EventArgs e)
        {
            valorTextBox16 = textBox_16.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(listBox1.SelectedItems.ToString());
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {

            for (int i=0; i <= listBox1.SelectedIndices.Count-1; i++)
            {

                MessageBox.Show(listBox1.SelectedItems[i].ToString());

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /*string elemento = checkedListBox1.SelectedItem.ToString();

            if ( e.NewValue == CheckState.Checked )*/

        }

        

       


        
    }
}
