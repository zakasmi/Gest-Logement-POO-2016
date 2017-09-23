using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace GererLogments
{
    public partial class Form1 : Form
    {
        public Form1()//---------------------------------------------------------------------------------------------------
        {
            // ri ka texecuter application kayw9a3 had chi 
            InitializeComponent();
            //ajouter les élement a un text box
            CB_Type.Items.Add("Studio");
            CB_Type.Items.Add("Appartement");
            CB_Type.Items.Add("Maison");
            CB_Type.DropDownStyle = ComboBoxStyle.DropDownList; // input . desactivated // utilisateur may9darch yaktab f combobox
            CB_Type.SelectedIndex = 1; // select an Item . 0 ou 1 ou 3 // index lli radi ytselecionna falbadya

            // ta9dar dir les colonne man design . ana darthom hna 7it maradich takhdam b pc f l'exam =D 
            dataGridView1.Columns.Add("id_Apartement", "ID Batiment");// left : the name of the column . right :the name that will displayed in the datagridview
            dataGridView1.Columns.Add("adresse", "Adresse"); //gauche nom .droit valeur // li 3la lissar smya . oli 3la liman smya li radi tban f datagridview
            dataGridView1.Columns.Add("superficie", "Superficie");
            dataGridView1.Columns.Add("type", "Type");
            dataGridView1.Columns.Add("prix", "Prix");

            //desactiver l id . radi yatincrementa auto 
            TB_ID.Enabled = false;


        }
        //Declaration des variables global en FOrm1---------------------------------
        //ila briti declarihom f class programm // dir array list static + khasak fo9ach ma 3ayati 3la logment dir Program.Logment 
        
        ArrayList Logments = new ArrayList();
        int Pos = 0;
// Nouveau || vider les champs--------------------------------------------------------------------------------------------------------------------
        private void BNouveau_Click(object sender, EventArgs e)
        {


            // initialiser les "TextBox" 
            foreach (Control Control in Controls)
            {
                if (Control is TextBox) Control.Text = "";
            }
            TB_ID.Text = (Logment.NumeroLogment + 1).ToString();
            CB_Type.Text = "";  // initialiser le Text de ComboBox // Studio o appartement o Maison Maradich ytmas7o 

            // ou CB_Type.SelectedIndex = -1; // ou CB_Type.SelectionLength = 0;

        }
// Ajouter -------------------------------------------------------------------------------------------------------------------
        private void BAjouter_Click(object sender, EventArgs e)
        {

            Logment log;

            //manb3d remplissage dyal les text box .o lcomboBox . radi t affecter le contenu dyalhom l constructeur .dyal logment
            // N.B  khasak t converter 3la 7ssab le type . 

            try // ila madkhaltich les donne correct .radi ytlonsa l'exception . omaradich itchajlo f datagrid o rarraylist
            {
                // instancie wa7ad objet logment . 
                log = new Logment(TB_Adresse.Text, uint.Parse(TB_Superficie.Text), CB_Type.Text, uint.Parse(TB_Prix.Text));
                // nzidou had log l arraylist (logments )
                Logments.Add(log);

                // ndeclariw wa7ad string w n3amro fiha le contenu dyal les textbox o lcombobox
                string[] S = { log.IdLogment.ToString(), TB_Adresse.Text, TB_Superficie.Text.ToString(), CB_Type.Text, TB_Prix.Text };
                // na3tiw dak la chaine l datagridview1 .
                // nb rows homa les lignes .
                dataGridView1.Rows.Add(S);
                MessageBox.Show("l'element est ajouté");
            }
            catch (Exception e1)
            {
                // 2 messages lawal personnalisé o tani dyal systeme .
                MessageBox.Show("Valeur Non valide  ... " + e1.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //n3ayto 3la evenment nouveau .bach n vidiw les champs 
            BNouveau_Click(sender, e);

        }


 //supprimer -------------------------------------------------------------------------------------------------------------------------------
   
        private void BSupprimer_Click(object sender, EventArgs e)
        {
            try
            { // hadi kanjiboha man visual basic . kat3tik tablaue . kat3ammar fih wa7ad lvaleur .katroutournilak dak lvaleur comme string
                // affecter dak lvaleur lwa7ad string o testet 3liha
                string S2 = Interaction.InputBox("Entrer l'ID ", "Boite de recherche");
                // matnsach using Microsoft.VisualBasic;
                int i = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)  
                {
                    if (row.Cells[0].Value.ToString() == S2)// antestiw rir 3la Id li kayan f colonne 0
                    {
                        // had tableau . ratklicker yes wla No 
                        if (MessageBox.Show("voulez vous vraiment  supprimer ? ", "supprimer", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            //supprimer dak ligne man datagrid
                            dataGridView1.Rows.Remove(row);
                            //supprimer dak objet man ARRaylist(logments)
                            Logments.RemoveAt(i);
                           
                            MessageBox.Show("l'element est supprimé", "supprimer");

                        }
                    }
                    i++;
                }
                 // ila kayan chi exception radi yaffichilak MessagBox
            }catch (Exception e2){ MessageBox.Show(""+e2.Message); }

        }
//serialisation -------------------------------------------------------------------------------------------------------
        private void BSauvegarder_Click(object sender, EventArgs e)
        {

            try
            {
                if (!(Logments.Count < 1)) // ila kan array list khawi .mat9adch tsauvegarder
                {


                    FileStream fich = new FileStream("logment.dat", FileMode.Create);

                    BinaryFormatter format = new BinaryFormatter();

                    format.Serialize(fich, Logments);
                    MessageBox.Show("les logments sont enregistrées");


                }
                else MessageBox.Show("Makayan Walouu ", "Vide ");

                // deserialisation ila briti ta9ra man fichier radi tbaddal dak Creat b OPen .
                
            }
            catch (Exception e4)
            { 
                // had try catch khdama f le cas dyal deserialize 
                MessageBox.Show(""+e4.Message); 
            }

            //N.B dima dir f classe li bari t serialisiha . [Serializable] chouf class logment radi tal9aha 
        }

        //deserlialiser------------------------------------------------------------------------------------------------

        private void BDeserialiser_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fich = new FileStream("logment.dat",FileMode.Open);
                BinaryFormatter format = new BinaryFormatter();
                
                Logments.Clear();
               

                Logments = (ArrayList)format.Deserialize(fich);
                if (Logments.Count > 0)
                {
                    Afficher(0);
                
                }
                MessageBox.Show("les logments sont Deserialisées");



                foreach (Logment log in Logments)
                {

                    string[] S = new string[] { log.IdLogment.ToString(), log.Adresse, log.Superficie.ToString(), log.Type, log.Prix.ToString() } ;
                    dataGridView1.Rows.Add(S);
                }

            }
            catch (Exception e6)
            {
                MessageBox.Show("" + e6.Message);

            }
        }
//methode afficher------------------------------------------------------------------------------------------------
        public void Afficher(int i)
        {

            TB_ID.Text = ((Logment)Logments[i]).IdLogment.ToString();
            TB_Adresse.Text = ((Logment)Logments[i]).Adresse;
            TB_Superficie.Text = ((Logment)Logments[i]).Superficie.ToString();
            TB_Prix.Text = ((Logment)Logments[i]).Prix.ToString();
            CB_Type.Text = ((Logment)Logments[i]).Type;

        }

// Debut -------------------------------------------------------------------------------------------------        
        private void BDebut_Click(object sender, EventArgs e)
        {
            if (Logments.Count > 0)
            {
                Afficher(0);
                MessageBox.Show("Debut De List");

            }
        }


// Fin -------------------------------------------------------------------------------------------------        

        private void BFin_Click(object sender, EventArgs e)
        {
            if(Logments.Count > 0)
            {
                Afficher(Logments.Count-1);
                MessageBox.Show("Fin de List");
            }
        }

// dernier -------------------------------------------------------------------------------------------------        

        private void Bdernier_Click(object sender, EventArgs e)
        {
            if (Pos < Logments.Count - 1) Afficher(++Pos);
            else { MessageBox.Show("Fin de List"); }

        }


// suivant -------------------------------------------------------------------------------------------------        

        private void BSuivant_Click(object sender, EventArgs e)
        {
            if (Pos > 0) Afficher(--Pos);
            else MessageBox.Show("Debut De List");
        }


// supprimer ligne selectionner -------------------------------------------------------------------------------------------------        

        private void BSupprimerLigne_Click(object sender, EventArgs e)
        {
            //hadi dartha ri zyada . ila briti tamsa7 chi ligne man datagrid 
            // selectionne ligne o wta 3la button supprimer ligne datagrid
            try
            {
                if (dataGridView1.Rows.Count > 0)
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

                else MessageBox.Show("Data Grid est Vide");

            }catch (Exception e5){

                MessageBox.Show(""+e5.Message);
            }
            
        }

        private void BQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BModifier_Click(object sender, EventArgs e)
        {
            try
            {
                Logment log;
                log = new Logment(TB_Adresse.Text, uint.Parse(TB_Superficie.Text), CB_Type.Text, uint.Parse(TB_Prix.Text));
                string[] S = { log.IdLogment.ToString(), TB_Adresse.Text, TB_Superficie.Text.ToString(), CB_Type.Text, TB_Prix.Text };

                Logments[Pos] = log;

                //   dataGridView1.Rows.RemoveAt(Pos);
                dataGridView1.Rows.RemoveAt(Pos);
                dataGridView1.Rows.Insert(Pos, S);
                MessageBox.Show("Bien Modifier");

            }
            catch (Exception e1)
            {
                // 2 messages lawal personnalisé o tani dyal systeme .
                MessageBox.Show("Valeur Non valide  ... " + e1.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        // chi 7wayaj mohimmin bzaaaf  

        // initialiser radio button => RadioButton.Ischeked = false ; 

        // logments rah arraylist radi nkhadmoha bzaf 


        // ila briti takhwi chi list wla arraylist etc dir smya dyal objet.clear() ex Logments.clear();

        // bnisba l combobox dir  ex comboBox1.Items.clear();


        // t3raf wa7ad objet wach kayan f list wla la .ex Logments.contains(logment1);

        // tsupprimer wa7ad objet man List wla aary list wla combobox ..etc ex :  logments.RemoveAt(i); i rah entier

        //  affcter le contenue dyal eadio button l chi string . ex: string s =radiobutton1.text;
        // trier wa7ad list wla combobox etc C.Sorted = true ; 
        // ta3raf index dyal element selectionne f combobox ex : int i = CB1.SelectedIndex;

        // ta3raf valeur dyal element selectionne f combobox ex string s = CB1.SelectedItem ; 
        //ajouter wa7ad element l Combobox : ex CB1.Items.Add("morocco");

        // declarer hashtable : HashTable H1 = new HashTable();

        // ajouter un element l HashTable ex : H1.Add("ista","lazaret");ex H1.Add(L1.logment,Logment);

        // la valeur dyal wahad element f hashtable ex . H1["ista"];=> Lazaret 

        // quiter application . Application.Exit(); dirha f chi button 

        // calculer age DateTime today = DateTime.Today;

        // int age = today.Year - bday.Year;

        // ajouter x jours ou année ou mois  ou  sur une date .  DateTime Date1 = DateTime.Today.Addmonths(x); // AddDays //addYears 

        // contenue dyal dateTimePicker =>>  dateTimePicker1.Value.Year

        // initialiser DateTImePicker ==> dateTimePicker1.ResetText();

    }
}
