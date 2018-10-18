namespace FizzBuzz.Lib
{
    public class FizzHandler : AbstractHandler
    {
        public override FizzBuzzEventArgs HandleEventArgs(FizzBuzzEventArgs args)
        {
            var counter = 0;
            foreach (var i in args.OriginalArray)
            {
                
            }

            return base.HandleEventArgs(args);
        }
    }
}