namespace GymPro.WinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtCNP;
        private TextBox txtOptions;
        private TextBox txtPrice;
        private TextBox txtDuration;
        private TextBox txtContact;
        private ComboBox cmbSubscriptionType;  // Dropdown for subscription
        private ComboBox cmbPersonalCoach;  // Dropdown for coaches
        private Button btnAddClient;
        private Button btnLoadClients;
        private ListBox lstClients;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblCNP;
        private Label lblSubscription;
        private Label lblOptions;
        private Label lblPrice;
        private Label lblDuration;
        private Label lblContact;
        private Label lblCoach;
        private DateTimePicker dtpExpirationDate;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtCNP = new TextBox();
            txtOptions = new TextBox();
            txtPrice = new TextBox();
            txtDuration = new TextBox();
            txtContact = new TextBox();
            cmbSubscriptionType = new ComboBox();
            cmbPersonalCoach = new ComboBox();
            btnAddClient = new Button();
            btnLoadClients = new Button();
            lstClients = new ListBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblCNP = new Label();
            lblSubscription = new Label();
            lblOptions = new Label();
            lblPrice = new Label();
            lblDuration = new Label();
            lblContact = new Label();
            lblCoach = new Label();
            dtpExpirationDate = new DateTimePicker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblLastNameError = new Label();
            lblFirstNameError = new Label();
            lblCNPError = new Label();
            lblPriceError = new Label();
            lblDurationError = new Label();
            lblContactError = new Label();
            panel1 = new Panel();
            About = new Button();
            CoachInfo = new Button();
            Search = new Button();
            AddClients = new Button();
            SearchPanel = new Panel();
            SaveButton = new Button();
            dgvSearchResults = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            HomePanel = new Panel();
            CoachPanel = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CoachInfoPanel = new Label();
            pictureBox1 = new PictureBox();
            AboutPannel = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).BeginInit();
            HomePanel.SuspendLayout();
            CoachPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            AboutPannel.SuspendLayout();
            SuspendLayout();
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(320, 91);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(320, 137);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtCNP
            // 
            txtCNP.Location = new Point(320, 187);
            txtCNP.Name = "txtCNP";
            txtCNP.Size = new Size(200, 23);
            txtCNP.TabIndex = 2;
            // 
            // txtOptions
            // 
            txtOptions.Location = new Point(320, 272);
            txtOptions.Name = "txtOptions";
            txtOptions.Size = new Size(200, 23);
            txtOptions.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(320, 301);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(320, 346);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(200, 23);
            txtDuration.TabIndex = 6;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(320, 391);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(200, 23);
            txtContact.TabIndex = 7;
            // 
            // cmbSubscriptionType
            // 
            cmbSubscriptionType.Location = new Point(320, 235);
            cmbSubscriptionType.Name = "cmbSubscriptionType";
            cmbSubscriptionType.Size = new Size(200, 23);
            cmbSubscriptionType.TabIndex = 3;
            cmbSubscriptionType.SelectedIndexChanged += cmbSubscriptionType_SelectedIndexChanged;
            // 
            // cmbPersonalCoach
            // 
            cmbPersonalCoach.Location = new Point(320, 437);
            cmbPersonalCoach.Name = "cmbPersonalCoach";
            cmbPersonalCoach.Size = new Size(200, 23);
            cmbPersonalCoach.TabIndex = 8;
            // 
            // btnAddClient
            // 
            btnAddClient.BackColor = Color.Transparent;
            btnAddClient.ForeColor = SystemColors.ControlLightLight;
            btnAddClient.FlatStyle = FlatStyle.Popup;
            btnAddClient.Location = new Point(216, 495);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(100, 30);
            btnAddClient.TabIndex = 10;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = false;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnLoadClients
            // 
            btnLoadClients.BackColor = Color.Transparent;
            btnLoadClients.ForeColor = SystemColors.ControlLightLight;
            btnLoadClients.FlatStyle = FlatStyle.Popup;
            btnLoadClients.Location = new Point(447, 495);
            btnLoadClients.Name = "btnLoadClients";
            btnLoadClients.Size = new Size(100, 30);
            btnLoadClients.TabIndex = 11;
            btnLoadClients.Text = "Load Clients";
            btnLoadClients.UseVisualStyleBackColor = false;
            btnLoadClients.Click += btnLoadClients_Click;
            // 
            // lstClients
            // 
            lstClients.BackColor = SystemColors.Control;
            lstClients.ForeColor = Color.Black;
            lstClients.HorizontalScrollbar = true;
            lstClients.ItemHeight = 15;
            lstClients.Location = new Point(195, 543);
            lstClients.Name = "lstClients";
            lstClients.Size = new Size(380, 124);
            lstClients.TabIndex = 12;
            // 
            // lblLastName
            // 
            lblLastName.BackColor = Color.Transparent;
            lblLastName.ForeColor = Color.WhiteSmoke;
            lblLastName.Location = new Point(216, 94);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 23);
            lblLastName.TabIndex = 13;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.ForeColor = Color.WhiteSmoke;
            lblFirstName.Location = new Point(216, 140);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 23);
            lblFirstName.TabIndex = 14;
            lblFirstName.Text = "First Name";
            // 
            // lblCNP
            // 
            lblCNP.BackColor = Color.Transparent;
            lblCNP.ForeColor = Color.WhiteSmoke;
            lblCNP.Location = new Point(216, 187);
            lblCNP.Name = "lblCNP";
            lblCNP.Size = new Size(100, 23);
            lblCNP.TabIndex = 15;
            lblCNP.Text = "CNP";
            // 
            // lblSubscription
            // 
            lblSubscription.BackColor = Color.Transparent;
            lblSubscription.ForeColor = Color.WhiteSmoke;
            lblSubscription.Location = new Point(216, 238);
            lblSubscription.Name = "lblSubscription";
            lblSubscription.Size = new Size(100, 23);
            lblSubscription.TabIndex = 16;
            lblSubscription.Text = "Subscription Type";
            // 
            // lblOptions
            // 
            lblOptions.BackColor = Color.Transparent;
            lblOptions.ForeColor = Color.WhiteSmoke;
            lblOptions.Location = new Point(216, 272);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(100, 23);
            lblOptions.TabIndex = 17;
            lblOptions.Text = "Options";
            // 
            // lblPrice
            // 
            lblPrice.BackColor = Color.Transparent;
            lblPrice.ForeColor = Color.WhiteSmoke;
            lblPrice.Location = new Point(216, 301);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Price";
            // 
            // lblDuration
            // 
            lblDuration.BackColor = Color.Transparent;
            lblDuration.ForeColor = Color.WhiteSmoke;
            lblDuration.Location = new Point(216, 349);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(100, 23);
            lblDuration.TabIndex = 19;
            lblDuration.Text = "Duration";
            // 
            // lblContact
            // 
            lblContact.BackColor = Color.Transparent;
            lblContact.ForeColor = Color.WhiteSmoke;
            lblContact.Location = new Point(216, 391);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(100, 23);
            lblContact.TabIndex = 20;
            lblContact.Text = "Contact";
            // 
            // lblCoach
            // 
            lblCoach.BackColor = Color.Transparent;
            lblCoach.ForeColor = Color.WhiteSmoke;
            lblCoach.Location = new Point(216, 437);
            lblCoach.Name = "lblCoach";
            lblCoach.Size = new Size(100, 23);
            lblCoach.TabIndex = 21;
            lblCoach.Text = "Personal Coach";
            // 
            // dtpExpirationDate
            // 
            dtpExpirationDate.CalendarMonthBackground = Color.Transparent;
            dtpExpirationDate.CalendarTitleBackColor = Color.Transparent;
            dtpExpirationDate.CalendarTrailingForeColor = Color.Transparent;
            dtpExpirationDate.Location = new Point(320, 466);
            dtpExpirationDate.Name = "dtpExpirationDate";
            dtpExpirationDate.Size = new Size(200, 23);
            dtpExpirationDate.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblLastNameError
            // 
            lblLastNameError.AutoSize = true;
            lblLastNameError.BackColor = Color.Transparent;
            lblLastNameError.ForeColor = Color.Red;
            lblLastNameError.Location = new Point(333, 119);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(98, 15);
            lblLastNameError.TabIndex = 22;
            lblLastNameError.Text = "lblLastNameError";
            lblLastNameError.Visible = false;
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.AutoSize = true;
            lblFirstNameError.BackColor = Color.Transparent;
            lblFirstNameError.ForeColor = Color.Red;
            lblFirstNameError.Location = new Point(333, 163);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(99, 15);
            lblFirstNameError.TabIndex = 23;
            lblFirstNameError.Text = "lblFirstNameError";
            lblFirstNameError.Visible = false;
            // 
            // lblCNPError
            // 
            lblCNPError.AutoSize = true;
            lblCNPError.BackColor = Color.Transparent;
            lblCNPError.ForeColor = Color.Red;
            lblCNPError.Location = new Point(333, 213);
            lblCNPError.Name = "lblCNPError";
            lblCNPError.Size = new Size(69, 15);
            lblCNPError.TabIndex = 24;
            lblCNPError.Text = "lblCNPError";
            lblCNPError.Visible = false;
            // 
            // lblPriceError
            // 
            lblPriceError.AutoSize = true;
            lblPriceError.BackColor = Color.Transparent;
            lblPriceError.ForeColor = Color.Red;
            lblPriceError.Location = new Point(333, 327);
            lblPriceError.Name = "lblPriceError";
            lblPriceError.Size = new Size(71, 15);
            lblPriceError.TabIndex = 25;
            lblPriceError.Text = "lblPriceError";
            lblPriceError.Visible = false;
            // 
            // lblDurationError
            // 
            lblDurationError.AutoSize = true;
            lblDurationError.BackColor = Color.Transparent;
            lblDurationError.ForeColor = Color.Red;
            lblDurationError.Location = new Point(333, 373);
            lblDurationError.Name = "lblDurationError";
            lblDurationError.Size = new Size(91, 15);
            lblDurationError.TabIndex = 26;
            lblDurationError.Text = "lblDurationError";
            lblDurationError.Visible = false;
            // 
            // lblContactError
            // 
            lblContactError.AutoSize = true;
            lblContactError.BackColor = Color.Transparent;
            lblContactError.ForeColor = Color.Red;
            lblContactError.Location = new Point(333, 419);
            lblContactError.Name = "lblContactError";
            lblContactError.Size = new Size(87, 15);
            lblContactError.TabIndex = 27;
            lblContactError.Text = "lblContactError";
            lblContactError.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(About);
            panel1.Controls.Add(CoachInfo);
            panel1.Controls.Add(Search);
            panel1.Controls.Add(AddClients);
            panel1.Location = new Point(6, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 576);
            panel1.TabIndex = 28;
            // 
            // About
            // 
            About.FlatStyle = FlatStyle.Popup;
            About.ForeColor = SystemColors.ControlLight;
            About.Location = new Point(20, 228);
            About.Name = "About";
            About.Size = new Size(75, 23);
            About.TabIndex = 3;
            About.Text = "About";
            About.UseVisualStyleBackColor = true;
            About.Click += About_Click;
            // 
            // CoachInfo
            // 
            CoachInfo.FlatStyle = FlatStyle.Popup;
            CoachInfo.ForeColor = SystemColors.ControlLightLight;
            CoachInfo.Location = new Point(20, 163);
            CoachInfo.Name = "CoachInfo";
            CoachInfo.Size = new Size(75, 23);
            CoachInfo.TabIndex = 2;
            CoachInfo.Text = "CoachInfo";
            CoachInfo.UseVisualStyleBackColor = true;
            CoachInfo.Click += CoachInfo_Click;
            // 
            // Search
            // 
            Search.FlatStyle = FlatStyle.Popup;
            Search.ForeColor = SystemColors.ControlLightLight;
            Search.Location = new Point(20, 93);
            Search.Name = "Search";
            Search.Size = new Size(75, 23);
            Search.TabIndex = 1;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // AddClients
            // 
            AddClients.FlatStyle = FlatStyle.Popup;
            AddClients.ForeColor = SystemColors.ControlLightLight;
            AddClients.Location = new Point(20, 25);
            AddClients.Name = "AddClients";
            AddClients.Size = new Size(75, 23);
            AddClients.TabIndex = 0;
            AddClients.Text = "AddClients\r\n";
            AddClients.UseVisualStyleBackColor = true;
            AddClients.Click += AddClients_Click;
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor = Color.Transparent;
            SearchPanel.BackgroundImage = (Image)resources.GetObject("SearchPanel.BackgroundImage");
            SearchPanel.Controls.Add(SaveButton);
            SearchPanel.Controls.Add(dgvSearchResults);
            SearchPanel.Controls.Add(textBox1);
            SearchPanel.Controls.Add(button1);
            SearchPanel.Location = new Point(0, 0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(389, 582);
            SearchPanel.TabIndex = 0;
            SearchPanel.Visible = false;
            // 
            // SaveButton
            // 
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.ForeColor = SystemColors.ControlLightLight;
            SaveButton.Location = new Point(204, 95);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // dgvSearchResults
            // 
            dgvSearchResults.AllowUserToAddRows = true;
            dgvSearchResults.AllowUserToDeleteRows = true;
            dgvSearchResults.BackgroundColor = SystemColors.ControlLightLight;
            dgvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchResults.Location = new Point(30, 150);
            dgvSearchResults.Name = "dgvSearchResults";
            dgvSearchResults.ReadOnly = false;
            dgvSearchResults.RightToLeft = RightToLeft.Yes;
            dgvSearchResults.RowTemplate.Height = 25;
            dgvSearchResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchResults.Size = new Size(331, 339);
            dgvSearchResults.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 1;
            // 
            // search panel button
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(81, 95);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "search\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HomePanel
            // 
            HomePanel.BackColor = SystemColors.ActiveCaptionText;
            HomePanel.BackgroundImage = (Image)resources.GetObject("HomePanel.BackgroundImage");
            HomePanel.BackgroundImageLayout = ImageLayout.Stretch;
            HomePanel.Controls.Add(SearchPanel);
            HomePanel.Location = new Point(195, 91);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(389, 576);
            HomePanel.TabIndex = 30;
            // 
            // CoachPanel
            // 
            CoachPanel.BackColor = Color.OrangeRed;
            CoachPanel.BackgroundImage = (Image)resources.GetObject("CoachPanel.BackgroundImage");
            CoachPanel.Controls.Add(pictureBox5);
            CoachPanel.Controls.Add(pictureBox4);
            CoachPanel.Controls.Add(pictureBox3);
            CoachPanel.Controls.Add(pictureBox2);
            CoachPanel.Controls.Add(label4);
            CoachPanel.Controls.Add(label3);
            CoachPanel.Controls.Add(label2);
            CoachPanel.Controls.Add(label1);
            CoachPanel.Controls.Add(CoachInfoPanel);
            CoachPanel.Location = new Point(192, 91);
            CoachPanel.Name = "CoachPanel";
            CoachPanel.Size = new Size(392, 576);
            CoachPanel.TabIndex = 0;
            CoachPanel.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(235, 319);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(128, 167);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 319);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 167);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(235, 63);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(128, 167);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 63);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 167);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(212, 499);
            label4.Name = "label4";
            label4.Size = new Size(172, 30);
            label4.TabIndex = 4;
            label4.Text = "                 Sarah Davis\r\nSpecialization:Strength Training";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(18, 499);
            label3.Name = "label3";
            label3.Size = new Size(128, 30);
            label3.TabIndex = 3;
            label3.Text = "      Michael Brown\r\n Specialization: Crossfit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(249, 233);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 2;
            label2.Text = "      Eily Johnson\r\n Specialization: Yoga";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 233);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 1;
            label1.Text = "                John Smith\r\n   Specialization: Weight Training";
            // 
            // CoachInfoPanel
            // 
            CoachInfoPanel.AutoSize = true;
            CoachInfoPanel.BackColor = Color.Transparent;
            CoachInfoPanel.ForeColor = SystemColors.ControlLightLight;
            CoachInfoPanel.Location = new Point(138, 25);
            CoachInfoPanel.Name = "CoachInfoPanel";
            CoachInfoPanel.Size = new Size(129, 15);
            CoachInfoPanel.TabIndex = 0;
            CoachInfoPanel.Text = "Info about our coaches\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(611, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // AboutPannel
            // 
            AboutPannel.AutoScroll = true;
            AboutPannel.BackColor = Color.Transparent;
            AboutPannel.Controls.Add(label6);
            AboutPannel.Location = new Point(192, 91);
            AboutPannel.Name = "AboutPannel";
            AboutPannel.Size = new Size(395, 576);
            AboutPannel.TabIndex = 9;
            AboutPannel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(0, 5);
            label6.Name = "label6";
            label6.Size = new Size(437, 1110);
            label6.TabIndex = 1;
            label6.Text = resources.GetString("label6.Text");
            // 
            // Form1
            // 
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(611, 691);
            Controls.Add(AboutPannel);
            Controls.Add(CoachPanel);
            Controls.Add(HomePanel);
            Controls.Add(panel1);
            Controls.Add(lblContactError);
            Controls.Add(lblDurationError);
            Controls.Add(lblPriceError);
            Controls.Add(lblCNPError);
            Controls.Add(lblFirstNameError);
            Controls.Add(lblLastNameError);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtCNP);
            Controls.Add(cmbSubscriptionType);
            Controls.Add(txtOptions);
            Controls.Add(txtPrice);
            Controls.Add(txtDuration);
            Controls.Add(txtContact);
            Controls.Add(cmbPersonalCoach);
            Controls.Add(dtpExpirationDate);
            Controls.Add(btnAddClient);
            Controls.Add(btnLoadClients);
            Controls.Add(lstClients);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblCNP);
            Controls.Add(lblSubscription);
            Controls.Add(lblOptions);
            Controls.Add(lblPrice);
            Controls.Add(lblDuration);
            Controls.Add(lblContact);
            Controls.Add(lblCoach);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "GymPro Client Management";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).EndInit();
            HomePanel.ResumeLayout(false);
            CoachPanel.ResumeLayout(false);
            CoachPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            AboutPannel.ResumeLayout(false);
            AboutPannel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private ContextMenuStrip contextMenuStrip1;



        private void ShowError(Label label, string message)
        {
            label.Visible = !string.IsNullOrEmpty(message);

            label.Text = message;
        }
        private Label lblLastNameError;
        private Label lblFirstNameError;
        private Label lblCNPError;
        private Label lblPriceError;
        private Label lblDurationError;
        private Label lblContactError;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button CoachInfo;
        private Button Search;
        private Button AddClients;
        private Panel HomePanel;
        private Panel SearchPanel;
        private Panel CoachPanel;
        private Label CoachInfoPanel;
        private Button button1;
        private DataGridView dgvSearchResults;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Button About;
        private Panel AboutPannel;
        private Label label6;
        private Button SaveButton;
    }
}
