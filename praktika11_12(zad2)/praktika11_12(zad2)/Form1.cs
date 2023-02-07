using praktika11_12_zad2_.WindowsFormsApplication1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace praktika11_12_zad2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();   
            Time timer = new Time();
            try
            {
                timer.chas = Convert.ToInt32(textBox1.Text);
                timer.minuta = Convert.ToInt32(textBox2.Text);
                timer.sekunda = Convert.ToInt32(textBox3.Text);
                label4.Text = $"{timer.Chas()}:{timer.Minuta()}:{timer.Sekunda()}"; 
            }
            catch 
            { 
                MessageBox.Show("Вы ввели недопустимое число в числах. Повторите попытку", "Ошибка");
                
            }
                
        }           
        private void timer1_Tick_1(object sender, EventArgs e)
        {
         label5.Text = DateTime.Now.ToString("h:mm:ss");
        }
    }

}












