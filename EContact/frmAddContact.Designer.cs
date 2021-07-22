
namespace EContact
  {
  partial class frmAddContact
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddContact));
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNom = new System.Windows.Forms.TextBox();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.cmbGenre = new System.Windows.Forms.ComboBox();
      this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.pibPhoto = new System.Windows.Forms.PictureBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.BtnReset = new System.Windows.Forms.Button();
      this.btnUpload = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pibPhoto)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(65, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(196, 22);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nouveau Contact";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(0, 4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(57, 45);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnUpload);
      this.groupBox1.Controls.Add(this.BtnReset);
      this.groupBox1.Controls.Add(this.btnSave);
      this.groupBox1.Controls.Add(this.pibPhoto);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.txtTelephone);
      this.groupBox1.Controls.Add(this.cmbGenre);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.dtpNaissance);
      this.groupBox1.Controls.Add(this.txtEmail);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txtNom);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(36, 73);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1092, 538);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Infos contact";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(89, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(154, 22);
      this.label2.TabIndex = 0;
      this.label2.Text = "Nom Complet:";
      // 
      // txtNom
      // 
      this.txtNom.Location = new System.Drawing.Point(265, 49);
      this.txtNom.Name = "txtNom";
      this.txtNom.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.txtNom.Size = new System.Drawing.Size(298, 30);
      this.txtNom.TabIndex = 1;
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(265, 150);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.txtEmail.Size = new System.Drawing.Size(298, 30);
      this.txtEmail.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(176, 158);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(67, 22);
      this.label3.TabIndex = 2;
      this.label3.Text = "Email;";
      // 
      // dtpNaissance
      // 
      this.dtpNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNaissance.Location = new System.Drawing.Point(265, 100);
      this.dtpNaissance.Name = "dtpNaissance";
      this.dtpNaissance.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.dtpNaissance.Size = new System.Drawing.Size(298, 30);
      this.dtpNaissance.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(36, 103);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(207, 22);
      this.label4.TabIndex = 5;
      this.label4.Text = "Date de Naissance:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(163, 204);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(80, 22);
      this.label5.TabIndex = 6;
      this.label5.Text = "Genre:";
      // 
      // cmbGenre
      // 
      this.cmbGenre.FormattingEnabled = true;
      this.cmbGenre.Items.AddRange(new object[] {
            "Masculin",
            "Féminin"});
      this.cmbGenre.Location = new System.Drawing.Point(265, 203);
      this.cmbGenre.Name = "cmbGenre";
      this.cmbGenre.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cmbGenre.Size = new System.Drawing.Size(297, 29);
      this.cmbGenre.TabIndex = 7;
      // 
      // txtTelephone
      // 
      this.txtTelephone.Location = new System.Drawing.Point(269, 257);
      this.txtTelephone.Mask = "00 00 00 00 00";
      this.txtTelephone.Name = "txtTelephone";
      this.txtTelephone.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.txtTelephone.Size = new System.Drawing.Size(293, 30);
      this.txtTelephone.TabIndex = 8;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(122, 260);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(121, 22);
      this.label6.TabIndex = 9;
      this.label6.Text = "Téléphone:";
      // 
      // pibPhoto
      // 
      this.pibPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pibPhoto.Location = new System.Drawing.Point(657, 52);
      this.pibPhoto.Name = "pibPhoto";
      this.pibPhoto.Size = new System.Drawing.Size(230, 230);
      this.pibPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pibPhoto.TabIndex = 11;
      this.pibPhoto.TabStop = false;
      // 
      // btnSave
      // 
      this.btnSave.BackColor = System.Drawing.Color.LightGreen;
      this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
      this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSave.Location = new System.Drawing.Point(134, 337);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(216, 43);
      this.btnSave.TabIndex = 12;
      this.btnSave.Text = "Sauvegarder";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
      // 
      // BtnReset
      // 
      this.BtnReset.BackColor = System.Drawing.Color.LightSteelBlue;
      this.BtnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnReset.Image = ((System.Drawing.Image)(resources.GetObject("BtnReset.Image")));
      this.BtnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BtnReset.Location = new System.Drawing.Point(396, 337);
      this.BtnReset.Name = "BtnReset";
      this.BtnReset.Size = new System.Drawing.Size(216, 43);
      this.BtnReset.TabIndex = 13;
      this.BtnReset.Text = "Initialiser:";
      this.BtnReset.UseVisualStyleBackColor = false;
      this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
      // 
      // btnUpload
      // 
      this.btnUpload.BackColor = System.Drawing.Color.Thistle;
      this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
      this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnUpload.Location = new System.Drawing.Point(657, 337);
      this.btnUpload.Name = "btnUpload";
      this.btnUpload.Size = new System.Drawing.Size(230, 43);
      this.btnUpload.TabIndex = 14;
      this.btnUpload.Text = "Uploader Photo";
      this.btnUpload.UseVisualStyleBackColor = false;
      this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
      // 
      // frmAddContact
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "frmAddContact";
      this.Size = new System.Drawing.Size(1153, 648);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pibPhoto)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtNom;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnUpload;
    private System.Windows.Forms.Button BtnReset;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.PictureBox pibPhoto;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.MaskedTextBox txtTelephone;
    private System.Windows.Forms.ComboBox cmbGenre;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DateTimePicker dtpNaissance;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label label3;
    }
  }
