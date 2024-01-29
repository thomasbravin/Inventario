using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thomas_Verifica
{
    public partial class FormModifica : Form
    {
        public string id_prodotto;
        public FormModifica(string id)
        {
            InitializeComponent();
            id_prodotto = id;
            PopolaForm();
        }

        public void PopolaForm()
        {
            string ConnectionString = "server=127.0.0.1;" +
                                    "database=inventario;" +
                                    "uid=root;";
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();
                string query = $"SELECT * FROM componenti WHERE id = '{id_prodotto}'";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();


                dr.Read();
                textBoxCodiceFarnell.Text = dr.GetString("CodiceFarnell");
                textBoxCodiceProduttore.Text = dr.GetString("CodiceProduttore");
                textBoxQuantita.Text = dr.GetString("Quantita");
                textBoxPrezzo.Text = dr.GetString("Prezzo");
                dr.Close();

                connessione.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string ConnectionString = "server=127.0.0.1;" +
                                    "database=inventario;" +
                                    "uid=root;";
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();

                string query = $"UPDATE componenti " +
                    $"SET " +
                    $"CodiceFarnell = '{textBoxCodiceFarnell.Text}', " +
                    $"CodiceProduttore = '{textBoxCodiceProduttore.Text}', " +
                    $"Quantita = '{textBoxQuantita.Text}', " +
                    $"Prezzo = '{textBoxPrezzo.Text}' " +
                    $"WHERE id = '{id_prodotto}'";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                cmd.ExecuteNonQuery();
                
                connessione.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}
