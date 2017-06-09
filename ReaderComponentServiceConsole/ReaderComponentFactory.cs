using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderComponentService
{

	sealed class ReaderComponentFactory
	{

		public static IComponentHandler GetComponentManager(ReaderComponentType type)
		{

			switch (type)
			{

				case ReaderComponentType.GenericReader:
					return new GenericReaderHandler();

				case ReaderComponentType.PolarReader:
					return new PolarReaderHandler();

				default:
					throw new ArgumentException();

			}

		}
	}
}
