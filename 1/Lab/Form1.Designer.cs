namespace Lab
{
    partial class MainWindowForm
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
            EncryptButton = new Button();
            PlainTextBox = new TextBox();
            EncryptedTextBox = new TextBox();
            DecryptButton = new Button();
            CipherListBox = new ListBox();
            KeyTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            FileMenu = new ToolStripMenuItem();
            открытьДляЧтенияToolStripMenuItem = new ToolStripMenuItem();
            ReadPlainButton = new ToolStripMenuItem();
            ReadEncryptedButton = new ToolStripMenuItem();
            открытьДляЗаписиToolStripMenuItem = new ToolStripMenuItem();
            WritePlainButton = new ToolStripMenuItem();
            WriteEncryptedButton = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // EncryptButton
            // 
            EncryptButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            EncryptButton.Location = new Point(19, 477);
            EncryptButton.Margin = new Padding(5);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(305, 73);
            EncryptButton.TabIndex = 0;
            EncryptButton.Text = "Зашифровать";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // PlainTextBox
            // 
            PlainTextBox.Location = new Point(19, 29);
            PlainTextBox.Margin = new Padding(5);
            PlainTextBox.Multiline = true;
            PlainTextBox.Name = "PlainTextBox";
            PlainTextBox.Size = new Size(425, 421);
            PlainTextBox.TabIndex = 1;
            // 
            // EncryptedTextBox
            // 
            EncryptedTextBox.Location = new Point(479, 29);
            EncryptedTextBox.Margin = new Padding(5);
            EncryptedTextBox.Multiline = true;
            EncryptedTextBox.Name = "EncryptedTextBox";
            EncryptedTextBox.Size = new Size(425, 421);
            EncryptedTextBox.TabIndex = 2;
            // 
            // DecryptButton
            // 
            DecryptButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DecryptButton.Location = new Point(599, 477);
            DecryptButton.Margin = new Padding(5);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(305, 73);
            DecryptButton.TabIndex = 4;
            DecryptButton.Text = "Дешифрировать";
            DecryptButton.UseVisualStyleBackColor = true;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // CipherListBox
            // 
            CipherListBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CipherListBox.FormattingEnabled = true;
            CipherListBox.ItemHeight = 25;
            CipherListBox.Items.AddRange(new object[] { "«Столбцовый метод» с одним ключевым словом, текст на русском языке", "Алгоритм Виженера, самогенерирующийся ключ, текст на русском языке " });
            CipherListBox.Location = new Point(19, 577);
            CipherListBox.Margin = new Padding(5);
            CipherListBox.Name = "CipherListBox";
            CipherListBox.Size = new Size(885, 129);
            CipherListBox.TabIndex = 5;
            CipherListBox.SelectedIndexChanged += CipherListBox_SelectedIndexChanged;
            // 
            // KeyTextBox
            // 
            KeyTextBox.ImeMode = ImeMode.Off;
            KeyTextBox.Location = new Point(381, 498);
            KeyTextBox.Name = "KeyTextBox";
            KeyTextBox.PlaceholderText = "Ключ";
            KeyTextBox.Size = new Size(158, 32);
            KeyTextBox.TabIndex = 6;
            KeyTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(925, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            FileMenu.BackColor = SystemColors.ActiveCaption;
            FileMenu.DropDownItems.AddRange(new ToolStripItem[] { открытьДляЧтенияToolStripMenuItem, открытьДляЗаписиToolStripMenuItem });
            FileMenu.Name = "FileMenu";
            FileMenu.Size = new Size(54, 20);
            FileMenu.Text = "Файл..";
            // 
            // открытьДляЧтенияToolStripMenuItem
            // 
            открытьДляЧтенияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ReadPlainButton, ReadEncryptedButton });
            открытьДляЧтенияToolStripMenuItem.Name = "открытьДляЧтенияToolStripMenuItem";
            открытьДляЧтенияToolStripMenuItem.Size = new Size(190, 22);
            открытьДляЧтенияToolStripMenuItem.Text = "Открыть для чтения..";
            // 
            // ReadPlainButton
            // 
            ReadPlainButton.Name = "ReadPlainButton";
            ReadPlainButton.Size = new Size(170, 22);
            ReadPlainButton.Text = "Исходного текста";
            ReadPlainButton.Click += ReadPlainButton_Click;
            // 
            // ReadEncryptedButton
            // 
            ReadEncryptedButton.Name = "ReadEncryptedButton";
            ReadEncryptedButton.Size = new Size(170, 22);
            ReadEncryptedButton.Text = "Шифротекста";
            ReadEncryptedButton.Click += ReadEncryptedButton_Click;
            // 
            // открытьДляЗаписиToolStripMenuItem
            // 
            открытьДляЗаписиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { WritePlainButton, WriteEncryptedButton });
            открытьДляЗаписиToolStripMenuItem.Name = "открытьДляЗаписиToolStripMenuItem";
            открытьДляЗаписиToolStripMenuItem.Size = new Size(190, 22);
            открытьДляЗаписиToolStripMenuItem.Text = "Открыть для записи..";
            // 
            // WritePlainButton
            // 
            WritePlainButton.Name = "WritePlainButton";
            WritePlainButton.Size = new Size(170, 22);
            WritePlainButton.Text = "Исходного текста";
            WritePlainButton.Click += WritePlainButton_Click;
            // 
            // WriteEncryptedButton
            // 
            WriteEncryptedButton.Name = "WriteEncryptedButton";
            WriteEncryptedButton.Size = new Size(170, 22);
            WriteEncryptedButton.Text = "Шифротекста";
            WriteEncryptedButton.Click += WriteEncryptedButton_Click;
            // 
            // MainWindowForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 727);
            Controls.Add(KeyTextBox);
            Controls.Add(CipherListBox);
            Controls.Add(DecryptButton);
            Controls.Add(EncryptedTextBox);
            Controls.Add(PlainTextBox);
            Controls.Add(EncryptButton);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MainWindowForm";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Теория информации, Шифратор-Дешифратор";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EncryptButton;
        private TextBox PlainTextBox;
        private TextBox EncryptedTextBox;
        private Button DecryptButton;
        private ListBox CipherListBox;
        private TextBox KeyTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileMenu;
        private ToolStripMenuItem открытьДляЧтенияToolStripMenuItem;
        private ToolStripMenuItem ReadPlainButton;
        private ToolStripMenuItem ReadEncryptedButton;
        private ToolStripMenuItem открытьДляЗаписиToolStripMenuItem;
        private ToolStripMenuItem WritePlainButton;
        private ToolStripMenuItem WriteEncryptedButton;
    }
}