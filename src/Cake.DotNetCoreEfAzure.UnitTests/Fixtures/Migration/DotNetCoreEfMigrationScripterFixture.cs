﻿using Cake.DotNetCoreEfAzure.Migration;

namespace Cake.DotNetCoreEfAzure.Tests.Fixtures.Migration
{
    internal sealed class DotNetCoreEfMigrationScripterFixture : DotNetCoreEfFixture<DotNetCoreEfMigrationScriptSettings>
    {
        public string Project { get; set; }

        public string Arguments { get; set; }

        protected override void RunTool()
        {
            var tool = new DotNetCoreEfMigrationScripter(FileSystem, Environment, ProcessRunner, Tools);
            tool.Script(Project, Arguments, Settings);
        }
    }
}
