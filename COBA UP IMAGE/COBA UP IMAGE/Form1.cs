using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace COBA_UP_IMAGE
{
    public partial class Form1 : Form
    {

        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private string connectionString = "Host=localhost;Port=5432;Database=image;Username=postgres;Password=Yus2064.";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string imagelocation = " ";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";


            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imagelocation = openFileDialog.FileName;

                image1.ImageLocation = imagelocation;
                try
                {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    byte[] imageData;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Change the format if needed
                        imageData = ms.ToArray();
                    }

                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("INSERT INTO img (id_img, nama_img,image) VALUES (@id_img, @nama_img,@ImageData)", connection))
                        {
                            command.Parameters.AddWithValue("@id_img", Convert.ToInt32(textBox1.Text));
                            command.Parameters.AddWithValue("@nama_img", textBox2.Text);
                            command.Parameters.AddWithValue("@ImageData", imageData);
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                    MessageBox.Show("Image uploaded successfully!");
                    ShowData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        private void ShowData()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {

                    string connectionString = "Host=localhost;Port=5432;Database=image;Username=postgres;Password=Yus2064.";
                    string query = "SELECT image FROM img WHERE id_img = @id_img AND nama_img = @nama_img";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@id_img", Convert.ToInt32(textBox1.Text));
                        command.Parameters.AddWithValue("@nama_img", textBox2.Text);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] imageData = (byte[])reader["image"];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    pictureBox1.BackgroundImage = Image.FromStream(ms);
                                }
                            }
                        }
                        connection.Close();

                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
            label3.Text = textBox2.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}