namespace Lab_work_30_05._12._2024
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HelloButton = new Button();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // HelloButton
            // 
            HelloButton.BackgroundImage = Properties.Resources.Hello;
            HelloButton.Location = new Point(40, 52);
            HelloButton.Name = "HelloButton";
            HelloButton.Size = new Size(454, 169);
            HelloButton.TabIndex = 0;
            HelloButton.Text = "Привет!";
            HelloButton.TextAlign = ContentAlignment.TopLeft;
            HelloButton.UseVisualStyleBackColor = true;
            HelloButton.Click += HelloButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = Properties.Resources.Close;
            CloseButton.Location = new Point(40, 227);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(454, 211);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Закрыть";
            CloseButton.TextAlign = ContentAlignment.TopLeft;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 450);
            Controls.Add(CloseButton);
            Controls.Add(HelloButton);
            Name = "Form2";
            Text = "Второе окошечко";
            ResumeLayout(false);
        }

        #endregion

        private Button HelloButton;
        private Button CloseButton;
    }
}