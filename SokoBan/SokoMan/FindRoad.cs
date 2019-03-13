using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace SokoManMap
{
    class FindRoad
    {        
        private  int WIDTH = 25;
        private  int HEIGHT = 15;       

        private int StartX = 1;
        private int StartY = 1;
        private int EndX = 2;
        private int EndY = 2;

        private int[,] Map;
        private int[,] MapResult;
        private List<Point> listRoads = new List<Point>();

        private string m_ErrStr = "";

        private FindRoad()
        {
        }       

        public FindRoad(int width, int height)
        {
            WIDTH = width;
            HEIGHT = height;

            MapResult = new int[WIDTH, HEIGHT];
        }

        public int[,] MAP
        {
            set
            {
                Map = value;
            }
        }

        public Point StartPoint
        {
            set
            {
                StartX = value.X;
                StartY = value.Y;
            }
        }

        public Point EndPoint
        {
            set
            {
                EndX = value.X;
                EndY = value.Y;
            }
        }

        public List<Point> Roads
        {
            get
            {
                return listRoads;
            }
        }

        public string ErrorMessage
        {
            get
            {
                return m_ErrStr;
            }
        }

        public bool  Run()
        {
            listRoads.Clear();

            for (int i = 0; i < WIDTH; i++)
                for (int j = 0; j < HEIGHT; j++)
                {
                    MapResult[i, j] = 10000;
                }
            MapResult[StartX, StartY] = 0;

            int Current = 0;
            int Selected = 0;

            while (true)
            {
                for (int i = 0; i < WIDTH; i++)
                    for (int j = 0; j < HEIGHT; j++)
                    {
                        if (MapResult[i, j] == Current)
                        {
                            Selected++;

                            Research(Current, i, j);
                        }
                    }

                if (Selected > 0)
                {
                    Current++;
                    Selected = 0;
                }
                else
                {
                    break;
                }
            }
                      

            if (MapResult[EndX, EndY] == 10000)
            {
                m_ErrStr = "Not find the way!";
                return false;
            }
            else
            {  
                int x = EndX;
                int y = EndY;

                listRoads.Add(new Point(x, y));
                Current = MapResult[x, y];

                int xs,ys;
                
                while (true)
                {
                    xs = x - 1;
                    ys = y;
                    if (xs >= 0 && xs < WIDTH && ys >= 0 && ys < HEIGHT && MapResult[xs, ys] == Current - 1)
                    {
                        listRoads.Add(new Point(xs, ys));

                        if (xs == StartX && ys == StartY)
                        {
                            return true;
                        }
                        else
                        {
                            Current--;
                            x = xs;
                            y = ys;
                            continue;
                        }
                    }

                    xs = x + 1;
                    ys = y;
                    if (xs >= 0 && xs < WIDTH && ys >= 0 && ys < HEIGHT && MapResult[xs, ys] == Current - 1)
                    {
                        listRoads.Add(new Point(xs, ys));

                        if (xs == StartX && ys == StartY)
                        {
                            return true;
                        }
                        else
                        {
                            Current--;
                            x = xs;
                            y = ys;
                            continue;
                        }
                    }

                    xs = x ;
                    ys = y + 1;
                    if (xs >= 0 && xs < WIDTH && ys >= 0 && ys < HEIGHT && MapResult[xs, ys] == Current - 1)
                    {
                        listRoads.Add(new Point(xs, ys));

                        if (xs == StartX && ys == StartY)
                        {
                            return true;
                        }
                        else
                        {
                            Current--;
                            x = xs;
                            y = ys;
                            continue;
                        }
                    }

                    xs = x ;
                    ys = y - 1;
                    if (xs >= 0 && xs < WIDTH && ys >= 0 && ys < HEIGHT && MapResult[xs, ys] == Current - 1)
                    {
                        listRoads.Add(new Point(xs, ys));

                        if (xs == StartX && ys == StartY)
                        {
                            return true;
                        }
                        else
                        {
                            Current--;
                            x = xs;
                            y = ys;
                            continue;
                        }
                    }

                    m_ErrStr = "Something Error!";
                    return false; 
                }               
            }           
        }

        private void Research(int Current, int i, int j)
        {
            int x, y;                  

            x = i - 1;
            y = j ;
            SetNewResult(Current, x, y);
           
            x = i ;
            y = j - 1;
            SetNewResult(Current, x, y);

            x = i ;
            y = j + 1;
            SetNewResult(Current, x, y);
           
            x = i + 1;
            y = j ;
            SetNewResult(Current, x, y);          
        }

        private void SetNewResult(int Current, int x, int y)
        {
            if (x >= 0 && x < WIDTH && y >= 0 && y < HEIGHT)
            {
                if (Map[x, y] == 0 && MapResult[x, y] > Current)
                {
                    MapResult[x, y] = Current + 1;
                }
            }
        }
    }
}
