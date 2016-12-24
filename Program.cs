﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using StructureMap.Graph;

namespace PlayGround
{
    class Program
    {
        static IContainer container;

        static void Main(string[] args)
        {
            container = Container.For<LoggerRegistry>();

            var t = new test();

            t.t(container);
        }
    }

    public class test
    {
        public void t(IContainer container)
        {
            ILogger log = container.GetInstance<ILogger>();

            log.SetSource(this.GetType().ToString());

            log.Error("Read this message...!", new Exception("An exception occured"));
            log.Info("Everything is fine");
            log.Warn("This is a warning!", new Exception("This is a test exception"));

            Console.ReadLine();
        }
    }

    public class LoggerRegistry : Registry
    {
        public LoggerRegistry()
        {
            For<ILogger>().Use<Log4NetLogger>();
        }
    }
}
