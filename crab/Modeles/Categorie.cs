using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crab.Modeles
{
    class Categorie
    {
        #region Attributs
        public static ArrayList CollClasseCategorie = new ArrayList();
        private int _idCategorie;
        private string _nomCategorie;
        private ArrayList _collObjetsTypeBorne;


        #endregion
        #region Constructeurs
        public Categorie(int idCategorie, string nomCategorie)
        {
            IdCategorie = idCategorie;
            NomCategorie = nomCategorie;
            CollObjetsTypeBorne = new ArrayList();
            Categorie.CollClasseCategorie.Add(this);
        }


        #endregion
        #region Getters/Setters
        public int IdCategorie { get => _idCategorie; set => _idCategorie = value; }
        public string NomCategorie { get => _nomCategorie; set => _nomCategorie = value; }
        public ArrayList CollObjetsTypeBorne { get => _collObjetsTypeBorne; set => _collObjetsTypeBorne = value; }

        #endregion
        #region Methodes
        public string GetNomCategorie()
        {
            return this.NomCategorie;
        }

        public int NbreTypeBorne()
        {
            return this.CollObjetsTypeBorne.Count;
        }

        public ArrayList ListeBorne()
        {
            ArrayList resultat = new ArrayList();

            if(this.IdCategorie == 1)
            {
                return this.RecupererLaborne(117).CollObjetsBornes;
            }
            else if (this.IdCategorie == 2)
            {
                return this.RecupererLaborne(217).CollObjetsBornes;
            }
            return resultat;
        }

        private TypeBorne RecupererLaborne(int id)
        {
            foreach(TypeBorne leTypeBorne in this.CollObjetsTypeBorne)
            {  
                if( leTypeBorne.CodeTypeBorne == id)
                {
                    return leTypeBorne;
   
                }
            }
            return null;
        }

        public void calcultemps ()
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2019, 10, 15);

            TimeSpan t1 = d1 - d2;

            double totaljours = t1.TotalDays;
        }
        #endregion
    }
}
