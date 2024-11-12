using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? Status { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.UtcNow.AddHours(7);
            UpdatedDate = DateTime.UtcNow.AddHours(7);
        }
    }
}
