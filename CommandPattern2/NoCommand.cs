namespace CommandPattern2
{
    internal class NoCommand : Command
    {
        public void execute()
        {
            throw new System.NotImplementedException();
        }
    }
}