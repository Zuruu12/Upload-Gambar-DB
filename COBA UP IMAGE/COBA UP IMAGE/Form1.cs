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
        private NpgsqlConnection connection;

        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private string connectionString = "Host=localhost;Port=5432;Database=image;Username=postgres;Password=QWERTY30";
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
                            command.Parameters.AddWithValue("@id_img", textBox1.Text);
                            command.Parameters.AddWithValue("@nama_img", textBox2.Text);
                            command.Parameters.AddWithValue("@ImageData", imageData);
                            command.ExecuteNonQuery();
                        }
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
                connection.Open();
                sql = @"SELECT * FROM img";
                cmd = new NpgsqlCommand(sql, connection);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                connection.Close();
                dgv1.DataSource = null;
                dgv1.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection(connectionString);

        }
    }
}