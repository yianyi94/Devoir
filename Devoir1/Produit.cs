using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Devoir1
{
    public class Produit
    {
        public string Reference { get; set; }
        
        public double Prix_unitaire { get; set; }
        public string Prix_Total { get { return string.Format("(0)$", Prix_unitaire * Quantite); } }
        public double Quantite { get; set; }
        public string date { get; set; }
       
        public string Designation { get; set; }
        public Produit( string reference,string designation,double quantite, double prix_unitaire)
        {
            
            this.Prix_unitaire = prix_unitaire;
            this.Quantite = quantite;
            this.Reference = reference;
            this.Designation = designation;
        }
        public Produit() { } 

        public override bool Equals(object obj)
        {
            return obj is Produit produit &&
                   Reference == produit.Reference;
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Reference);
        }

       
    }
}
