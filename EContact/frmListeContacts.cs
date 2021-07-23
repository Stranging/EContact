using EContact.Models;

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EContact
  {
  public partial class frmListeContacts : UserControl
    {
    public frmListeContacts()
      {
      InitializeComponent();
      }

    private void FrmListeContacts_Load(object sender, EventArgs e)
      {
      BindingList<Contact> lst = new BindingList<Contact>(DBContact.GetListContacts());
      dgvContacts.DataSource = lst;
      dgvContacts.AutoResizeColumns();
      dgvContacts.AllowUserToResizeColumns = true;
      dgvContacts.AllowUserToOrderColumns = true;
      dgvContacts.AllowUserToAddRows = false;
      dgvContacts.Columns["Photo"].Visible = false;
      lblNbreContacts.Text = dgvContacts.Rows.Count.ToString();
      }

    private void BtnRechercher_Click(object sender, EventArgs e)
      {
      if (txtRecherche.Text != "")
        {
        var lst = new BindingList<Contact>(DBContact.SearchContact(txtRecherche.Text));
        dgvContacts.DataSource = lst;
        }
      else
        {
        var lst = new BindingList<Contact>(DBContact.GetListContacts());
        dgvContacts.DataSource = lst;
        }
      lblNbreContacts.Text = dgvContacts.Rows.Count.ToString();
      }

    private void TxtRecherche_KeyUp(object sender, KeyEventArgs e)
      {
      BtnRechercher_Click(sender, e);
      }

    private void DgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
      {
      if (e.RowIndex >= 0)
        {
        int index = e.RowIndex;
        dgvContacts.Rows[index].Selected = true;
        txtID.Text = dgvContacts.Rows[index].Cells[0].Value.ToString();
        txtNom.Text = dgvContacts.Rows[index].Cells[1].Value.ToString();
        string txtDate = dgvContacts.Rows[index].Cells[2].Value.ToString();
        dtpNaissance.Text = DateTime.Parse(txtDate).ToString("dd/MM/yyyy");
        txtEmail.Text = dgvContacts.Rows[index].Cells[3].Value.ToString();
        txtTelephone.Text = dgvContacts.Rows[index].Cells[4].Value.ToString();
        cmbGenre.Text = dgvContacts.Rows[index].Cells[5].Value.ToString();
        byte[] img = (byte[])dgvContacts.Rows[index].Cells[6].Value;
        if (img != null)
          {
          MemoryStream stream = new MemoryStream(img);
          pibPhoto.Image = Image.FromStream(stream);
          }
        else
          {
          pibPhoto.Image = null;
          }
        }
      }
    }
  }
