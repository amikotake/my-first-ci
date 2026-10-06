using System;
using System.Net.Http;

DateTime now = DateTime.Now;
Console.WriteLine($"現在の時間: {now:yyyy-MM-dd HH:mm:ss}");

DateTime future = now.AddDays(30);
Console.WriteLine($"30日後の日付: {future:yyyy-MM-dd}");

using HttpClient client = new HttpClient();
client.DefaultRequestHeaders.Add("User-Agent", "CSharpApp");
string result = await client.GetStringAsync("https://api.github.com/zen");
Console.WriteLine($"\n[GitHubからの取得データ]\n{result}");