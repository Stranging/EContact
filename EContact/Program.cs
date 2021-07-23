using EContact.Models;

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EContact
  {
  static class Program
    {
    /// <summary>
    /// Point d'entrée principal de l'application.
    /// </summary>
    [STAThread]
    static void Main()
      {
      /**
       * Pour l'image par défaut
       */
      MemoryStream stream = new MemoryStream();
      Bitmap image = Properties.Resources._default;
      image.Save(stream, image.RawFormat);
      byte[] binImage = stream.ToArray();

      /**
       * Données de test
       */
      DBContact.AddContact(new Contact("Poupouss", DateTime.Parse("05/04/1972"), "poupouss@gmail.com", "06 10 20 30 40", "M", binImage));
      DBContact.AddContact(new Contact("Vick", DateTime.Parse("07/07/1975"), "vick@gmail.com", "06 00 00 00 00", "M", binImage));
      DBContact.AddContact(new Contact("Olaf", DateTime.Parse("10/04/78"), "olaf@gmail.com", "06 10 00 00 00", "M", binImage));
      DBContact.AddContact(new Contact("Pilou", DateTime.Parse("01/12/1998"), "pilou@gmail.com", "06 20 00 00 00", "M", binImage));
      DBContact.AddContact(new Contact("Zouzou", DateTime.Parse("04/05/2002"), "zouzou@gmail.com", "06 30 00 00 00", "M", binImage));
      DBContact.AddContact(new Contact("Pepette", DateTime.Parse("01/06/2011"), "pepette@gmail.com", "06 40 00 00 00", "F", binImage));
      DBContact.AddContact(new Contact("Les 5 zouilles", DateTime.Parse("10/03/2002"), "les5zouilles@univ.dieu", "00 00 00 00 00", "M", binImage));
      DBContact.AddContact(new Contact("Le chat gris", DateTime.Parse("10/05/1980"), "lechatgris@univ.dieu", "00 00 00 00 00", "M", binImage));
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new frmMenu());
      }
    }
  }
