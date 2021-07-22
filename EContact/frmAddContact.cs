using EContact.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EContact
  {
  public partial class frmAddContact : UserControl
    {
    public frmAddContact()
      {
      InitializeComponent();
      }

    private void BtnSave_Click(object sender, EventArgs e)
      {
      Contact c = new Contact();

      c.nomComplet = txtNom.Text;
      c.dateNaiss = dtpNaissance.Value.Date;
      c.email = txtEmail.Text;
      c.telephone = txtTelephone.Text;
      c.genre = cmbGenre.Text;

      MemoryStream stream = new MemoryStream();
      pibPhoto.Image.Save(stream, pibPhoto.Image.RawFormat);
      byte[] binImage = stream.ToArray();

      c.photo = binImage;

      int res = DBContact.AddContact(c);

      MessageBox.Show("Contact ajouté avec succès, Id = " + res, "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

    private void BtnReset_Click(object sender, EventArgs e)
      {
      txtNom.Text = "";
      txtEmail.Text = "";
      txtTelephone.Text = "";
      cmbGenre.Text = "";
      pibPhoto.Image = null;
      }

    private void BtnUpload_Click(object sender, EventArgs e)
      {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.png; *.bmp) | *.jpg; *.jpeg; *.gif; *.png; *.bmp";
      if (ofd.ShowDialog() == DialogResult.OK)
        {
        pibPhoto.Image = new Bitmap(ofd.FileName);
        }
      }
    }
  }
