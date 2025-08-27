namespace ej
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSimularDia = new Button();
            lsbSimular = new ListBox();
            SuspendLayout();
            // 
            // btnSimularDia
            // 
            btnSimularDia.Location = new Point(664, 196);
            btnSimularDia.Name = "btnSimularDia";
            btnSimularDia.Size = new Size(151, 54);
            btnSimularDia.TabIndex = 0;
            btnSimularDia.Text = "Simular Dia";
            btnSimularDia.UseVisualStyleBackColor = true;
            btnSimularDia.Click += btnSimularDia_Click;
            // 
            // lsbSimular
            // 
            lsbSimular.FormattingEnabled = true;
            lsbSimular.HorizontalScrollbar = true;
            lsbSimular.ItemHeight = 15;
            lsbSimular.Location = new Point(12, 12);
            lsbSimular.Name = "lsbSimular";
            lsbSimular.ScrollAlwaysVisible = true;
            lsbSimular.Size = new Size(646, 454);
            lsbSimular.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 482);
            Controls.Add(lsbSimular);
            Controls.Add(btnSimularDia);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSimularDia;
        private ListBox lsbSimular;
    }
}
