﻿using System.Reflection;

namespace Lab.DynamicAccessor.Accessor2
{
    public class DynamicMemberManager
    {
        private static AccessorFactoryBase<PropertyInfo, IPropertyAccessor> s_property;
        private static AccessorFactoryBase<MethodInfo, IMethodAccessor>     s_method;
        private static AccessorFactoryBase<FieldInfo, IFieldAccessor>       s_field;

        public static AccessorFactoryBase<PropertyInfo, IPropertyAccessor> Property
        {
            get
            {
                if (s_property == null)
                {
                    s_property = new PropertyAccessorFactory();
                }

                return s_property;
            }
            set => s_property = value;
        }

        public static AccessorFactoryBase<MethodInfo, IMethodAccessor> Method
        {
            get
            {
                if (s_method == null)
                {
                    s_method = new MethodAccessorFactory();
                }

                return s_method;
            }
            set => s_method = value;
        }

        public static AccessorFactoryBase<FieldInfo, IFieldAccessor> Field
        {
            get
            {
                if (s_field == null)
                {
                    s_field = new FieldAccessorFactory();
                }

                return s_field;
            }
            set => s_field = value;
        }
    }
}