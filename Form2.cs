using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;




namespace location_film
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

            // eto mideclarer chaine de connexion à la base
            string connectionString = "Data Source=films.db;Version=3;";  // anaran'le base de donnée

            // manamboatra connexion
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {

                    conn.Open();
                    MessageBox.Show("Connexion réussie dans Form2 !");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erreur de connexion : " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox5.Text;
            string titre = textBox2.Text;
            string genre = textBox1.Text;
            string prix = textBox3.Text;
            int disponible = checkBox1.Checked ? 1 : 0;
            string connectionString = "Data Source=films.db;Version=3;";
            string query = "INSERT INTO Films (id, titre, genre, prix_location,disponible) VALUES (@Id, @titre, @genre, @prix_location,@disponible)";


            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@titre", titre);
                        cmd.Parameters.AddWithValue("@prix_location", prix);
                        cmd.Parameters.AddWithValue("@disponible", disponible);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Location ajoutée avec succès !");
                    }
                }
                catch (Exception ex)
                {
                    // En cas d'erreur, afficher un message
                    MessageBox.Show("Erreur lors de l'ajout de la location : " + ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox5.Text;
            string titre = textBox2.Text;
            string genre = textBox1.Text;
            string prix = textBox3.Text;
            int disponible = checkBox1.Checked ? 1 : 0;
            string connectionString = "Data Source=films.db;Version=3;";

            string query = "UPDATE  Films SET  titre=@titre,genre=@genre,prix_location=@prix_location,disponible=@disponible WHERE id=@Id";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@titre", titre);
                        cmd.Parameters.AddWithValue("@prix_location", prix);
                        cmd.Parameters.AddWithValue("@disponible", disponible);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("modification avec succès !");
                    }
                }
                catch (Exception ex)
                {
                    // En cas d'erreur, afficher un message
                    MessageBox.Show("Erreur lors de l'ajout de la location : " + ex.Message);
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = textBox5.Text; 
            string connectionString = "Data Source=films.db;Version=3;";
            string query = "DELETE FROM Films WHERE id = @id";

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
                            MessageBox.Show("Film supprimé avec succès !");
                        else
                            MessageBox.Show("Aucun film trouvé avec cet ID.");
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
