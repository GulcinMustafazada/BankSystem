﻿using Core.CrossCuttingConcerns.Caching;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Postsharp.Caching
{
    [Serializable]
  public  class CacheRemoveAspect:OnMethodBoundaryAspect
    {
      
        private Type _cacheType;
        private string _pattern;
        private ICacheManager _cacheManager;
        public CacheRemoveAspect(Type cacheType,string pattern)
        {
            _cacheType = cacheType;
            _pattern = pattern;
        }

        public CacheRemoveAspect(Type cacheType)
        {
            _cacheType = cacheType;
        }
        public override void RuntimeInitialize(MethodBase method)
        {
            if (!typeof(ICacheManager).IsAssignableFrom(_cacheType))
            {
                throw new Exception("Wrong cache type");
            }
            _cacheManager = (ICacheManager)Activator.CreateInstance(_cacheType);
            base.RuntimeInitialize(method);
        }
        public override void OnSuccess(MethodExecutionArgs args)
        {
            _cacheManager.RemoveByPattern(string.IsNullOrEmpty(_pattern) ? string.Format("{0}.{1}.*",
                 args.Method.ReflectedType.Namespace, args.Method.ReflectedType.Name) : _pattern);
        }
    }
}
