using System;
using System.Globalization;
using System.Windows.Forms;
using System.IO;

namespace Kalendář
{
    public partial class Form1 : Form
    {
        /*Takže... co tento program dělá? Je to kalendář. Při spuštění se získává dnešní datum a každých 10 vteřin se kontroluje nynější čas. Při spuštění se též z textového souboru
         * sem přepíší všechny informace o již vytvořených událostech. Ty se dají vytvářet i v 2. formu, který je na to přizpůsobený. Po vytvoření program zapíše do textového souboru, 
         * aby data byla možná uchovat pro příští spuštění. Třetí form informace buď maže nebo je změní. 
         */

        //deklarace. Dnesniden je číslo dne v měsíci
        public int dnesniden;

        //Dnesnimesic je číslo pro měsíc
        public int dnesnimesic;

        //Dnesnirok je nynější rok jako číslo. Je statický, protože si jeho hodnotu bere 2. form pro roky v comboboxu
        public static int dnesnirok;

        //Dnesnivtydnu je den v týdnu
        public string dnesnivtydnu;

        //UdalostForm je název druhého formu, v kterém se vybírá vytvoření nové události
        UdalostForm formickaUdal = new UdalostForm();

        //ZmenForm je název třetího formu, který slouží pro měnění událostí a jejich vymazání
        ZmenForm zmenitUdal = new ZmenForm(null);

        //bool, který slouží pro rozpoznání jestli je vytvořena událost
        public static bool jevytvoreno = false;

        //Data přenesená z vytvoření nové události
        public static object[] stuff = new object[3];

        //Multidimensionální pole typu object. Uchovávají se v něm všechny vytvořené události.
        object[,] multiArray = new object[100,3];

        //Proměnná, která se zvyšuje při čtení nebo vytváření nové události. Její číslo je rovno počtu událostí (Doufám.)
        public static Int16 ypsilon = 0;

        //string, který popisuje cestu k textovému bloku v debugu
        const string cestazmesta = "Zapisdat.txt";

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //vytvoření nového formuláře pro data
            //proměnné berou jejich datum pomocí příkazů
            dnesniden = DateTime.Now.Day;
            dnesnimesic = DateTime.Now.Month;
            dnesnirok = DateTime.Now.Year;


            //Deklarujeme datetime s dnešním datem, což by nám dalo číslo dnu v týdnu. S culture info a to string nám vyjede den v týdnu česky
            DateTime dateValue = new DateTime(dnesnirok, dnesnimesic, dnesniden);
            dnesnivtydnu = dateValue.ToString("dddd", new CultureInfo("cs-CS"));

            //Kód změní první písmeno na velké
            dnesnivtydnu = char.ToUpper(dnesnivtydnu[0]) + dnesnivtydnu.Substring(1);

            //přepis proměnných do textových polí
            vtydnubox.Text = dnesnivtydnu;
            denbox.Text = Convert.ToString(dnesniden + ".");
            mesicbox.Text = Convert.ToString(dnesnimesic + ".");
            rokbox.Text = Convert.ToString(dnesnirok);
            casHodiny_lejbl.Text = Convert.ToString(DateTime.Now.Hour);

            //přečtení a zařazení již uložených událostí v paměti

            if (!File.Exists(cestazmesta))
            {
                FileStream strm = File.Create(cestazmesta);
                strm.Close();
                //zkouška, jestli C# najde soubor Zapisdat. Jestli ne, tak ho vytvoří.
            }

            StreamReader ctu = new StreamReader(cestazmesta);

            //stufak je pomocný array, pouze pro rozdělení lajny. Z něj se přepisuje do stuffu
            string lajna = ctu.ReadLine();
            string[] stufak = new string[3];
            while (lajna != null)
            {
                //příkaz rozdělí přečtenou line na 3 stringy, které uloží do stufaku. Rozdělí je pomocí hvězdičky
                stufak = lajna.Split('*');
                stuff[0] = Convert.ToDateTime(stufak[0]);
                stuff[1] = stufak[1];
                stuff[2] = Convert.ToBoolean(stufak[2]);

                //kontrola toho, jestli není datum starší než dnešní datum
                if ((DateTime)stuff[0] < DateTime.Now)
                {
                    //chybné datum. Stará data se nezapíší do multiarraye
                    if ((bool)stuff[2] == true)
                    {
                        //toto se spustí v případě, že se má událost opakovat
                        //Kód by měl přidávat roky tak dlouhu, dokud je událost menší nebo rovno dnešnímu datu
                        //Jakmile bude větší, měl by se zapsat
                        DateTime docasnejDatum = (DateTime)stuff[0];
                        do
                        {
                            docasnejDatum = docasnejDatum.AddYears(1);
                        }
                        while (docasnejDatum <= DateTime.Now);
                        stuff[0] = Convert.ToDateTime(docasnejDatum);
                        PrevedDoMultiArraye(false);
                    }
                }
                else
                {
                    PrevedDoMultiArraye(false);
                }
                lajna = ctu.ReadLine();
            }
            ctu.Close();

            HledamDatum();
            PrepisText();
        }

        public void HledamDatum()
        {
            //funkce je zavolána vždy, když se přidá nové datum. Porovná pak všechny data a to nejstarší (nejmenší) zapíše
            DateTime nejstarsidatum = new DateTime(5000, 1, 1);

            for (int z = 0; z < ypsilon; z++)
            {
                if ((DateTime)multiArray[z, 0] < nejstarsidatum)
                {
                    //pokud systém najde starší datum, přepíše se do polí a spočítá se rozdíl ve dnech ode dnešeka
                    nejstarsidatum = (DateTime)multiArray[z, 0];

                    //jednotlivé informace se přepisují do polí
                    nameEvent_box.Text = (string)multiArray[z, 1];
                    DateTime datapokus = (DateTime)multiArray[z, 0];
                    denEvent_box.Text = datapokus.Day.ToString() + ".";
                    mesicEvent_box.Text = datapokus.Month.ToString() + ".";
                    rokEvent_Box.Text = datapokus.Year.ToString() + "";
                    //vypočítává se počet dní mezi dneškem a událostí, zaokrouhluje se na celé číslo.

                    TimeSpan ts = (DateTime)multiArray[z, 0] - DateTime.Now;
                    denleft_box.Text = Convert.ToString(ts.Days);
                }
            }
        }

        public void PrevedDoMultiArraye(bool zapisujem)
        {
            //iks počítá počet loopů
            int iks = 0;

            do
            {
                //loop přepisuje data z výroby nové události do multiaraye s pomocí iks
                multiArray[ypsilon, iks] = stuff[iks];
                iks++;
            }
            while (iks < 3);

            Array.Clear(stuff, 0, stuff.Length);
            if (zapisujem == true)
            {
                //přepsat kód - ze stuffu se nyní musí všechn překonvertovat. .append způsobí, že se píše na konec dokumentu
                StreamWriter pisu = File.AppendText(cestazmesta);
                pisu.WriteLine("" + (DateTime)multiArray[ypsilon, 0] + "*" + (string)multiArray[ypsilon, 1] +"*"+ (bool)multiArray[ypsilon, 2]);
                pisu.Close();
            }

            // ypsilon umožňuje další zapisování odlišené události
            ypsilon++;
        }

        private void PrepisText()
        {
            //Tohle se zavolá v případě, že text se prepisuje (tj. - vymazává se všechno co není v multiarrayi)
            //Nejdřív se vymaže všechen text
            File.WriteAllText(cestazmesta, String.Empty);
            StreamWriter prepisu = new StreamWriter(cestazmesta);
            int pridej = 0;
            //pak se vypíše všechen text
            while ((string)multiArray[pridej, 1] != null && (string)multiArray[pridej, 1] != "")
            {
                prepisu.WriteLine("" + Convert.ToString((DateTime)multiArray[pridej, 0]) + "*" + (string)multiArray[pridej, 1] + "*" + Convert.ToString((bool)multiArray[pridej, 2]));
                pridej++;
            }
            prepisu.Close();

        }

        private void novaUdal_butt_Click(object sender, EventArgs e)
        {

            try
            {
                formickaUdal.Show();
            }
            catch
            {
                UdalostForm formickaUdal = new UdalostForm();
                formickaUdal.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //každý tick se kontroluje změna minut v hodinách
            casMinuty_lejbl.Text = Convert.ToString(DateTime.Now.Minute);

            if (casMinuty_lejbl.Text == "0")
            {
                //Pokud je :00, obnoví se hodiny - hours
                casHodiny_lejbl.Text = Convert.ToString(DateTime.Now.Hour);
            }

            if (jevytvoreno == true)
            {
                //mění se na false takhle brzy proto, aby se timer neaktivoval víckrát. Zaznemená vytvoření nové události.
                jevytvoreno = false;
                PrevedDoMultiArraye(true);
                HledamDatum();
            }
            if (ZmenForm.pozmen)
            {
                ZmenForm.pozmen = false;
                multiArray = ZmenForm.docasArray;
                HledamDatum();
                PrepisText();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // posíláme do ZmenForm přez konstruktor celý multiarray. Aby to fungovalo tak musíme vytvořit novou instanci
            try
            {
                zmenitUdal.Close();
            }
            finally
            {
                ZmenForm zmenitUdal = new ZmenForm(multiArray);
                zmenitUdal.Show();
            }
        }
    }
}
