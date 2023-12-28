using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05
{
    public partial class Form1 : Form
    {
        private int panelCount = 0; // счетчик созданных панелей
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
   


        private void button1_Click_1(object sender, EventArgs e)
        {
            // Создаем новую панель
            Panel panel = new Panel();
            // Задаем положение и размеры панели
            panel.Location = new System.Drawing.Point(180, 20 + panelCount * 30);
            panel.Size = new System.Drawing.Size(200, 25);
            panel.BorderStyle = BorderStyle.FixedSingle;
            // Добавляем панель на форму
            this.Controls.Add(panel);
            // Увеличиваем счетчик панелей
            panelCount++;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                // Для каждой панели на форме добавляем новое текстовое поле
                foreach (Control control in this.Controls)
                {
                    if (control is Panel)
                    {
                        TextBox textBox = new TextBox();
                        // Задаем положение и размеры текстового поля
                        textBox.Location = new System.Drawing.Point(10, 3);
                        textBox.Size = new System.Drawing.Size(180, 15);
                        // Добавляем текстовое поле в текущую панель
                        ((Panel)control).Controls.Add(textBox);
                    }
                }
            }
        }
    }
}
