using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Net;
using System.Net.Mail;

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

                string query = "INSERT INTO Locations (id, client_id, film_id, date_location, date_retour, montant) " +
                               "VALUES (@id, @clientId, @filmId, @dateLocation, @dateRetour, @montant)";

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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de l'ajout : " + ex.Message);
                        return; // On arrête ici si l'insertion échoue
                    }
                }

                // Vérifier si la date de retour est dépassée
                if (DateTime.TryParse(dateRetour.ToString(), out DateTime dateRetourA))
                {
                    if (dateRetourA < DateTime.Today)
                    {
                        int joursRetard = (DateTime.Today - dateRetourA).Days;
                        int penalite = joursRetard * 2;
                        string updateQuery = "UPDATE Locations SET montant = montant + @penalite WHERE id = @id";

                        using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@id", Id);
                            updateCmd.Parameters.AddWithValue("@penalite", penalite);

                            try
                            {
                                updateCmd.ExecuteNonQuery();
                                MessageBox.Show("Montant mis à jour pour cause de retour tardif !");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
                            }
                        }
                        string emailClient = "";
                        string queryEmail = "SELECT email FROM Clients WHERE id = @clientId";
                        using (SQLiteCommand cmdEmail = new SQLiteCommand(queryEmail, conn))
                        {
                            cmdEmail.Parameters.AddWithValue("@clientId", clientId);
                            using (SQLiteDataReader reader = cmdEmail.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    emailClient = reader["email"].ToString();
                                }
                            }
                        }

                        if (!string.IsNullOrEmpty(emailClient))
                        {
                            EnvoyerEmailRetard(emailClient, joursRetard, penalite);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Date de retour invalide.");
                }
            

            }
                }

        private void EnvoyerEmailRetard(string destinataire, int joursRetard, int penalite)
        {
            string expediteur = "andrianilanathierry@gmail.com"; 
            string motDePasse = "qibiqxpuykknlmoa"; // à remplacer avec mot de passe d'application

            MailMessage message = new MailMessage();
            message.From = new MailAddress(expediteur);
            message.To.Add(destinataire);
            message.Subject = "Retard de retour de film";
            message.Body = $"Bonjour,\n\nVous avez {joursRetard} jour(s) de retard sur votre location de film. " +
                           $"Des frais de {penalite} € ont été ajoutés à votre facture.\n\nMerci de votre compréhension.";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(expediteur, motDePasse);
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(message);
                MessageBox.Show("E-mail de retard envoyé.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'envoi de l'e-mail : " + ex.Message);
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
            DateTime dateDebut = dateTimePicker3.Value.Date;
            DateTime dateFin = dateTimePicker4.Value.Date;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Locations WHERE date_location BETWEEN @dateDebut AND @dateFin";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@dateDebut", dateDebut);
                adapter.SelectCommand.Parameters.AddWithValue("@dateFin", dateFin);

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
        

    }
}
