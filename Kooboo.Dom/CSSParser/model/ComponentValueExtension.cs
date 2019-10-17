//Copyright (c) 2018 Yardi Technology Limited. Http://www.kooboo.com
//All rights reserved.
using Kooboo.Dom.CSS.Tokens;
using System.Collections.Generic;

namespace Kooboo.Dom.CSS.rawmodel
{
    public static class ComponentValueExtension
    {
        public static string getString(List<ComponentValue> valuelist, ref int startindex, ref int endindex, ref string cssText)
        {
            string returnstring = string.Empty;

            foreach (var item in valuelist)
            {
                if (startindex <= 0)
                {
                    startindex = item.startindex;
                }

                if (item.endindex > endindex)
                {
                    endindex = item.endindex;
                }

                if (item.Type == CompoenentValueType.preservedToken)
                {
                    PreservedToken pretoken = item as PreservedToken;
                    returnstring += pretoken?.token.GetString(ref cssText);
                }
                else if (item.Type == CompoenentValueType.function)
                {
                    Function func = item as Function;
                    returnstring += func?.getString(ref cssText);
                }
                else if (item.Type == CompoenentValueType.simpleBlock)
                {
                    SimpleBlock simpleblock = item as SimpleBlock;
                    returnstring += simpleblock?.getString(ref cssText);
                }
            }

            return returnstring.Trim();
        }
    }
}