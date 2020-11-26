using Microsoft.AspNetCore.Components;
using RealEstateWeb.Models;

namespace RealEstateWeb.BaseClasses
{
    public class PropertyBase : ComponentBase
    {
        public Property Listing { get; set; } = new Property();

    }
}
