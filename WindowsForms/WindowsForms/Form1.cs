using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            RegistryKey key = Registry.CurrentUser.CreateSubKey("WindowsForm");
            if (key != null) {
                
                string color = Convert.ToString(key.GetValue("Color"));
                if (color == "Оранжевый")
                    BackColor = Color.Orange;
                if (color == "Голубой")
                    BackColor = Color.LightBlue;
                if (color == "Зеленый")
                    BackColor = Color.LightGreen;
                if (color == "Розовый")
                    BackColor = Color.Pink;
                Height = Convert.ToInt32(key.GetValue("Height"));
                Width = Convert.ToInt32(key.GetValue("Width"));
                Size = new Size(Width, Height);
            }
            
        }


        private void button6_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("WindowsForm");
            key.SetValue("Height", TextBox1.Text);
            Height = Convert.ToInt32(key.GetValue("Height"));
            key.SetValue("Width", TextBox2.Text);
            Width = Convert.ToInt32(key.GetValue("Width"));
            Size = new Size(Width, Height);
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("WindowsForm");
            key.SetValue("Color", comboBox1.Text);
            string color = Convert.ToString(key.GetValue("Color"));
            if (color == "Оранжевый")
                BackColor = Color.Orange;
            if (color == "Голубой")
                BackColor = Color.LightBlue;
            if (color == "Зеленый")
                BackColor = Color.LightGreen;
            if (color == "Розовый")
                BackColor = Color.Pink;
        }
    }
}
