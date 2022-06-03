using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TransMqtt
    {
        public int IdTransMqtt { get; set; }
        /// <summary>
        /// event name
        /// </summary>
        public string EventName { get; set; }
        /// <summary>
        /// answer in json format
        /// </summary>
        public string JsonString { get; set; }
        /// <summary>
        /// work done
        /// </summary>
        public int? Done { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
