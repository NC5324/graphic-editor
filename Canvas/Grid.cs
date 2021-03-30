using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CourseProject
{
    internal class Grid
    {
        #region Private Members
        private List<List<Point>> _grid;
        #endregion Private Members

        #region Public Properties
        internal int CellSize { get; set; }
        internal DashStyle LineStyle { get; set; }
        #endregion

        public Grid(int cellSize)
        {
            CellSize = cellSize;
            _grid = new List<List<Point>>();
        }

        internal void Initialize(Canvas canvas)
        {
            _grid = new List<List<Point>>();

            for (int r = 0, y = 1; y < canvas.Height + CellSize; r++, y += CellSize)
            {
                if (r > _grid.Count - 1)
                {
                    _grid.Add(new List<Point>());
                }
                for (int c = 0, x = 1; x < canvas.Width + CellSize; c++, x += CellSize)
                {
                    if (c > _grid[r].Count - 1)
                    {
                        _grid[r].Add(new Point(x, y));
                    }
                }
            }
        }

        internal void Draw(Graphics gfx)
        {
            using (Pen dashedPen = new Pen(Color.Black))
            {
                dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                for (int i = 0; i < _grid.Count; i++)
                {
                    for (int j = 0; j < _grid[i].Count; j++)
                    {
                        if (j < _grid[i].Count - 1)
                            gfx.DrawLine(dashedPen, _grid[i][j], _grid[i][j + 1]);
                        if (i < _grid.Count - 1)
                            gfx.DrawLine(dashedPen, _grid[i][j], _grid[i + 1][j]);
                    }
                }
            }
        }

        internal Point this[int row, int col]
        {
            get
            {
                return _grid[row][col];
            }
            set
            {
                _grid[row][col] = value;
            }
        }

        internal void AddRow()
        {
            _grid.Add(new List<Point>());
        }

        internal void Add(int row, Point point)
        {
            _grid[row].Add(point);
        }
    }
}
