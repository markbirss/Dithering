﻿using Cyotek.Drawing;

namespace Cyotek.DitheringTest.Transforms
{
  internal sealed class SimpleIndexedPalettePixelTransform8 : SimpleIndexedPalettePixelTransform
  {
    #region Constructors

    public SimpleIndexedPalettePixelTransform8()
      : base(new[]
             {
               ArgbColor.FromArgb(0, 0, 0),
               ArgbColor.FromArgb(255, 0, 0),
               ArgbColor.FromArgb(0, 255, 0),
               ArgbColor.FromArgb(0, 0, 255),
               ArgbColor.FromArgb(255, 255, 0),
               ArgbColor.FromArgb(255, 0, 255),
               ArgbColor.FromArgb(0, 255, 255),
               ArgbColor.FromArgb(255, 255, 255)
             })
    { }

    #endregion
  }
}
