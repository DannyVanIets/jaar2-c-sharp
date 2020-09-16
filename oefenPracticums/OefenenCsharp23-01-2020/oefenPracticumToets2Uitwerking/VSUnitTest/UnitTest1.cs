using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpdrachtUnitTest;

namespace VSUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void drieStringsKleineLetters_levertZinMetHoofdletterAfgeslotenMetPunt()
        {
            // arrange
            string[] strings = { "wat", "een", "prachtige", "dag" };

            // act
            string actual = StringBewerkingen.MaakZinVanWoorden(strings);

            // assert
            string expected = "Wat een prachtige dag.";
            Assert.AreEqual(expected, actual, "Geen goede zin gevormd");
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void geenStrings_levertException()       // is een ontwerpbeslissing!
        {
            // arrange
            string[] strings = { };

            // act
            StringBewerkingen.MaakZinVanWoorden(strings);
        }

        [TestMethod]
        public void eenStringKleineLetters_levertWoordMetHoofdletterAfgeslotenMetPunt()
        {
            // arrange
            string[] strings = { "dus" };

            // act
            string actual = StringBewerkingen.MaakZinVanWoorden(strings);

            // assert
            string expected = "Dus.";
            Assert.AreEqual(expected, actual, "Geen goede zin gevormd");
        }

        [TestMethod]
        public void eenStringVanEenLetter_levertLetterMetHoofdletterAfgeslotenMetPunt()
        {
            // arrange
            string[] strings = { "i" };

            // act
            string actual = StringBewerkingen.MaakZinVanWoorden(strings);

            // assert
            string expected = "I.";
            Assert.AreEqual(expected, actual, "Geen goede zin gevormd");
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void eenLegeString_levertException() // Ontwerpbeslissing!
        {
            // arrange
            string[] strings = { "" };

            // act
            StringBewerkingen.MaakZinVanWoorden(strings);
            
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void arrayBevatAlleenStringsMetSpaties_levertException() // Ontwerp beslissing!
        {
            // arrange
            string[] strings = { "  " };

            // act
            StringBewerkingen.MaakZinVanWoorden(strings);
        }

        [TestMethod]
        public void stringsBevattenHoofdletters_levertZinMetAlleenAanBeginHoofdletter()
        {
            // arrange
            string[] strings = { "WAT", "EEN", "Prachtige", "DAG" };

            // act
            string actual = StringBewerkingen.MaakZinVanWoorden(strings);

            // assert
            string expected = "Wat een prachtige dag.";
            Assert.AreEqual(expected, actual, "Geen goede zin gevormd");
        }

        [TestMethod]
        public void eersteZinBegintNietMetLetter_levertZinMetAlleenAanBeginHoofdletter()
        {
            // arrange
            string[] strings = { " WAT", "EEN", "Prachtige", "DAG" };

            // act
            string actual = StringBewerkingen.MaakZinVanWoorden(strings);

            // assert
            string expected = "Wat een prachtige dag.";
            Assert.AreEqual(expected, actual, "Geen goede zin gevormd");
        }

        [TestMethod]
        public void stringsMetVoorloopSpatiesEnNaloopSpaties_levertZinMetSlechtsEenSpatieTussenDeWoorden()
        {
            // arrange
            string[] strings = { "wat  ", "   een", " prachtige ", " dag " };

            // act
            string actual = StringBewerkingen.MaakZinVanWoorden(strings);

            // assert
            string expected = "Wat een prachtige dag.";
            Assert.AreEqual(expected, actual, "Geen goede zin gevormd");
        }

        [TestMethod]
        public void eerstStringBegintNietMetEenLetter_levertZinDieNietMetHoofdletterBegint()
        {
            // arrange
            string[] strings = { "!wat  ", "   een", " prachtige ", " dag " };

            // act
            string actual = StringBewerkingen.MaakZinVanWoorden(strings);

            // assert
            string expected = "!wat een prachtige dag.";
            Assert.AreEqual(expected, actual, "Geen goede zin gevormd");
        }
    }
}
