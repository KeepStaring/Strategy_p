using System;

public static class RandomExtension
{
    public static int RandomNumber(this Random random, int lengthValues, int invalidNumber)
    {
        int result = random.Next(lengthValues - 1);

        if (result < invalidNumber)
            return result;

        return result + 1;
    }
}