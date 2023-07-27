
using System;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DBproject
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-7T0NOLAV;Initial Catalog=testing;Integrated Security=True");
        private object errorProvider;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Table_1 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            disp_data();

            MessageBox.Show("Record inserted successfully");

        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table_1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Table_1 where name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Name should not be Empty");
            }
            else
            {
                MessageBox.Show("Record deleted successfully");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table_1 where name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Table_1 set name='" + textBoxN2.Text + "' where name='" + textBox1.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Name should not be Empty");
            }
            else
            {
                MessageBox.Show("Record updated successfully");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBox3.Focus();
            }

        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                textBox1.Focus();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightGreen;

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.LightGreen;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.LightGreen;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.LightGreen;
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Enter Key is Pressed");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Enter Key is Pressed");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Enter Key is Pressed");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.BackColor = Color.LightGreen;
        }

        private void textBoxN2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("you have double clicked");
            textBoxN2.BackColor = Color.Orange;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.BackColor = Color.LightYellow;
                MessageBox.Show("please insert your Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }



        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Lime;
            button1.Text = "Save";
        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
            string Pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (Regex.IsMatch(textBox4.Text, Pattern) == false)
            {
                textBox3.Focus();
                errorProvider1.SetError(this.textBox4, "Invalid Email ");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button6_MouseCaptureChanged(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
            button6.ForeColor = Color.Green;
        }

        private void label7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label7.Text = " mouse double click ";
        }

       
    }
}