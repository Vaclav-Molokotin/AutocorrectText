
namespace AutocorrectText
{
    partial class FrmHome
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnOpenOrSaveFile = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.labPath = new System.Windows.Forms.Label();
            this.labSearch = new System.Windows.Forms.Label();
            this.labChange = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.labText = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbReplace
            // 
            this.tbReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReplace.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbReplace.Location = new System.Drawing.Point(437, 102);
            this.tbReplace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(323, 27);
            this.tbReplace.TabIndex = 4;
            this.tbReplace.TextChanged += new System.EventHandler(this.tbReplace_TextChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(29, 102);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(323, 27);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnReplace
            // 
            this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReplace.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnReplace.Location = new System.Drawing.Point(836, 102);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(191, 27);
            this.btnReplace.TabIndex = 6;
            this.btnReplace.Text = "Заменить";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnOpenOrSaveFile
            // 
            this.btnOpenOrSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenOrSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenOrSaveFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOpenOrSaveFile.Location = new System.Drawing.Point(836, 30);
            this.btnOpenOrSaveFile.Margin = new System.Windows.Forms.Padding(100, 2, 3, 2);
            this.btnOpenOrSaveFile.Name = "btnOpenOrSaveFile";
            this.btnOpenOrSaveFile.Size = new System.Drawing.Size(191, 27);
            this.btnOpenOrSaveFile.TabIndex = 1;
            this.btnOpenOrSaveFile.Text = "Выбрать файл";
            this.btnOpenOrSaveFile.UseVisualStyleBackColor = true;
            this.btnOpenOrSaveFile.Click += new System.EventHandler(this.btnOpenOrSaveFile_Click);
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.BackColor = System.Drawing.SystemColors.Window;
            this.tbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbPath.Location = new System.Drawing.Point(29, 30);
            this.tbPath.Margin = new System.Windows.Forms.Padding(3, 2, 100, 2);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(729, 27);
            this.tbPath.TabIndex = 2;
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            this.tbPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPath_EnterKeyPressed);
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbText.Location = new System.Drawing.Point(29, 187);
            this.tbText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbText.Size = new System.Drawing.Size(997, 324);
            this.tbText.TabIndex = 5;
            this.tbText.TextChanged += new System.EventHandler(this.tbText_OriginalTextChanged);
            // 
            // labPath
            // 
            this.labPath.AutoSize = true;
            this.labPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labPath.Location = new System.Drawing.Point(27, 7);
            this.labPath.Name = "labPath";
            this.labPath.Size = new System.Drawing.Size(102, 18);
            this.labPath.TabIndex = 9;
            this.labPath.Text = "Путь к файлу";
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labSearch.Location = new System.Drawing.Point(27, 79);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(158, 18);
            this.labSearch.TabIndex = 10;
            this.labSearch.Text = "Символы для поиска";
            // 
            // labChange
            // 
            this.labChange.AutoSize = true;
            this.labChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labChange.Location = new System.Drawing.Point(433, 79);
            this.labChange.Name = "labChange";
            this.labChange.Size = new System.Drawing.Size(163, 18);
            this.labChange.TabIndex = 11;
            this.labChange.Text = "Символы для замены";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // labText
            // 
            this.labText.AutoSize = true;
            this.labText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labText.Location = new System.Drawing.Point(26, 160);
            this.labText.Name = "labText";
            this.labText.Size = new System.Drawing.Size(121, 18);
            this.labText.TabIndex = 12;
            this.labText.Text = "Исходный текст";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(29, 543);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(191, 27);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnHelp.Location = new System.Drawing.Point(836, 543);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(191, 27);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Помощь";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(477, 530);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(93, 54);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 13;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1048, 603);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.labText);
            this.Controls.Add(this.labChange);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.labPath);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btnOpenOrSaveFile);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.tbSearch);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1015, 579);
            this.Name = "FrmHome";
            this.Padding = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.Text = "Автозамена текста";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnOpenOrSaveFile;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label labPath;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.Label labChange;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label labText;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

