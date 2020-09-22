using System;
using System.Windows.Forms;

namespace Kalendář
{
    public partial class UdalostForm : Form
    {
        public UdalostForm()
        {
            InitializeComponent();
        }

        private void UdalostForm_Load(object sender, EventArgs e)
        {
            //tímto přiřazujeme proměnné temp hodnotu z proměnné dnesnirok z 1. formu
            int temp = Form1.dnesnirok;

            //do comboboxu s rokem dáváme dnešní rok a příští rok
            newYear_combo.Items.Add(Convert.ToString(temp));
            temp++;
            newYear_combo.Items.Add(Convert.ToString(temp));

            //indexy všech comboboxů měníme na 1. - aby odpovídaly 1. položce v kolekci
            newDay_combo.SelectedIndex = 0;
            newMonth_combo.SelectedIndex = 0;
            newYear_combo.SelectedIndex = 0;
        }

        private void zrusitUdal_butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void potvrdUdal_butt_Click(object sender, EventArgs e)
        {
            //proměnné info dáváme text do messageboxu podle toho, jak dopadne vyhodnocení jednotlivých aspektů v dělání nové události
            string info;
            DateTime datumidk;
            try
            {
                //tato kontrola kontroluje jestli jdou hodnoty do datatime přiložit - pokud ne, tak takové datum nemůže existovat
                datumidk = new DateTime(Convert.ToInt32(newYear_combo.Text), Convert.ToInt32(newMonth_combo.Text), Convert.ToInt32(newDay_combo.Text));
            }
            catch
            {
                info = "Tento datum není možný. Jste si jistí že tento měsíc má tolik dní?";
                goto odznova;
            }
            //Z comboboxů vybíráme tímto rok, měsíc a den pro událost a balíme ho do datumu. To je nyní připravené pro poslání, pokud zbytek informací sedí
            string letstradyyis = newEvent_box.Text;

            if (newEvent_box.Text == "" || newEvent_box.Text == " ")
            {
                //pokud se stane tohle, přeruší se akce z důvodů žádného názvu akce
                info = "Prosím vyplňte všechny políčka";
                goto odznova;
            }
            else if(datumidk <= DateTime.Now)
            {
                //tato podmínka porovnává nynější datum s vytvářeným. Pokud je vytvářené starší, přeruší se akce
                info = "Prosím zadejte validní budoucí datum";
                goto odznova;
            }
            Form1.stuff[0] = datumidk;
            Form1.stuff[1] = newEvent_box.Text;
            Form1.stuff[2] = everyYear_check.Checked;

            //vše je v pořádku a položky se uloží do listu stuff. Form 2 se zavře a dá Formu 1 informaci, že vše proběhlo úspěšně. Messagebox o tom dá vědět uživateli.
            info = "Událost úspěšně vytvořena";
            Form1.jevytvoreno = true;
            this.Close();

            odznova:
            MessageBox.Show(info);
        }
    }
}
