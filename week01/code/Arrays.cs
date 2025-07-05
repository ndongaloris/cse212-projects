public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Creating an array where I will storing my new data
        var arraysMultiples = new double [5];
        // storing the source number first before adding the extras
        arraysMultiples[0]= number;
        // looping  to be able to add the extra number into the array
        for (int i = 2; i < length + 1; i++)
        {
            //storing the multiplied number from the index 1 to 5
            arraysMultiples[i-1] = number * i;
        }

        // returning te array
        return arraysMultiples; // replace this return statement with your own

    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static List<int> RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // List<int> oldList = data;

        //The last data range was taken and put in a variable to be rotated
        var part = data.GetRange(data.Count() - amount, amount);
        // Loop into the original data list and 
        // storing the variable that needs to be moved at the beginning of the list
        for (int j = 0; j < part.Count(); j++)
        {
            // Inserting the data at the beginning of the index
            data.Insert(j, part[j]);
        }
        //Recounting the number of element into the data list to know how many overflowed
        int dataCount = data.Count();
        // Removing the extra data or the one that was moved at the beginning of the array
        data.RemoveRange(dataCount - amount, amount);
        
        return data;
    }
}
