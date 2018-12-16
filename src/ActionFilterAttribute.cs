﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeetleX.FastHttpApi
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class FilterAttribute : Attribute
    {
        public virtual bool Executing(ActionContext context)
        {
            return true;
        }

        public virtual void Executed(ActionContext context)
        {

        }
    }

    public class DefaultJsonResultFilter : FilterAttribute
    {
        public override void Executed(ActionContext context)
        {
            base.Executed(context);
            context.Result = new JsonResult(context.Result);
        }
    }
}
