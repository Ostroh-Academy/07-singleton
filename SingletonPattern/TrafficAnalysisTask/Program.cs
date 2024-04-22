namespace TrafficAnalysisTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficAnalysisSingleton traficCamera = TrafficAnalysisSingleton.GetInstance();
            TrafficAnalysisSingleton police = TrafficAnalysisSingleton.GetInstance();
            TrafficAnalysisSingleton witness = TrafficAnalysisSingleton.GetInstance();

            if(traficCamera == police)
            {
                Console.WriteLine("Singleton works");
            }
            else
            {
                Console.WriteLine("Singleton failed");
            }
            Dictionary<string, TrafficAnalysisSingleton> sources = new Dictionary<string, TrafficAnalysisSingleton>
            {
                { "Traffic Camera", traficCamera },
                { "Police", police },
                { "Witness", witness }
            };

            string[] events = { "Accident", "Traffic jam", "Road block", "Car breakdown",
                "Pedestrian crossing", "Traffic light failure", 
                "Road construction", "Animal crossing", 
                "Emergency vehicle passing", "Parade" };
            TrafficData[] trafficData = { TrafficData.Dangerous, TrafficData.Normal };

            Random random = new Random();

            while(true)
            {
                var randomSourceKey = sources.Keys.ElementAt(random.Next(sources.Count));
                TrafficAnalysisSingleton randomSource = sources[randomSourceKey];
                string randomEvent = events[random.Next(events.Length)];
                TrafficData randomTrafficData = trafficData[random.Next(trafficData.Length)];

                randomSource.AddData(new Event { EventName = randomEvent, TrafficData = randomTrafficData }, randomSourceKey);

                Thread.Sleep(random.Next(2000, 6000));
            }
        }
    }
    }
    public class Event
    {
        public string EventName { get; set; }
        public TrafficData TrafficData { get; set; }
    }
    public enum TrafficData
    {
        Dangerous,
        Normal,
    }
    public sealed class TrafficAnalysisSingleton
    {
        private static TrafficAnalysisSingleton _instance;
        private static List<Event> _trafficData;
        private TrafficAnalysisSingleton() { }
        public static TrafficAnalysisSingleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new TrafficAnalysisSingleton();
                _trafficData = new List<Event>();
            }
            return _instance;
        }
        public void AddData(Event data, string obj)
        {
            _trafficData.Add(data);
            if (data.TrafficData == TrafficData.Dangerous)
            {
                Console.WriteLine($"{obj}: Event {data.EventName} is dangerous. An ambulance is needed");
            }
            else
            {
                Console.WriteLine($"{obj}: Event {data.EventName} is normal");
            }

        }
        
        public void AnalyzeData()
        {
            foreach(var data in _trafficData)
            {
                if(data.TrafficData == TrafficData.Dangerous)
                {
                    Console.WriteLine($"Event {data.EventName} is dangerous. An ambulance is needed");
                }
                else
                {
                    Console.WriteLine($"Event {data.EventName} is normal");
                }
            }
        }

    }

