
using SiteManagementApi.Entities.Entities.Site;

namespace SiteManagementApi.Entities.Entities.General
{
    public class SiteGeneralInfo
    {
        public SiteManagementApi.Entities.Entities.Site.Site? site { get; set; }
        public Address? address { get; set; }
    }
}
