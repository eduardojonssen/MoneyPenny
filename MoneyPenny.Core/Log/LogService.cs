using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace MoneyPenny.Core.Log
{
	public static class LogService
	{
		public static void Save(string type, object data, [CallerMemberName] string methodName = null)
		{
			string logContent = Serializer.JavaScriptSerialize(data);

			string log = string.Format("{0} | {1} | {2} | {3}\r\n", DateTime.Now, type, methodName, logContent);
			//byte[] logByte = log.GetBytes();

			//string path = "c:/Log/MoneyPenny.log";

			//string directory = Path.GetDirectoryName(path);

			//if (Directory.Exists(directory) == false)
			//{
			//	Directory.CreateDirectory(directory);
			//}

			//using (FileStream stream = new FileStream(path, FileMode.Append))
			//{
			//	stream.Write(logByte, 0, logByte.Length);
			//}

			using (EventLog eventLog = new EventLog())
			{
				eventLog.Source = "MoneyPenny";
				eventLog.WriteEntry(log, EventLogEntryType.Information);
			}
		}
	}
}
