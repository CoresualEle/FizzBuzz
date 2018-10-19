namespace FizzBuzz.Lib
{
    public class FizzHandler : AbstractHandler
    {
        public override FizzBuzzEventArgs HandleEventArgs(FizzBuzzEventArgs args)
        {
            for (var i = 0; i < args.OriginalArray.Length; i++)
            {
                if (args.OriginalArray[i] % 3 == 0)
                {
                    if (args.ModifiedArray[i] != "Buzz")
                    {
                        args.ModifiedArray[i] = "Fizz";
                    }
                    else
                    {
                        args.ModifiedArray[i] = "FizzBuzz";
                    }
                }
                else
                {
                    if (args.ModifiedArray[i] != "Buzz")
                    {
                        args.ModifiedArray[i] = args.OriginalArray[i].ToString();
                    }
                }
            }

            return base.HandleEventArgs(args);
        }
    }
}