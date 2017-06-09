using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ReaderComponentService
{

	sealed class PolarReaderHandler : IComponentHandler
	{

		public IEnumerable<PersonalData> ReadData()
		{

			Int32 port = 11002;
			TcpClient client = new TcpClient("localhost", port);

			byte[] data = System.Text.Encoding.ASCII.GetBytes("CM-READ");

			try
			{

				// Get a client stream for reading and writing.
				NetworkStream stream = client.GetStream();

				// Send the message to the connected TcpServer. 
				stream.Write(data, 0, data.Length);



				// The DATA as follow (can happen multiple times): 
				// LastName,FirstName(20 bytes)
				var fullName = new byte[20];

				// Country (3 bytes)
				var country = new byte[3];

				// Age (3 bytes)
				var age = new byte[3];

				// TODO parse data
				// "WILLIAMS,JOHN       USA021&DOE,JOHN            USA046&SMITH,MARY          CAN038&JOHNSON,TAYLOR      CAN015";
				// & is the separator for multiple data
				// if all the fields have fixed length, why is that we need a separator??

				/*
				// String to store the response ASCII representation.
				String responseData = String.Empty;

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
