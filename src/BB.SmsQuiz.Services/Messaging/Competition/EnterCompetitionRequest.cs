﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BB.SmsQuiz.Services.Messaging.Competition
{
    public class EnterCompetitionRequest : BaseRequest
    {
        public EntrantItem Entrant { get; set; }
    }
}