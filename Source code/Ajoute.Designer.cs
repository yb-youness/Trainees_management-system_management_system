namespace gestion_stagiaire_colaimo
{
    partial class Ajoute
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajoute));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ajouter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiocin = new System.Windows.Forms.RadioButton();
            this.radionom = new System.Windows.Forms.RadioButton();
            this.combosepecialite = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textrecher = new System.Windows.Forms.TextBox();
            this.comboservice = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textpernom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimefin = new System.Windows.Forms.DateTimePicker();
            this.dateTimedebut = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textetablisement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texttel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textadress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textcin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textnom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zoneStagiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneSpecialitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.badgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attestationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1277, 500);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ajouter
            // 
            this.ajouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ajouter.BackgroundImage")));
            this.ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ajouter.FlatAppearance.BorderSize = 0;
            this.ajouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouter.Location = new System.Drawing.Point(824, 10);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(40, 40);
            this.ajouter.TabIndex = 18;
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            this.ajouter.MouseHover += new System.EventHandler(this.ajouter_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.combosepecialite);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textrecher);
            this.groupBox1.Controls.Add(this.comboservice);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textpernom);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ajouter);
            this.groupBox1.Controls.Add(this.dateTimefin);
            this.groupBox1.Controls.Add(this.dateTimedebut);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textetablisement);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.texttel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textadress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textcin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textnom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(149, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 161);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(824, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 58;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiocin);
            this.groupBox2.Controls.Add(this.radionom);
            this.groupBox2.Location = new System.Drawing.Point(604, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 64);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rechercher par:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radiocin
            // 
            this.radiocin.AutoSize = true;
            this.radiocin.Location = new System.Drawing.Point(101, 31);
            this.radiocin.Name = "radiocin";
            this.radiocin.Size = new System.Drawing.Size(43, 17);
            this.radiocin.TabIndex = 55;
            this.radiocin.TabStop = true;
            this.radiocin.Text = "CIN";
            this.radiocin.UseVisualStyleBackColor = true;
            this.radiocin.CheckedChanged += new System.EventHandler(this.radiocin_CheckedChanged);
            // 
            // radionom
            // 
            this.radionom.AutoSize = true;
            this.radionom.Location = new System.Drawing.Point(46, 30);
            this.radionom.Name = "radionom";
            this.radionom.Size = new System.Drawing.Size(47, 17);
            this.radionom.TabIndex = 54;
            this.radionom.TabStop = true;
            this.radionom.Text = "Nom";
            this.radionom.UseVisualStyleBackColor = true;
            this.radionom.CheckedChanged += new System.EventHandler(this.radionom_CheckedChanged);
            // 
            // combosepecialite
            // 
            this.combosepecialite.FormattingEnabled = true;
            this.combosepecialite.Location = new System.Drawing.Point(242, 71);
            this.combosepecialite.Name = "combosepecialite";
            this.combosepecialite.Size = new System.Drawing.Size(121, 21);
            this.combosepecialite.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Specialite";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Service";
            // 
            // textrecher
            // 
            this.textrecher.Location = new System.Drawing.Point(604, 115);
            this.textrecher.Name = "textrecher";
            this.textrecher.Size = new System.Drawing.Size(176, 20);
            this.textrecher.TabIndex = 53;
            this.textrecher.Click += new System.EventHandler(this.textrecher_Click);
            this.textrecher.TextChanged += new System.EventHandler(this.textrecher_TextChanged);
            // 
            // comboservice
            // 
            this.comboservice.FormattingEnabled = true;
            this.comboservice.Location = new System.Drawing.Point(423, 20);
            this.comboservice.Name = "comboservice";
            this.comboservice.Size = new System.Drawing.Size(121, 21);
            this.comboservice.TabIndex = 45;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(781, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textpernom
            // 
            this.textpernom.Location = new System.Drawing.Point(72, 72);
            this.textpernom.Name = "textpernom";
            this.textpernom.Size = new System.Drawing.Size(100, 20);
            this.textpernom.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Prenom";
            // 
            // dateTimefin
            // 
            this.dateTimefin.Location = new System.Drawing.Point(604, 49);
            this.dateTimefin.Name = "dateTimefin";
            this.dateTimefin.Size = new System.Drawing.Size(200, 20);
            this.dateTimefin.TabIndex = 39;
            // 
            // dateTimedebut
            // 
            this.dateTimedebut.Location = new System.Drawing.Point(604, 18);
            this.dateTimedebut.Name = "dateTimedebut";
            this.dateTimedebut.Size = new System.Drawing.Size(200, 20);
            this.dateTimedebut.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "DU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "AU";
            // 
            // textetablisement
            // 
            this.textetablisement.Location = new System.Drawing.Point(242, 44);
            this.textetablisement.Name = "textetablisement";
            this.textetablisement.Size = new System.Drawing.Size(121, 20);
            this.textetablisement.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Etablisment";
            // 
            // texttel
            // 
            this.texttel.Location = new System.Drawing.Point(242, 18);
            this.texttel.Name = "texttel";
            this.texttel.Size = new System.Drawing.Size(121, 20);
            this.texttel.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "TEL";
            // 
            // textadress
            // 
            this.textadress.Location = new System.Drawing.Point(72, 96);
            this.textadress.Multiline = true;
            this.textadress.Name = "textadress";
            this.textadress.Size = new System.Drawing.Size(472, 41);
            this.textadress.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Adresse";
            // 
            // textcin
            // 
            this.textcin.Location = new System.Drawing.Point(72, 20);
            this.textcin.Name = "textcin";
            this.textcin.Size = new System.Drawing.Size(100, 20);
            this.textcin.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "CIN";
            // 
            // textnom
            // 
            this.textnom.Location = new System.Drawing.Point(72, 46);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(100, 20);
            this.textnom.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nom";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Honeydew;
            this.menuStrip1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneStagiaireToolStripMenuItem,
            this.zoneServiceToolStripMenuItem,
            this.zoneSpecialitéToolStripMenuItem,
            this.imprimerToolStripMenuItem,
            this.compteToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1265, 26);
            this.menuStrip1.TabIndex = 74;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zoneStagiaireToolStripMenuItem
            // 
            this.zoneStagiaireToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoneStagiaireToolStripMenuItem.Image")));
            this.zoneStagiaireToolStripMenuItem.Name = "zoneStagiaireToolStripMenuItem";
            this.zoneStagiaireToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoneStagiaireToolStripMenuItem.Text = "Zone Stagiaire";
            this.zoneStagiaireToolStripMenuItem.Click += new System.EventHandler(this.zoneStagiaireToolStripMenuItem_Click);
            // 
            // zoneServiceToolStripMenuItem
            // 
            this.zoneServiceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoneServiceToolStripMenuItem.Image")));
            this.zoneServiceToolStripMenuItem.Name = "zoneServiceToolStripMenuItem";
            this.zoneServiceToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.zoneServiceToolStripMenuItem.Text = "Zone Service";
            this.zoneServiceToolStripMenuItem.Click += new System.EventHandler(this.zoneServiceToolStripMenuItem_Click);
            // 
            // zoneSpecialitéToolStripMenuItem
            // 
            this.zoneSpecialitéToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoneSpecialitéToolStripMenuItem.Image")));
            this.zoneSpecialitéToolStripMenuItem.Name = "zoneSpecialitéToolStripMenuItem";
            this.zoneSpecialitéToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.zoneSpecialitéToolStripMenuItem.Text = "Zone Specialité";
            this.zoneSpecialitéToolStripMenuItem.Click += new System.EventHandler(this.zoneSpecialitéToolStripMenuItem_Click);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.badgeToolStripMenuItem,
            this.attestationToolStripMenuItem});
            this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            this.imprimerToolStripMenuItem.Click += new System.EventHandler(this.imprimerToolStripMenuItem_Click);
            // 
            // badgeToolStripMenuItem
            // 
            this.badgeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("badgeToolStripMenuItem.Image")));
            this.badgeToolStripMenuItem.Name = "badgeToolStripMenuItem";
            this.badgeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.badgeToolStripMenuItem.Text = "Badge";
            this.badgeToolStripMenuItem.Click += new System.EventHandler(this.badgeToolStripMenuItem_Click);
            // 
            // attestationToolStripMenuItem
            // 
            this.attestationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("attestationToolStripMenuItem.Image")));
            this.attestationToolStripMenuItem.Name = "attestationToolStripMenuItem";
            this.attestationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.attestationToolStripMenuItem.Text = "Attestation";
            this.attestationToolStripMenuItem.Click += new System.EventHandler(this.attestationToolStripMenuItem_Click);
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("compteToolStripMenuItem.Image")));
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.compteToolStripMenuItem.Text = "Compte";
            this.compteToolStripMenuItem.Click += new System.EventHandler(this.compteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(18, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 59;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 22);
            this.label11.TabIndex = 75;
            this.label11.Text = "Accueil";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Ajoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1265, 492);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ajoute";
            this.Text = "Ajouter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ajoute_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ajoute_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboservice;
        private System.Windows.Forms.TextBox textpernom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimefin;
        private System.Windows.Forms.DateTimePicker dateTimedebut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textetablisement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texttel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textadress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textcin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textrecher;
        private System.Windows.Forms.RadioButton radionom;
        private System.Windows.Forms.RadioButton radiocin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combosepecialite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zoneStagiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneSpecialitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem badgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attestationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
    }
}