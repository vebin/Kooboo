﻿using Kooboo.Meta.Views.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kooboo.Meta.Views
{
    public class KbTable : KbView
    {

        public class Column : KbContainer
        {
            public override string Name => nameof(Column);

            public string Text { get; set; }

        }

        public bool ShowCheck { get; set; }

        public override string Name => nameof(KbTable);

        public List<Column> Columns { get; private set; } = new List<Column>();
    }
}
