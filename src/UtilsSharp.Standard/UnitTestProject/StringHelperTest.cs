﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilsSharp;

namespace UnitTestProjectNetCore
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void GetCharLengthTest()
        {
            var txt = "追忆那些年的绝代名士 精装民国男士人物传记徐志摩梁启超胡适书H";

            var aa = StringHelper.GetCharLength(txt);
           
        }
    }
}
