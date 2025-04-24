IsHappy(19);

bool IsHappy(int n)
{
    List<double> numbers = new List<double>();
    double sum = 0;
    var numberAr = n.ToString().ToCharArray();
    for (int i = 0; i < numberAr.Length + 1; i++)
    {
        if (i < numberAr.Length)
        {
            sum += Math.Pow(char.GetNumericValue(numberAr[i]), 2);
        }

        if (i == numberAr.Length)
        {
            if (sum == 1)
            {
                return true;
            }

            if (numbers.Contains(sum))
            {
                return false;
            }

            numbers.Add(sum);
            numberAr = sum.ToString().ToCharArray();
            i = -1;
            sum = 0;
        }
    }
    return false;
}

;