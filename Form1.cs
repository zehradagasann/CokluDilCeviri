using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Resources;
using System.Reflection;

namespace CokluDilCeviri 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DilDegistir(string kulturKodu)
        {
            CultureInfo ci = new CultureInfo(kulturKodu);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            ResourceManager rm = new ResourceManager("CokluDilCeviri.Properties.Resources", Assembly.GetExecutingAssembly());

            this.Text = rm.GetString("FormBaslik");

            lblKarsilama.Text = rm.GetString("KarsilamaMetni");
            btnDilEN.Text = rm.GetString("IngilizceButon");
            lblKullanici.Text = rm.GetString("KullaniciAdi");
            btnDilDE.Text = rm.GetString("AlmancaButon");

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DilDegistir("tr-TR");
        }

        private void btnDilTR_Click(object sender, EventArgs e)
        {
            DilDegistir("tr-TR");
        }

        private void btnDilEN_Click(object sender, EventArgs e)
        {
            DilDegistir("en-US");
        }

        private void btnDilDE_Click(object sender, EventArgs e)
        {
            DilDegistir("de");
        }

      
    }
}

