using System;

namespace EContact.Models
  {
   public class Contact
    {
    public int iD { get; set; }
    public string nomComplet { get; set; }
    public DateTime dateNaiss { get; set; }
    public string email { get; set; }
    public string telephone { get; set; }
    public string genre { get; set; }
    public byte[] photo { get; set; }

    public Contact()
      {
      }

    public Contact(string nomComplet, DateTime dateNaiss, string email, string telephone, string genre, byte[] photo)
      {
      this.nomComplet = nomComplet;
      this.dateNaiss = dateNaiss;
      this.email = email;
      this.telephone = telephone;
      this.genre = genre;
      this.photo = photo;
      }
    }
  }
