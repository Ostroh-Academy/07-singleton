using System.Xml.Linq;

namespace Practice7_SIngletonPersonalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommandManager commandManager = CommandManager.Instance;

            Command command1 = new ConcreteCommand("Command1","Initial State");
            Command command2 = new ConcreteCommand("Command2","Initial State");
            Command command4 = new ConcreteCommand("Command4","Initial State");

            commandManager.RegisterCommand(command1.Name, command1);
            commandManager.RegisterCommand(command2.Name, command2);
            commandManager.RegisterCommand(command4.Name, command4);

            commandManager.ExecuteCommand("Command1");
            commandManager.ExecuteCommand("Command2");
            commandManager.ExecuteCommand("Command3");

            commandManager.RegisterCommand("Command2", command2);

            commandManager.PrintCommandStates();
        }
    }

    public class CommandManager
    {
        private static CommandManager _instance = null;
        private Dictionary<string, Command> commands;

        private static readonly object lockObj = new object();

        private CommandManager() 
        {
            commands = new Dictionary<string, Command>();
        }

        public static CommandManager Instance
        {
            get
            {
                lock (lockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new CommandManager();
                    }
                }
                return _instance;
            }
        }

        public void RegisterCommand(string name, Command command)
        {
            if(!commands.ContainsKey(name))
            {
                commands.Add(name, command);
            }
            else
            {
                Console.WriteLine($"Command '{name}' is already registered.");
            }
        }

        public void ExecuteCommand(string name)
        {
            if (commands.ContainsKey(name))
            {
                commands[name].Execute();
            }
            else
            {
                Console.WriteLine($"Command '{name}' does not exist.");
            }
        }

        public void PrintCommandStates()
        {
            Console.WriteLine("\nStates of all registered commands:");
            foreach (var kvp in commands)
            {
                Console.WriteLine($"Command '{kvp.Key}' state: {kvp.Value.State}");
            }
        }

    }
    public abstract class Command
    {
        protected string name;
        public Command(string name)
        {
            this.name = name;
        }
        public abstract void Execute();
        
        public abstract string State { get; }
        public string Name => name;

    }
    public class ConcreteCommand : Command
    {
        private string state;
        public ConcreteCommand(string name, string initialState): base(name)
        {
            state = initialState;
        }

        public override void Execute()
        {
            state = "Executed";
            Console.WriteLine($"Command '{Name}' executed successfully.");
        }

        public override string State
        {
            get { return state; }
        }
    }
}
