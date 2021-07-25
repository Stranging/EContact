using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EContact
	{
	class Serialise
		{
		/// <summary>
		/// Sérialisation
		/// </summary>
		/// <param name="fichier"></param>
		/// <param name="objet"></param>
		/// 
		public static void Sauve(string fichier, Object objet)
			{
			// si le fichier existe il faut le supprimer
			if (File.Exists(fichier))
				{
				File.Delete(fichier);
				}
			// Création du flux pour l'écriture dans le fichier
			FileStream flux = new FileStream(fichier, FileMode.Create);
			// Création d'un objet pour le formatage en binaire des informations
			BinaryFormatter fbinaire = new BinaryFormatter();
			// Sérialisation des informations
			fbinaire.Serialize(flux, objet);
			// Fermeture du flux
			flux.Close();
			}

		/// <summary>
		/// Désérialisation
		/// </summary>
		/// <returns></returns>
		/// 
		public static Object Recup(string fichier)
			{
			// Cont^role de l'existence du fichier
			if (File.Exists(fichier))
				{
				// Ouverture du flux pour la lecture dans le fichier
				FileStream flux = new FileStream(fichier, FileMode.Open);
				// Création d'un objet pour le formatage en binaire
				BinaryFormatter fbinaire = new BinaryFormatter();
				// Récupération de l'objet sérialisé
				try
					{
					Object objet = fbinaire.Deserialize(flux);
					// fermeture du flux
					flux.Close();
					// retour de l'objet
					return objet;
					}
				catch
					{
					return null;
					}
				}
			else
				{
				return null;
				}
			}
		}
	}
