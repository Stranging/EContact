
namespace EContact
  {
  partial class frmMenu
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

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
      {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
      this.panelMenu = new System.Windows.Forms.Panel();
      this.btnQuitter = new System.Windows.Forms.Button();
      this.btnNouveau = new System.Windows.Forms.Button();
      this.btnListeContacts = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panelContent = new System.Windows.Forms.Panel();
      this.panelMenu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panelMenu
      // 
      this.panelMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
      this.panelMenu.Controls.Add(this.btnQuitter);
      this.panelMenu.Controls.Add(this.btnNouveau);
      this.panelMenu.Controls.Add(this.btnListeContacts);
      this.panelMenu.Controls.Add(this.pictureBox1);
      this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelMenu.Location = new System.Drawing.Point(0, 0);
      this.panelMenu.Name = "panelMenu";
      this.panelMenu.Size = new System.Drawing.Size(223, 647);
      this.panelMenu.TabIndex = 0;
      // 
      // btnQuitter
      // 
      this.btnQuitter.BackColor = System.Drawing.Color.PaleTurquoise;
      this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnQuitter.FlatAppearance.BorderSize = 0;
      this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitter.Image")));
      this.btnQuitter.Location = new System.Drawing.Point(14, 312);
      this.btnQuitter.Name = "btnQuitter";
      this.btnQuitter.Size = new System.Drawing.Size(201, 65);
      this.btnQuitter.TabIndex = 3;
      this.btnQuitter.Text = "Quitter";
      this.btnQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnQuitter.UseVisualStyleBackColor = false;
      this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
      // 
      // btnNouveau
      // 
      this.btnNouveau.BackColor = System.Drawing.Color.PaleTurquoise;
      this.btnNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnNouveau.FlatAppearance.BorderSize = 0;
      this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNouveau.Image = ((System.Drawing.Image)(resources.GetObject("btnNouveau.Image")));
      this.btnNouveau.Location = new System.Drawing.Point(14, 241);
      this.btnNouveau.Name = "btnNouveau";
      this.btnNouveau.Size = new System.Drawing.Size(201, 65);
      this.btnNouveau.TabIndex = 2;
      this.btnNouveau.Text = "Nouveau";
      this.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnNouveau.UseVisualStyleBackColor = false;
      this.btnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click);
      // 
      // btnListeContacts
      // 
      this.btnListeContacts.BackColor = System.Drawing.Color.PaleTurquoise;
      this.btnListeContacts.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnListeContacts.FlatAppearance.BorderSize = 0;
      this.btnListeContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnListeContacts.Image = ((System.Drawing.Image)(resources.GetObject("btnListeContacts.Image")));
      this.btnListeContacts.Location = new System.Drawing.Point(14, 170);
      this.btnListeContacts.Name = "btnListeContacts";
      this.btnListeContacts.Size = new System.Drawing.Size(201, 65);
      this.btnListeContacts.TabIndex = 1;
      this.btnListeContacts.Text = "Contacts";
      this.btnListeContacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnListeContacts.UseVisualStyleBackColor = false;
      this.btnListeContacts.Click += new System.EventHandler(this.BtnListeContacts_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(12, 11);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(203, 133);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // panelContent
      // 
      this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelContent.Location = new System.Drawing.Point(223, 0);
      this.panelContent.Name = "panelContent";
      this.panelContent.Size = new System.Drawing.Size(845, 647);
      this.panelContent.TabIndex = 1;
      // 
      // frmMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1068, 647);
      this.Controls.Add(this.panelContent);
      this.Controls.Add(this.panelMenu);
      this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.Name = "frmMenu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormMenu";
      this.Load += new System.EventHandler(this.FrmMenu_Load);
      this.panelMenu.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

      }

    #endregion
    private System.Windows.Forms.Panel panelMenu;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnListeContacts;
    private System.Windows.Forms.Button btnQuitter;
    private System.Windows.Forms.Button btnNouveau;
    private System.Windows.Forms.Panel panelContent;
    }
  }

