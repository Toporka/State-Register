namespace Registry
{
    partial class Registry
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
            this.components = new System.ComponentModel.Container();
            this.LegalEntity = new System.Windows.Forms.RadioButton();
            this.SoleTrader = new System.Windows.Forms.RadioButton();
            this.INN_OGRN = new System.Windows.Forms.ComboBox();
            this.WriteData = new System.Windows.Forms.TextBox();
            this.butGetReq = new System.Windows.Forms.Button();
            this.CheckSign = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.SaveDoc = new System.Windows.Forms.Button();
            this.Datas = new System.Windows.Forms.ListBox();
            this.Loading = new System.Windows.Forms.ProgressBar();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.labSearch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorWrData = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSign = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrint = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSave = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWrData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSave)).BeginInit();
            this.SuspendLayout();
            // 
            // LegalEntity
            // 
            this.LegalEntity.AutoSize = true;
            this.LegalEntity.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LegalEntity.Location = new System.Drawing.Point(25, 98);
            this.LegalEntity.Name = "LegalEntity";
            this.LegalEntity.Size = new System.Drawing.Size(155, 22);
            this.LegalEntity.TabIndex = 0;
            this.LegalEntity.TabStop = true;
            this.LegalEntity.Text = "Юридическое лицо";
            this.LegalEntity.UseVisualStyleBackColor = true;
            // 
            // SoleTrader
            // 
            this.SoleTrader.AutoSize = true;
            this.SoleTrader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SoleTrader.Location = new System.Drawing.Point(218, 98);
            this.SoleTrader.Name = "SoleTrader";
            this.SoleTrader.Size = new System.Drawing.Size(267, 22);
            this.SoleTrader.TabIndex = 1;
            this.SoleTrader.TabStop = true;
            this.SoleTrader.Text = "Индивидуальный предприниматель";
            this.SoleTrader.UseVisualStyleBackColor = true;
            // 
            // INN_OGRN
            // 
            this.INN_OGRN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.INN_OGRN.FormattingEnabled = true;
            this.INN_OGRN.Items.AddRange(new object[] {
            "ИНН",
            "ОГРН"});
            this.INN_OGRN.Location = new System.Drawing.Point(25, 147);
            this.INN_OGRN.Name = "INN_OGRN";
            this.INN_OGRN.Size = new System.Drawing.Size(79, 24);
            this.INN_OGRN.TabIndex = 2;
            // 
            // WriteData
            // 
            this.WriteData.Location = new System.Drawing.Point(110, 147);
            this.WriteData.MaxLength = 13;
            this.WriteData.Name = "WriteData";
            this.WriteData.Size = new System.Drawing.Size(129, 22);
            this.WriteData.TabIndex = 3;
            this.WriteData.Validating += new System.ComponentModel.CancelEventHandler(this.WriteData_Validating);
            // 
            // butGetReq
            // 
            this.butGetReq.BackColor = System.Drawing.SystemColors.Highlight;
            this.butGetReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butGetReq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butGetReq.Location = new System.Drawing.Point(295, 141);
            this.butGetReq.Name = "butGetReq";
            this.butGetReq.Size = new System.Drawing.Size(163, 34);
            this.butGetReq.TabIndex = 4;
            this.butGetReq.Text = "Получить заяву";
            this.butGetReq.UseVisualStyleBackColor = false;
            this.butGetReq.Click += new System.EventHandler(this.butGetReq_Click);
            // 
            // CheckSign
            // 
            this.CheckSign.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CheckSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckSign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckSign.Location = new System.Drawing.Point(605, 71);
            this.CheckSign.Name = "CheckSign";
            this.CheckSign.Size = new System.Drawing.Size(183, 30);
            this.CheckSign.TabIndex = 5;
            this.CheckSign.Text = "Проверить подпись";
            this.CheckSign.UseVisualStyleBackColor = false;
            this.CheckSign.Click += new System.EventHandler(this.CheckSign_Click);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Print.Location = new System.Drawing.Point(605, 107);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(183, 30);
            this.Print.TabIndex = 6;
            this.Print.Text = "Печать";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // SaveDoc
            // 
            this.SaveDoc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SaveDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveDoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveDoc.Location = new System.Drawing.Point(605, 143);
            this.SaveDoc.Name = "SaveDoc";
            this.SaveDoc.Size = new System.Drawing.Size(183, 30);
            this.SaveDoc.TabIndex = 7;
            this.SaveDoc.Text = "Сохранить";
            this.SaveDoc.UseVisualStyleBackColor = false;
            this.SaveDoc.Click += new System.EventHandler(this.SaveDoc_Click);
            // 
            // Datas
            // 
            this.Datas.FormattingEnabled = true;
            this.Datas.ItemHeight = 16;
            this.Datas.Location = new System.Drawing.Point(-2, 222);
            this.Datas.Name = "Datas";
            this.Datas.Size = new System.Drawing.Size(802, 228);
            this.Datas.TabIndex = 8;
            // 
            // Loading
            // 
            this.Loading.Location = new System.Drawing.Point(218, 324);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(369, 15);
            this.Loading.TabIndex = 9;
            this.Loading.Visible = false;
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 1500;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSearch.Location = new System.Drawing.Point(319, 301);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(166, 20);
            this.labSearch.TabIndex = 10;
            this.labSearch.Text = "Поиск совпадений";
            this.labSearch.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // errorWrData
            // 
            this.errorWrData.ContainerControl = this;
            // 
            // errorSign
            // 
            this.errorSign.ContainerControl = this;
            this.errorSign.RightToLeft = true;
            // 
            // errorPrint
            // 
            this.errorPrint.ContainerControl = this;
            this.errorPrint.RightToLeft = true;
            // 
            // errorSave
            // 
            this.errorSave.ContainerControl = this;
            this.errorSave.RightToLeft = true;
            // 
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.Datas);
            this.Controls.Add(this.SaveDoc);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.CheckSign);
            this.Controls.Add(this.butGetReq);
            this.Controls.Add(this.WriteData);
            this.Controls.Add(this.INN_OGRN);
            this.Controls.Add(this.SoleTrader);
            this.Controls.Add(this.LegalEntity);
            this.Name = "Registry";
            this.Text = "Выписка из гос. реестра";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWrData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton LegalEntity;
        private System.Windows.Forms.RadioButton SoleTrader;
        private System.Windows.Forms.ComboBox INN_OGRN;
        private System.Windows.Forms.TextBox WriteData;
        private System.Windows.Forms.Button butGetReq;
        private System.Windows.Forms.Button CheckSign;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button SaveDoc;
        private System.Windows.Forms.ListBox Datas;
        private System.Windows.Forms.ProgressBar Loading;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorWrData;
        private System.Windows.Forms.ErrorProvider errorSign;
        private System.Windows.Forms.ErrorProvider errorPrint;
        private System.Windows.Forms.ErrorProvider errorSave;
    }
}

