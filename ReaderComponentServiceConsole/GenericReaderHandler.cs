using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ReaderComponentService
{

	sealed class GenericReaderHandler : IComponentHandler
	{

		public IEnumerable<PersonalData> ReadData()
		{

			Int32 port = 11001;
			TcpClient client = new TcpClient("localhost", port);

			byte[] data = System.Text.Encoding.ASCII.GetBytes("READDATA");

			try
			{

				// Get a client stream for reading and writing.
				NetworkStream stream = client.GetStream();

				// Send the message to the connected TcpServer. 
				stream.Write(data, 0, data.Length);



				// First 4 characters indicates length of message in hex
				var messageLength = new byte[8];

				// Next 4 characters indicates component status
				var componentStatus = new byte[8];

				// Next 8 characters for date
				var messageDate = new byte[16];

				// Next characters are the DATA as follow: 
				// FirstName/LastName/Country/Age (can happen multiple times)
				// | is the separator for multiple data
				// Buffer to store the response bytes.
				data = new Byte[256];

				// String to store the response ASCII representation.
				String responseData = String.Empty;

				// TODO parse data
				// "0047021520160101JOHN/WILLIAMS/USA/21|JOHN/DOE/USA/46|MARY/SMITH/CAN/38|TAYLOR/JOHNSON/CAN/13"

				/*
				// Read the first batch of the TcpServer response bytes.
				Int32 bytes = stream.Read(data, 0, data.Length);
				responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
				Console.WriteLine("Received: {0}", responseData);
				*/



				stream.Close();

			}
			catch (Exception ex) when (ex is ObjectDisposedException || ex is InvalidOperationException || ex is System.IO.IOException)
			{
				// TODO
			}
			catch (ArgumentOutOfRangeException ex)
			{
				// TODO
			}
			catch (Exception ex)
			{
				// TODO
			}

			client.Close();

			return new List<PersonalData>();

		}

	}

}
