using System.Xml;

namespace CheckBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(chbSakrij.Checked)
            {
                txtBox.Visible = false;
            }
            else
            {
                txtBox.Visible = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            if (chbDorucak.Checked && chbRucak.Checked && chbVecera.Checked) // dorucak + rucak + vecera
            {
                txtBox.Text = "Odabrali ste: " + newLine + "dorucak" + newLine + "rucak"+ newLine + "vecera";
            }
            else if (chbDorucak.Checked && chbRucak.Checked) //dorucak + rucak
            {
                txtBox.Text = "Odabrali ste: " + newLine + "dorucak" + newLine + "rucak";
            }
            else if (chbDorucak.Checked  && chbVecera.Checked) //dorucak + vecera
            {
                txtBox.Text = "Odabrali ste: " + newLine + "dorucak" + newLine + "vecera";
            }
            else if ( chbRucak.Checked && chbVecera.Checked) // rucak + vecera
            {
                txtBox.Text = "Odabrali ste: " +newLine + "rucak" + newLine + "vecera";
            }
            else if (chbRucak.Checked ) // rucak 
            {
                txtBox.Text = "Odabrali ste: " + newLine + "rucak";
            }
            else if (chbDorucak.Checked) // dorucak
            {
                txtBox.Text = "Odabrali ste: " + newLine + "dorucak";
            }
            else if (chbVecera.Checked) // vecera
            {
                txtBox.Text = "Odabrali ste: " + newLine + "vecera";
            }
            else
            {
                txtBox.Text = "Odabrali ste: ";
            }

        }
    }
}