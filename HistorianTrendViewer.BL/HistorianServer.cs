using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HistorianTrendViewer.DL;


namespace HistorianTrendViewer.BL
{
   
    [Serializable()]
    public class HistorianServer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
        public string LoginID { get; set; }
        public string Password { get; set; }

        public bool RetainPassword { get; set; }

        private int queryTimeout;
        public int QueryTimeout 
        { 
            get 
            { 
               return queryTimeout; 
            } 
            set 
            { 
                queryTimeout = value;  
                if (value < 0) 
                    queryTimeout = 0; 
                if (value > 120) 
                    queryTimeout = 120; 
            } 
        }

        public int LoginTimeout { get; set; }

        public bool TrustedConnection { get; set; }

        public HistorianServer Clone() { return (HistorianServer)this.MemberwiseClone(); }

        public HistorianServer()
        {
            Id = Guid.NewGuid().ToString();
            Name = "NewServer";
            RetainPassword = true;
            TrustedConnection = false;
            queryTimeout = 60;
            LoginTimeout = 5;
            LoginID = "sa";
            Password = "";
        }

        public HistorianServer(string _name)
            :this()  { Name = _name; }
        
    }

    public enum ServerState
    {
        LoggedOn = 0,
        Error = 1,
        LoggedOff = 2,
        LoggingOn = 3
    }
}
