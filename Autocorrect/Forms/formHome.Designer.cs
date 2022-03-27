
namespace Autocorrect
{
    partial class formHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonFileSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReplace.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxReplace.Location = new System.Drawing.Point(437, 102);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(323, 27);
            this.textBoxReplace.TabIndex = 3;
            this.textBoxReplace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbReplace_KeyPress);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSearch.Location = new System.Drawing.Point(30, 102);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(323, 27);
            this.textBoxSearch.TabIndex = 2;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReplace.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonReplace.Location = new System.Drawing.Point(836, 102);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(191, 27);
            this.buttonReplace.TabIndex = 7;
            this.buttonReplace.Text = "Заменить";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonOpenFile.Location = new System.Drawing.Point(836, 30);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(191, 27);
            this.buttonOpenFile.TabIndex = 6;
            this.buttonOpenFile.Text = "Выбрать файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxPath.Location = new System.Drawing.Point(30, 30);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(730, 27);
            this.textBoxPath.TabIndex = 5;
            this.textBoxPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            this.textBoxPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPath_EnterKeyPressed);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(30, 187);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(997, 324);
            this.textBox.TabIndex = 8;
            this.textBox.TextChanged += new System.EventHandler(this.tbText_OriginalTextChanged);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelPath.Location = new System.Drawing.Point(26, 7);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(102, 18);
            this.labelPath.TabIndex = 9;
            this.labelPath.Text = "Путь к файлу";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelSearch.Location = new System.Drawing.Point(26, 79);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(158, 18);
            this.labelSearch.TabIndex = 10;
            this.labelSearch.Text = "Символы для поиска";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelChange.Location = new System.Drawing.Point(433, 79);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(163, 18);
            this.labelChange.TabIndex = 11;
            this.labelChange.Text = "Символы для замены";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelText.Location = new System.Drawing.Point(26, 164);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(121, 18);
            this.labelText.TabIndex = 12;
            this.labelText.Text = "Исходный текст";
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonBack.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonBack.Location = new System.Drawing.Point(836, 102);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(191, 27);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // buttonFileSave
            // 
            this.buttonFileSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFileSave.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonFileSave.Location = new System.Drawing.Point(836, 30);
            this.buttonFileSave.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.buttonFileSave.Name = "buttonFileSave";
            this.buttonFileSave.Size = new System.Drawing.Size(191, 27);
            this.buttonFileSave.TabIndex = 14;
            this.buttonFileSave.Text = "Сохранить в файл";
            this.buttonFileSave.UseVisualStyleBackColor = true;
            this.buttonFileSave.Visible = false;
            this.buttonFileSave.Click += new System.EventHandler(this.btnFileSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonReset.ForeColor = System.Drawing.Color.Red;
            this.buttonReset.Location = new System.Drawing.Point(30, 543);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(191, 27);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.btnResetClick);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonHelp.Location = new System.Drawing.Point(836, 543);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(191, 27);
            this.buttonHelp.TabIndex = 16;
            this.buttonHelp.Text = "Помощь";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1048, 603);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonFileSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.textBoxReplace);
            this.Controls.Add(this.textBoxSearch);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1016, 580);
            this.Name = "formHome";
            this.Padding = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.Text = "Автозамена текста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonFileSave;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button buttonHelp;
    }
}

