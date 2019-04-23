using System;

namespace MP.AspNetCore.GraphQL.Models
{
    public class Bribe
    {
        public int Id { get; set; } = 0;
        public int StudentId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public float Value { get; set; }
        public DateTime? PaymentDate { get; set; }
    }
}