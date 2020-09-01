using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace TriangleServiceAPI.Controllers
{
    public class GridController : ControllerBase
    {
        [HttpGet("api/points")]

        public JsonResult GetTriangleRowAndColumn([FromQuery]int x1, [FromQuery]int y1, [FromQuery]int x2, [FromQuery]int y2, [FromQuery]int x3, [FromQuery]int y3)
        {
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);

            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);
            Point point3 = new Point(x3, y3);

            return new JsonResult(grid.CalculateTriangleRowAndColumn(point1, point2, point3));
        }

        [HttpGet("api/location")]
        public JsonResult GetTrianglePoints([FromQuery] string location)
        {
            if (location != null)
            {
                Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);

                Triangle triangle = grid.GetTriangle(location);

                return new JsonResult(triangle);
            }
            else
            {
                throw new Exception("Location is null");
            }
        }
    }
}
