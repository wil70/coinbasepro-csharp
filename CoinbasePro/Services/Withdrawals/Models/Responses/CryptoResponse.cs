﻿using System;

namespace CoinbasePro.Services.Withdrawals.Models.Responses
{
    public class CryptoResponse
    {
        public Guid Id { get; set; }

        public decimal Amount { get; set; }

        public string Currency { get; set; }
    }
}
