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
            StateBox = new TextBox();
            menuStrip1 = new MenuStrip();
            FileMenu = new ToolStripMenuItem();
            открытьДляЧтенияToolStripMenuItem = new ToolStripMenuItem();
            ReadPlainButton = new ToolStripMenuItem();
            ReadEncryptedButton = new ToolStripMenuItem();
            открытьДляЗаписиToolStripMenuItem = new ToolStripMenuItem();
            WritePlainButton = new ToolStripMenuItem();
            WriteEncryptedButton = new ToolStripMenuItem();
            KeyBox = new TextBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // EncryptButton
            // 
            EncryptButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            EncryptButton.Location = new Point(14, 515);
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
            PlainTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlainTextBox.Location = new Point(486, 29);
            PlainTextBox.Margin = new Padding(5);
            PlainTextBox.Multiline = true;
            PlainTextBox.Name = "PlainTextBox";
            PlainTextBox.Size = new Size(425, 211);
            PlainTextBox.TabIndex = 1;
            // 
            // EncryptedTextBox
            // 
            EncryptedTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EncryptedTextBox.Location = new Point(486, 266);
            EncryptedTextBox.Margin = new Padding(5);
            EncryptedTextBox.Multiline = true;
            EncryptedTextBox.Name = "EncryptedTextBox";
            EncryptedTextBox.Size = new Size(425, 211);
            EncryptedTextBox.TabIndex = 2;
            // 
            // DecryptButton
            // 
            DecryptButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DecryptButton.Location = new Point(606, 515);
            DecryptButton.Margin = new Padding(5);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(305, 73);
            DecryptButton.TabIndex = 4;
            DecryptButton.Text = "Дешифрировать";
            DecryptButton.UseVisualStyleBackColor = true;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // StateBox
            // 
            StateBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StateBox.ImeMode = ImeMode.Off;
            StateBox.Location = new Point(19, 29);
            StateBox.Multiline = true;
            StateBox.Name = "StateBox";
            StateBox.PlaceholderText = "Начальное состояние регистра";
            StateBox.Size = new Size(425, 211);
            StateBox.TabIndex = 6;
            StateBox.TextChanged += StateBox_TextChanged;
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
            // KeyBox
            // 
            KeyBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KeyBox.ImeMode = ImeMode.Off;
            KeyBox.Location = new Point(19, 266);
            KeyBox.Multiline = true;
            KeyBox.Name = "KeyBox";
            KeyBox.PlaceholderText = "Сгенерированный ключ";
            KeyBox.ReadOnly = true;
            KeyBox.Size = new Size(425, 211);
            KeyBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 243);
            label1.Name = "label1";
            label1.Size = new Size(447, 21);
            label1.TabIndex = 9;
            label1.Text = "Введённая длина состояния регистра ( длина регистра 30 ): 0";
            // 
            // MainWindowForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 611);
            Controls.Add(label1);
            Controls.Add(KeyBox);
            Controls.Add(StateBox);
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
        private TextBox StateBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileMenu;
        private ToolStripMenuItem открытьДляЧтенияToolStripMenuItem;
        private ToolStripMenuItem ReadPlainButton;
        private ToolStripMenuItem ReadEncryptedButton;
        private ToolStripMenuItem открытьДляЗаписиToolStripMenuItem;
        private ToolStripMenuItem WritePlainButton;
        private ToolStripMenuItem WriteEncryptedButton;
        private TextBox KeyBox;
        private Label label1;
    }
}