using System;
using Restaurants.Commons.Enumerations;

namespace Restaurants.DataAccess.Entities
{
    public class Tenant
    {
        public Guid TenantId { get; set; }
        public string TenantName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? Deleted { get; set; }

        // navigation property
        public TenantStatus TenantStatus { get; set; }
        public TenantStatusEnum StatusId { get; set; } // FK

        //public DateTime SubscriptionExpiryDate { get; set; }
    }
}
