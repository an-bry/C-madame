using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace location_film
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=films.db;Version=3;";

            // Récupération des valeurs depuis l’interface
            string Id = textBox1.Text;
            string filmId = textBox2.Text;
            string clientId = textBox3.Text;
            string montant = textBox4.Text;
            string dateLocation = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string dateRetour = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Locations (id,client_id,film_id,date_location,date_retour,montant) " +
                               "VALUES (@id,@clientId, @filmId, @dateLocation, @dateRetour,@montant)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@filmId", filmId);
                    cmd.Parameters.AddWithValue("@clientId", clientId);
                    cmd.Parameters.AddWithValue("@dateLocation", dateLocation);
                    cmd.Parameters.AddWithValue("@dateRetour", dateRetour);
                    cmd.Parameters.AddWithValue("@montant", montant);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ajout réussi !");
                        // ChargerLocations(); // Recharge les données dans le DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de l'ajout : " + ex.Message);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=films.db;Version=3;";

            // ID reste inchangé (utilisé pour cibler l'enregistrement)
            string Id = textBox1.Text;
            string filmId = textBox2.Text;
            string clientId = textBox3.Text;
            string montant = textBox4.Text;
            string dateLocation = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string dateRetour = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE Locations SET client_id = @clientId, film_id = @filmId, " +
                               "date_location = @dateLocation, date_retour = @dateRetour, montant = @montant " +
                               "WHERE id = @id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@clientId", clientId);
                    cmd.Parameters.AddWithValue("@filmId", filmId);
                    cmd.Parameters.AddWithValue("@dateLocation", dateLocation);
                    cmd.Parameters.AddWithValue("@dateRetour", dateRetour);
                    cmd.Parameters.AddWithValue("@montant", montant);
                    cmd.Parameters.AddWithValue("@id", Id);  // utilisé uniquement dans WHERE

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Modification réussie !");
                            // ChargerLocations(); // Actualiser la grille si nécessaire
                        }
                        else
                        {
                            MessageBox.Show("Aucun enregistrement trouvé avec cet ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la modification : " + ex.Message);
                    }
                }
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=films.db;Version=3;";

            // ID reste inchangé (utilisé pour cibler l'enregistrement)
            string Id = textBox1.Text;
            string filmId = textBox2.Text;
            string clientId = textBox3.Text;
            string montant = textBox4.Text;
            string dateLocation = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string dateRetour = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE Locations SET client_id = @clientId, film_id = @filmId, " +
                               "date_location = @dateLocation, date_retour = @dateRetour, montant = @montant " +
                               "WHERE id = @id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@clientId", clientId);
                    cmd.Parameters.AddWithValue("@filmId", filmId);
                    cmd.Parameters.AddWithValue("@dateLocation", dateLocation);
                    cmd.Parameters.AddWithValue("@dateRetour", dateRetour);
                    cmd.Parameters.AddWithValue("@montant", montant);
                    cmd.Parameters.AddWithValue("@id", Id);  // utilisé uniquement dans WHERE

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Modification réussie !");
                            // ChargerLocations(); // Actualiser la grille si nécessaire
                        }
                        else
                        {
                            MessageBox.Show("Aucun enregistrement trouvé avec cet ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la modification : " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=films.db;Version=3;";
            string Id = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(Id))
            {
                MessageBox.Show("Veuillez entrer un ID à supprimer.");
                return;
            }

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet enregistrement ?",
                                                  "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM Locations WHERE id = @id";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", Id);

                        try
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Suppression réussie !");
                                // ChargerLocations(); // Actualiser le DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Aucun enregistrement trouvé avec cet ID.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                        }
                    }
                }
            }
        }

        private void ChargerDonnees()
        {

            string connectionString = "Data Source=films.db;Version=3;";
            string query = "SELECT * FROM Locations";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.Columns["A"].DataPropertyName = "id";
                    dataGridView1.Columns["B"].DataPropertyName = "client_id";
                    dataGridView1.Columns["C"].DataPropertyName = "film_id";
                    dataGridView1.Columns["D"].DataPropertyName = "date_location";
                    dataGridView1.Columns["E"].DataPropertyName = "date_retour";
                    dataGridView1.Columns["F"].DataPropertyName = "montant";

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=films.db;Version=3;";
            string recherche = textBox6.Text.Trim();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Locations WHERE client_id LIKE @recherche OR film_id LIKE @recherche";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@recherche", "%" + recherche + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=films.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Locations";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
