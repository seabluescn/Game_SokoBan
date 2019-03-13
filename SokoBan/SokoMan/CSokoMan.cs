using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using SokobanLib;

namespace SokoManMap
{
    public struct Operate
    {
        public int Direct;
        public bool PushBox;
        
        public Operate(int dir, bool push)
        {
            Direct = dir;
            PushBox = push ;
        }
    }

    public class CSokoMan
    {
        private const int LEFT = 1;
        private const int UP = 2;
        private const int RIGHT = 3;
        private const int DOWN = 4;

        private const int WIDTH = 15;
        private const int HEIGHT = 10;

        private MapState[,] map = new MapState[WIDTH, HEIGHT];
        public MapState[,] Map
        {
            get
            {
                return map;
            }
            set
            {
                int i, j;
                for (i = 0; i < WIDTH; i++)
                {
                    for (j = 0; j < HEIGHT; j++)
                    {
                        map[i, j] = value[i, j];
                    }
                }

                ManX = -1;
                ManY = -1;              
                
                for (i = 0; i < WIDTH; i++)
                {
                    for (j = 0; j < HEIGHT; j++)
                    {
                        if (map[i, j] == MapState.MAN || map[i, j] == MapState.DIRECT_MAN)
                        {
                            ManX = i;
                            ManY = j;
                            goto Result;
                        }
                    }
                }
            Result:
                if (ManX == -1 || ManY == -1)
                {
                    throw new Exception("map error!");
                }
                ResetRoadStack();
            }
        }

        //
        private int ManX = -1;
        private int ManY = -1;
        public Point ManLocation
        {
            get
            {
                return new Point(ManX, ManY);
            }
        }

        //
        public System.Collections.Generic.Stack<Operate> RoadStack = new Stack<Operate>();

        public CSokoMan()
        {
            ResetMap();
        }

        public void ResetMap()
        {
            int i, j;
            for (i = 0; i < WIDTH; i++)
            {
                for (j = 0; j < HEIGHT; j++)
                {
                    map[i, j] = MapState.GLASS;
                }
            }
        }

        public void ResetRoadStack()
        {
            this.RoadStack.Clear();
        }

        public void GoBack()
        {
            if (RoadStack.Count == 0)
            {
                return ;
            }

            Operate r = RoadStack.Pop();
            switch (r.Direct)
            {
                case LEFT:  Right(); 
                            RoadStack.Pop();
                            if (r.PushBox)
                            {
                                if (map[ManX - 2, ManY] == MapState.BOX)
                                {
                                    map[ManX - 2, ManY] = MapState.ROAD;
                                }
                                if (map[ManX - 2, ManY] == MapState.DIRECT_BOX)
                                {
                                    map[ManX - 2, ManY] = MapState.DIRECT;
                                }
                                if (map[ManX - 1, ManY] == MapState.ROAD)
                                {
                                    map[ManX - 1, ManY] = MapState.BOX;
                                }
                                if (map[ManX - 1, ManY] == MapState.DIRECT)
                                {
                                    map[ManX - 1, ManY] = MapState.DIRECT_BOX;
                                }                                
                            }
                            break;
                case RIGHT: Left(); 
                            RoadStack.Pop();
                            if (r.PushBox)
                            {
                                if (map[ManX + 2, ManY] == MapState.BOX)
                                {
                                    map[ManX + 2, ManY] = MapState.ROAD;
                                }
                                if (map[ManX + 2, ManY] == MapState.DIRECT_BOX)
                                {
                                    map[ManX + 2, ManY] = MapState.DIRECT;
                                }
                                if (map[ManX + 1, ManY] == MapState.ROAD)
                                {
                                    map[ManX + 1, ManY] = MapState.BOX;
                                }
                                if (map[ManX + 1, ManY] == MapState.DIRECT)
                                {
                                    map[ManX + 1, ManY] = MapState.DIRECT_BOX;
                                }
                            }
                            break;
                case UP:    Down();
                            RoadStack.Pop();
                            if (r.PushBox)
                            {
                                if (map[ManX, ManY - 2] == MapState.BOX)
                                {
                                    map[ManX, ManY - 2] = MapState.ROAD;
                                }
                                if (map[ManX, ManY - 2] == MapState.DIRECT_BOX)
                                {
                                    map[ManX, ManY - 2] = MapState.DIRECT;
                                }
                                if (map[ManX, ManY - 1] == MapState.ROAD)
                                {
                                    map[ManX, ManY - 1] = MapState.BOX;
                                }
                                if (map[ManX, ManY - 1] == MapState.DIRECT)
                                {
                                    map[ManX, ManY - 1] = MapState.DIRECT_BOX;
                                }
                            }
                            break;
                case DOWN:  Up();
                            RoadStack.Pop();
                            if (r.PushBox)
                            {
                                if (map[ManX, ManY + 2] == MapState.BOX)
                                {
                                    map[ManX, ManY + 2] = MapState.ROAD;
                                }
                                if (map[ManX, ManY + 2] == MapState.DIRECT_BOX)
                                {
                                    map[ManX, ManY + 2] = MapState.DIRECT;
                                }
                                if (map[ManX, ManY + 1] == MapState.ROAD)
                                {
                                    map[ManX, ManY + 1] = MapState.BOX;
                                }
                                if (map[ManX, ManY + 1] == MapState.DIRECT)
                                {
                                    map[ManX, ManY + 1] = MapState.DIRECT_BOX;
                                }
                            }
                            break;
            }
        }

        public int GetRoadStackCount()
        {
            return RoadStack.Count;
        }
             

        public bool Left()
        {
            if (ManX <= 0 || ManX >= WIDTH - 1)
            {
                return false;
            }

            if (map[ManX - 1, ManY] == MapState.ROAD || map[ManX - 1, ManY] == MapState.DIRECT)
            {
                if (map[ManX, ManY] == MapState.MAN)
                {
                    map[ManX, ManY] = MapState.ROAD;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT;
                }

                ManX--;

                if (map[ManX, ManY] == MapState.ROAD)
                {
                    map[ManX, ManY] = MapState.MAN;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT_MAN;
                }

                RoadStack.Push(new Operate(LEFT,false));
                return true;
            }

            if ((map[ManX - 1, ManY] == MapState.BOX || map[ManX - 1, ManY] == MapState.DIRECT_BOX)
                && (map[ManX - 2, ManY] == MapState.ROAD || map[ManX - 2, ManY] == MapState.DIRECT))
            {
                if (map[ManX - 2, ManY] == MapState.ROAD)
                {
                    map[ManX - 2, ManY] = MapState.BOX;
                }
                else
                {
                    map[ManX - 2, ManY] = MapState.DIRECT_BOX;
                }

                if (map[ManX, ManY] == MapState.MAN)
                {
                    map[ManX, ManY] = MapState.ROAD;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT;
                }

                ManX--;

                if (map[ManX, ManY] == MapState.BOX)
                {
                    map[ManX, ManY] = MapState.MAN;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT_MAN;
                }

                RoadStack.Push(new Operate(LEFT, true));
                return true;
            }

            return false;
        }

        public bool Right()
        {
            if (ManX <= 0 || ManX >= WIDTH - 1)
            {
                return false;
            }

            if (map[ManX + 1, ManY] == MapState.ROAD || map[ManX + 1, ManY] == MapState.DIRECT)
            {
                if (map[ManX, ManY] == MapState.MAN)
                {
                    map[ManX, ManY] = MapState.ROAD;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT;
                }

                ManX++;

                if (map[ManX, ManY] == MapState.ROAD)
                {
                    map[ManX, ManY] = MapState.MAN;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT_MAN;
                }

                RoadStack.Push(new Operate(RIGHT,false));
                return true;
            }

            if ((map[ManX + 1, ManY] == MapState.BOX || map[ManX + 1, ManY] == MapState.DIRECT_BOX)
                && (map[ManX + 2, ManY] == MapState.ROAD || map[ManX + 2, ManY] == MapState.DIRECT))
            {
                if (map[ManX + 2, ManY] == MapState.ROAD)
                {
                    map[ManX + 2, ManY] = MapState.BOX;
                }
                else
                {
                    map[ManX + 2, ManY] = MapState.DIRECT_BOX;
                }

                if (map[ManX, ManY] == MapState.MAN)
                {
                    map[ManX, ManY] = MapState.ROAD;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT;
                }

                ManX++;

                if (map[ManX, ManY] == MapState.BOX)
                {
                    map[ManX, ManY] = MapState.MAN;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT_MAN;
                }

                RoadStack.Push(new Operate(RIGHT, true));
                return true;
            }

            return false;
        }

        public bool Up()
        {
            if (ManX <= 0 || ManX >= WIDTH - 1)
            {
                return false;
            }

            if (map[ManX, ManY - 1] == MapState.ROAD || map[ManX, ManY - 1] == MapState.DIRECT)
            {
                if (map[ManX, ManY] == MapState.MAN)
                {
                    map[ManX, ManY] = MapState.ROAD;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT;
                }

                ManY--;

                if (map[ManX, ManY] == MapState.ROAD)
                {
                    map[ManX, ManY] = MapState.MAN;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT_MAN;
                }

                RoadStack.Push(new Operate(UP,false));
                return true;
            }

            if ((map[ManX, ManY - 1] == MapState.BOX || map[ManX, ManY - 1] == MapState.DIRECT_BOX)
                && (map[ManX, ManY - 2] == MapState.ROAD || map[ManX, ManY - 2] == MapState.DIRECT))
            {
                if (map[ManX, ManY - 2] == MapState.ROAD)
                {
                    map[ManX, ManY - 2] = MapState.BOX;
                }
                else
                {
                    map[ManX, ManY - 2] = MapState.DIRECT_BOX;
                }

                if (map[ManX, ManY] == MapState.MAN)
                {
                    map[ManX, ManY] = MapState.ROAD;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT;
                }

                ManY--;

                if (map[ManX, ManY] == MapState.BOX)
                {
                    map[ManX, ManY] = MapState.MAN;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT_MAN;
                }

                RoadStack.Push(new Operate(UP, true));
                return true;
            }

            return false;
        }

        public bool Down()
        {
            if (ManX <= 0 || ManX >= WIDTH - 1)
            {
                return false;
            }

            if (map[ManX, ManY + 1] == MapState.ROAD || map[ManX, ManY + 1] == MapState.DIRECT)
            {
                if (map[ManX, ManY] == MapState.MAN)
                {
                    map[ManX, ManY] = MapState.ROAD;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT;
                }

                ManY++;

                if (map[ManX, ManY] == MapState.ROAD)
                {
                    map[ManX, ManY] = MapState.MAN;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT_MAN;
                }

                RoadStack.Push(new Operate(DOWN,false));
                return true;
            }

            if ((map[ManX, ManY + 1] == MapState.BOX || map[ManX, ManY + 1] == MapState.DIRECT_BOX)
                && (map[ManX, ManY + 2] == MapState.ROAD || map[ManX, ManY + 2] == MapState.DIRECT))
            {
                if (map[ManX, ManY + 2] == MapState.ROAD)
                {
                    map[ManX, ManY + 2] = MapState.BOX;
                }
                else
                {
                    map[ManX, ManY + 2] = MapState.DIRECT_BOX;
                }

                if (map[ManX, ManY] == MapState.MAN)
                {
                    map[ManX, ManY] = MapState.ROAD;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT;
                }

                ManY++;

                if (map[ManX, ManY] == MapState.BOX)
                {
                    map[ManX, ManY] = MapState.MAN;
                }
                else
                {
                    map[ManX, ManY] = MapState.DIRECT_MAN;
                }

                RoadStack.Push(new Operate(DOWN, true ));
                return true;
            }

            return false;
        }

        public bool CheckSuccess()
        {
            int i, j;
            int Count = 0;
            for (i = 0; i < WIDTH; i++)
            {
                for (j = 0; j < HEIGHT; j++)
                {
                    if (map[i, j] == MapState.BOX)
                    {
                        Count++;
                    }
                }
            }

            if (Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Point> GotoLocation(int x, int y)
        {
            if (x < 0 || x >= WIDTH || y < 0 || y >= HEIGHT)
            {
                throw new UserException("未知错误！");
            }

            if (map[x, y] != MapState.ROAD && map[x, y] != MapState.DIRECT)
            {
                return null;
                //throw new UserException("不可到达！");
            }

            FindRoad finder = new FindRoad(WIDTH, HEIGHT);

            int[,] road = new int[WIDTH, HEIGHT];

            int i, j;
            for (i = 0; i < WIDTH; i++)
            {
                for (j = 0; j < HEIGHT; j++)
                {
                    if (map[i, j] == MapState.ROAD || map[i, j] == MapState.DIRECT)
                    {
                        road[i, j] = 0;
                    }
                    else
                    {
                        road[i, j] = 1;
                    }
                }
            }

            finder.MAP = road;
            finder.StartPoint = new Point(ManX, ManY);
            finder.EndPoint = new Point(x, y);

            if (!finder.Run())
            {
                return null;
            }
            else
            {
                return finder.Roads;
            }
        }


    }
}
