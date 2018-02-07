﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;
using MvvmCross.Core.Views;

namespace MvvmCross.Platform.Mac.Views.Presenters.Attributes
{
    public class MvxTabPresentationAttribute : MvxBasePresentationAttribute
    {
        public string WindowIdentifier { get; set; }

        public string TabTitle { get; set; }
    }
}
