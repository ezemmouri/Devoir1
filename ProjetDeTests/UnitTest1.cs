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
            int nbJour1 = 23;
            bool valider1 = Condition.Valider(nbJour1);
            Assert.AreEqual(true, valider1);
            // Le nombre de jours d'achat est > à 30 jours
            int nbJour2 = 32;
            bool valider2 = Condition.Valider(nbJour2);
            Assert.AreEqual(false, valider2);
        }

        [TestMethod()]
        public void CalculerMontantMaxTest()
        {
            // Pour la catégorie livre
            string categorie1 = "Livres";
            int Montant1 = Condition.CalculerMontantMax(categorie1);
            Assert.AreEqual(30, Montant1);
            // Pour la catégorie jouet
            string categorie2 = "Jouets";
            int Montant2 = Condition.CalculerMontantMax(categorie2);
            Assert.AreEqual(50, Montant2);
            // Pour la catégorie informatique
            string categorie3 = "Informatique";
            int Montant3 = Condition.CalculerMontantMax(categorie3);
            Assert.AreEqual(1000, Montant3);
        }

        [TestMethod()]
        public void CalculerMontantRembourseTest()
        {
            // Un livre achété 24 euros depuis 15 jours avec un état "Très abimé" en étant non membre
            int nbJour1 = 15;
            string categorie1 = "Livres";
            double montantRemb1 = Condition.CalculerMontantRembourse(nbJour1, categorie1, false, "Tres abime", 24);
            Assert.AreEqual(12, montantRemb1);
            // Un livre achété 24 euros depuis 15 jours avec un état "Bon" en étant membre
            int nbJour2 = 15;
            string categorie2 = "Livres";
            double montantRemb2 = Condition.CalculerMontantRembourse(nbJour2, categorie2, true, "Bon", 24);
            Assert.AreEqual(21.6, montantRemb2);
        }

        [TestMethod()]
        public void CalculerReductionMembreTest()
        {
            // Il est membre
            double membre1 = Condition.CalculerReductionMembre(true);
            Assert.AreEqual(0, membre1);
            // Il n'est pas membre
            double membre2 = Condition.CalculerReductionMembre(false);
            Assert.AreEqual(0.2, membre2);
        }

        [TestMethod()]
        public void CalculerReductionTest()
        {
            // Pour un état "bon"
            double reduction1 = Condition.CalculerReduction("bon");
            Assert.AreEqual(0.1, reduction1);
            // Pour un état "abimé"
            double reduction2 = Condition.CalculerReduction("Abime");
            Assert.AreEqual(0.3, reduction2);
        }
    }
}
