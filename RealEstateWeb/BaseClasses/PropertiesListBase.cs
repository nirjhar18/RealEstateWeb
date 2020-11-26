using Microsoft.AspNetCore.Components;
using RealEstateWeb.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateWeb.BaseClasses
{
    public class PropertiesListBase : ComponentBase
    {
        public IEnumerable<Property> Properties { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadProperties();
            return base.OnInitializedAsync();
        }

        private void LoadProperties()
        {
            Property p1 = new Property
            {
                PropertyId = 1,
                Address = "Address of the Property",
                ImageUrl = "images/OurHome.jpg",
                PropertyUrl = "https://www.redfin.ca/on/burlington/1106-Augustus-Dr-L7S-2L2/home/153425352"
            };

            Property p2 = new Property
            {
                PropertyId = 2,
                Address = "Burlington",
                ImageUrl = "images/OurHome.jpg",
                PropertyUrl = "https://www.redfin.ca/on/burlington/1106-Augustus-Dr-L7S-2L2/home/153425352"
            };
            Properties = new List<Property> { p1, p2 };
        }
    }
}
