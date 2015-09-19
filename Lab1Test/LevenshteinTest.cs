using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace Lab1Test
{
    [TestClass]
    public class LevenshteinTest
    {
        [TestMethod]
        public void BothStringsAreEmpty()
        {
            string source = "";
            string comp = "";
            int expectedDistance = 0;

            int actualDistance1 = StringDistCalc.levenshteinDist(source, comp);
            int actualDistance2 = StringDistCalc.levenshteinDistStack(source, comp);
            int actualDistance3 = StringDistCalc.damerauLevensteinDistance(source, comp);
            int actualDistance4 = StringDistCalc.levenshteinDistMatrix(source, comp);

            Assert.AreEqual(expectedDistance, actualDistance1, "levenshteinDist method is failed");
            Assert.AreEqual(expectedDistance, actualDistance2, "levenshteinDistStack method is failed");
            Assert.AreEqual(expectedDistance, actualDistance3, "damerauLevensteinDistance method is failed");
            Assert.AreEqual(expectedDistance, actualDistance4, "levenshteinDistMatrix method is failed");
        }

        [TestMethod]
        public void FirstStringIsEmpty()
        {
            string source = "";
            string comp = "abcd";
            int expectedDistance = 4;

            int actualDistance1 = StringDistCalc.levenshteinDist(source, comp);
            int actualDistance2 = StringDistCalc.levenshteinDistStack(source, comp);
            int actualDistance3 = StringDistCalc.damerauLevensteinDistance(source, comp);
            int actualDistance4 = StringDistCalc.levenshteinDistMatrix(source, comp);

            Assert.AreEqual(expectedDistance, actualDistance1, "levenshteinDist method is failed");
            Assert.AreEqual(expectedDistance, actualDistance2, "levenshteinDistStack method is failed");
            Assert.AreEqual(expectedDistance, actualDistance3, "damerauLevensteinDistance method is failed");
            Assert.AreEqual(expectedDistance, actualDistance4, "levenshteinDistMatrix method is failed");
        }

        [TestMethod]
        public void SecondStringIsEmpty()
        {
            string source = "abcd";
            string comp = "";
            int expectedDistance = 4;

            int actualDistance1 = StringDistCalc.levenshteinDist(source, comp);
            int actualDistance2 = StringDistCalc.levenshteinDistStack(source, comp);
            int actualDistance3 = StringDistCalc.damerauLevensteinDistance(source, comp);
            int actualDistance4 = StringDistCalc.levenshteinDistMatrix(source, comp);

            Assert.AreEqual(expectedDistance, actualDistance1, "levenshteinDist method is failed");
            Assert.AreEqual(expectedDistance, actualDistance2, "levenshteinDistStack method is failed");
            Assert.AreEqual(expectedDistance, actualDistance3, "damerauLevensteinDistance method is failed");
            Assert.AreEqual(expectedDistance, actualDistance4, "levenshteinDistMatrix method is failed");
        }

        [TestMethod]
        public void EqualStrings()
        {
            string source = "abcd";
            string comp = "abcd";
            int expectedDistance = 0;

            int actualDistance1 = StringDistCalc.levenshteinDist(source, comp);
            int actualDistance2 = StringDistCalc.levenshteinDistStack(source, comp);
            int actualDistance3 = StringDistCalc.damerauLevensteinDistance(source, comp);
            int actualDistance4 = StringDistCalc.levenshteinDistMatrix(source, comp);

            Assert.AreEqual(expectedDistance, actualDistance1, "levenshteinDist method is failed");
            Assert.AreEqual(expectedDistance, actualDistance2, "levenshteinDistStack method is failed");
            Assert.AreEqual(expectedDistance, actualDistance3, "damerauLevensteinDistance method is failed");
            Assert.AreEqual(expectedDistance, actualDistance4, "levenshteinDistMatrix method is failed");
        }

        [TestMethod]
        public void CharactersMissing_AtTheEnd()
        {
            string source = "abcde";
            string comp = "abc";
            int expectedDistance = 2;

            int actualDistance1 = StringDistCalc.levenshteinDist(source, comp);
            int actualDistance2 = StringDistCalc.levenshteinDistStack(source, comp);
            int actualDistance3 = StringDistCalc.damerauLevensteinDistance(source, comp);
            int actualDistance4 = StringDistCalc.levenshteinDistMatrix(source, comp);

            Assert.AreEqual(expectedDistance, actualDistance1, "levenshteinDist method is failed");
            Assert.AreEqual(expectedDistance, actualDistance2, "levenshteinDistStack method is failed");
            Assert.AreEqual(expectedDistance, actualDistance3, "damerauLevensteinDistance method is failed");
            Assert.AreEqual(expectedDistance, actualDistance4, "levenshteinDistMatrix method is failed");
        }

        [TestMethod]
        public void CharactesSuperfluous_AtTheEnd()
        {
            string source = "abc";
            string comp = "abcde";
            int expectedDistance = 2;

            int actualDistance1 = StringDistCalc.levenshteinDist(source, comp);
            int actualDistance2 = StringDistCalc.levenshteinDistStack(source, comp);
            int actualDistance3 = StringDistCalc.damerauLevensteinDistance(source, comp);
            int actualDistance4 = StringDistCalc.levenshteinDistMatrix(source, comp);

            Assert.AreEqual(expectedDistance, actualDistance1, "levenshteinDist method is failed");
            Assert.AreEqual(expectedDistance, actualDistance2, "levenshteinDistStack method is failed");
            Assert.AreEqual(expectedDistance, actualDistance3, "damerauLevensteinDistance method is failed");
            Assert.AreEqual(expectedDistance, actualDistance4, "levenshteinDistMatrix method is failed");
        }

        [TestMethod]
        public void CharactersMissing_AtTheBeginning()
        {
            string source = "abcde";
            string comp = "cde";
            int expectedDistance = 2;

            int actualDistance1 = StringDistCalc.levenshteinDist(source, comp);
            int actualDistance2 = StringDistCalc.levenshteinDistStack(source, comp);
            int actualDistance3 = StringDistCalc.damerauLevensteinDistance(source, comp);
            int actualDistance4 = StringDistCalc.levenshteinDistMatrix(source, comp);

            Assert.AreEqual(expectedDistance, actualDistance1, "levenshteinDist method is failed");
            Assert.AreEqual(expectedDistance, actualDistance2, "levenshteinDistStack method is failed");
            Assert.AreEqual(expectedDistance, actualDistance3, "damerauLevensteinDistance method is failed");
            Assert.AreEqual(expectedDistance, actualDistance4, "levenshteinDistMatrix method is failed");
        }

        [TestMethod]
        public void CharactesSuperfluous_AtTheBeginning()
        {
            string source = "cde";
            string comp = "abcde";
            int expectedDistance = 2;

            int actualDistance1 = StringDistCalc.levenshteinDist(source, comp);
            int actualDistance2 = StringDistCalc.levenshteinDistStack(source, comp);
            int actualDistance3 = StringDistCalc.damerauLevensteinDistance(source, comp);
            int actualDistance4 = StringDistCalc.levenshteinDistMatrix(source, comp);

            Assert.AreEqual(expectedDistance, actualDistance1, "levenshteinDist method is failed");
            Assert.AreEqual(expectedDistance, actualDistance2, "levenshteinDistStack method is failed");
            Assert.AreEqual(expectedDistance, actualDistance3, "damerauLevensteinDistance method is failed");
            Assert.AreEqual(expectedDistance, actualDistance4, "levenshteinDistMatrix method is failed");
        }

        [TestMethod]
        public void CharactersMissing_InTheMiddle()
        {
            string source = "abcdef";
            string comp = "abef";
            int expectedDistance = 2;

            int actualDistance1 = StringDistCalc.levenshteinDist(source, comp);
            int actualDistance2 = StringDistCalc.levenshteinDistStack(source, comp);
            int actualDistance3 = StringDistCalc.damerauLevensteinDistance(source, comp);
            int actualDistance4 = StringDistCalc.levenshteinDistMatrix(source, comp);

            Assert.AreEqual(expectedDistance, actualDistance1, "levenshteinDist method is failed");
            Assert.AreEqual(expectedDistance, actualDistance2, "levenshteinDistStack method is failed");
            Assert.AreEqual(expectedDistance, actualDistance3, "damerauLevensteinDistance method is failed");
            Assert.AreEqual(expectedDistance, actualDistance4, "levenshteinDistMatrix method is failed");
        }

        [TestMethod]
        public void CharactesSuperfluous_InTheMiddle()
        {
            string source = "abef";
            string comp = "abcdef";
            int expectedDistance = 2;

            int actualDistance1 = StringDistCalc.levenshteinDist(source, comp);
            int actualDistance2 = StringDistCalc.levenshteinDistStack(source, comp);
            int actualDistance3 = StringDistCalc.damerauLevensteinDistance(source, comp);
            int actualDistance4 = StringDistCalc.levenshteinDistMatrix(source, comp);

            Assert.AreEqual(expectedDistance, actualDistance1, "levenshteinDist method is failed");
            Assert.AreEqual(expectedDistance, actualDistance2, "levenshteinDistStack method is failed");
            Assert.AreEqual(expectedDistance, actualDistance3, "damerauLevensteinDistance method is failed");
            Assert.AreEqual(expectedDistance, actualDistance4, "levenshteinDistMatrix method is failed");
        }

        [TestMethod]
        public void AllCharactersDoNotMatch()
        {
            string source = "abcd";
            string comp = "efgh";
            int expectedDistance = 4;

            int actualDistance1 = StringDistCalc.levenshteinDist(source, comp);
            int actualDistance2 = StringDistCalc.levenshteinDistStack(source, comp);
            int actualDistance3 = StringDistCalc.damerauLevensteinDistance(source, comp);
            int actualDistance4 = StringDistCalc.levenshteinDistMatrix(source, comp);

            Assert.AreEqual(expectedDistance, actualDistance1, "levenshteinDist method is failed");
            Assert.AreEqual(expectedDistance, actualDistance2, "levenshteinDistStack method is failed");
            Assert.AreEqual(expectedDistance, actualDistance3, "damerauLevensteinDistance method is failed");
            Assert.AreEqual(expectedDistance, actualDistance4, "levenshteinDistMatrix method is failed");
        }

        [TestMethod]
        public void DifferentStringLength_AllCharactersDoNotMatch()
        {
            string source = "abcd";
            string comp = "efg";
            int expectedDistance = 4;

            int actualDistance1 = StringDistCalc.levenshteinDist(source, comp);
            int actualDistance2 = StringDistCalc.levenshteinDistStack(source, comp);
            int actualDistance3 = StringDistCalc.damerauLevensteinDistance(source, comp);
            int actualDistance4 = StringDistCalc.levenshteinDistMatrix(source, comp);

            Assert.AreEqual(expectedDistance, actualDistance1, "levenshteinDist method is failed");
            Assert.AreEqual(expectedDistance, actualDistance2, "levenshteinDistStack method is failed");
            Assert.AreEqual(expectedDistance, actualDistance3, "damerauLevensteinDistance method is failed");
            Assert.AreEqual(expectedDistance, actualDistance4, "levenshteinDistMatrix method is failed");
        }

        [TestMethod]
        public void WrongCharactersOrder()
        {
            string source = "abcdef";
            string comp = "abedcf";
            int expectedDistance = 2;

            int actualDistance1 = StringDistCalc.levenshteinDist(source, comp);
            int actualDistance2 = StringDistCalc.levenshteinDistStack(source, comp);
            int actualDistance3 = StringDistCalc.damerauLevensteinDistance(source, comp);
            int actualDistance4 = StringDistCalc.levenshteinDistMatrix(source, comp);

            Assert.AreEqual(expectedDistance, actualDistance1, "levenshteinDist method is failed");
            Assert.AreEqual(expectedDistance, actualDistance2, "levenshteinDistStack method is failed");
            Assert.AreEqual(expectedDistance, actualDistance3, "damerauLevensteinDistance method is failed");
            Assert.AreEqual(expectedDistance, actualDistance4, "levenshteinDistMatrix method is failed");
        }

        [TestMethod]
        public void WrongCharactersOrder_between_AdjacentCharacters()
        {
            string source = "abcdef";
            string comp = "abdcef";
            int expectedDistanceLevenshtein = 2;
            int expectedDistanceDemerauLevenshtein = 1;

            int actualDistance1 = StringDistCalc.levenshteinDist(source, comp);
            int actualDistance2 = StringDistCalc.levenshteinDistStack(source, comp);
            int actualDistance3 = StringDistCalc.damerauLevensteinDistance(source, comp);
            int actualDistance4 = StringDistCalc.levenshteinDistMatrix(source, comp);

            Assert.AreEqual(expectedDistanceLevenshtein, actualDistance1, 
                "levenshteinDist method is failed");
            Assert.AreEqual(expectedDistanceLevenshtein, actualDistance2, 
                "levenshteinDistStack method is failed");
            Assert.AreEqual(expectedDistanceDemerauLevenshtein, actualDistance3, 
                "damerauLevensteinDistance method is failed");
            Assert.AreEqual(expectedDistanceLevenshtein, actualDistance4, 
                "levenshteinDistMatrix method is failed");
        }
    }
}
