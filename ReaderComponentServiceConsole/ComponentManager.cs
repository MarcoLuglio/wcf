using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ReaderComponentService.Proxies
{

	public sealed class ComponentManager : IComponentManager
	{

		public IEnumerable<PersonalData> ReadData()
		{

			var readerComponentStringSetting = ConfigurationManager.AppSettings["readerComponent"];
			ReaderComponentType readerComponentType;

			if (!Enum.TryParse<ReaderComponentType>(readerComponentStringSetting, out readerComponentType))
			{
				throw new ArgumentException();
			}

			var componentHandler = ReaderComponentFactory.GetComponentManager(readerComponentType);

			return componentHandler.ReadData();
		}

	}

}
