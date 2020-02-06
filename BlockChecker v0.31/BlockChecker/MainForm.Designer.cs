namespace BlockChecker
{
	partial class MainForm
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.WorkPage = new System.Windows.Forms.TabPage();
			this.filePathLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ProviderNameBox = new System.Windows.Forms.TextBox();
			this.buttonStop = new System.Windows.Forms.Button();
			this.AutoScrollBox = new System.Windows.Forms.CheckBox();
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.timer = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonChooseFile = new System.Windows.Forms.Button();
			this.SettingPage = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.domainPingBox = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.timeOutInput = new System.Windows.Forms.NumericUpDown();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.addStubButton = new System.Windows.Forms.Button();
			this.stubsFilterSave = new System.Windows.Forms.Button();
			this.stubsBox = new System.Windows.Forms.RichTextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.domainsFilterSave = new System.Windows.Forms.Button();
			this.domainsBox = new System.Windows.Forms.RichTextBox();
			this.resultPage = new System.Windows.Forms.TabPage();
			this.resultBox = new System.Windows.Forms.RichTextBox();
			this.sessionPage = new System.Windows.Forms.TabPage();
			this.nowSessionLabel = new System.Windows.Forms.Label();
			this.newSessionBtn = new System.Windows.Forms.RadioButton();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.sessionFile = new System.Windows.Forms.TextBox();
			this.SessionList = new System.Windows.Forms.ListBox();
			this.tabControl.SuspendLayout();
			this.WorkPage.SuspendLayout();
			this.SettingPage.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.timeOutInput)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.resultPage.SuspendLayout();
			this.sessionPage.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.WorkPage);
			this.tabControl.Controls.Add(this.SettingPage);
			this.tabControl.Controls.Add(this.resultPage);
			this.tabControl.Controls.Add(this.sessionPage);
			this.tabControl.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl.ItemSize = new System.Drawing.Size(120, 32);
			this.tabControl.Location = new System.Drawing.Point(1, -1);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(951, 495);
			this.tabControl.TabIndex = 0;
			// 
			// WorkPage
			// 
			this.WorkPage.Controls.Add(this.filePathLabel);
			this.WorkPage.Controls.Add(this.label3);
			this.WorkPage.Controls.Add(this.label1);
			this.WorkPage.Controls.Add(this.ProviderNameBox);
			this.WorkPage.Controls.Add(this.buttonStop);
			this.WorkPage.Controls.Add(this.AutoScrollBox);
			this.WorkPage.Controls.Add(this.richTextBox);
			this.WorkPage.Controls.Add(this.timer);
			this.WorkPage.Controls.Add(this.progressBar);
			this.WorkPage.Controls.Add(this.buttonStart);
			this.WorkPage.Controls.Add(this.buttonChooseFile);
			this.WorkPage.Location = new System.Drawing.Point(4, 36);
			this.WorkPage.Name = "WorkPage";
			this.WorkPage.Padding = new System.Windows.Forms.Padding(3);
			this.WorkPage.Size = new System.Drawing.Size(943, 455);
			this.WorkPage.TabIndex = 0;
			this.WorkPage.Text = "Проверка";
			this.WorkPage.UseVisualStyleBackColor = true;
			// 
			// filePathLabel
			// 
			this.filePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.filePathLabel.AutoSize = true;
			this.filePathLabel.Location = new System.Drawing.Point(239, 391);
			this.filePathLabel.Name = "filePathLabel";
			this.filePathLabel.Size = new System.Drawing.Size(118, 16);
			this.filePathLabel.TabIndex = 10;
			this.filePathLabel.Text = "Файл не выбран";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(140, 391);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 16);
			this.label3.TabIndex = 9;
			this.label3.Text = "Путь файла:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(779, 404);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Название провайдера";
			// 
			// ProviderNameBox
			// 
			this.ProviderNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ProviderNameBox.Location = new System.Drawing.Point(710, 423);
			this.ProviderNameBox.Name = "ProviderNameBox";
			this.ProviderNameBox.Size = new System.Drawing.Size(225, 23);
			this.ProviderNameBox.TabIndex = 7;
			this.ProviderNameBox.Text = "МТС";
			this.ProviderNameBox.TextChanged += new System.EventHandler(this.ProviderNameBox_TextChanged);
			// 
			// buttonStop
			// 
			this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonStop.Location = new System.Drawing.Point(465, 420);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(210, 29);
			this.buttonStop.TabIndex = 6;
			this.buttonStop.Text = "Остановить проверку";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// AutoScrollBox
			// 
			this.AutoScrollBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AutoScrollBox.AutoSize = true;
			this.AutoScrollBox.Checked = true;
			this.AutoScrollBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoScrollBox.Location = new System.Drawing.Point(6, 390);
			this.AutoScrollBox.Name = "AutoScrollBox";
			this.AutoScrollBox.Size = new System.Drawing.Size(130, 20);
			this.AutoScrollBox.TabIndex = 5;
			this.AutoScrollBox.Text = "Автопрокрутка";
			this.AutoScrollBox.UseVisualStyleBackColor = true;
			// 
			// richTextBox
			// 
			this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox.AutoWordSelection = true;
			this.richTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.richTextBox.Location = new System.Drawing.Point(0, 0);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.Size = new System.Drawing.Size(943, 357);
			this.richTextBox.TabIndex = 4;
			this.richTextBox.Text = "";
			this.richTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox_LinkClicked);
			this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
			// 
			// timer
			// 
			this.timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.timer.AutoSize = true;
			this.timer.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.timer.Location = new System.Drawing.Point(5, 360);
			this.timer.Name = "timer";
			this.timer.Size = new System.Drawing.Size(66, 16);
			this.timer.TabIndex = 3;
			this.timer.Text = "00:00:00";
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(88, 360);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(848, 24);
			this.progressBar.TabIndex = 2;
			// 
			// buttonStart
			// 
			this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonStart.Location = new System.Drawing.Point(232, 420);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(210, 29);
			this.buttonStart.TabIndex = 0;
			this.buttonStart.Text = "Начать проверрку";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonChooseFile
			// 
			this.buttonChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonChooseFile.Location = new System.Drawing.Point(3, 420);
			this.buttonChooseFile.Name = "buttonChooseFile";
			this.buttonChooseFile.Size = new System.Drawing.Size(210, 29);
			this.buttonChooseFile.TabIndex = 0;
			this.buttonChooseFile.Text = "Выбрать файл (txt)";
			this.buttonChooseFile.UseVisualStyleBackColor = true;
			this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
			// 
			// SettingPage
			// 
			this.SettingPage.BackColor = System.Drawing.Color.Silver;
			this.SettingPage.Controls.Add(this.groupBox4);
			this.SettingPage.Controls.Add(this.groupBox3);
			this.SettingPage.Controls.Add(this.groupBox2);
			this.SettingPage.Controls.Add(this.groupBox1);
			this.SettingPage.Location = new System.Drawing.Point(4, 36);
			this.SettingPage.Name = "SettingPage";
			this.SettingPage.Padding = new System.Windows.Forms.Padding(3);
			this.SettingPage.Size = new System.Drawing.Size(943, 455);
			this.SettingPage.TabIndex = 1;
			this.SettingPage.Text = "Настройки";
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox4.BackColor = System.Drawing.Color.White;
			this.groupBox4.Controls.Add(this.domainPingBox);
			this.groupBox4.Location = new System.Drawing.Point(177, 391);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(209, 58);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Домен для PING";
			// 
			// domainPingBox
			// 
			this.domainPingBox.Location = new System.Drawing.Point(6, 22);
			this.domainPingBox.Name = "domainPingBox";
			this.domainPingBox.Size = new System.Drawing.Size(197, 23);
			this.domainPingBox.TabIndex = 0;
			this.domainPingBox.TextChanged += new System.EventHandler(this.domainPingBox_TextChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox3.BackColor = System.Drawing.Color.White;
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.timeOutInput);
			this.groupBox3.Location = new System.Drawing.Point(7, 375);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(156, 74);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Время ожидания ответа";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(103, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "сек";
			// 
			// timeOutInput
			// 
			this.timeOutInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.timeOutInput.Location = new System.Drawing.Point(6, 38);
			this.timeOutInput.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.timeOutInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.timeOutInput.Name = "timeOutInput";
			this.timeOutInput.Size = new System.Drawing.Size(68, 23);
			this.timeOutInput.TabIndex = 0;
			this.timeOutInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.timeOutInput.ValueChanged += new System.EventHandler(this.timeOutInput_ValueChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.addStubButton);
			this.groupBox2.Controls.Add(this.stubsFilterSave);
			this.groupBox2.Controls.Add(this.stubsBox);
			this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(357, 6);
			this.groupBox2.MaximumSize = new System.Drawing.Size(1560, 940);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(579, 310);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Список триггеров";
			// 
			// addStubButton
			// 
			this.addStubButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addStubButton.Enabled = false;
			this.addStubButton.Location = new System.Drawing.Point(6, 268);
			this.addStubButton.Name = "addStubButton";
			this.addStubButton.Size = new System.Drawing.Size(100, 36);
			this.addStubButton.TabIndex = 2;
			this.addStubButton.Text = "Добавить";
			this.addStubButton.UseVisualStyleBackColor = true;
			this.addStubButton.Click += new System.EventHandler(this.addStubButton_Click);
			// 
			// stubsFilterSave
			// 
			this.stubsFilterSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.stubsFilterSave.Location = new System.Drawing.Point(473, 268);
			this.stubsFilterSave.Name = "stubsFilterSave";
			this.stubsFilterSave.Size = new System.Drawing.Size(100, 36);
			this.stubsFilterSave.TabIndex = 1;
			this.stubsFilterSave.Text = "Сохранить";
			this.stubsFilterSave.UseVisualStyleBackColor = true;
			this.stubsFilterSave.Click += new System.EventHandler(this.stubsFilterSave_Click);
			// 
			// stubsBox
			// 
			this.stubsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.stubsBox.Location = new System.Drawing.Point(6, 22);
			this.stubsBox.Name = "stubsBox";
			this.stubsBox.Size = new System.Drawing.Size(567, 240);
			this.stubsBox.TabIndex = 0;
			this.stubsBox.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.domainsFilterSave);
			this.groupBox1.Controls.Add(this.domainsBox);
			this.groupBox1.Location = new System.Drawing.Point(7, 6);
			this.groupBox1.MaximumSize = new System.Drawing.Size(720, 940);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(292, 310);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Список доменов";
			// 
			// domainsFilterSave
			// 
			this.domainsFilterSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.domainsFilterSave.Location = new System.Drawing.Point(186, 268);
			this.domainsFilterSave.Name = "domainsFilterSave";
			this.domainsFilterSave.Size = new System.Drawing.Size(100, 36);
			this.domainsFilterSave.TabIndex = 1;
			this.domainsFilterSave.Text = "Сохранить";
			this.domainsFilterSave.UseVisualStyleBackColor = true;
			this.domainsFilterSave.Click += new System.EventHandler(this.domainsFilterSave_Click);
			// 
			// domainsBox
			// 
			this.domainsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.domainsBox.Location = new System.Drawing.Point(6, 22);
			this.domainsBox.Name = "domainsBox";
			this.domainsBox.Size = new System.Drawing.Size(280, 240);
			this.domainsBox.TabIndex = 0;
			this.domainsBox.Text = "";
			// 
			// resultPage
			// 
			this.resultPage.Controls.Add(this.resultBox);
			this.resultPage.Location = new System.Drawing.Point(4, 36);
			this.resultPage.Name = "resultPage";
			this.resultPage.Padding = new System.Windows.Forms.Padding(3);
			this.resultPage.Size = new System.Drawing.Size(943, 455);
			this.resultPage.TabIndex = 2;
			this.resultPage.Text = "Результат";
			this.resultPage.UseVisualStyleBackColor = true;
			// 
			// resultBox
			// 
			this.resultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultBox.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.resultBox.Location = new System.Drawing.Point(7, 6);
			this.resultBox.Name = "resultBox";
			this.resultBox.Size = new System.Drawing.Size(929, 443);
			this.resultBox.TabIndex = 0;
			this.resultBox.Text = "";
			this.resultBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox_LinkClicked);
			// 
			// sessionPage
			// 
			this.sessionPage.Controls.Add(this.nowSessionLabel);
			this.sessionPage.Controls.Add(this.newSessionBtn);
			this.sessionPage.Controls.Add(this.groupBox6);
			this.sessionPage.Controls.Add(this.SessionList);
			this.sessionPage.Location = new System.Drawing.Point(4, 36);
			this.sessionPage.Name = "sessionPage";
			this.sessionPage.Padding = new System.Windows.Forms.Padding(3);
			this.sessionPage.Size = new System.Drawing.Size(943, 455);
			this.sessionPage.TabIndex = 3;
			this.sessionPage.Text = "Сессии";
			this.sessionPage.UseVisualStyleBackColor = true;
			this.sessionPage.Enter += new System.EventHandler(this.sessionPage_Enter);
			// 
			// nowSessionLabel
			// 
			this.nowSessionLabel.AutoSize = true;
			this.nowSessionLabel.Location = new System.Drawing.Point(185, 18);
			this.nowSessionLabel.Name = "nowSessionLabel";
			this.nowSessionLabel.Size = new System.Drawing.Size(143, 16);
			this.nowSessionLabel.TabIndex = 9;
			this.nowSessionLabel.Text = "                           ";
			// 
			// newSessionBtn
			// 
			this.newSessionBtn.AutoSize = true;
			this.newSessionBtn.Location = new System.Drawing.Point(8, 16);
			this.newSessionBtn.Name = "newSessionBtn";
			this.newSessionBtn.Size = new System.Drawing.Size(121, 20);
			this.newSessionBtn.TabIndex = 8;
			this.newSessionBtn.TabStop = true;
			this.newSessionBtn.Text = "Новая Сессия";
			this.newSessionBtn.UseVisualStyleBackColor = true;
			this.newSessionBtn.Click += new System.EventHandler(this.newSessionBtn_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.sessionFile);
			this.groupBox6.Location = new System.Drawing.Point(593, 45);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(343, 205);
			this.groupBox6.TabIndex = 7;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Путь до файла";
			// 
			// sessionFile
			// 
			this.sessionFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sessionFile.Location = new System.Drawing.Point(7, 35);
			this.sessionFile.Multiline = true;
			this.sessionFile.Name = "sessionFile";
			this.sessionFile.ReadOnly = true;
			this.sessionFile.Size = new System.Drawing.Size(336, 164);
			this.sessionFile.TabIndex = 0;
			// 
			// SessionList
			// 
			this.SessionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SessionList.FormattingEnabled = true;
			this.SessionList.ItemHeight = 16;
			this.SessionList.Location = new System.Drawing.Point(6, 45);
			this.SessionList.Name = "SessionList";
			this.SessionList.Size = new System.Drawing.Size(560, 404);
			this.SessionList.TabIndex = 4;
			this.SessionList.SelectedIndexChanged += new System.EventHandler(this.SessionList_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(953, 496);
			this.Controls.Add(this.tabControl);
			this.MaximumSize = new System.Drawing.Size(5120, 3840);
			this.MinimumSize = new System.Drawing.Size(320, 39);
			this.Name = "MainForm";
			this.Text = "Block Checker";
			this.tabControl.ResumeLayout(false);
			this.WorkPage.ResumeLayout(false);
			this.WorkPage.PerformLayout();
			this.SettingPage.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.timeOutInput)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.resultPage.ResumeLayout(false);
			this.sessionPage.ResumeLayout(false);
			this.sessionPage.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage WorkPage;
		private System.Windows.Forms.TabPage SettingPage;
		private System.Windows.Forms.Button buttonChooseFile;
		private System.Windows.Forms.Label timer;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.RichTextBox richTextBox;
		private System.Windows.Forms.CheckBox AutoScrollBox;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.RichTextBox domainsBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button domainsFilterSave;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button stubsFilterSave;
		private System.Windows.Forms.RichTextBox stubsBox;
		private System.Windows.Forms.TabPage resultPage;
		private System.Windows.Forms.RichTextBox resultBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.NumericUpDown timeOutInput;
		private System.Windows.Forms.Button addStubButton;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox domainPingBox;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ProviderNameBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label filePathLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage sessionPage;
		private System.Windows.Forms.ListBox SessionList;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox sessionFile;
		private System.Windows.Forms.RadioButton newSessionBtn;
		private System.Windows.Forms.Label nowSessionLabel;
	}
}

