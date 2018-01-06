using System.Collections.Generic;

namespace SOKA.Core
{
    public  class MetricStore
    {
        private static Dictionary<string, string> _store=new Dictionary<string, string>();
        public string this[string index]
        {
            get { return _store.ContainsKey(index) ?_store[index]:null; }
            set { if (_store.ContainsKey(index)) _store.Add(index, value); else _store[index] = value; }
        }
    }
}
