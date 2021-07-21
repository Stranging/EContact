using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EContact.Models
  {
  public static class DBContact
    {
    public static List<Contact> lstContacts = new List<Contact>();

    // Ajouter un contacts à la liste de contacts
    public static int AddContact(Contact c)
      {
      c.iD = lstContacts.Any() ? lstContacts.Max(x => x.iD + 1) : 100;

      /*
       * Equivaut à 
       * if (lstContacts.Any())
        {
        c.iD = lstContacts.Max().iD +1;
        }
      else
        {
        c.iD = 100;
        }
      */
      lstContacts.Add(c);
      return c.iD;
      }

    // Récuperer la liste des contacts
    public static List<Contact> GetListContacts()
      {
      return lstContacts;
      }

    // Supprimer un contact de la liste de contacts
    public static void DeleteContact(int idContact)
      {
      int index = lstContacts.FindIndex(x => x.iD == idContact);
      lstContacts.RemoveAt(index);
      }

    // Modifier un contact
    public static void UpdateContact(Contact c)
      {
      Contact recherche = lstContacts.FirstOrDefault(x => x.iD == c.iD);
      recherche.nomComplet = c.nomComplet;
      recherche.dateNaiss = c.dateNaiss;
      recherche.email = c.email;
      recherche.telephone = c.telephone;
      recherche.genre = c.genre;
      recherche.photo = c.photo;
      }

    // recherche un contact par nom
    public static List<Contact> SearchContact(string name)
      {
      List<Contact> resultat = lstContacts.Where(x => x.nomComplet.ToLower().Contains(name.ToLower())).ToList();
      return resultat;
      }
    }
  }
