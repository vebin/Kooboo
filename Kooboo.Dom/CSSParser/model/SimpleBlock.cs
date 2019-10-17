//Copyright (c) 2018 Yardi Technology Limited. Http://www.kooboo.com
//All rights reserved.
using Kooboo.Dom.CSS.Tokens;
using System.Collections.Generic;

namespace Kooboo.Dom.CSS.rawmodel
{
    /// <summary>
    /// A simple block has an associated token (either a [-token, (-token, or {-token) and a value consisting of a list of component values.
    /// </summary>
    public class SimpleBlock : ComponentValue
    {
        public SimpleBlock()
        {
            this.Type = CompoenentValueType.simpleBlock;
            this.startindex = -1;
            this.endindex = -1;
        }

        public cssToken token;

        public List<ComponentValue> value = new List<ComponentValue>();

        public string getString(ref string cssText)
        {
            string valuelist = string.Empty;

            foreach (var item in this.value)
            {
                if (item.Type == CompoenentValueType.preservedToken)
                {
                    PreservedToken pretoken = item as PreservedToken;
                    valuelist += pretoken?.token.GetString(ref cssText);
                }
                else if (item.Type == CompoenentValueType.function)
                {
                    Function func = item as Function;
                    valuelist += func?.getString(ref cssText);
                }
                else if (item.Type == CompoenentValueType.simpleBlock)
                {
                    SimpleBlock simpleblock = item as SimpleBlock;
                    valuelist += simpleblock?.getString(ref cssText);
                }
            }

            if (token != null)
            {
                if (token.Type == enumTokenType.curly_bracket_left || token.Type == enumTokenType.curly_bracket_right)
                {
                    valuelist = "{" + valuelist + "}";
                }
                else if (token.Type == enumTokenType.square_bracket_left || token.Type == enumTokenType.square_bracket_right)
                {
                    valuelist = "[" + valuelist + "]";
                }
                else if (token.Type == enumTokenType.round_bracket_left || token.Type == enumTokenType.round_bracket_right)
                {
                    valuelist = "(" + valuelist + ")";
                }
            }

            return valuelist;
        }
    }
}