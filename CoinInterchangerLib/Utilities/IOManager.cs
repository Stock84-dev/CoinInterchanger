using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoinInterchangerLib.Utilities
{
	public class IOManager
	{
		private string _filePath;

		public IOManager(string filePath)
		{
			_filePath = filePath;
		}

		public static async Task<bool> LoadByLineAsync(string filePath, Action<string> action)
		{
			if (!File.Exists(filePath))
				return false;

			StreamReader sr = new StreamReader(filePath);
			string line = string.Empty;
			while ((line = await sr.ReadLineAsync()) != null)
				action(line);

			sr.Close();
			return true;
		}

		public static async void SaveByLineAsync(string filePath, IEnumerable<string> lines)
		{
			StreamWriter sw = new StreamWriter(filePath);
			foreach (var line in lines)
				await sw.WriteLineAsync(line);
			sw.Close();
		}

		/// <summary>
		/// Performs action for each line that is in file.
		/// </summary>
		public async Task<bool> LoadByLineAsync(Action<string> action)
		{
			return await LoadByLineAsync(_filePath, action);
		}

		public void SaveByLineAsync(IEnumerable<string> lines)
		{
			SaveByLineAsync(_filePath, lines);
		}
	}

	public enum IOException { FileNotFound, Other }
}
