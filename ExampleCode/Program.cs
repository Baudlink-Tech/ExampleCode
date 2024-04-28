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

byte[]? bytes = IPAddressParser.Parse_IPv6("::1");
IPAddressParser? addr1 = IPAddressParser.Factory(bytes);
bytes[15] += 1;
IPAddressParser? addr2 = IPAddressParser.Factory(bytes);
List<IPAddressParser?> ipList = new List<IPAddressParser?>();
ipList.Add(addr1);
ipList.Add(addr2);
ipList.Sort();
s = DataDumper.Dump(ipList);
Console.WriteLine(s);
