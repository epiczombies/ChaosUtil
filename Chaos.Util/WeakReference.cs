﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chaos.Util
{
	public class WeakReference<T> : WeakReference
		where T : class
	{
		public WeakReference(T target)
			: base(target)
		{
		}

		public WeakReference(T target, bool trackResurrection)
			: base(target, trackResurrection)
		{
		}

		public new T Target { get { return (T)base.Target; } set { base.Target = value; } }
	}
}
