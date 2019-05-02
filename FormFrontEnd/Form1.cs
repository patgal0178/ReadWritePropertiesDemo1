using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFrontEnd
{
    public partial class Form1 : Form
    {
        private Baaalloon balloon;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                balloon = new Baaalloon();
                balloon.Color = txtColor.Text;
                balloon.Height = Convert.ToDouble(txtHeight.Text);
                balloon.Diametre = Convert.ToDouble(txtDiameter.Text);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            lblOutput.Text = $"Color = {balloon.Color},\nHeight = {balloon.Height},\nDiameter = {balloon.Diametre}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Baaalloon bal = new Baaalloon();
            //bal.Color = "black";
            //bal.Height = 40.5;
            //bal.Diametre = 34.5;

            //MessageBox.Show(bal.Diametre.ToString());
        }
    }
}
