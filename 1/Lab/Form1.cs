namespace Lab
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }

        static CryptMethod? MethodToCrypth;

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MethodToCrypth != null)
                {
                    MethodToCrypth.ReadText(EncryptedTextBox.Text);
                    MethodToCrypth.ReadKey(KeyTextBox.Text);
                    MethodToCrypth.Decrypt();
                    PlainTextBox.Text = MethodToCrypth.WriteText();
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
                if (MethodToCrypth != null)
                {
                    MethodToCrypth.ReadText(PlainTextBox.Text);
                    MethodToCrypth.ReadKey(KeyTextBox.Text);
                    MethodToCrypth.Encrypt();
                    EncryptedTextBox.Text = MethodToCrypth.WriteText();
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
            ofd.Filter = "txt files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    PlainTextBox.Text = reader.ReadToEnd();
                    reader.Close();
                }
            }
        }

        private void WritePlainButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(PlainTextBox.Text);
                    writer.Close();
                }
            }
        }

        private void WriteEncryptedButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(EncryptedTextBox.Text);
                    writer.Close();
                }
            }
        }

        private void ReadEncryptedButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    EncryptedTextBox.Text = reader.ReadToEnd();
                    reader.Close();
                }
            }
        }

        private void CipherListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CipherListBox.SelectedIndex)
            {
                case 0:
                    MethodToCrypth = new ColumnMethod();
                    break;
                case 1:
                    MethodToCrypth = new VigenèreSelfGenMethod();
                    break;
                case -1:
                    MethodToCrypth = null;
                    break;
            }
        }
        /*   private void MainWindowForm_KeyDown(object sender, KeyEventArgs e)
           {
               switch (e.KeyCode)
               {
                   case Keys.F2:
                       ReadPlainButton_Click(sender, e);
                       break;
                   case Keys.F3:
                       WriteEncryptedButton_Click(sender, e);
                       break;
                   case Keys.F4:
                       ReadEncryptedButton_Click(sender, e);
                       break;
                   case Keys.F5:
                       WritePlainButton_Click(sender, e);
                       break;
               }
           }*/
    }
}