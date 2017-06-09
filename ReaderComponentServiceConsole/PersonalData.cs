using System.Runtime.Serialization;

namespace ReaderComponentService
{

	[DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ReaderComponentService")]
	public sealed class PersonalData
	{
		[DataMember]
		public string FirstName { get; set; }
		[DataMember]
		public string LastName { get; set; }
		[DataMember]
		public string Country { get; set; }
		[DataMember]
		public int Age { get; set; }
	}

}