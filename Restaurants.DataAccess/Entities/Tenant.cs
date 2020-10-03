using System;
using Restaurants.Commons.Enumerations;

namespace Restaurants.DataAccess.Entities
{
    public class Tenant
    {
        public Guid TenantId { get; set; }
        public string TenantName { get; set; }
        public TenantStatusEnum Status { get; set; }
        //public DateTime SubscriptionExpiryDate { get; set; }
    }
}
