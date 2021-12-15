﻿using System.Collections.Generic;
using CommunityToolkit.Maui.Sample.Models;
using CommunityToolkit.Maui.Sample.Pages.Views;
using CommunityToolkit.Maui.Views;

namespace CommunityToolkit.Maui.Sample.ViewModels.Views;

public class ViewsGalleryViewModel : BaseGalleryViewModel
{
    protected override IEnumerable<SectionModel> CreateItems() => new[]
    {
        new SectionModel(
            typeof(UniformGridPage),
            nameof(UniformGrid),
            "A Grid where all rows and columns have the same size"),

        new SectionModel(
            typeof(UniformGridTestPage),
            nameof(UniformGridTestPage),
            "A test page that adds new views to UniformGrid")
    };
}
