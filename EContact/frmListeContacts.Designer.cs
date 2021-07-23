
namespace EContact
  {
  partial class frmListeContacts
    {
    /// <summary> 
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
      {
      if (disposing && (components != null))
        {
        components.Dispose();
        }
      base.Dispose(disposing);
      }

    #region Code généré par le Concepteur de composants

    /// <summary> 
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
      {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeContacts));
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dgvContacts = new System.Windows.Forms.DataGridView();
      this.lblNbreContacts = new System.Windows.Forms.Label();
      this.txtRecherche = new System.Windows.Forms.TextBox();
      this.btnRechercher = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.btnUpload = new System.Windows.Forms.Button();
      this.BtnUpdate = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.pibPhoto = new System.Windows.Forms.PictureBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
      this.cmbGenre = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtNom = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtID = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.btnPrint = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pibPhoto)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(0, 4);
      this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(57, 45);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox2.TabIndex = 3;
      this.pictureBox2.TabStop = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(65, 13);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(190, 22);
      this.label2.TabIndex = 2;
      this.label2.Text = "Liste des contacts";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(659, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(231, 22);
      this.label1.TabIndex = 4;
      this.label1.Text = "Nombre de contacts: ";
      // 
      // dgvContacts
      // 
      this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvContacts.Location = new System.Drawing.Point(15, 119);
      this.dgvContacts.Name = "dgvContacts";
      this.dgvContacts.RowHeadersWidth = 51;
      this.dgvContacts.RowTemplate.Height = 24;
      this.dgvContacts.Size = new System.Drawing.Size(1119, 269);
      this.dgvContacts.TabIndex = 5;
      this.dgvContacts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContacts_CellClick);
      // 
      // lblNbreContacts
      // 
      this.lblNbreContacts.AutoSize = true;
      this.lblNbreContacts.ForeColor = System.Drawing.Color.Red;
      this.lblNbreContacts.Location = new System.Drawing.Point(885, 13);
      this.lblNbreContacts.Name = "lblNbreContacts";
      this.lblNbreContacts.Size = new System.Drawing.Size(22, 22);
      this.lblNbreContacts.TabIndex = 6;
      this.lblNbreContacts.Text = "0";
      // 
      // txtRecherche
      // 
      this.txtRecherche.Location = new System.Drawing.Point(148, 78);
      this.txtRecherche.Name = "txtRecherche";
      this.txtRecherche.Size = new System.Drawing.Size(235, 30);
      this.txtRecherche.TabIndex = 7;
      this.txtRecherche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtRecherche_KeyUp);
      // 
      // btnRechercher
      // 
      this.btnRechercher.BackColor = System.Drawing.Color.Transparent;
      this.btnRechercher.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRechercher.Image = ((System.Drawing.Image)(resources.GetObject("btnRechercher.Image")));
      this.btnRechercher.Location = new System.Drawing.Point(401, 73);
      this.btnRechercher.Name = "btnRechercher";
      this.btnRechercher.Size = new System.Drawing.Size(38, 40);
      this.btnRechercher.TabIndex = 8;
      this.btnRechercher.UseVisualStyleBackColor = false;
      this.btnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(11, 82);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(134, 22);
      this.label3.TabIndex = 9;
      this.label3.Text = "Rechercher:";
      // 
      // btnUpload
      // 
      this.btnUpload.BackColor = System.Drawing.Color.Thistle;
      this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
      this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnUpload.Location = new System.Drawing.Point(13, 650);
      this.btnUpload.Name = "btnUpload";
      this.btnUpload.Size = new System.Drawing.Size(230, 43);
      this.btnUpload.TabIndex = 7;
      this.btnUpload.Text = "Uploader Photo";
      this.btnUpload.UseVisualStyleBackColor = false;
      this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
      // 
      // BtnUpdate
      // 
      this.BtnUpdate.BackColor = System.Drawing.Color.NavajoWhite;
      this.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.Image")));
      this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BtnUpdate.Location = new System.Drawing.Point(462, 580);
      this.BtnUpdate.Name = "BtnUpdate";
      this.BtnUpdate.Size = new System.Drawing.Size(216, 43);
      this.BtnUpdate.TabIndex = 8;
      this.BtnUpdate.Text = "Modifier";
      this.BtnUpdate.UseVisualStyleBackColor = false;
      this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.BackColor = System.Drawing.Color.Pink;
      this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
      this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDelete.Location = new System.Drawing.Point(732, 580);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(216, 43);
      this.btnDelete.TabIndex = 9;
      this.btnDelete.Text = "Supprimer";
      this.btnDelete.UseVisualStyleBackColor = false;
      this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
      // 
      // pibPhoto
      // 
      this.pibPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pibPhoto.Location = new System.Drawing.Point(13, 405);
      this.pibPhoto.Name = "pibPhoto";
      this.pibPhoto.Size = new System.Drawing.Size(230, 230);
      this.pibPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pibPhoto.TabIndex = 26;
      this.pibPhoto.TabStop = false;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(728, 520);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(121, 22);
      this.label6.TabIndex = 25;
      this.label6.Text = "Téléphone:";
      // 
      // txtTelephone
      // 
      this.txtTelephone.Location = new System.Drawing.Point(864, 516);
      this.txtTelephone.Mask = "00 00 00 00 00";
      this.txtTelephone.Name = "txtTelephone";
      this.txtTelephone.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.txtTelephone.Size = new System.Drawing.Size(189, 30);
      this.txtTelephone.TabIndex = 6;
      // 
      // cmbGenre
      // 
      this.cmbGenre.FormattingEnabled = true;
      this.cmbGenre.Items.AddRange(new object[] {
            "Masculin",
            "Féminin"});
      this.cmbGenre.Location = new System.Drawing.Point(862, 413);
      this.cmbGenre.Name = "cmbGenre";
      this.cmbGenre.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cmbGenre.Size = new System.Drawing.Size(191, 29);
      this.cmbGenre.TabIndex = 2;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(769, 416);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(80, 22);
      this.label5.TabIndex = 23;
      this.label5.Text = "Genre:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(248, 524);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(207, 22);
      this.label4.TabIndex = 21;
      this.label4.Text = "Date de Naissance:";
      // 
      // dtpNaissance
      // 
      this.dtpNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNaissance.Location = new System.Drawing.Point(462, 516);
      this.dtpNaissance.Name = "dtpNaissance";
      this.dtpNaissance.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.dtpNaissance.Size = new System.Drawing.Size(206, 30);
      this.dtpNaissance.TabIndex = 5;
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(864, 464);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.txtEmail.Size = new System.Drawing.Size(270, 30);
      this.txtEmail.TabIndex = 4;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(786, 471);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(67, 22);
      this.label7.TabIndex = 17;
      this.label7.Text = "Email;";
      // 
      // txtNom
      // 
      this.txtNom.Location = new System.Drawing.Point(462, 464);
      this.txtNom.Name = "txtNom";
      this.txtNom.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.txtNom.Size = new System.Drawing.Size(296, 30);
      this.txtNom.TabIndex = 3;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(285, 472);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(154, 22);
      this.label8.TabIndex = 14;
      this.label8.Text = "Nom Complet:";
      // 
      // txtID
      // 
      this.txtID.Enabled = false;
      this.txtID.Location = new System.Drawing.Point(462, 412);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(97, 30);
      this.txtID.TabIndex = 1;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(403, 420);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(36, 22);
      this.label9.TabIndex = 29;
      this.label9.Text = "Id:";
      // 
      // btnPrint
      // 
      this.btnPrint.BackColor = System.Drawing.Color.AliceBlue;
      this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
      this.btnPrint.Location = new System.Drawing.Point(889, 63);
      this.btnPrint.Name = "btnPrint";
      this.btnPrint.Size = new System.Drawing.Size(193, 48);
      this.btnPrint.TabIndex = 30;
      this.btnPrint.Text = "Imprimer";
      this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnPrint.UseVisualStyleBackColor = false;
      this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
      // 
      // frmListeContacts
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.Controls.Add(this.btnPrint);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.txtID);
      this.Controls.Add(this.btnUpload);
      this.Controls.Add(this.BtnUpdate);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.pibPhoto);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtTelephone);
      this.Controls.Add(this.cmbGenre);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.dtpNaissance);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtNom);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnRechercher);
      this.Controls.Add(this.txtRecherche);
      this.Controls.Add(this.lblNbreContacts);
      this.Controls.Add(this.dgvContacts);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.label2);
      this.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmListeContacts";
      this.Size = new System.Drawing.Size(1153, 708);
      this.Load += new System.EventHandler(this.FrmListeContacts_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pibPhoto)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dgvContacts;
    private System.Windows.Forms.Label lblNbreContacts;
    private System.Windows.Forms.TextBox txtRecherche;
    private System.Windows.Forms.Button btnRechercher;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnUpload;
    private System.Windows.Forms.Button BtnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.PictureBox pibPhoto;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.MaskedTextBox txtTelephone;
    private System.Windows.Forms.ComboBox cmbGenre;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DateTimePicker dtpNaissance;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtNom;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtID;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Button btnPrint;
    }
  }
