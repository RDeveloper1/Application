using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactApp.WebAPI.Models
{
    public class Participant
    {
        public bool IsKey { get; set; }
        public string RoleType { get; set; }
        public bool IsOnScreen { get; set; }
        public string ParticipantType { get; set; }
        public string Name { get; set; }
        public Int32 SortOrder { get; set; }
        public Int32 ParticipantId { get; set; }
    }
}