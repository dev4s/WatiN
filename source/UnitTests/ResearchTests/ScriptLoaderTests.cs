﻿#region WatiN Copyright (C) 2006-2011 Jeroen van Menen

//Copyright 2006-2011 Jeroen van Menen
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

#endregion Copyright

using System;
using NUnit.Framework;
using WatiN.Core.UnitTests.TestUtils;
using WatiN.Core.UtilityClasses;

namespace WatiN.Core.UnitTests.ResearchTests
{
    [TestFixture]
    public class ScriptLoaderTests : BaseWithBrowserTests
    {
        [Test]
        public void Should_return_sizzlejs_install_script()
        {
            // GIVEN
            var scriptLoader = new ScriptLoader();

            // WHEN
            var script = scriptLoader.GetSizzleInstallScript();

            // THEN
            Console.WriteLine(script);
            Assert.That(script, Is.Not.Null, "expected script");
            Assert.That(script, Does.Contain("Sizzle"), "expected Sizzle function");
        }

        [Test]
        public void Should_inject_script_sucessfully()
        {
            ExecuteTest(browser =>
                            {
                                // GIVEN
                                var scriptLoader = new ScriptLoader();

                                // THEN
                                browser.RunScript(scriptLoader.GetSizzleInstallScript());

                                // WHEN
                                var eval = browser.Eval("window.Sizzle('#popupid').length;");
                                Assert.That(eval, Is.EqualTo("1"));
                            });
        }

        public override Uri TestPageUri
        {
            get { return MainURI; }
        }
    }
}
