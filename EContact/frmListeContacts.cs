using EContact.Models;

using System;
using System.ComponentModel;
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
        if(txtRecherche.Text != "")
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
    }
  }
