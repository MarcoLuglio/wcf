using ReaderComponentService.Proxies;
using System;
using System.Diagnostics;
using System.ServiceModel;

namespace ReaderComponentServiceConsole
{
	class Program
	{
		static void Main(string[] args)
		{

			// reserva a url e porta para uso

			/*string everyone = new System.Security.Principal.SecurityIdentifier(
			"S-1-1-0").Translate(typeof(System.Security.Principal.NTAccount)).ToString();

			string parameter = @"http add urlacl url=http://+:8733/ReaderComponentService/ user=\" + everyone;

			ProcessStartInfo psi = new ProcessStartInfo("netsh", parameter);

			psi.Verb = "runas";
			psi.RedirectStandardOutput = false;
			psi.CreateNoWindow = true;
			psi.WindowStyle = ProcessWindowStyle.Hidden;
			psi.UseShellExecute = true;
			Process.Start(psi);*/

			// inicia o serviço

			ServiceHost host = new ServiceHost(typeof(ComponentManager));
			host.Open();

			Console.WriteLine("Host Open Sucessfully ...");
			Console.Read();

		}
	}
}
