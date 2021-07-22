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
  public partial class frmMenu : Form
    {
    public frmMenu()
      {
      InitializeComponent();
      }

    private void BtnQuitter_Click(object sender, EventArgs e)
      {
      Application.Exit();
      }

    private void BtnListeContacts_Click(object sender, EventArgs e)
      {
      panelContent.Controls.Clear();
      frmListeContacts frmlc = new frmListeContacts
        {
        Dock = DockStyle.Fill
        };
      panelContent.Controls.Add(frmlc);
      }

    private void BtnNouveau_Click(object sender, EventArgs e)
      {
      panelContent.Controls.Clear();
      frmAddContact frmac = new frmAddContact
        {
        Dock = DockStyle.Fill
        };
      panelContent.Controls.Add(frmac);
      }

    private void FrmMenu_Load(object sender, EventArgs e)
      {
      BtnListeContacts_Click(sender, e);
      }
    }
  }
