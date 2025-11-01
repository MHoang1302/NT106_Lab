using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Bai06
{
    public enum PacketType
    {
        Connect,
        Chat,
        Disconnect,
        UpdateParticipants
    }

    [Serializable]
    public class ChatPacket
    {
        public PacketType Type { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public List<string> Participants { get; set; }
    }
}
