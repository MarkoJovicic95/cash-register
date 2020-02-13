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
    public partial class DodajArtikal : Form
    {
        Baza baza;
        List<Artikal> lista;
        public DodajArtikal()
        {
            InitializeComponent();
            baza = new Baza();
            lista = new List<Artikal>();
        }

        private void DodajArtikal_Load(object sender, EventArgs e)
        {
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
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = baza.Conn;
                cmd2.CommandText = "SELECT * FROM Artikal";
                reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    Artikal a = new Artikal();
                    a.Id_artikal = int.Parse(reader["id_artikal"].ToString());
                    a.Naziv = reader["naziv"].ToString();
                    a.Cena = double.Parse(reader["cena"].ToString());
                    a.Popust = double.Parse(reader["popust"].ToString());
                    lista.Add(a);
                }
                if (cbArtikal.Items.Count > 0)
                {
                    cbArtikal.DataSource = null;
                    cbArtikal.Items.Clear();
                }
                cbArtikal.DataSource = lista;
                cbArtikal.SelectedIndex = -1;


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

        private void btnDodajUGrupu_Click(object sender, EventArgs e)
        {
            int id_grupa = cbGrupa.SelectedIndex + 1;
            Artikal a = (Artikal)cbArtikal.SelectedItem;
            int id_artikla = a.Id_artikal;
            try
            {
                baza.OtvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = @"INSERT INTO Grupa(id_grupa,id_artikla) VALUES (@id_grupa,@id_artikla)";
                cmd.Parameters.AddWithValue("id_grupa", id_grupa);
                cmd.Parameters.AddWithValue("id_artikla", id_artikla);
                int rezultat = cmd.ExecuteNonQuery();    
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            lista.Clear();
            double cena;
            bool successfullyParsed = double.TryParse(txtCena.Text, out cena);
            double popust;
            bool successfullyParsed2 = double.TryParse(txtPopust.Text, out popust);

            if (txtNaziv.Text == "")
                MessageBox.Show("Pogrešan unos za naziv!", "Greška");
            else if (!successfullyParsed || txtCena.Text == "" || cena <= 0)
                MessageBox.Show("Pogrešan unos za cenu!", "Greška");
            else if (!successfullyParsed2 || txtPopust.Text == "" || popust >= cena || popust < 0)
                MessageBox.Show("Pogrešan unos za popust!", "Greška");
            else
            {
                try
                {
                    baza.OtvoriKonekciju();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    cmd.CommandText = @"INSERT INTO Artikal(naziv,cena,popust) VALUES (@naziv,@cena,@popust)";
                    cmd.Parameters.AddWithValue("naziv", txtNaziv.Text);
                    cmd.Parameters.AddWithValue("cena", cena);
                    cmd.Parameters.AddWithValue("popust", popust);
                    int rezultat = cmd.ExecuteNonQuery();    
                    if (rezultat > 0)
                        MessageBox.Show("Uspešno dodat zapis u bazu!");
                    else
                        MessageBox.Show("Dodavanje zapisa nije uspelo");

                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = baza.Conn;
                    cmd2.CommandText = "SELECT * FROM Artikal";
                    OleDbDataReader reader = cmd2.ExecuteReader();
                    while (reader.Read())
                    {
                        Artikal a = new Artikal();
                        a.Id_artikal = int.Parse(reader["id_artikal"].ToString());
                        a.Naziv = reader["naziv"].ToString();
                        a.Cena = double.Parse(reader["cena"].ToString());
                        a.Popust = double.Parse(reader["popust"].ToString());
                        lista.Add(a);
                    }
                    if (cbArtikal.Items.Count > 0)
                    {
                        cbArtikal.DataSource = null;
                        cbArtikal.Items.Clear();
                    }
                    cbArtikal.DataSource = lista;
                    cbArtikal.SelectedIndex = -1;

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
