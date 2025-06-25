namespace KelimeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] harflerim = new char[]
{
       'A', 'B', 'C','Ç', 'D', 'E', 'F', 'G', 'Ð', 'H', 'I','Ý', 'J', 'K', 'L', 'M', 'N', 'O','Ö', 'P', 'R', 'S', 'Þ', 'T', 'U','Ü', 'V', 'Y', 'Z'
};
        string[] iller = { "Adana", "Adýyaman", "Afyonkarahisar", "Aðrý", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydýn", "Balýkesir", "Bartýn", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankýrý", "Çorum", "Denizli", "Diyarbakýr", "Düzce", "Edirne", "Elazýð", "Erzincan", "Erzurum", "Eskiþehir", "Gaziantep", "Giresun", "Gümüþhane", "Hakkari", "Hatay", "Iðdýr", "Isparta", "Ýstanbul", "Ýzmir", "Kahramanmaraþ", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kýrýkkale", "Kýrklareli", "Kýrþehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muðla", "Muþ", "Nevþehir", "Niðde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Þanlýurfa", "Þýrnak", "Tekirdað", "Tokat", "Trabzon", "Tunceli", "Uþak", "Van", "Yalova", "Yozgat", "Zonguldak" };
        string[] secilenIller = new string[1];
        string secilenKelime;
        int sayac = 0;
        private void btnSec_Click(object sender, EventArgs e)
        {
            OyunuSifirla();
            foreach (var item in flwAlfabe.Controls)
            {
                Button btn = item as Button;
                btn.Enabled=true;
            }
            RastgeleSehirSec();
            ButonlarýAyarla();
            hak= (byte)secilenKelime.Length;
            lblHak.Text=hak.ToString();
            
        }

        private void OyunuSifirla()
        {
            dogruSayisi = 0;
            lblDogru.Text=dogruSayisi.ToString();
        }

        private void ButonlarýAyarla()
        {
            flwSehir.Controls.Clear();
            for (int i = 0; i < secilenKelime.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(70, 70);
                btn.Text = "--";
                btn.Tag = i;
                btn.Name = "btn" + i;
                flwSehir.Controls.Add(btn);
            }
        }

        private void RastgeleSehirSec()
        {
            if (secilenIller.Length==iller.Length+1)
            {
                secilenIller=new string[1];
                sayac = 0;
            }
            do
            {
               Random rnd= new Random();
                int rastgeleSayi=rnd.Next(0, iller.Length);
                secilenKelime = iller[rastgeleSayi];
            }
            while (secilenIller.Contains(secilenKelime));

            secilenIller[sayac] = secilenKelime;
            sayac++;
            Array.Resize(ref secilenIller, secilenIller.Length+1);
        }

        private void Alfabe()
        {
            for (int i = 0; i < harflerim.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(70, 70);
                btn.Text = harflerim[i].ToString();
                btn.Tag = i;
                btn.Enabled = false;
                btn.Click += Btn_Click;
                flwAlfabe.Controls.Add(btn);
            }
        }
        int dogruSayisi;
        byte hak; 
        private void Btn_Click(object? sender, EventArgs e)
        {
            bool buldunmu = false;
            Button? btn = sender as Button;
            if (btn != null)
            {
                string secilenHarf= btn.Text;
                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (secilenKelime[i].ToString().ToUpper()==secilenHarf.ToUpper())
                    {
                        flwSehir.Controls[i].Text = secilenHarf;
                        dogruSayisi++;
                        lblDogru.Text=dogruSayisi.ToString(); 
                        buldunmu = true;
                    }
                }
                if (!buldunmu)
                {
                    hak--;
                    lblHak.Text=hak.ToString();
                }
                if (hak==0)
                {
                    OyunSonuKontrol("Kaybettiniz");
                }
                if (dogruSayisi==secilenKelime.Length)
                {
                    OyunSonuKontrol("Kazandýnýz");
                }
            }
        }

        private void OyunSonuKontrol(string mesaj)
        {
            DialogResult cvp= MessageBox.Show($"Oyun Bitti. {mesaj}. Yeniden Oynamak Ýster misiniz?","Bilgi", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (cvp == DialogResult.Yes)
            {
                btnSec.PerformClick();
            }
            else
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Alfabe();
        }
    }
}
