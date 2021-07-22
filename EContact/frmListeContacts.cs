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
    }
  }
