using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomnumberapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] renk = { "blue", "red", "green" };
            Random rand = new Random();

            int r = rand.Next(5);
            this.BackColor = Color.FromName(renk[r]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sehirler = new string[81] { "adana", "adıyaman", "afyon", "ağrı", "amasya", "ankara", "antalya", "artvin", "aydın", "balıkesir", "bilecik", "bingöl", "bitlis", "bolu", "burdur", "bursa", "çanakkale", "çankırı", "çorum", "denizli", "diyarbakır", "edirne", "elazığ", "erzincan", "erzurum", "eskişehir", "gaziantep", "giresun", "gümüşhane", "hakkari", "hatay", "ısparta", "mersin", "istanbul", "izmir", "kars", "kastamonu", "kayseri", "kırklareli", "kırşehir", "kocaeli", "konya", "kütahya", "malatya", "manisa", "kahramanmaraş", "mardin", "muğla", "muş", "nevşehir", "niğde", "ordu", "rize", "sakarya", "samsun", "siirt", "sinop", "sivas", "tekirdağ", "tokat", "trabzon", "tunceli", "şanlıurfa", "uşak", "van", "yozgat", "zonguldak", "aksaray", "bayburt", "karaman", "kırıkkale", "batman", "şırnak", "bartın", "ardahan","ığdır", "yalova", "karabük", "kilis", "osmaniye", "düzce"};
            int plakano = Convert.ToInt32(textBox1.Text);
            string sehir = sehirler[plakano-1];
            MessageBox.Show(plakano + " Numaralı Şehrin Adı: " + sehir.ToUpper());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
