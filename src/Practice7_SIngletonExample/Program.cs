﻿namespace Practice7_SIngletonExample
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);

            Parallel.ForEach(numbers, i =>
            {
                VoteMachine vm = VoteMachine.Instance;
                vm.RegisterVote();
            });

            Console.WriteLine(VoteMachine.Instance.TotalVotes);
        }
    }

        public class VoteMachine
        {
            private static VoteMachine _instance = null;
            private int _totalVotes = 0;

            private static readonly object lockObj = new object();

            private VoteMachine()
            {
            }

            public static VoteMachine Instance
            {
                get
                {
                    lock (lockObj)
                    {
                        if (_instance == null)
                        {
                            _instance = new VoteMachine();
                        }
                    }

                    return _instance;
                }
            }

            public void RegisterVote()
            {
                _totalVotes += 1;
                Console.WriteLine("Registered Vote #" + _totalVotes);
            }

            public int TotalVotes
            {
                get
                {
                    return _totalVotes;
                }
            }
        }
    }
