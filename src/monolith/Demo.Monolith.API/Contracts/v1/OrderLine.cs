﻿
namespace Demo.Monolith.API.Contracts.v1
{
    public class OrderLine
    {
        public int Amount { get; set; }
        public Product Product { get; set; }
    }
}