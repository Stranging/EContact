
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
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
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
      this.dgvContacts.Location = new System.Drawing.Point(15, 140);
      this.dgvContacts.Name = "dgvContacts";
      this.dgvContacts.RowHeadersWidth = 51;
      this.dgvContacts.RowTemplate.Height = 24;
      this.dgvContacts.Size = new System.Drawing.Size(1119, 315);
      this.dgvContacts.TabIndex = 5;
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
      // frmListeContacts
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
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
      this.Size = new System.Drawing.Size(1153, 648);
      this.Load += new System.EventHandler(this.FrmListeContacts_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
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
    }
  }
