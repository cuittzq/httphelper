using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TEST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string url = "http://localhost:21336/MsgHandle.aspx";
            string postContent1 = @"<xml>
<URL>
<![CDATA[http://msg.8qqt.com/MsgHandle.aspx]]>
</URL>
<ToUserName>
<![CDATA[mark.1]]>
</ToUserName>
<FromUserName>
<![CDATA[mark.1]]>
</FromUserName>
<CreateTime>11</CreateTime>
<MsgType><![CDATA[event]]>
</MsgType><Event><![CDATA[SCAN]]>
</Event><Latitude></Latitude>
<Longitude>
</Longitude>
<Precision>
</Precision><MsgId>1234</MsgId></xml>";

            string postContent2 = @"<xml>
<URL>
<![CDATA[http://msg.8qqt.com/MsgHandle.aspx]]>
</URL>
<ToUserName>
<![CDATA[mark.2]]>
</ToUserName>
<FromUserName>
<![CDATA[mark.2]]>
</FromUserName>
<CreateTime>11</CreateTime>
<MsgType><![CDATA[event]]>
</MsgType><Event><![CDATA[SCAN]]>
</Event><Latitude></Latitude>
<Longitude>
</Longitude>
<Precision>
</Precision><MsgId>12345</MsgId></xml>";

            string postContent3 = @"<xml>
<URL>
<![CDATA[http://msg.8qqt.com/MsgHandle.aspx]]>
</URL>
<ToUserName>
<![CDATA[mark.3]]>
</ToUserName>
<FromUserName>
<![CDATA[mark.3]]>
</FromUserName>
<CreateTime>11</CreateTime>
<MsgType><![CDATA[event]]>
</MsgType><Event><![CDATA[SCAN]]>
</Event><Latitude></Latitude>
<Longitude>
</Longitude>
<Precision>
</Precision><MsgId>123456</MsgId></xml>";


            string postContent4 = @"<xml>
<URL>
<![CDATA[http://msg.8qqt.com/MsgHandle.aspx]]>
</URL>
<ToUserName>
<![CDATA[mark.4]]>
</ToUserName>
<FromUserName>
<![CDATA[mark.4]]>
</FromUserName>
<CreateTime>11</CreateTime>
<MsgType><![CDATA[event]]>
</MsgType><Event><![CDATA[SCAN]]>
</Event><Latitude></Latitude>
<Longitude>
</Longitude>
<Precision>
</Precision><MsgId>1234567</MsgId></xml>";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(string.Format("响应{0}", HttpPost.HttpHelper.HttpPost(url, postContent1)));
                Console.WriteLine(string.Format("响应{0}", HttpPost.HttpHelper.HttpPost(url, postContent2)));
                Console.WriteLine(string.Format("响应{0}", HttpPost.HttpHelper.HttpPost(url, postContent3)));
                Console.WriteLine(string.Format("响应{0}", HttpPost.HttpHelper.HttpPost(url, postContent4)));
                Thread.Sleep(1000);
            }

            Console.ReadKey();
        }
    }
}
