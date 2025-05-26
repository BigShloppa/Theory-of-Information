namespace Lab
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }

        static StreamEncryptionMethod? crypt = new StreamEncryptionMethod();

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                crypt.register = new LFSR("10000 00000 00001 10000 00000 00001", StateBox.Text);
                if (crypt.register.state.Count != 30)
                    MessageBox.Show("Недостаточная длина многочлена состояния!");
                else
                {
                    if (EncryptedTextBox.Text.Length == 0)
                        MessageBox.Show("Не выбран файл для шифрования!");
                    else
                    {
                        crypt.generateKey();
                        crypt.decrypt();
                        PlainTextBox.Text = "Первые 15 байт: \n" + crypt.getFirstBytes(crypt.data)
                            + "\n                   Последние 15 байт: " + crypt.getLastBytes(crypt.data);
                        KeyBox.Text = "Первые 15 байт: \n" + crypt.getFirstBytes(crypt.key)
                            + "\n                   Последние 15 байт: " + crypt.getLastBytes(crypt.key);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Проверьте полноту полей ввода!");
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                crypt.register = new LFSR("10000 00000 00001 10000 00000 00001", StateBox.Text);
                if (crypt.register.state.Count != 30)
                    MessageBox.Show("Недостаточная длина многочлена состояния!");
                else
                {
                    if (PlainTextBox.Text.Length == 0)
                        MessageBox.Show("Не выбран файл для шифрования!");
                    else
                    {
                        crypt.generateKey();
                        crypt.encrypt();
                        EncryptedTextBox.Text = "Первые 15 байт: \n" + crypt.getFirstBytes(crypt.data)
                            + "\n                   Последние 15 байт: \n" + crypt.getLastBytes(crypt.data);
                        KeyBox.Text = "Первые 15 байт: \n" + crypt.getFirstBytes(crypt.key)
                            + "\n                   Последние 15 байт: \n" + crypt.getLastBytes(crypt.key);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Проверьте полноту полей ввода!");
            }
        }

        private void ReadPlainButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                crypt.readFile(filePath);
                PlainTextBox.Text = "Первые 15 байт: \n" + crypt.getFirstBytes(crypt.data)
                    + "\n                   Последние 15 байт: \n" + crypt.getLastBytes(crypt.data);
            }
        }

        private void WritePlainButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                crypt.writeFile(filePath);
            }
        }

        private void WriteEncryptedButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                crypt.writeFile(filePath);
            }
        }

        private void ReadEncryptedButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                crypt.readFile(filePath);
                EncryptedTextBox.Text = "Первые 15 байт: \n" + crypt.getFirstBytes(crypt.data)
                    + "\n                   Последние 15 байт: \n" + crypt.getLastBytes(crypt.data);
            }
        }

        private void StateBox_TextChanged(object sender, EventArgs e)
        {
            crypt.register = new LFSR("10000 00000 00001 10000 00000 00001", StateBox.Text);
            label1.Text = "Введённая длина состояния регистра ( длина регистра 30 ): " + crypt.register.state.Count.ToString();
        }
    }
}