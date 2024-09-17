using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    internal class Room : BaseEntity
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Description { get; set; }

        public Decimal Price { get; set; }

        public Guid UserId { get; set; }

        public Double Size { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public string Address { get; set; }

        public double Rating { get; set; }

    }
}
