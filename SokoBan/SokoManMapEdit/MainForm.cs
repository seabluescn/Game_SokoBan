using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SokobanLib;

namespace SokoManMap
{
    public partial class frmMain : Form
    {
        //常量
        private const int WIDTH = 15;
        private const int HEIGHT = 10;
        private const int length = 60;
        private const int XOFFSET = 10;
        private const int YOFFSET = 80;

        //
        private MapState[,] map = new MapState[WIDTH, HEIGHT];
        private MapState CurrentState = MapState.GLASS;

        private string FileName = "Noname.map";
        private bool Durty = false;

        //
        private bool MouseActived = false;

        //
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Width = 935;
            this.Height = 745;

            ResetMap();

            ResetFormText();
        }
   

        private void ResetMap()
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
       

        //重绘事件
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Debug.WriteLine("OpPain...(" + e.ClipRectangle.ToString());

            if (e.ClipRectangle.Y > 25)
            {
                ReDraw();
            }           
        }

        private void ReDraw(Point p)
        {
            Graphics g = this.CreateGraphics();

            MapState state = map[p.X, p.Y];
            int x = XOFFSET + length * p.X;
            int y = YOFFSET + length * p.Y;

            switch (state)
            {
                case MapState.GLASS:
                    g.DrawImage(SokoManMap.Properties.Resources.None, x, y, length, length);                 
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
    
            g.Dispose();
        }

        private void ReDraw()
        {            
            Graphics g = this.CreateGraphics();
            Bitmap bmp = new Bitmap(WIDTH * length , HEIGHT * length );
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
                    MapState state = map[i, j];
                    x = length * i;
                    y = length * j;

                    switch (state)
                    {
                        case MapState.GLASS:
                            g.DrawImage(SokoManMap.Properties.Resources.None, x, y, length, length);                         
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

        //菜单
        private void ResetFormText()
        {
            string Title = "MapEdit - " + FileName;
            if (Durty)
            {
                Title += "*";
            }
            this.Text = Title;
        }
       
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            FileName = "Noname.map";
            ResetMap();
            Durty = true;
            ResetFormText();
        }      

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "map files(*.map)|*.map";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileName = dlg.FileName;
               
                FileStream file = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formater = new BinaryFormatter();
                map = (MapState[,])formater.Deserialize(file);
                file.Close();
                ReDraw();

                Durty = false;
                ResetFormText();
            }
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            if (!Durty)
            {
                return;
            }

            if (FileName == "Noname.map")
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "map files(*.map)|*.map";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FileName = dlg.FileName;
                }
                else
                {
                    return;
                }
            }
            FileStream file = new FileStream(FileName, FileMode.Create);
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(file, this.map);
            file.Close();
            MessageBox.Show("Save OK");
            Durty = false;
            ResetFormText();
        }

        private void meunFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region ToolBar
        private void toolGlass_Click(object sender, EventArgs e)
        {
            CurrentState = MapState.GLASS;
        }

        private void toolWall_Click(object sender, EventArgs e)
        {
            CurrentState = MapState.WALL;
        }

        private void toolRoad_Click(object sender, EventArgs e)
        {
            CurrentState = MapState.ROAD;
        }

        private void toolDirect_Click(object sender, EventArgs e)
        {
            CurrentState = MapState.DIRECT;
        }

        private void toolBox_Click(object sender, EventArgs e)
        {
            CurrentState = MapState.BOX;
        }

        private void toolDirectBox_Click(object sender, EventArgs e)
        {
            CurrentState = MapState.DIRECT_BOX;
        }

        private void toolMan_Click(object sender, EventArgs e)
        {
            CurrentState = MapState.MAN;
        }

        private void toolDirectMan_Click(object sender, EventArgs e)
        {
            CurrentState = MapState.DIRECT_MAN;
        }
        #endregion

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {            
            MouseActived = false;
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            MouseActived = true;

            int x = (e.X - XOFFSET) / length;
            int y = (e.Y - YOFFSET) / length;

            if (x >= WIDTH || y >= HEIGHT)
            {
                return;
            }

            map[x, y] = this.CurrentState;

            ReDraw(new Point(x, y));
            Durty = true;
            ResetFormText();
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseActived)
            {
                int x = (e.X - XOFFSET) / length;
                int y = (e.Y - YOFFSET) / length;

                if (x >= WIDTH || y >= HEIGHT)
                {
                    return;
                }

                map[x, y] = this.CurrentState;

                ReDraw(new Point(x, y));
                Durty = true;
                ResetFormText();
            }
        }

              
    }
}