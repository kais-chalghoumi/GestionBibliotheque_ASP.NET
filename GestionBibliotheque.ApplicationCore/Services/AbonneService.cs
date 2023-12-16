using GestionBibliotheque.ApplicationCore.Services;
using GestionBibliotheque.ApplicationCore.Domain;
using GestionBibliotheque.ApplicationCore.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionBibliotheque.ApplicationCore.Services
{
    public class AbonneService : Service<Abonne>, IAbonneService
    {
        public AbonneService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {}
        
    }
}
