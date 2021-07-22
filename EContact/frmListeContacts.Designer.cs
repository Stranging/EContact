
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
      this.lblNombre = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(0, 4);
      this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
      // lblNombre
      // 
      this.lblNombre.AutoSize = true;
      this.lblNombre.Location = new System.Drawing.Point(659, 13);
      this.lblNombre.Name = "lblNombre";
      this.lblNombre.Size = new System.Drawing.Size(71, 22);
      this.lblNombre.TabIndex = 4;
      this.lblNombre.Text = "label1";
      // 
      // frmListeContacts
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.Controls.Add(this.lblNombre);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.label2);
      this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "frmListeContacts";
      this.Size = new System.Drawing.Size(845, 647);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblNombre;
    }
  }
