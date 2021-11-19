using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CryptoWatcher.Utilities
{
	class AssemblyPreloader
	{
		public static void PreloadAllAsync()
		{
			//Task.Run(() =>
			//{
				//Thread.CurrentThread.Priority = ThreadPriority.Lowest;
				foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
				{
					if (type.IsGenericType)
						continue;
					foreach (var method in type.GetMethods(BindingFlags.DeclaredOnly |
										BindingFlags.NonPublic |
										BindingFlags.Public | BindingFlags.Instance |
										BindingFlags.Static))
					{
						if (method.IsAbstract || method.IsGenericMethod)
							continue;
						System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(method.MethodHandle);

					}
				}
			//});
		}

		public static void PreloadSpecific()
		{
			foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
			{
				if (!type.IsGenericType && type.GetCustomAttributes(typeof(PreloadAttribute), true).Length > 0 )
				{
					foreach (var method in type.GetMethods(BindingFlags.DeclaredOnly |
										BindingFlags.NonPublic |
										BindingFlags.Public | BindingFlags.Instance |
										BindingFlags.Static))
					{
						if (method.IsAbstract || method.IsGenericMethod)
							continue;
						System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(method.MethodHandle);
					}
				}
			}
		}

		public static void PreloadSpecificWithTypes()
		{
			foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
			{
				var attributes = (PreloadAttribute[])type.GetCustomAttributes(typeof(PreloadAttribute));
				if (attributes.Count() > 0 && !type.IsGenericType)
				{
					foreach (var typeToPreload in attributes.First().TypesToPreload)
					{
						GC.KeepAlive(typeToPreload);
					}
				}
			}
		}
	}

	class PreloadAttribute : Attribute
	{
		public PreloadAttribute(Type[] typesToPreload)
		{
			TypesToPreload = typesToPreload;
		}

		public Type[] TypesToPreload { get; set; }
	}
}
