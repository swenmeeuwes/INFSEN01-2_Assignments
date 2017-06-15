﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUILibrary.Util.Structures
{
    /// <summary>
    /// Represents a point in a 2-dimensional space
    /// </summary>
    public class Point2D<T>
    {
        public dynamic X { get; set; }
        public dynamic Y { get; set; }
        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }        
    }
}
