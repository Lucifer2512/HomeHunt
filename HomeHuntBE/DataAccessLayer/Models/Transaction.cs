using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Transaction : BaseEntity
    {
        public int TransactionCode {  get; set; }
        public Guid UserId { get; set; }
        public Guid? PostId { get; set; }
        public decimal Price {  get; set; }

        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
