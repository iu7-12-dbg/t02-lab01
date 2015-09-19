using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    public class StringDistCalc
    {
        static public int damerauLevensteinDistance(string source, string comp)
        {
            int firstLength = source.Length;
            int secondLength = comp.Length;

            int[] currentRow = null;
            int[] previousRow = null;
            int[] transpositionRow = null;

            if (firstLength == 0)
                return secondLength;
            else if (secondLength == 0) return firstLength;

            if (firstLength > secondLength)
            {
                string tmp = source;
                source = comp;
                comp = tmp;
                firstLength = secondLength;
                secondLength = comp.Length;
            }

            int max = secondLength;

            currentRow = new int[firstLength + 1];
            previousRow = new int[firstLength + 1];
            transpositionRow = new int[firstLength + 1];

            for (int i = 0; i <= firstLength; i++)
                previousRow[i] = i;

            char lastSecondCh = '\0';
            for (int i = 1; i <= secondLength; i++)
            {
                char secondCh = comp[i - 1];
                currentRow[0] = i;

                // Вычисляем только диагональную полосу шириной 2 * (max + 1)
                int from = Math.Max(i - max - 1, 1);
                int to = Math.Min(i + max + 1, firstLength);

                char lastFirstCh = '\0';
                for (int j = from; j <= to; j++)
                {
                    char firstCh = source[j - 1];

                    // Вычисляем минимальную цену перехода в текущее состояние из предыдущих среди удаления, вставки и
                    // замены соответственно.
                    int cost = firstCh == secondCh ? 0 : 1;
                    int value = Math.Min(Math.Min(currentRow[j - 1] + 1, previousRow[j] + 1), previousRow[j - 1] + cost);

                    // Если вдруг была транспозиция, надо также учесть и её стоимость.
                    if (firstCh == lastSecondCh && secondCh == lastFirstCh)
                        value = Math.Min(value, transpositionRow[j - 2] + cost);

                    currentRow[j] = value;
                    lastFirstCh = firstCh;
                }
                lastSecondCh = secondCh;

                int[] tempRow = transpositionRow;
                transpositionRow = previousRow;
                previousRow = currentRow;
                currentRow = tempRow;
            }

            return previousRow[firstLength];
        }

        private struct DistLevel
        {
            public int i;
            public int j;
            public int level;

            public DistLevel(int ip, int jp, int lp)
            {
                i = ip;
                j = jp;
                level = lp;
            }
        }

        static public int levenshteinDistStack(string source, string comp)
        {
            int result = Int32.MaxValue;

            Stack<DistLevel> positions = new Stack<DistLevel>();
            positions.Push(new DistLevel(source.Length, comp.Length, 0));


            int maxCountOfStack = 0;
            while (positions.Count != 0)
            {
                DistLevel d = positions.Pop();
                int j = d.j;
                int i = d.i;

                if (j == 0 && i > 0)
                {
                    result = Math.Min(result, i + d.level);
                }
                else if (i == 0 && j > 0)
                {
                    result = Math.Min(result, j + d.level);
                }
                else if (i > 0 && j > 0)
                {
                    int nextLevel = d.level + 1;

                    if (nextLevel < result)
                    {
                        positions.Push(new DistLevel(i, j - 1, d.level + 1));
                        positions.Push(new DistLevel(i - 1, j, d.level + 1));
                    }

                    int compResult = source[i - 1] == comp[j - 1] ? 0 : 1;
                    nextLevel = d.level + compResult;
                    if (nextLevel < result)
                    {
                        positions.Push(new DistLevel(i - 1, j - 1, d.level + compResult));
                    }
                }
                else
                {
                    result = Math.Min(result, d.level);
                }
                maxCountOfStack = Math.Max(positions.Count(), maxCountOfStack);
            }

            return result;
        }

        static public int levenshteinDist(string source, string comp)
        {
            return recursiveLevenshteinPart(source, comp, source.Length, comp.Length);
        }


        static private int recursiveLevenshteinPart(string source, string comp, int i, int j)
        {

            int result = 0;

            if (j == 0 && i > 0)
            {
                result = i;
            }
            else if (i == 0 && j > 0)
            {
                result = j;
            }
            else if (i > 0 && j > 0)
            {
                result = Int32.MaxValue;
                result = Math.Min(result, recursiveLevenshteinPart(source, comp, i, j - 1) + 1);
                result = Math.Min(result, recursiveLevenshteinPart(source, comp, i - 1, j) + 1);

                int compResult = source[i - 1] == comp[j - 1] ? 0 : 1;
                result = Math.Min(result, recursiveLevenshteinPart(source, comp, i - 1, j - 1) + compResult);
            }

            return result;
        }

        static public int levenshteinDistMatrix(string source, string comp)
        {
            if (source == comp) return 0;
            if (source.Length == 0) return comp.Length;
            if (comp.Length == 0) return source.Length;

            int[] previousRow = new int[comp.Length + 1];
            int[] currentRow = new int[comp.Length + 1];

            for (int i = 0; i < previousRow.Length; i++)
                previousRow[i] = i;

            for (int i = 0; i < source.Length; i++)
            {
                currentRow[0] = i + 1;

                for (int j = 0; j < comp.Length; j++)
                {
                    var cost = (source[i] == comp[j]) ? 0 : 1;
                    currentRow[j + 1] = Math.Min(currentRow[j] + 1, previousRow[j + 1] + 1);
                    currentRow[j + 1] = Math.Min(currentRow[j + 1], previousRow[j] + cost);
                }

                for (int j = 0; j < previousRow.Length; j++)
                    previousRow[j] = currentRow[j];
            }

            return currentRow[comp.Length];
        }
    }
}
