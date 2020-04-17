namespace DotnetCoreServer.Models
{
    public class UpgradeRequest
    {
        public long UserID;
        public string UpgradeType;
    }

    public class GainPoint
    {
        public long UserID;
        
        public int AddPoint;
    }

    public class GainPointResult
    {
        public int ResultCode;

        public int AddPoint; 

        public string Message;
    }
}