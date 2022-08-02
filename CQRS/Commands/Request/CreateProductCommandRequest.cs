﻿namespace CQRS.CQRS.Commands.Request
{
    public class CreateProductCommandRequest
    {
        public string Name { get; set; }
        public int Quantity  { get; set; }
        public decimal Price { get; set; }
    }
}
