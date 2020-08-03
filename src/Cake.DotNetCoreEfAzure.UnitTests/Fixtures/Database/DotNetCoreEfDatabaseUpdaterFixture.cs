﻿using Cake.DotNetCoreEfAzure.Database;

namespace Cake.DotNetCoreEfAzure.Tests.Fixtures.Database
{
    internal sealed class DotNetCoreEfDatabaseUpdaterFixture : DotNetCoreEfFixture<DotNetCoreEfDatabaseUpdateSettings>
    {
        public string Project { get; set; }

        public string Arguments { get; set; }

        protected override void RunTool()
        {
            var tool = new DotNetCoreEfDatabaseUpdater(FileSystem, Environment, ProcessRunner, Tools);
            tool.Update(Project, Arguments, Settings);
        }
    }
}
