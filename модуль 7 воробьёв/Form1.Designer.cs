namespace модуль_7_воробьёв
{
    partial class Form1
    {
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonInstructions;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelWeight = new Label();
            labelHeight = new Label();
            textBoxWeight = new TextBox();
            textBoxHeight = new TextBox();
            buttonCalculate = new Button();
            labelResult = new Label();
            buttonInstructions = new Button();
            SuspendLayout();
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.BackColor = Color.Transparent;
            labelWeight.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWeight.Location = new Point(23, 22);
            labelWeight.Margin = new Padding(2, 0, 2, 0);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(115, 17);
            labelWeight.TabIndex = 0;
            labelWeight.Text = "Введите вес (кг):";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.BackColor = Color.Transparent;
            labelHeight.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelHeight.Location = new Point(23, 60);
            labelHeight.Margin = new Padding(2, 0, 2, 0);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(120, 17);
            labelHeight.TabIndex = 1;
            labelHeight.Text = "Введите рост (м):";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(142, 20);
            textBoxWeight.Margin = new Padding(2);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(105, 23);
            textBoxWeight.TabIndex = 2;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(142, 58);
            textBoxHeight.Margin = new Padding(2);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(105, 23);
            textBoxHeight.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = Color.FromArgb(34, 139, 34);
            buttonCalculate.Cursor = Cursors.Hand;
            buttonCalculate.FlatAppearance.BorderSize = 0;
            buttonCalculate.FlatStyle = FlatStyle.Flat;
            buttonCalculate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCalculate.ForeColor = Color.White;
            buttonCalculate.Location = new Point(87, 95);
            buttonCalculate.Margin = new Padding(2);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(113, 35);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Рассчитать";
            buttonCalculate.UseVisualStyleBackColor = false;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = Color.Transparent;
            labelResult.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelResult.Location = new Point(23, 135);
            labelResult.Margin = new Padding(2, 0, 2, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(76, 17);
            labelResult.TabIndex = 5;
            labelResult.Text = "Ваш ИМТ: ";
            // 
            // buttonInstructions
            // 
            buttonInstructions.BackColor = Color.FromArgb(0, 123, 255);
            buttonInstructions.Cursor = Cursors.Hand;
            buttonInstructions.FlatAppearance.BorderSize = 0;
            buttonInstructions.FlatStyle = FlatStyle.Flat;
            buttonInstructions.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonInstructions.ForeColor = Color.White;
            buttonInstructions.Location = new Point(87, 160);
            buttonInstructions.Margin = new Padding(2);
            buttonInstructions.Name = "buttonInstructions";
            buttonInstructions.Size = new Size(113, 35);
            buttonInstructions.TabIndex = 6;
            buttonInstructions.Text = "Инструкция";
            buttonInstructions.UseVisualStyleBackColor = false;
            buttonInstructions.Click += buttonInstructions_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(293, 206);
            Controls.Add(buttonInstructions);
            Controls.Add(labelResult);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxWeight);
            Controls.Add(labelHeight);
            Controls.Add(labelWeight);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Калькулятор ИМТ";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}