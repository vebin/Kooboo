﻿using Kooboo.Meta.Views.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kooboo.Meta.Views
{
    public class KbPopup : KbView
    {
        public override string Name => nameof(KbPopup);

        public bool Visible { get; set; } = false;

        public string Title { get; set; }

        public KbView Body { get; set; }

        public List<KbButton> Footer { get; private set; } = new List<KbButton>();
    }
}
