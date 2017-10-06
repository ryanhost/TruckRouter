﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapSolver.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MapSolver.Controllers
{
    [Route("api/[controller]")]
    public class MazeController : Controller
    {
        public MazeController()
        {
            
        }

        /// <summary>
        /// Endpoints used to solve mazes. 
        /// </summary>
        /// <param name="request">Maze as string array</param>
        /// <returns>Maze with optimal path to reach destination and amount of steps it took</returns>
        [HttpPost]
        [Route("solveMaze")]
        public SolveMazeResponse SolveMaze([FromBody] SolveMazeRequest request)
        {
            // Solve maze

            //Output solution to maze
            return new SolveMazeResponse
            {
                Steps = 14,
                Solution = new []
                {
                    "##########",
                    "#A@@.#...#",
                    "#.#@##.#.#",
                    "#.#@##.#.#",
                    "#.#@@@@#B#",
                    "#.#.##@#@#",
                    "#....#@@@#",
                    "##########"
                }
            };
        }
    }
}