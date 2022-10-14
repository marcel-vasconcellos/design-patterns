using System;

namespace CommandPattern
{
    internal class Client
    {
        static void Main(string[] args)
        {
            // Command pattern encapsulates method's invocations, queueing and organizing them.
            // Pay attention to the invoker, client, command and receiver classes.
            Console.WriteLine("***Command Pattern Demo***");
            // Client will hold invoker and command objects
            Invoke invoker = new Invoke();
            Receiver receiver = new Receiver();

            MyUndoCommand undoCommand = new MyUndoCommand(receiver);
            invoker.SetCommand(undoCommand);
            invoker.ExecuteCommand();

            MyRedoCommand redoCommand = new MyRedoCommand(receiver);
            invoker.SetCommand(redoCommand);
            invoker.ExecuteCommand();
            Console.ReadKey();
        }
    }
}
