using System;
using System.Windows.Forms;

namespace модуль_7_воробьёв
{
    public partial class Form1 : Form
    {
        // Конструктор формы
        public Form1()
        {
            InitializeComponent();  // Инициализация компонентов формы
        }

        // Метод, обрабатывающий клик по кнопке "Рассчитать"
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение данных от пользователя: вес и рост
                double weight = Convert.ToDouble(textBoxWeight.Text);  // Преобразование текста из текстового поля в число
                double height = Convert.ToDouble(textBoxHeight.Text);

                // Проверка на корректность ввода данных: должны быть положительные значения
                if (weight <= 0 || height <= 0)
                {
                    // Если введены неверные данные, выводится сообщение об ошибке
                    MessageBox.Show("Введите положительные значения для веса и роста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Завершение метода, если данные некорректны
                }

                // Рассчет ИМТ (индекса массы тела) по формуле: вес (кг) / (рост (м) * рост (м))
                double bmi = weight / (height * height);

                // Определение категории по ИМТ
                string category;
                if (bmi < 18.5)
                {
                    category = "Недостаточный вес";  // ИМТ < 18.5: недостаточный вес
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    category = "Нормальный вес";  // ИМТ в диапазоне 18.5 - 24.9: нормальный вес
                }
                else if (bmi >= 25 && bmi <= 29.9)
                {
                    category = "Избыточный вес";  // ИМТ в диапазоне 25 - 29.9: избыточный вес
                }
                else if (bmi >= 30 && bmi <= 34.9)
                {
                    category = "Ожирение 1 степени";  // ИМТ в диапазоне 30 - 34.9: ожирение 1 степени
                }
                else if (bmi >= 35 && bmi <= 39.9)
                {
                    category = "Ожирение 2 степени";  // ИМТ в диапазоне 35 - 39.9: ожирение 2 степени
                }
                else
                {
                    category = "Ожирение 3 степени";  // ИМТ >= 40: ожирение 3 степени
                }

                // Вывод результата на форму: ИМТ и категория
                labelResult.Text = $"Ваш ИМТ: {bmi:F2} ({category})";
            }
            catch (FormatException)
            {
                // Обработка исключения, если введены некорректные данные (например, буквы вместо чисел)
                MessageBox.Show("Пожалуйста, введите корректные значения для веса и роста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод, обрабатывающий клик по кнопке "Инструкция"
        private void buttonInstructions_Click(object sender, EventArgs e)
        {
            // Открытие формы с инструкцией
            InstructionForm instructionForm = new InstructionForm();
            instructionForm.ShowDialog();  // Открывает новую форму с инструкцией
        }
    }
}