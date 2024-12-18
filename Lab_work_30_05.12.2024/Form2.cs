using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_work_30_05._12._2024
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.AcceptButton = HelloButton; 
            this.CancelButton = CloseButton;
            HelloButton.FlatStyle = FlatStyle.Flat;
            //HelloButton.Image = Image.FromFile(@"C:\Users\Александр\source\repos\Lab_work_30_05.12.2024\Lab_work_30_05.12.2024\Hello"); 
            HelloButton.ImageAlign = ContentAlignment.MiddleLeft;
            HelloButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            HelloButton.Padding = new Padding(10, 0, 0, 0);

            CloseButton.FlatStyle = FlatStyle.Flat;
            
            CloseButton.ImageAlign = ContentAlignment.MiddleLeft;
            CloseButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CloseButton.Padding = new Padding(10, 0, 0, 0);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здравствуйте!");
        }

        
    }
}
