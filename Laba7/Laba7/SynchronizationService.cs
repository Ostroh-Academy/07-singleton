using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    public class SynchronizationService : ISynchronizationService
    {
        private static readonly object _lock = new object();
        private static SynchronizationService _instance;
        private readonly List<string> _actions;

        private SynchronizationService()
        {
            _actions = new List<string>();
        }

        public static SynchronizationService Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SynchronizationService();
                    }
                }
                return _instance;
            }
        }

        public void PerformAction(string user, string action)
        {
            lock (_lock)
            {
                _actions.Add($"{user} performed {action}");
                Console.WriteLine($"{user} performed {action}");
            }
        }

        public IEnumerable<string> GetActions()
        {
            lock (_lock)
            {
                return _actions.ToArray();
            }
        }
    }
}
