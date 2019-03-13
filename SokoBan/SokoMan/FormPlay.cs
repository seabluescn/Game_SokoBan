using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SokobanLib;
using Gif.Components;

namespace SokoManMap
{
    public partial class FormPlay : Form
    {
        public FormPlay()
        {
            InitializeComponent();
        }

        //常量
        private const int LEFT = 1;
        private const int UP = 2;
        private const int RIGHT = 3;
        private const int DOWN = 4;

        private const int WIDTH = 15;
        private const int HEIGHT = 10;
        private const int length = 30;
        private const int XOFFSET = 5;
        private const int YOFFSET = 60;

        //
        private MapState[,] OriginalMap;
        private CSokoMan Soko = new CSokoMan();
        private List<Operate> OperateList = new List<Operate>();
        private int Step=-1;

        public void SetHomeSokoban(MapState[,] _OriginalMap,CSokoMan _soko)
        {
            while (_soko.GetRoadStackCount() > 0)
            {
               Operate oper =  _soko.RoadStack.Pop();
               OperateList.Insert(0, oper);              
            }

            OriginalMap = _OriginalMap;
            Soko.Map = _OriginalMap;
        }

        private void FormPlay_Load(object sender, EventArgs e)
        {
           
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            ReDraw();
        }

        private void ReDraw()
        {            
            Graphics g = this.CreateGraphics();
            Bitmap bmp = new Bitmap(WIDTH * length, HEIGHT * length);
            Graphics gp = Graphics.FromImage(bmp);
            DrawImage(gp);

            g.DrawImage(bmp, XOFFSET, YOFFSET);

            gp.Dispose();
            bmp.Dispose();
            g.Dispose();
           
        }

        //绘图:没有偏移量
        private void DrawImage(Graphics g)
        {
            int i, j;
            int x, y;

            for (i = 0; i < WIDTH; i++)
            {
                for (j = 0; j < HEIGHT; j++)
                {
                    MapState state = Soko.Map[i, j];
                    x = length * i;
                    y = length * j;

                    switch (state)
                    {
                        case MapState.GLASS:
                            g.FillRectangle(Brushes.Gray, x, y, length, length);
                            break;
                        case MapState.WALL:
                            g.DrawImage(SokoManMap.Properties.Resources.Wall, x, y, length, length);
                            break;
                        case MapState.ROAD:
                            g.DrawImage(SokoManMap.Properties.Resources.Road, x, y, length, length);
                            break;
                        case MapState.MAN:
                            g.DrawImage(SokoManMap.Properties.Resources.Man, x, y, length, length);
                            break;
                        case MapState.BOX:
                            g.DrawImage(SokoManMap.Properties.Resources.Box, x, y, length, length);
                            break;
                        case MapState.DIRECT:
                            g.DrawImage(SokoManMap.Properties.Resources.Direct, x, y, length, length);
                            break;
                        case MapState.DIRECT_BOX:
                            g.DrawImage(SokoManMap.Properties.Resources.BoxInDirect, x, y, length, length);
                            break;
                        case MapState.DIRECT_MAN:
                            g.DrawImage(SokoManMap.Properties.Resources.ManInDirect, x, y, length, length);
                            break;
                    }
                }
            }
        }
           

        private void toolBack_Click(object sender, EventArgs e)
        {
            if (Step < 0)
            {
                MessageBox.Show("Begin");
                return;
            }

            Step--;

            Soko.GoBack();

            ReDraw();  
        }

        private void toolPrev_Click(object sender, EventArgs e)
        {

            if (Step >= OperateList.Count-1)
            {
                MessageBox.Show("End");
                return;
            }

            Step++;

            Operate oper = OperateList[Step];

            switch (oper.Direct)
            {
                case LEFT: Soko.Left(); break;
                case RIGHT: Soko.Right(); break;
                case UP: Soko.Up(); break;
                case DOWN: Soko.Down(); break;
                default: break;
            }  

            ReDraw();
        }

        private void toolMakeGIF_Click(object sender, EventArgs e)
        {
            toolReset_Click(null,null);
            
            String outputPath = System.Windows.Forms.Application.StartupPath +"\\GIF\\"+DateTime.Now.Ticks.ToString()+".gif";
          
            AnimatedGifEncoder gif = new AnimatedGifEncoder();
            gif.Start(outputPath);
            gif.SetDelay(600);
            gif.SetRepeat(0);

            Bitmap bmp = new Bitmap(WIDTH * length, HEIGHT * length);
            Graphics gp = Graphics.FromImage(bmp);
            DrawImage(gp);
            gif.AddFrame(bmp);

            foreach (Operate oper in OperateList)
            {              

                switch (oper.Direct)
                {
                    case LEFT: Soko.Left(); break;
                    case RIGHT: Soko.Right(); break;
                    case UP: Soko.Up(); break;
                    case DOWN: Soko.Down(); break;
                    default: break;
                }

                bmp = new Bitmap(WIDTH * length, HEIGHT * length);
                gp = Graphics.FromImage(bmp);
                DrawImage(gp);
                gif.AddFrame(bmp);

            }

            gif.Finish();

            MessageBox.Show("完成：" + outputPath);
        }

        private void toolReset_Click(object sender, EventArgs e)
        {
            Soko.Map = OriginalMap;
            Step = -1;
        }
    }
}
