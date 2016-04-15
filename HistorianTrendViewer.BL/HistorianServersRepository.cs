using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace HistorianTrendViewer.BL
{
    public interface IHistorianServersRepository
    {
        ReadOnlyCollection<HistorianServer> List { get; }
        int Count { get; }

        void Add(HistorianServer _h);
        void RemoveById(string _id);
        void ReplaceById(string _id, HistorianServer _h);

        HistorianServer GetServerById(string _id);
        HistorianServer Clone(HistorianServer _h);
        HistorianServer Create();

        void LoadServers();
        void SaveServers();
    }
    
    public class HistorianServersRepository: IHistorianServersRepository
    {
        private List<HistorianServer> list;

        public ReadOnlyCollection<HistorianServer> List { get { return list.AsReadOnly(); } }

        public int Count { get { return (list == null)? 0: list.Count; } }
                
        public HistorianServersRepository()
        {
            list = new List<HistorianServer>();
        }

        public void Add(HistorianServer _h)
        {
            this.list.Add(_h);
        }

        public void RemoveById(string _id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == _id)
                {
                    list.RemoveAt(i);
                }
            }
        }

        public void ReplaceById(string _id, HistorianServer _h)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == _id)
                {
                    list.RemoveAt(i);
                    list.Insert(i, _h);
                }
            }
        }

        public HistorianServer GetServerById(string _id)
        {
            foreach (HistorianServer server in this.List)
            {
                if (server.Id == _id)
                    return server;
            }
            return null;
        }

        public HistorianServer Clone(HistorianServer _h)
        {
            return _h.Clone();
        }

        public HistorianServer Create()
        {
            return new HistorianServer();
        }

        public void LoadServers()
        {
            this.list = ((List<HistorianServer>)Serializer.Deserialize("Servers.xml", typeof(List<HistorianServer>)) == null)? new List<HistorianServer>(): (List<HistorianServer>)Serializer.Deserialize("Servers.xml", typeof(List<HistorianServer>));
        }

        public void SaveServers()
        {
            Serializer.Serialize(this.list, "Servers.xml");
        }
    }
}
