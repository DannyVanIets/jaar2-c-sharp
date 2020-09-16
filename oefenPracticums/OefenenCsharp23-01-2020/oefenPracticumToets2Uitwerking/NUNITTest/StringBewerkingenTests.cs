using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpdrachtUnitTest;

namespace NUNITTest
{
    [TestFixture]
    public class StringBewerkingenTests
    {
        [Test]
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

        [Test]
        public void geenStrings_levertException()       // is een ontwerpbeslissing!
        {
            // arrange
            string[] strings = { };

            // act
            Assert.Throws(typeof(Exception), () => StringBewerkingen.MaakZinVanWoorden(strings));
        }

        [Test]
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

        [Test]
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

        [Test]
        public void eenLegeString_levertException() // Ontwerpbeslissing!
        {
            // arrange
            string[] strings = { "" };

            // act
            Assert.Throws(typeof(Exception), () => StringBewerkingen.MaakZinVanWoorden(strings));

        }

        [Test]
        public void arrayBevatAlleenStringsMetSpaties_levertException() // Ontwerpbeslissing!
        {
            // arrange
            string[] strings = { "  " };

            // act
            Assert.Throws(typeof(Exception), () => StringBewerkingen.MaakZinVanWoorden(strings));
        }

        [Test]
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

        [Test]
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

        [Test]
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

       
        [Test]
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
