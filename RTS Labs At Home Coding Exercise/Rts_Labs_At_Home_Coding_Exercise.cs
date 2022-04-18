namespace RTS_Labs_At_Home_Coding_Exercise
{
    public class Rts_Labs_At_Home_Coding_Exercise
    {
        public ComparisonObject aboveBelow(List<int> values, int comparison)
        {
            var comparisonOutcome = new ComparisonObject();

            foreach(var value in values)
            {
                ComparisonObject newOutcome = new ComparisonObject();

                if(value < comparison)
                {
                    comparisonOutcome.Below++;
                }
                else if(value > comparison)
                {
                    comparisonOutcome.Above++;
                }
                else
                {
                    comparisonOutcome.Equal++;
                }
            }

            return comparisonOutcome;
        }
        public string stringRotation(string originalString, int rotationAmount)
        {
            string rotatedString = originalString;
            int rotationAmountTotal = rotationAmount;
            bool negativeRotation = false;

            if (rotationAmountTotal < 0)
            {
                negativeRotation = true;
                rotationAmountTotal = rotationAmountTotal * -1;
            }

            while (rotationAmountTotal > originalString.Length)
            {
                rotationAmountTotal -= originalString.Length;
            }

            if (!negativeRotation)
            {
                rotationAmountTotal = originalString.Length - rotationAmountTotal;
            }

            if (rotationAmountTotal != 0)
            {
                string head = originalString.Substring(rotationAmountTotal, (originalString.Length - rotationAmountTotal));
                string tail = originalString.Substring(0, rotationAmountTotal);

                rotatedString = head + tail;
            }

            return rotatedString;
        }
    }
}