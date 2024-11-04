using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tringle
{
    public partial class Tringle_Vorm : Form
    {
        public Tringle_Vorm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Создаем кнопку Start
            Button startButton = new Button();
            startButton.Text = "Start";
            startButton.Font = new Font("Arial", 28, FontStyle.Regular);
            startButton.Size = new Size(150, 80);
            startButton.BackColor = Color.Pink;
            startButton.ForeColor = Color.White;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.FlatAppearance.BorderColor = Color.Black;
            startButton.Location = new Point(50, 50);

            // Добавляем обработчик события для кнопки
            startButton.Click += StartButton_Click;

            // Добавляем кнопку на форму
            Controls.Add(startButton);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр треугольника с заданными сторонами
            Triangle triangle = new Triangle(3, 4, 5); // Пример значений для сторон a, b и c

            // Открываем форму TriangleForm и передаем туда объект треугольника
            TriangleForm triangleForm = new TriangleForm(triangle);
            triangleForm.Show();
        }
    }
}
