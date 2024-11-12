using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ResponseModels
{
    public class PostResponseModel
    {
        public Guid? Id { get; set; }
        public string? Phoneseller { get; set; }
        public string? PostTitle { get; set; }
        public string? Description { get; set; }
        public string? BuildingName { get; set; }
        public List<string>? Images { get; set; }
        public decimal? RentPrice { get; set; }
        public string? Address { get; set; }
        public string? PropertyType { get; set; }
        public string? ApartmentNumber { get; set; }
        public string? Block { get; set; }
        public string? Floor { get; set; }
        public string? ApartmentType { get; set; }
        public string? Bedrooms { get; set; }
        public string? Bathrooms { get; set; }
        public string? LegalDocument { get; set; }
        public string? FurnitureCondition { get; set; }
        public string? Area { get; set; }
        public decimal? Deposit { get; set; }
        public Guid? UserId { get; set; }
        public bool? Status { get; set; }

    }
}
