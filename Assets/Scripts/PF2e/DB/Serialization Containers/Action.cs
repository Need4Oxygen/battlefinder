using System.Collections.Generic;

namespace Pathfinder2e.Containers
{

    public sealed class Action
    {
        public string name { get; set; }
        public string descr { get; set; }
        public string type { get; set; }
        public string level { get; set; }
        public string actioncost { get; set; }
        public string frequency { get; set; }
        public string cost { get; set; }
        public string trigger { get; set; }
        public string prereqs { get; set; }
        public string requirement { get; set; }
        public List<string> traits { get; set; }
        public List<string> lectures { get; set; }
        public List<Source> source { get; set; }
    }

}