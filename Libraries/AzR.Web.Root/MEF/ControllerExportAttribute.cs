﻿using System;
using System.ComponentModel.Composition;

namespace AzR.Web.Root.MEF
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ControllerExportAttribute : ExportAttribute
    {
        public ControllerExportAttribute(Type concreteType)
            : base(concreteType.FullName, typeof(IAzRController))
        {
        }
    }
}