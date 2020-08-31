using System;
using System.Windows.Forms;

namespace Kalendář
{
    public partial class ZmenForm : Form
    {
        bool pozor;
        public static object[,] docasArray = new object[100, 3];
        public static bool pozmen;
        //docasArray uchovává hodnoty z multiArray
        int index;
        public ZmenForm(object[,] preber)
        {
            InitializeComponent();
            docasArray = preber;
        }

        private void zrusitUdal_butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZmenForm_Load(object sender, EventArgs e)
        {
            //tímto přiřazujeme proměnné temp hodnotu z proměnné dnesnirok z 1. formu
            int docas= Form1.dnesnirok;
            pozor = false;
            //slouží k rozpoznání jestli je možné vytvořit událost
            pozmen = false;
            //proměnná vyjadřující, jestli všechno klaplo

            rok_combo.Items.Add(Convert.ToString(docas));
            docas++;
            rok_combo.Items.Add(Convert.ToString(docas));
            //do comboboxu s rokem dáváme dnešní rok a příští rok

            den_combo.SelectedIndex = 0;
            mesic_combo.SelectedIndex = 0;
            rok_combo.SelectedIndex = 0;
            index = 0;
            //indexy všech comboboxů měníme na 1. - aby odpovídaly 1. položce v kolekci
            try
            {
                int j = 0;
                while (docasArray[j, 0] != null)
                {
                    typudalosti_combo.Items.Add((string)docasArray[j, 1]);
                    // Loop nám dodá do comboboxu tolik názvů, kolik jich je v docasArrayi
                    j++;
                }
                typudalosti_combo.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Nejdříve prosím vytvořte událost");
                pozor = true;
                //toto se aktivuje v případě, že žádné události nejsou a proto selže try
            }
        }

        private void vybrat_butt_Click(object sender, EventArgs e)
        {
            if (pozor == true)
            {
                //test jestli catch nechytil vyjímku
                MessageBox.Show("Nejdříve prosím vytvořte událost. Není možné změnit událost, která neexistuje");
            }
            else
            {
                DateTime datum;
                try
                {
                    datum = new DateTime(Convert.ToInt32(rok_combo.Text), Convert.ToInt32(mesic_combo.Text), Convert.ToInt32(den_combo.Text));
                }
                catch
                {
                    MessageBox.Show("Zadejte prosím validní datum");
                    goto znova;
                }

                if (typudalosti_combo.Text == "")
                {
                    MessageBox.Show("Zadejte prosím text");
                    goto znova;
                }
                if (datum <= DateTime.Now)
                {
                    MessageBox.Show("Zadejte prosím novější datum");
                    goto znova;
                }
                docasArray[index, 0] = datum;
                docasArray[index, 1] = typudalosti_combo.Text;
                docasArray[index, 2] = opakujese_check.Checked;
                pozmen = true;
                //proměnná pozmen volá tick v Form1
                MessageBox.Show("Úspěšně pozměněno!");
                this.Close();
            }
            znova:
            ;
        }

        private void typudalosti_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //zavolá se když se změní index comboboxu na události
            index = typudalosti_combo.SelectedIndex;

            DateTime datumoid = (DateTime)docasArray[index, 0];

            den_combo.Text = Convert.ToString(datumoid.Day);
            mesic_combo.Text = Convert.ToString(datumoid.Month);
            rok_combo.Text = Convert.ToString(datumoid.Year);

            if ((bool)docasArray[index, 2])
            {
                opakujese_check.Checked = true;
            }
            else
            {
                opakujese_check.Checked = false;
            }

            //Kód nad mění comboboxy a checklist box, aby odpovídaly dané události
        }

        private void vymaz_butt_Click(object sender, EventArgs e)
        {
            //smazání položky
            do
            {
                docasArray[index, 0] = docasArray[index + 1, 0];
                docasArray[index, 1] = docasArray[index + 1, 1];
                docasArray[index, 2] = docasArray[index + 1, 2];
                index++;
            }
            while (docasArray[index, 1] != null);
            Form1.ypsilon--;
            MessageBox.Show("Úspěšně smazáno!");
            pozmen = true;
            this.Close();
        }
    }
}
