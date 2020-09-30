﻿using System;

namespace Ziggeo
{
    public class LogModel
    {
        public readonly DateTime Timestamp;
        public readonly string Reason;
        public readonly string Details;

        public LogModel(string reason, string details)
        {
            Timestamp = DateTime.Now;
            Reason = reason;
            Details = details;
        }

        public override string ToString()
        {
            return FormattedOutput;
        }

        public string FormattedOutput => $"[{Timestamp:dd.MM.yyyy HH:mm:ss}] {Reason} {Details}";
    }
}