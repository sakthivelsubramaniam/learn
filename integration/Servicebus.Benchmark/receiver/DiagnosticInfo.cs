using System;

namespace Learn.Integration.ServiceBus
{
    class DiagInfo
    {
        public int RunId {get;set;}
        public int ExecId {get;set;}
        public DateTime StartTime {get;set;}
        public DateTime EndTime {get;set;} 
        public System.TimeSpan TimeElapsed {get;set;}
        public string Message { get; set; }

        public bool ExeStatus {get;set;}

    }
    
}