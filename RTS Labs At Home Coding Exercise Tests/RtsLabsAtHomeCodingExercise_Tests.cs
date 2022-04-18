using System;
using System.Collections.Generic;
using System.Linq;

using Xunit;

using RTS_Labs_At_Home_Coding_Exercise;

namespace RTS_Labs_At_Home_Coding_Exercise_Tests
{
    public class RtsLabsAtHomeCodingExercise_Tests
    {
        Rts_Labs_At_Home_Coding_Exercise exercise = new Rts_Labs_At_Home_Coding_Exercise();

        [Theory]
        [InlineData(-1, 0, 0, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9)]
        [InlineData(10, 9, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9)]
        [InlineData(2, 0, 9, 0, 2, 2, 2, 2, 2, 2, 2, 2, 2)]
        [InlineData(5, 4, 0, 5, 9, 7, 1, 9, 2, 2, 8, 1, 9)]
        public void Comparison_Test(int comparison, int below, int equal, int above, params int[] inputValues)
        {
            var comparisonOutcome = exercise.aboveBelow(inputValues.ToList(), comparison);

            Assert.Equal(below, comparisonOutcome.Below);
            Assert.Equal(equal, comparisonOutcome.Equal);
            Assert.Equal(above, comparisonOutcome.Above);
        }
        [Theory]
        [InlineData("MyString", 2, "ngMyStri")]
        [InlineData("MyString", 0, "MyString")]
        [InlineData("MyString", -2, "StringMy")]
        public void StringWrap_Test(string originalString, int rotation, string expectedOutcome)
        {
            string actualOutcome = exercise.stringRotation(originalString, rotation);
            Assert.Equal(expectedOutcome, actualOutcome);
        }
    }
}