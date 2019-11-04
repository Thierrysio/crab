using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crab.Modeles
{
    class Borne
    {
        #region Attributs
        public static ArrayList CollClasseBorne = new ArrayList();

        private int _idBorne;
        private DateTime _dateDerniereRevision;
        private int _indiceCompteurUnites;
        private  TypeBorne _leType;
        #endregion
        #region Constructeurs
        public Borne(int idBorne, DateTime dateDerniereRevision, int indiceCompteurUnites, TypeBorne leType)
        {
            IdBorne = idBorne;
            DateDerniereRevision = dateDerniereRevision;
            IndiceCompteurUnites = indiceCompteurUnites;
            LeType = leType;
            LeType.CollObjetsBornes.Add(this);
            
            Borne.CollClasseBorne.Add(this);
            
        }
        #endregion

        #region Getters/Setters
        public int IdBorne { get => _idBorne; set => _idBorne = value; }
        public DateTime DateDerniereRevision { get => _dateDerniereRevision; set => _dateDerniereRevision = value; }
        public int IndiceCompteurUnites { get => _indiceCompteurUnites; set => _indiceCompteurUnites = value; }
        internal TypeBorne LeType { get => _leType; set => _leType = value; }
        #endregion

        #region Methodes
        public int GetNbJoursEntreRevisions()
        {
            return this.LeType.GetNbJoursEntreRevisions();
        }

        public string AlerteRevision()
        {
            if (IndiceCompteurUnites > this.GetNbJoursEntreRevisions())
            {
                return "Vous devez réviser cette borne";
            }
            else
            {
                return "Aucun Problème";
            }
        }
        public string RecupererLaCategorie()
        {
            return this.LeType.LaCategorie.GetNomCategorie();
        }
        #endregion
    }
}
