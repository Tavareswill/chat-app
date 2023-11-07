using System;

namespace DemoApp.Chat.Persistence.Model
{
    public class MSGHIST
    {
        public string User { get; set; }
        public string Message { get; set; }
        public DateTime SendOn { get; set; }
    }
}
