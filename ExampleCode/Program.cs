using Baudlink.Helper;
using Baudlink.Intervals;
using Baudlink.Intervals.Extensions;
using Baudlink.Parser;

DateTime dateTime = DateTime.Now;
DateTime dateTime2 = dateTime.AddHours(1);
List<TimeInterval> lsTimeIntervals = new List<TimeInterval>();
lsTimeIntervals.Add(new TimeInterval(dateTime, dateTime2));
lsTimeIntervals.Add(new TimeInterval(dateTime2, dateTime));
string s = DataDumper.Dump(lsTimeIntervals);
Console.WriteLine(s);
lsTimeIntervals.Sort();
s = DataDumper.Dump(lsTimeIntervals);
Console.WriteLine(s);

DateTime dt1 = DateTime.Parse("1777-04-30T00:00:00.000Z");
decimal ageInDay = DateTimeHelper.GetExactAgeInEarthDay(dt1);
Console.WriteLine($"\nage in day = {ageInDay} days\n");
decimal ageInYear = DateTimeHelper.GetExactAgeInEarthYear(dt1);
Console.WriteLine($"age in year = {ageInYear} years\n");

#region namespace Baudlink.Parser
byte[]? bytes = IPAddressParser.Parse_IPv6("a84d:35cf::7be0:9f1e");
IPAddressParser? addr1 = IPAddressParser.Factory(bytes);
bytes[15] += 1;
IPAddressParser? addr2 = IPAddressParser.Factory(bytes);
bytes = IPAddressParser.Parse_IPv4("127.0.0.1");
IPAddressParser? addr3 = IPAddressParser.Factory(bytes);
bytes = IPAddressParser.Parse_IPv4("192.168.0.1");
IPAddressParser? addr4 = IPAddressParser.Factory(bytes);
bytes = IPAddressParser.Parse_IPv6("::1");
IPAddressParser? addr5 = IPAddressParser.Factory(bytes);
bytes = IPAddressParser.Parse_IPv6("a84d:35cf:8041:ebac:40f6:902c:7be0:9f1e");
IPAddressParser? addr6 = IPAddressParser.Factory(bytes);
List<IPAddressParser?> ipList = new List<IPAddressParser?>();
ipList.Add(addr1);
ipList.Add(addr2);
ipList.Add(addr3);
ipList.Add(addr4);
ipList.Add(addr5);
ipList.Add(addr6);
ipList.Sort();
s = DataDumper.Dump(ipList);
Console.WriteLine(s);
#endregion namespace Baudlink.Parser
