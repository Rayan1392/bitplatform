﻿namespace Bit.Websites.Careers.Web.Shared;

public partial class Footer
{
    [Inject] IJSRuntime JsRuntime { get; set; }
    private async Task BackToTop()
    {
        await JsRuntime.InvokeVoidAsync("App.backToTop");
    }

    private string? SelectedCulture;

    private async Task OnCultureChanged()
    {
        var cultureCookie = $"c={SelectedCulture}|uic={SelectedCulture}";

        await JSRuntime.InvokeVoidAsync("window.App.setCookie", ".AspNetCore.Culture", cultureCookie, 30 * 24 * 3600);

        NavigationManager.ForceReload();
    }

    private static List<BitDropdownItem> GetCultures() =>
        CultureInfoManager.SupportedCultures.Select(sc => new BitDropdownItem { Value = sc.code, Text = sc.name }).ToList();
}
