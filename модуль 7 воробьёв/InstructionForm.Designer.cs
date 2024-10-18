namespace модуль_7_воробьёв
{
    partial class InstructionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelInstructions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionForm));
            labelInstructions = new Label();
            SuspendLayout();
            // 
            // labelInstructions
            // 
            labelInstructions.BackColor = Color.Transparent;
            labelInstructions.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInstructions.Location = new Point(21, 9);
            labelInstructions.Margin = new Padding(2, 0, 2, 0);
            labelInstructions.Name = "labelInstructions";
            labelInstructions.Size = new Size(940, 498);
            labelInstructions.TabIndex = 0;
            labelInstructions.Text = resources.GetString("labelInstructions.Text");
            // 
            // InstructionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(965, 514);
            Controls.Add(labelInstructions);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "InstructionForm";
            Text = "Инструкция";
            ResumeLayout(false);
        }
    }
}