using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PhotoStore
{
    public class Filter
    {
        /// <summary>
        /// Returns the name of filter. This will show below filter preview image
        /// </summary>
        /// <returns>Name of filter</returns>
        public virtual string GetFilterName()
        {
            return "Base Filter";
        }

        /// <summary>
        /// Returns the minimum value allowed in filter.
        /// </summary>
        /// <returns>Minimum value allowed</returns>
        public virtual int GetMinimumValue()
        {
            return 0;
        }

        /// <summary>
        /// Returns the maximum value allowed in filter.
        /// </summary>
        /// <returns>Maximum value allowed</returns>
        public virtual int GetMaximumValue()
        {
            return 100;
        }

        /// <summary>
        /// Returns the value step between minimum and maximum value
        /// </summary>
        /// <returns>Value step</returns>
        public virtual int GetValueStep()
        {
            return 1;
        }

        /// <summary>
        /// Returns the permission of drag selection.
        /// </summary>
        /// <returns>true, if allowed</returns>
        public virtual bool AllowDragSelection()
        {
            return false;
        }

        /// <summary>
        /// Returns the image which has been processed by filter.
        /// </summary>
        /// <param name="bgWorker">BackgroundWorker to report progress</param>
        /// <param name="value">Input value from user</param>
        /// <param name="pos">All positions from dragging</param>
        /// <param name="selection">Selection scope</param>
        /// <param name="source">Input image</param>
        /// <returns> null, if no changes has been done to image. Otherwise, output image from filter.</returns>
        public virtual Image RunFilter(BackgroundWorker bgWorker, int value, Position pos, Selection selection, Image source)
        {
            return null;
        }
    }
}
