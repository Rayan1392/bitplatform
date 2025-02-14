﻿namespace Bit.BlazorUI.Demo.Client.Core.Components;

public partial class ComponentDemo
{
    [Parameter] public string ComponentName { get; set; } = default!;
    [Parameter] public string? ComponentDescription { get; set; }
    [Parameter] public string? Notes { get; set; }
    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter] public List<ComponentParameter> ComponentParameters { get; set; } = new();
    [Parameter] public List<ComponentSubClass> ComponentSubClasses { get; set; } = new();
    [Parameter] public List<ComponentSubEnum> ComponentSubEnums { get; set; } = new();
    [Parameter] public List<ComponentParameter> ComponentPublicMembers { get; set; } = new();
    


    private readonly List<ComponentParameter> _componentBaseParameters = new()
    {
        new()
        {
            Name = "Class",
            Type = "string?",
            DefaultValue = "null",
            Description = "Custom CSS class for the root element of the component.",
        },
        new()
        {
            Name = "IsEnabled",
            Type = "bool",
            DefaultValue = "true",
            Description = "Whether or not the component is enabled.",
        },
        new()
        {
            Name = "Style",
            Type = "string?",
            DefaultValue = "null",
            Description = "Custom CSS style for the root element of the component.",
        },
        new()
        {
            Name = "Visibility",
            Type = "BitVisibility",
            DefaultValue = "BitVisibility.Visible",
            Description = "Whether the component is visible, hidden or collapsed.",
            LinkType = LinkType.Link,
            Href = "#component-visibility",
        },
    };

    private readonly List<ComponentParameter> _componentBasePublicMembers = new()
    {
        new()
        {
            Name = "UniqueId",
            Type = "Guid",
            DefaultValue = "Guid.NewGuid()",
            Description = "The readonly unique id of the root element. it will be assigned to a new Guid at component instance construction.",
        },
        new()
        {
            Name = "RootElement",
            Type = "ElementReference",
            Description = "The ElementReference of the root element.",
        },
    };

    private readonly List<ComponentSubEnum> _componentBaseSubEnums = new()
    {
        new()
        {
            Id = "component-visibility",
            Name = "BitVisibility",
            Description = "",
            Items = new List<ComponentEnumItem>()
            {
                new()
                {
                    Name= "Visible",
                    Value="0",
                    Description="The content of the component is visible.",
                },
                new()
                {
                    Name= "Hidden",
                    Value="1",
                    Description="The content of the component is hidden, but the space it takes on the page remains (visibility:hidden).",
                },
                new()
                {
                    Name= "Collapsed",
                    Value="2",
                    Description="The component is hidden (display:none).",
                }
            }
        }
    };



    private readonly List<string> _inputComponents = new() { 
        "Calendar", "Checkbox", "ChoiceGroup", "DatePicker", "DateRangePicker", "Dropdown", "NumericTextField", "OtpInput", "Rating",
        "SearchBox", "SpinButton", "TextField", "TimePicker", "Toggle"
    };
    private readonly List<ComponentParameter> _inputBaseParameters = new()
    {
        new()
        {
            Name = "DisplayName",
            Type = "string?",
            DefaultValue = "null",
            Description = "Gets or sets the display name for this field.",
        },
        new()
        {
            Name = "InputHtmlAttributes",
            Type = "IReadOnlyDictionary<string, object>?",
            DefaultValue = "null",
            Description = "Gets or sets a collection of additional attributes that will be applied to the created element.",
        },
        new()
        {
            Name = "Value",
            Type = "TValue?",
            DefaultValue = "null",
            Description = "Gets or sets the value of the input. This should be used with two-way binding.",
        },
    };

}
