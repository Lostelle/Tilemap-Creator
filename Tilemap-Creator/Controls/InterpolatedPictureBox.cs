﻿using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TMC.Controls
{
    /// <summary>
    /// Represents a Windows picture box control for displaying an image with interpolation.
    /// </summary>
    public class InterpolatedPictureBox : PictureBox
    {
        /// <summary>
        /// Gets or sets the interpolation mode associated with this <see cref="PictureBox"/>.
        /// </summary>
        [Category("Behavior"), DefaultValue(InterpolationMode.Default)]
        public InterpolationMode InterpolationMode { get; set; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.InterpolationMode = InterpolationMode;
            base.OnPaint(pe);
        }
    }
}
