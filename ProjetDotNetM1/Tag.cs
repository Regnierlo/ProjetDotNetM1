using System;
using System.Collections.Generic;

namespace ProjetDotNetM1
{
    public class Tag
    {
        #region Variables de classe
        private String _libelle;
        private List<Tag> _lpere;
        #endregion

        #region Propriétés
        public String Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }

        public List<Tag> ListePere
        {
            get { return _lpere; }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur sans pere, donc un noeud principal
        /// </summary>
        /// <param name="libelle">Libelle du tag.</param>
        public Tag(String libelle)
        {
            this._libelle = libelle;
            _lpere = new List<Tag>();
        }

        /// <summary>
        /// Constructeur avec un seul pere.
        /// </summary>
        /// <param name="libelle">Libelle. du tag</param>
        /// <param name="pere">Pere du tag crée.</param>
        public Tag(String libelle, Tag pere)
        {
            this._libelle = libelle;
            this._lpere = new List<Tag>();
            this._lpere.Add(pere);
        }

        /// <summary>
        /// Constructeur avec plusieurs peres.
        /// </summary>
        /// <param name="libelle">Libelle du tag.</param>
        /// <param name="pere">Peres du tag. Il faut une liste de tag qui servira à lister les pères.</param>
        public Tag(String libelle, List<Tag> pere)
        {
            this._libelle = libelle;
            this._lpere = pere;
        }
        #endregion

        #region GestionPere
        /// <summary>
        /// Ajouter un pere.
        /// </summary>
        /// <param name="npere">Nom du nouveau pere à ajouter.</param>
        public void AjouterUnPere(Tag npere)
        {
            _lpere.Add(npere);
        }

        /// <summary>
        /// Ajouter plusieurs pères en une seule fois.
        /// </summary>
        /// <param name="nlpere">Liste des pères à ajouter.</param>
        public void AjouterListePeres(List<Tag> nlpere)
        {
            //pour tous les tags present dans nlpere, on les lit et le tag courant sera ntag
            foreach (var ntag in nlpere)
            {
                //ajout du tag en lecture courante
                _lpere.Add(ntag);
            }
        }

        /// <summary>
        /// Supprimer un pere de la liste.
        /// </summary>
        /// <param name="suppPere">Tag du pere à supprimer</param>
        public void SupprimerPere(Tag suppPere)
        {
            try
            {
                //On parcourt tous les tags de la liste du tag courant
                foreach (var tagCourant in _lpere)
                {
                    //Si le tag en lecture est le meme que le tag a supprimer
                    if (tagCourant.Equals(suppPere))
                    {
                        //On supprime le pere voulu de la liste
                        _lpere.Remove(tagCourant);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        /// <summary>
        /// Permet de comparer deux objets entre eux afin de vérifier s'il s'agit du même. Ici on compare le tag courant avec un objet quelconque.
        /// </summary>
        /// <param name="o">Objet qui va être comparé avec le tag courant</param>
        /// <returns><c>true</c> si l'objet <see cref="object"/> est égal au tag courant
        /// <see cref="T:ProjetDotNetM1.Tag"/>; sinon, <c>false</c>.</returns>
        public override Boolean Equals(Object o)
        {
            Boolean res = false;
            Boolean exist = false;

            //Si l'objet a comparer est du même type que l'objet courant
            if(o.GetType() == this.GetType())
            {
                //On caste l'objet o en tag
                Tag t = (Tag)o;

                //On compare le libelle
                if (this._libelle == t._libelle)
                {
                    res = true;

                    //Pour tous les peres du tag courant
                    foreach (var thistag in this._lpere)
                    {
                        exist = false;
                        //On liste tous les peres du tag compare
                        foreach (var ttag in t._lpere)
                        {
                            //Si le tag n'existe pas
                            if (thistag.Equals(ttag))
                                exist = true;
                        }

                        if (!exist)
                            res = false;
                    }
                }
            }

            return res;
        }
    }
}
