using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SQLImage
{
    public partial class SQLImage : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = school_management; Integrated Security = True");

        public SQLImage()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            try
            {
                OpenFile.FileName = "";
                OpenFile.Title = "Photo:";
                OpenFile.Filter = "Image files: (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.Gif)|*.Gif|(*.bmp)|*.bmp| All Files (*.*)|*.*";
                DialogResult res = OpenFile.ShowDialog();
                if (res == DialogResult.OK)
                {
                    this.pic_data.Image = System.Drawing.Image.FromFile(OpenFile.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = " ";
                SqlCommand cmd = new SqlCommand(query, connection);

                MemoryStream MemStream = new MemoryStream();
                Byte[] DataPic_Update = null;

                this.pic_data.Image.Save(MemStream, ImageFormat.Jpeg);
                DataPic_Update = MemStream.GetBuffer();
                MemStream.Read(DataPic_Update, 0, DataPic_Update.Length);


                SqlParameter photo = new SqlParameter("@photo", SqlDbType.Image);
                photo.Value = DataPic_Update;
                cmd.Parameters.Add(photo);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = " ";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = null;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    byte[] x = (byte[])dr["photo"];
                    MemoryStream ms = new MemoryStream(x);
                    pic_load_data.Image = Image.FromStream(ms);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
