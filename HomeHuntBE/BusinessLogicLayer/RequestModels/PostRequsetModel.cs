using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.RequestModels
{
    public class PostCreateRequestModel
    {
        //public string Field { get; set; } = null!;
        //public Guid RoomId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public List<string>? ImageUrl { get; set; } = null!;
        public string BuildingName { get; set; } = null!;
        public decimal Price { get; set; }= 0!;
        public string Address { get; set; }= null!;
        public string PropertyType { get; set; }= null!;
        public string ApartmentNumber { get; set; }= null!;
        public string Block { get; set; }= null!;
        public string Floor { get; set; }= null!;
        public string ApartmentType { get; set; }= null!;
        public string Bedrooms { get; set; }= null!;
        public string Bathrooms { get; set; }= null!;
        public string LegalDocument { get; set; }= null!;
        public string FurnitureCondition { get; set; }= null!;
        public string Area { get; set; }= null!;
        public decimal Deposit { get; set; }= 0!;
        public string PostTitle { get; set; }= null!;
        public Guid UserId { get; set; }= Guid.Empty!;
    }

    public class PostUpdateRequestModel
    {
        //public string Field { get; set; } = null!;
        //public Guid RoomId { get; set; }
        public string? Title { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public List<string>? ImageUrl { get; set; } = null!;
        public string? BuildingName { get; set; } = null!;
        public decimal? Price { get; set; } = 0!;
        public string? Address { get; set; } = null!;
        public string? PropertyType { get; set; } = null!;
        public string? ApartmentNumber { get; set; } = null!;
        public string? Block { get; set; } = null!;
        public string? Floor { get; set; } = null!;
        public string? ApartmentType { get; set; } = null!;
        public string? Bedrooms { get; set; } = null!;
        public string? Bathrooms { get; set; } = null!;
        public string? LegalDocument { get; set; } = null!;
        public string? FurnitureCondition { get; set; } = null!;
        public string? Area { get; set; } = null!;
        public decimal? Deposit { get; set; } = 0!;
        public string? PostTitle { get; set; } = null!;
        public bool? Status { get; set; } = null!;
    }
}
