namespace FizzBuzz.Lib
{
    public class BuzzHandler : AbstractHandler
    {
        public override FizzBuzzEventArgs HandleEventArgs(FizzBuzzEventArgs args)
        {
            for (var i = 0; i < args.OriginalArray.Length; i++)
            {
                if (args.OriginalArray[i] % 5 == 0)
                {
                    if (args.ModifiedArray[i] != "Fizz")
                    {
                        args.ModifiedArray[i] = "Buzz";
                    }
                    else
                    {
                        args.ModifiedArray[i] = "FizzBuzz";
                    }
                }
                else
                {
                    if (args.ModifiedArray[i] != "Fizz")
                    {
                        args.ModifiedArray[i] = args.OriginalArray[i].ToString();
                    }
                }
            }

            return base.HandleEventArgs(args);
        }
    }
}