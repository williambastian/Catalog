using System;

namespace Catalog.Entities
{
    //Record Types - useful for immutable objects
    //Record Types can use with- expressions, have value-based equality support
    public record Item
    {
        public Guid Id { get; init; } // init is useful for when we only set values during initialization
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate {get; init; }
    }
}