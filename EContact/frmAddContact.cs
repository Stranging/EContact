using EContact.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
      c.photo = null;
      int res = DBContact.AddContact(c);

      MessageBox.Show("Contact ajouté avec succès, Id = " + res , "Ajout", MessageBoxButtons.OK,MessageBoxIcon.Information);
      }
    }
  }
