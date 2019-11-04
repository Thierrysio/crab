using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crab.Modeles
{
    class TypeBorne
    {
        #region Attributs
        public static ArrayList CollClasseTypeBorne = new ArrayList();
        
        private int _codeTypeBorne;
        private DateTime _dureeRevision;
        private int _nbJoursEntreRevisions;
        private int _nbUnitesEntreRevisions;
        private Categorie _laCategorie;
        private ArrayList _collObjetsBornes;
        #endregion

        #region Constructeurs
        public TypeBorne(int codeTypeBorne, DateTime dureeRevision, int nbJoursEntreRevisions, int nbUnitesEntreRevisions, Categorie laCategorie)
        {
            CodeTypeBorne = codeTypeBorne;
            DureeRevision = dureeRevision;
            NbJoursEntreRevisions = nbJoursEntreRevisions;
            NbUnitesEntreRevisions = nbUnitesEntreRevisions;
            LaCategorie = laCategorie;
            laCategorie.CollObjetsTypeBorne.Add(this);
            TypeBorne.CollClasseTypeBorne.Add(this);
            CollObjetsBornes = new ArrayList();
            
        }

        #endregion

        #region Getters/Setters
        public int CodeTypeBorne { get => _codeTypeBorne; set => _codeTypeBorne = value; }
        public DateTime DureeRevision { get => _dureeRevision; set => _dureeRevision = value; }
        public int NbJoursEntreRevisions { get => _nbJoursEntreRevisions; set => _nbJoursEntreRevisions = value; }
        public int NbUnitesEntreRevisions { get => _nbUnitesEntreRevisions; set => _nbUnitesEntreRevisions = value; }
        public ArrayList CollObjetsBornes { get => _collObjetsBornes; set => _collObjetsBornes = value; }
        internal Categorie LaCategorie { get => _laCategorie; set => _laCategorie = value; }

        #endregion

        #region Methodes
        public int GetNbJoursEntreRevisions()
        {
            return this.NbJoursEntreRevisions;
        }
        #endregion
    }
}
