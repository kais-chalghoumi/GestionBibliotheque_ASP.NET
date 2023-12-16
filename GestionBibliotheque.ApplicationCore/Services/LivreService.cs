using GestionBibliotheque.ApplicationCore.Services;
using GestionBibliotheque.ApplicationCore.Domain;
using GestionBibliotheque.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionBibliotheque.ApplicationCore.Services
{
    public class LivreService : Service<Livre>, ILivreService
    {
        public LivreService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {}
        public Livre GetMostPrete()
        {
            return GetAll().OrderByDescending(e => e.PretLivres.Count).FirstOrDefault();
        }
    }
}
