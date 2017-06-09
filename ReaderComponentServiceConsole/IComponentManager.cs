using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ReaderComponentService.Proxies
{

	[ServiceContract]
	public interface IComponentManager
	{

		[OperationContract]
		IEnumerable<PersonalData> ReadData();

	}

}
