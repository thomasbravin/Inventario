using MySql.Data.MySqlClient;

namespace Thomas_Verifica
{
    public partial class Form1 : Form
    {

        string ConnectionString = "server=127.0.0.1;" +
                                    "database=inventario;" +
                                    "uid=root;";
        public Form1()
        {
            InitializeComponent();
            PololaTabella("");
        }

        public void PololaTabella(string q)
        {
            dataGridView1.Rows.Clear();
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();
                string query = "SELECT * FROM componenti";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(
                        dr.GetInt32("id").ToString(),
                        dr.GetInt32("CodiceFarnell").ToString(),
                        dr.GetString("Descrizione"),
                        dr.GetString("Produttore"),
                        dr.GetString("CodiceProduttore"),
                        dr.GetInt32("Quantita").ToString(),
                        dr.GetString("Prezzo")
                    );
                }

                connessione.Close();
            }
            catch
            {
                MessageBox.Show("Impossibile stabilire una connessione al DB");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            FormModifica formModifica = new FormModifica(id);

            formModifica.ShowDialog();

            PololaTabella("");

        }
    }
}
