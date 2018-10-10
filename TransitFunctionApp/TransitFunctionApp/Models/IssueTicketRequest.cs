﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TransitFunctionApp.Models
{
    class IssueTicketRequest : ITicketRequest
    {
        public string DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string MessageType { get; set; }
        public string TransactionId { get; set; }
        public DateTime CreateTime { get; set; }

        public string OriginLocation { get; set; }
        public string DestinationLocation { get; set; }
        public DateTime DepartureTime { get; set; }
        public long Price { get; set; }
    }
}
