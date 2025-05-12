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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nom = textBox2.Text;
            string prenom = textBox3.Text;
            string email = textBox4.Text;
            string telephone = textBox5.Text;
            string connectionString = "Data Source=films.db;Version=3;";
            string query = "INSERT INTO Clients (id, nom, prenom,email,telephone) VALUES (@Id, @nom, @prenom, @email,@telephone)";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@prenom", prenom);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@telephone", telephone);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Location ajoutée avec succès !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout de la location : " + ex.Message);
                }
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            string id = textBox1.Text;
            string nom = textBox2.Text;
            string prenom = textBox3.Text;
            string email = textBox4.Text;
            string telephone = textBox5.Text;
            string connectionString = "Data Source=films.db;Version=3;";
            string query = "UPDATE  Clients SET  nom=@nom,prenom=@prenom,email=@email,telephone=@telephone WHERE id=@Id";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@prenom", prenom);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@telephone", telephone);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("modification avec succès !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout de la location : " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string connectionString = "Data Source=films.db;Version=3;";
            string query = "DELETE FROM Clients WHERE id = @id";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("CLIENT supprimé avec succès !");
                        else
                            MessageBox.Show("Aucun CLIENT trouvé avec cet ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChargerDonnees()
        {
            string connectionString = "Data Source=films.db;Version=3;";
            string query = "SELECT * FROM Clients";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView2.Columns["AB"].DataPropertyName = "id";
                    dataGridView2.Columns["AC"].DataPropertyName = "nom";
                    dataGridView2.Columns["AD"].DataPropertyName = "prenom";
                    dataGridView2.Columns["AE"].DataPropertyName = "email";
                    dataGridView2.Columns["AF"].DataPropertyName = "telephone";

                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=films.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Clients";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView2.DataSource = dt;
            }
        }
    }
}
