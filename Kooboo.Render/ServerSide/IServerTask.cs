//Copyright (c) 2018 Yardi Technology Limited. Http://www.kooboo.com
//All rights reserved.
using Kooboo.Data.Context;
using Kooboo.Render.ObjectSource;
using System.Collections.Generic;

namespace Kooboo.Render.ServerSide
{
    public interface IServerTask
    {
        string name { get; }
        List<string> paras { get; set; }

        string Render(CommandDiskSourceProvider sourceProvider, RenderOption option, RenderContext context, string baseRelativeUrl);
    }
}