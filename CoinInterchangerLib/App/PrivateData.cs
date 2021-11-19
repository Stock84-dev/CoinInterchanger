using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoinInterchangerLib.App
{
	[Serializable]
	public class PrivateData
	{
		public static readonly FileInfo FILE = new FileInfo("Data/UserData.bin");
		public static PrivateData Data { get; set; } = new PrivateData();
		public static TaskCompletionSource<bool> LoadTask { get; private set; } = new TaskCompletionSource<bool>();

		public Dictionary<string, ExchangeAPI> ExchangeAPIs { get; set; }

		// To encrypt data we use SHA256 hash of provided password as hash
		// or we generate key if there is no password.
		/// <param name="password">If password is null function will generate one.</param>
		public static async Task SaveEncrypted(string password)
		{
			await Task.Run(async () =>
			{
				AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
				await State.LoadTask.Task;
				if (password == null)
				{
					if (State.Data.Key != null)
						aes.Key = State.Data.Key;
					else // generating and saving encryption keys because password is not provided
					{
						aes.GenerateKey();
						State.Data.Key = aes.Key;
					}
				}
				else
					aes.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
				// IV = initialization vector, every time we encrypt data we regenerate it
				// so every time we encrypt, output will be different
				aes.GenerateIV();
				State.Data.IV = aes.IV;
				using (Stream innerStream = File.Create(FILE.FullName))
				using (Stream cryptoStream = new CryptoStream(innerStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
				{
					BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(cryptoStream, Data);
				}
			});
		}

		/// <param name="password">If password is null function will use previously saved one.</param>
		public static async Task LoadEncrypted(string password)
		{
			await Task.Run(async () =>
			{
				if (!File.Exists(FILE.FullName))
					return;
				AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
				await State.LoadTask.Task;
				if (password == null)
				{
					aes.Key = State.Data.Key;
					aes.IV = State.Data.IV;
				}
				else
				{
					aes.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
					aes.IV = State.Data.IV;
				}
				using (Stream innerStream = File.Open(FILE.FullName, FileMode.Open))
				using (Stream cryptoStream = new CryptoStream(innerStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
				{
					BinaryFormatter bf = new BinaryFormatter();
					Data = (PrivateData)bf.Deserialize(cryptoStream);
				}
				LoadTask.SetResult(true);
			});
		}

		[Serializable]
		public class ExchangeAPI
		{
			public ExchangeAPI(string key, string secret)
			{
				Key = key;
				Secret = secret;
			}

			public string Key { get; set; }
			public string Secret { get; set; }
		}
	}
}
