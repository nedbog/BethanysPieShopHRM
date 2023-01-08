using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Blazor.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
