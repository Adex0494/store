using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Selling_Point
{
    public partial class usersok : Form
    {
        public usersok()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iconPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbFullName.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Connection.masterConnection.connection;
                con.Open();
                SqlCommand cmd = new SqlCommand("insert_user",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fullname", tbFullName.Text);
                cmd.Parameters.AddWithValue("@login",tbUser.Text);
                cmd.Parameters.AddWithValue("@password",tbPassword.Text);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                icon.Image.Save(ms, icon.Image.RawFormat);

                cmd.Parameters.AddWithValue("@icon",ms.GetBuffer());
                cmd.Parameters.AddWithValue("@iconName",lblIconNumber.Text);
                cmd.Parameters.AddWithValue("@email",tbEmail.Text);
                cmd.Parameters.AddWithValue("@role",tbRole);

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            icon.Image = pictureBox3.Image;
            lblIconNumber.Text = "1";
            lblIconAd.Visible = false;
            iconPanel.Visible = false; 
        }

        private void lblIconAd_Click(object sender, EventArgs e)
        {
            iconPanel.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            icon.Image = pictureBox4.Image;
            lblIconNumber.Text = "2";
            lblIconAd.Visible = false;
            iconPanel.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            icon.Image = pictureBox5.Image;
            lblIconNumber.Text = "3";
            lblIconAd.Visible = false;
            iconPanel.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            icon.Image = pictureBox6.Image;
            lblIconNumber.Text = "4";
            lblIconAd.Visible = false;
            iconPanel.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            icon.Image = pictureBox7.Image;
            lblIconNumber.Text = "5";
            lblIconAd.Visible = false;
            iconPanel.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            icon.Image = pictureBox8.Image;
            lblIconNumber.Text = "6";
            lblIconAd.Visible = false;
            iconPanel.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            icon.Image = pictureBox9.Image;
            lblIconNumber.Text = "7";
            lblIconAd.Visible = false;
            iconPanel.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            icon.Image = pictureBox10.Image;
            lblIconNumber.Text = "8";
            lblIconAd.Visible = false;
            iconPanel.Visible = false;
        }

        private void usersok_Load(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }
    }
}
