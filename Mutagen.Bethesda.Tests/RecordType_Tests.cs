﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mutagen.Bethesda.Tests
{
    public class RecordType_Tests
    {
        [Fact]
        public void StringToInt()
        {
            var type = new RecordType("NPC_");
            Assert.Equal("NPC_", type.Type);
            Assert.Equal(0x5F43504E, type.TypeInt);
        }

        [Fact]
        public void IntToString()
        {
            var type = new RecordType(0x5F43504E);
            Assert.Equal("NPC_", type.Type);
            Assert.Equal(0x5F43504E, type.TypeInt);
        }
    }
}
