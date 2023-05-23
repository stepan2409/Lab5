using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Hardware GetHardware()
        {
            string countryName = countryTextBox.Text;
            string manufacturerName = manufacturerTextBox.Text;
            DateTime productionDate = dateTimePicker1.Value.Date;
            if (string.IsNullOrEmpty(countryName) || string.IsNullOrEmpty(manufacturerName)) 
            {
                SpawnErrorBox("Не все поля заполнены");
                return null;
            }
            Hardware hardware = new Hardware(manufacturerName, productionDate, countryName);
            return hardware;
        }

        private Size GetSize(TextBox xTextBox, TextBox yTextBox) 
        {
            string xText = xTextBox.Text;
            string yText = yTextBox.Text;
            int x, y;
            if (!int.TryParse(xText, out x) || x <= 0) 
            {
                SpawnErrorBox("Введите целое положительное число в поле X!");
                return null;
            }
            if (!int.TryParse(yText, out y) || y <= 0)
            {
                SpawnErrorBox("Введите целое положитеьлное число в поле Y!");
                return null;
            }
            return new Size(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hardware hardware = GetHardware();
            if (hardware == null) return;
            if (printerColorComboBox.SelectedIndex == -1) 
            {
                SpawnErrorBox("Не выбран цветовой режим принтера");
                return;
            }
            ColorMode colorMode = (ColorMode)printerColorComboBox.SelectedIndex;
            Size size = GetSize(textBox5, textBox4);
            if (size == null) return;
            int amount;
            if (!int.TryParse(textBox3.Text, out amount) || amount <= 0)
            {
                SpawnErrorBox("Введите целое положительное число в поле максимального количества листов!");
                return;
            }
            Printer printer = new Printer(hardware, colorMode, size, amount);
            SpawnInfoBox("Создан принтер: \n" + printer.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hardware hardware = GetHardware();
            if (hardware == null) return;
            if (screenColorComboBox.SelectedIndex == -1)
            {
                SpawnErrorBox("Не выбран цветовой режим монитора");
                return;
            }
            ColorMode colorMode = (ColorMode)screenColorComboBox.SelectedIndex;
            Size size = GetSize(textBox1, textBox2);
            if (size == null) return;
            int amount;
            if (!int.TryParse(textBox6.Text, out amount) || amount <= 0)
            {
                SpawnErrorBox("Введите целое положительное число в поле максимального количества портов!");
                return;
            }
            Screen screen = new Screen(hardware, colorMode, size, amount);
            SpawnInfoBox("Создан монитор: \n" + screen.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hardware hardware = GetHardware();
            if (hardware == null) return;
            string os = textBox7.Text.Trim(), cpu = textBox8.Text.Trim();
            if (string.IsNullOrEmpty(os) || string.IsNullOrEmpty(cpu))
            {
                SpawnErrorBox("Не все поля заполнены");
                return;
            }
            Computer computer = new Computer(hardware, os, cpu);
            SpawnInfoBox("Создан компьютер: \n" + computer.ToString());
        }

        private void SpawnInfoBox(string text)
        {
            MessageBox.Show(text, "Данные введены", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SpawnErrorBox(string text)
        {
            MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
