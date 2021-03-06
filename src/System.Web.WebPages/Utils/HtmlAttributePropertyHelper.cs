﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Concurrent;
using System.Collections.Generic;

namespace System.Web.WebPages
{
    internal class HtmlAttributePropertyHelper : PropertyHelper
    {
        private static ConcurrentDictionary<Type, PropertyHelper[]> _reflectionCache = new ConcurrentDictionary<Type, PropertyHelper[]>();

        public static new PropertyHelper[] GetProperties(object instance)
        {
            return AnonymousObjectReflectionHelper.GetProperties<HtmlAttributePropertyHelper>(instance, _reflectionCache);
        }

        public override string Name
        {
            get
            {
                return base.Name;
            }

            protected set
            {
                base.Name = value == null ? null : value.Replace('_', '-');
            }
        }
    }
}
