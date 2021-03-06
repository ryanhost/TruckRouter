﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapSolver.Models;

namespace MapSolver.Algorithms
{
    /// <summary>
    /// Used to calculate G score in A* algorithm
    /// </summary>
    public interface IDistanceAlgorithm
    {
        double Calculate(Point from, Point to);
    }
}
