using System;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Sample_Pawn
{
    public partial class Form1 : KryptonForm
    {
        ResourceManager resManager; 
        CultureInfo cultureInfo;    
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            cmbLanguage.Items.Add("English");
            cmbLanguage.Items.Add("Tamil");

            cmbLanguage.SelectedIndex = 0;
        }
        private void SetLanguage(string cultureCode)
        {
            cultureInfo = new CultureInfo(cultureCode);
            resManager = new ResourceManager("Sample_Pawn.Labels", typeof(Form1).Assembly);
            lblName.Text = resManager.GetString("lblName", cultureInfo);
            lblPassword.Text = resManager.GetString("lblPassword", cultureInfo);
        }

        private void cmbLanguage_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedItem.ToString() == "English")
            {
                SetLanguage("en");
            }
            else if (cmbLanguage.SelectedItem.ToString() == "Tamil")
            {
                SetLanguage("ta");
            }
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonGroup1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
