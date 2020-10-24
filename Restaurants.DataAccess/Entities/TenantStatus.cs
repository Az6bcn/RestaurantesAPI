using System;
using Restaurants.Commons.Enumerations;

namespace Restaurants.DataAccess.Entities
{
    // https://kudchikarsk.com/entity-framework-enum-code-first/
    public class TenantStatus
    {
        public TenantStatusEnum Id { get; set; }
        public string Name { get; set; }
    }
}
