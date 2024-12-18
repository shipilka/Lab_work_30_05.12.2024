using System.Windows.Forms;

namespace Lab_work_30_05._12._2024
{
    public partial class Form1 : Form
    {
        private string currentFileName = "Безымянный";

        public Form1()
        {
            InitializeComponent();
            richTextBox1.Dock = DockStyle.Fill;
            this.Text = currentFileName;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            currentFileName = "Безымянный";
            this.Text = currentFileName;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые документы (*.txt)|*.txt|Текст в формате rtf (*.rtf)|*.rtf|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    currentFileName = openFileDialog.FileName;
                    this.Text = currentFileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые документы (*.txt)|*.txt|Текст в формате rtf (*.rtf)|*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (saveFileDialog.FileName.EndsWith(".rtf"))
                    {
                        richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                    }
                    currentFileName = saveFileDialog.FileName;
                    this.Text = currentFileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
                }
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ночнаяТемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ночнаяТемаToolStripMenuItem.Checked)
            {
                richTextBox1.BackColor = Color.DarkBlue;
                richTextBox1.ForeColor = Color.White;
            }
            else
            {
                richTextBox1.BackColor = Color.White;
                richTextBox1.ForeColor = Color.Black;
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
