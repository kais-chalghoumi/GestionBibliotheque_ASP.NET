using GestionBibliotheque.ApplicationCore.Domain;
using GestionBibliotheque.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace GestionBibliotheque.ApplicationCore.Interfaces
{
    public interface IPretLivreService : IService<PretLivre>
    {
        IEnumerable<Livre> GetLivresPretes(DateTime debut, DateTime fin);
        IEnumerable<Categorie> GetCategoriesLivresPretes(Statut statut);
    }
}
