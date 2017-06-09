using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderComponentService
{
	interface IComponentHandler
	{
		IEnumerable<PersonalData> ReadData();
	}
}
