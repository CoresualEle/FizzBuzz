namespace FizzBuzz.Lib
{
    public class FizzBuzzEventArgs
    {
        public FizzBuzzEventArgs(int[] originalArray)
        {
            OriginalArray = originalArray;
            ModifiedArray = new string[OriginalArray.Length];
        }

        public int[] OriginalArray { get; set; }

        public string[] ModifiedArray { get; set; }
    }
}