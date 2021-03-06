using System;
using Ecommerce.Data.Enums;

namespace Ecommerce.Data.Entities
{
    public class Transaction
    {
        public int Id { set; get; }
        public DateTime TransactionDate { set; get; }
        public int ExternalTransactionId { set; get; }
        public decimal Amount { set; get; }
        public decimal Fee { set; get; }
        public string Result { set; get; }
        public string Message { set; get; }
        public TransactionStatus Status { set; get; }
        public int Provider { set; get; }
        public Guid UserId { get; set; }

        public virtual User Users { get; set; }
    }
}