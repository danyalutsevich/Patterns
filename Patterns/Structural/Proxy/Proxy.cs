using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Proxy
{
    class ProxyDemo
    {

        public static void Show()
        {
            IRequester requester = new DbRequester();

            Console.WriteLine(requester.Request("GET ALL DATA"));
            Console.WriteLine(requester.Request("DELETE ALL DATA"));

            Console.WriteLine("with proxy");

            IRequester proxy = new ProxyRequester();
            Console.WriteLine(proxy.Request("GET ALL DATA"));
            Console.WriteLine(proxy.Request("DELETE ALL DATA"));


        }

    }

    interface IRequester
    {
        string Request(string cmd);
    }

    class DbRequester : IRequester
    {
        public string Request(string cmd)
        {
            return "request result for command " + cmd;
        }
    }

    class ProxyRequester : IRequester
    {

        private IRequester _requester;


        public ProxyRequester(IRequester requester = null)
        {
            if (requester != null)
            {
                _requester = requester;
            }
            else
            {
                _requester = new DbRequester();
            }

        }

        public string Request(string cmd)
        {

            if (cmd.Contains("GET"))
            {
                return _requester.Request(cmd);
            }
            else
            {
                return "command blocked";
            }

        }

    }



}
