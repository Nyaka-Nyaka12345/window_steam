using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oknosteam
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
         

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" || textBox2.Text != "")
            {
                if(textBox1.Text == "Max" && textBox2.Text == "Max" )
                {
                    MessageBox.Show("Подождите!", "Вы вошли", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("пароль или логин не верны", "попробуйте снова", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Поля не могут быть пустыми", "Заполните поля", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("функция временно не доступна!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("функция временно не доступна!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
    }
}
