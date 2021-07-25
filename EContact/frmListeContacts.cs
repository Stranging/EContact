using EContact.Models;

using Microsoft.Reporting.WinForms;

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EContact
  {
  public partial class frmListeContacts : UserControl
    {

    private string fichier;
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

    private void BtnUpload_Click(object sender, EventArgs e)
      {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.png; *.bmp) | *.jpg; *.jpeg; *.gif; *.png; *.bmp";
      if (ofd.ShowDialog() == DialogResult.OK)
        {
        pibPhoto.Image = new Bitmap(ofd.FileName);
        }
      }

    private void BtnUpdate_Click(object sender, EventArgs e)
      {
      if (txtID.Text != "")
        {
        Contact c = new Contact();
        c.iD = Int32.Parse(txtID.Text);
        c.nomComplet = txtNom.Text;
        c.dateNaiss = dtpNaissance.Value.Date;
        c.email = txtEmail.Text;
        c.telephone = txtTelephone.Text;
        c.genre = cmbGenre.Text;

        MemoryStream stream = new MemoryStream();
        pibPhoto.Image.Save(stream, pibPhoto.Image.RawFormat);
        byte[] img = stream.ToArray();
        c.photo = img;

        DBContact.UpdateContact(c);

        var lst = new BindingList<Contact>(DBContact.GetListContacts());
        dgvContacts.DataSource = lst;

        MessageBox.Show
          ("Modification du contact effectuée avec succès",
          "Modification contact",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
        }
      }

    private void BtnDelete_Click(object sender, EventArgs e)
      {
      if(txtID.Text != "")
        {
        DialogResult res = MessageBox.Show(
          "Voulez vous vraiment supprimer ce contact ?",
          "Confirmation suppression",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning
          );
        if(res == DialogResult.Yes)
          {
          DBContact.DeleteContact(Int32.Parse(txtID.Text));

          var lst = new BindingList<Contact>(DBContact.GetListContacts());
          dgvContacts.DataSource = lst;

          MessageBox.Show
            ("Suppression du contact effectuée avec succès",
            "Suppression contact",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
          }

        lblNbreContacts.Text = dgvContacts.Rows.Count.ToString();
        }
      }

    private void BtnPrint_Click(object sender, EventArgs e)
      {
      ReportDataSource rs = new ReportDataSource();
      rs.Name = "DataSetListeContacts";
      rs.Value = DBContact.SearchContact(txtRecherche.Text);
      frmPrint frm = new frmPrint();
      frm.RPV.LocalReport.DataSources.Clear();
      frm.RPV.LocalReport.DataSources.Add(rs);
      frm.RPV.LocalReport.ReportEmbeddedResource = "EContact.RPListeContact.rdlc";
      frm.RPV.Dock = DockStyle.Fill;
      frm.Controls.Add(frm.RPV);
      frm.RPV.RefreshReport();
      frm.StartPosition = FormStartPosition.CenterScreen;
      frm.WindowState = FormWindowState.Maximized;
      frm.ShowDialog();
      }
    }
  }
