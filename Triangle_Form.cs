using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tringle
{
    public partial class TriangleForm : Form
    {
        private Triangle triangle;

        // Конструктор формы, принимающий объект треугольника
        public TriangleForm(Triangle triangle)
        {
            
            this.triangle = triangle;
            DisplayTriangleInfo();
        }

        private void DisplayTriangleInfo()
        {
            // Метки для отображения информации о треугольнике
            Label labelA = new Label { Text = "Side A: " + triangle.OutputA(), Location = new Point(10, 10) };
            Label labelB = new Label { Text = "Side B: " + triangle.OutputB(), Location = new Point(10, 40) };
            Label labelC = new Label { Text = "Side C: " + triangle.OutputC(), Location = new Point(10, 70) };
            Label labelPerimeter = new Label { Text = "Perimeter: " + triangle.Perimeter(), Location = new Point(10, 100) };
            Label labelSurface = new Label { Text = "Surface: " + triangle.Surface(), Location = new Point(10, 130) };
            Label labelExist = new Label
            {
                Text = "Triangle Exists: " + (triangle.ExistTriangle ? "Yes" : "No"),
                Location = new Point(10, 160)
            };

            // Добавляем метки на форму
            Controls.Add(labelA);
            Controls.Add(labelB);
            Controls.Add(labelC);
            Controls.Add(labelPerimeter);
            Controls.Add(labelSurface);
            Controls.Add(labelExist);
        }
    }
}