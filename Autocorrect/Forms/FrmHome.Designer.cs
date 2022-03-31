
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
            this.tbReplace.Location = new System.Drawing.Point(328, 83);
            this.tbReplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(243, 23);
            this.tbReplace.TabIndex = 5;
            this.tbReplace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbReplace_KeyPress);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(22, 83);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(243, 23);
            this.tbSearch.TabIndex = 4;
            // 
            // btnReplace
            // 
            this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReplace.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnReplace.Location = new System.Drawing.Point(627, 83);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(143, 22);
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
            this.btnOpenOrSaveFile.Location = new System.Drawing.Point(627, 24);
            this.btnOpenOrSaveFile.Margin = new System.Windows.Forms.Padding(75, 2, 2, 2);
            this.btnOpenOrSaveFile.Name = "btnOpenOrSaveFile";
            this.btnOpenOrSaveFile.Size = new System.Drawing.Size(143, 22);
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
            this.tbPath.Location = new System.Drawing.Point(22, 24);
            this.tbPath.Margin = new System.Windows.Forms.Padding(2, 2, 75, 2);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(548, 23);
            this.tbPath.TabIndex = 2;
            this.tbPath.TabStop = false;
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            this.tbPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPath_EnterKeyPressed);
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbText.Location = new System.Drawing.Point(22, 152);
            this.tbText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbText.Size = new System.Drawing.Size(749, 264);
            this.tbText.TabIndex = 3;
            this.tbText.TextChanged += new System.EventHandler(this.tbText_OriginalTextChanged);
            // 
            // labPath
            // 
            this.labPath.AutoSize = true;
            this.labPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labPath.Location = new System.Drawing.Point(20, 6);
            this.labPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPath.Name = "labPath";
            this.labPath.Size = new System.Drawing.Size(84, 15);
            this.labPath.TabIndex = 9;
            this.labPath.Text = "Путь к файлу";
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labSearch.Location = new System.Drawing.Point(20, 64);
            this.labSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(128, 15);
            this.labSearch.TabIndex = 10;
            this.labSearch.Text = "Символы для поиска";
            // 
            // labChange
            // 
            this.labChange.AutoSize = true;
            this.labChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labChange.Location = new System.Drawing.Point(325, 64);
            this.labChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labChange.Name = "labChange";
            this.labChange.Size = new System.Drawing.Size(133, 15);
            this.labChange.TabIndex = 11;
            this.labChange.Text = "Символы для замены";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // labText
            // 
            this.labText.AutoSize = true;
            this.labText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labText.Location = new System.Drawing.Point(20, 133);
            this.labText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labText.Name = "labText";
            this.labText.Size = new System.Drawing.Size(101, 15);
            this.labText.TabIndex = 12;
            this.labText.Text = "Исходный текст";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(22, 441);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 22);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnResetClick);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnHelp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnHelp.Location = new System.Drawing.Point(627, 441);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(143, 22);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Помощь";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(358, 431);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(70, 44);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 13;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(786, 490);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(766, 479);
            this.Name = "formHome";
            this.Padding = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.Text = "Автозамена текста";
            this.Load += new System.EventHandler(this.formHome_Load);
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

