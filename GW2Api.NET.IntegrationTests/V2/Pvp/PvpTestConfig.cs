using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GW2Api.NET.IntegrationTests.V2.Pvp
{
    public class PvpTestConfig
    {
        public IEnumerable<Guid> Ids { get; set; }
        public Guid Id
        {
            get
            {
                var id = Ids.FirstOrDefault();
                if (id == default)
                    Assert.Fail("You must configure at least one pvp game id id in v2.config.json to run this test");
                return id;
            }
        }
    }
}
