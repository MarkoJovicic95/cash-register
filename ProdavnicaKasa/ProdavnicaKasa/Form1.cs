using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProdavnicaKasa
{
    public partial class Form1 : Form
    {
        Baza baza;
        List<Artikal> lista;
        List<Racun> racuni;
        
        public Form1()
        {
            InitializeComponent();
            baza = new Baza();
            lista = new List<Artikal>();
            racuni = new List<Racun>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Parse("21/06/2019");
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker2.MinDate = DateTime.Parse("21/06/2019");
            dateTimePicker2.MaxDate = DateTime.Now;
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT id_grupa FROM Grupa";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id_grupa"].ToString());
                    if (id == 1 && !cbGrupa.Items.Contains("Voće"))
                        cbGrupa.Items.Add("Voće");
                    else if (id == 2 && !cbGrupa.Items.Contains("Slatkiši"))
                        cbGrupa.Items.Add("Slatkiši");
                    else if (id == 3 && !cbGrupa.Items.Contains("Piće"))
                        cbGrupa.Items.Add("Piće");
                    else if (id == 4 && !cbGrupa.Items.Contains("Frižider"))
                        cbGrupa.Items.Add("Frižider");
                    else if (id == 5 && !cbGrupa.Items.Contains("Peciva"))
                        cbGrupa.Items.Add("Peciva");
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.ZatvoriKonekciju();
            }
        }

        private void cbGrupa_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            int id_grupa = cbGrupa.SelectedIndex + 1;
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT id_artikal, naziv, cena, popust FROM Artikal, Grupa WHERE Artikal.id_artikal=Grupa.id_artikla AND id_grupa like '" + id_grupa.ToString() + "'";
                OleDbDataReader reader = cmd.ExecuteReader();
                lista.Clear();
                while (reader.Read())
                {
                    Artikal a = new Artikal();
                    a.Id_artikal = int.Parse(reader["id_artikal"].ToString());
                    a.Naziv = reader["naziv"].ToString();
                    a.Cena = double.Parse(reader["cena"].ToString());
                    a.Popust = double.Parse(reader["popust"].ToString());
                    lista.Add(a);
                }
                if(cbArtikal.Items.Count > 0)
                {
                    cbArtikal.DataSource = null;
                    cbArtikal.Items.Clear();
                }
                cbArtikal.DataSource = lista;
                cbArtikal.SelectedIndex = -1;
                cbArtikal.Visible = true;
                lblArtikal.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.ZatvoriKonekciju();
            }
        }

        private void cbArtikal_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            txtKolicina.Text = "1";
            if(cbArtikal.SelectedIndex != -1)
            {
                lblKolicina.Visible = true;
                txtKolicina.Visible = true;
                btnDodajNaRacun.Visible = true;
            }
            else
            {
                lblKolicina.Visible = false;
                txtKolicina.Visible = false;
                btnDodajNaRacun.Visible = false;
            }
        }

        private void btnDodajNaRacun_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnSledeciKupac.Visible = true;
            int n;
            bool successfullyParsed = int.TryParse(txtKolicina.Text, out n);
            if (!successfullyParsed)
            {
                MessageBox.Show("Količina proizvoda mora biti broj");
            }
            else if(n<1)
            {
                MessageBox.Show("Količina proizvoda mora biti pozitivan broj");
            }
            else
            {
                Artikal a = (Artikal)cbArtikal.SelectedItem;
                a.Kolicina = n;
                listBox1.Items.Add(a);  
                
            }
        }

        private void btnStorniranje_Click(object sender, EventArgs e)   
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            
        }

        private void btnIzdavanjeRacuna_Click(object sender, EventArgs e)     
        {
            double ukupnaCena = 0; 
            for(int i=0; i<listBox1.Items.Count; i++)
            {
                Artikal a = (Artikal)listBox1.Items[i];
                ukupnaCena += (a.Cena - a.Popust) * a.Kolicina;
            }
            if (ukupnaCena > 0)
            {
                try
                {
                    baza.OtvoriKonekciju();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    cmd.CommandText = @"INSERT INTO Racun(cena,datum,vreme) VALUES (@cena,@datum,@vreme)";
                    cmd.Parameters.AddWithValue("cena", ukupnaCena);
                    cmd.Parameters.AddWithValue("datum", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("vreme", DateTime.Now.TimeOfDay);
                    int rezultat = cmd.ExecuteNonQuery();    //vraca koliko je redova promenjeno
                    if (rezultat > 0)
                        MessageBox.Show("Uspešno dodat zapis u bazu!");
                    else
                        MessageBox.Show("Dodavanje zapisa nije uspelo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    baza.ZatvoriKonekciju();
                }
            }
        }

        private void btnSledeciKupac_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        private void btnSviRacuni_Click(object sender, EventArgs e)
        {
            btnIzbrisi.Visible = true;
            int pom = DateTime.Compare(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            if (pom > 0)
                MessageBox.Show("Datum do mora biti veći od datuma od!", "Greška");
            else
            {
                panel1.Visible = false;
                try
                {
                    baza.OtvoriKonekciju();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    cmd.CommandText = "SELECT * FROM Racun WHERE datum between #" + dateTimePicker1.Value.ToShortDateString() + "# AND #" + dateTimePicker2.Value.ToShortDateString() + "#";
                    //cmd.CommandText = "SELECT * FROM Racun WHERE datum >= " + dateTimePicker1.Value.ToShortDateString() + " AND datum <= " + dateTimePicker2.Value.ToShortDateString() + "";
                    OleDbDataReader reader = cmd.ExecuteReader();
                    racuni.Clear();
                    while (reader.Read())
                    {
                        Racun r = new Racun();
                        r.Id_racun = int.Parse(reader["id_racun"].ToString());
                        r.Cena = double.Parse(reader["cena"].ToString());
                        r.Datum = (DateTime)reader["datum"];
                        r.Vreme = (DateTime)reader["vreme"];
                        racuni.Add(r);
                    }
                    if (listBox2.Items.Count > 0)
                    {
                        listBox2.DataSource = null;
                        listBox2.Items.Clear();
                    }
                    listBox2.DataSource = racuni;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    baza.ZatvoriKonekciju();
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrikaziRacun_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnIzbrisi.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)   //klik na dugme "Dodaj novi artikal u bazu"
        {
            DodajArtikal frm = new DodajArtikal();
            frm.Show();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex != -1)
            {
                Racun r = (Racun)listBox2.SelectedItem;
                try
                {
                    baza.OtvoriKonekciju();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    cmd.CommandText = "DELETE * FROM Racun WHERE id_racun = " + r.Id_racun;
                    int rezultat = cmd.ExecuteNonQuery();
                    if (rezultat > 0)
                        MessageBox.Show("Uspešno obrisan zapis iz baze!");
                    else
                        MessageBox.Show("Brisanje zapisa nije uspelo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    baza.ZatvoriKonekciju();
                }
            }

        }
    }
}
