﻿// Copyright 2013-2020 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

using ImageMagick;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magick.NET.Tests
{
    public partial class MagickSettingsTests
    {
        [TestClass]
        public class TheDepthProperty
        {
            [TestMethod]
            public void ShouldChangeTheDepthOfTheOutputImage()
            {
                using (IMagickImage input = new MagickImage(Files.Builtin.Logo))
                {
                    input.Settings.Depth = 5;

                    var bytes = input.ToByteArray(MagickFormat.Tga);

                    using (IMagickImage output = new MagickImage(bytes, MagickFormat.Tga))
                    {
                        Assert.AreEqual(5, output.Depth);
                    }
                }
            }
        }
    }
}
