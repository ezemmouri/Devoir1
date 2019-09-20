using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelObjet;

namespace ProjetDeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void ValiderTest()
        {
            // Le nombre de jours d'achat est < à 30 jours
            

            // Le nombre de jours d'achat est > à 30 jours
            
        }

        [TestMethod()]
        public void CalculerMontantMaxTest()
        {
            // Pour la catégorie livre
            

            // Pour la catégorie jouet
            

            // Pour la catégorie informatique
            
        }

        [TestMethod()]
        public void CalculerMontantRembourseTest()
        {
            // Un livre achété 24 euros depuis 15 jours avec un état "Très abimé" en étant non membre

            // Un livre achété 24 euros depuis 15 jours avec un état "Bon" en étant membre

        }

        [TestMethod()]
        public void CalculerReductionMembreTest()
        {
            // Il est membre
            


            // Il n'est pas membre
            

        }

        [TestMethod()]
        public void CalculerReductionTest()
        {
            // Pour un état "bon"
            


            // Pour un état "abimé"
            

        }
    }
}
