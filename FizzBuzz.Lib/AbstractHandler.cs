namespace FizzBuzz.Lib
{
    public abstract class AbstractHandler
    {
        private AbstractHandler _nextHandler;

        public void AppendHandler(AbstractHandler newHandler)
        {
            if (_nextHandler == null)
                _nextHandler = newHandler;
            else
                _nextHandler.AppendHandler(newHandler);
        }

        public FizzBuzzEventArgs HandleEventArgs(int[] source)
        {
            return HandleEventArgs(new FizzBuzzEventArgs(source));
        }

        public virtual FizzBuzzEventArgs HandleEventArgs(FizzBuzzEventArgs args)
        {
            return _nextHandler != null ? _nextHandler.HandleEventArgs(args) : args;
        }
    }
}