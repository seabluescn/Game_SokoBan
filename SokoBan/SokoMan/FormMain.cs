using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
        private const int XOFFSET = 5;
        private const int YOFFSET = 55;

        //
        private bool Wave = true;
        private bool Music = true;
        private System.Media.SoundPlayer SoundMove = new System.Media.SoundPlayer(SokoManMap.Properties.Resources.Clickerx);
        private MciDevice mci = new MciDevice();
        List<string> listMusic = new List<string>();
        
        //业务数据
        private CSokoMan Soko = new CSokoMan();
        private int MapIndex = 1;

        List<String> MapLevels = new List<string>();

        private MapState[,] OriginalMap = new MapState[WIDTH, HEIGHT];
                            
        //
        public frmMain()
        {
            InitializeComponent();            
        }

        public void LoadMapLevels()
        {
            DirectoryInfo dir = new DirectoryInfo("maps");
            FileInfo []maps = dir.GetFiles("*.map");

            foreach (FileInfo file in maps)
            {
                MapLevels.Add(file.FullName);               
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Width = 915;
            this.Height = 710;

            this.Text = "勤劳搬运工";
            this.Music = SokoManMap.Properties.Settings.Default.bMusic;
            this.Wave = SokoManMap.Properties.Settings.Default.bAudio;
            this.menuSetupMusic.Checked = Music;
            this.menuSetupWave.Checked = Wave;

            LoadMapLevels();

            this.MapIndex = SokoManMap.Properties.Settings.Default.iMapIndex;
                      
            LoadMapFile(MapIndex);
           
        }

        void LoadMapFile(int Index)
        {
            string FileName = MapLevels[Index];
            try
            {
                OpenMapFile(FileName);                              
            }
            catch (System.Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
       
       
        //重绘事件
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("OnPainting..." + DateTime.Now.ToString() + "(" + sender.ToString());
            System.Diagnostics.Debug.WriteLine(e.ClipRectangle.ToString());

            if (e.ClipRectangle.Height > 10)
            {
                ReDraw();
            }
        }

        private void ReDraw(Point point)
        {
            Graphics g = this.CreateGraphics();
            Bitmap bmp = new Bitmap(5 * length, 5 * length );
            Graphics gp = Graphics.FromImage(bmp);
            
            //
            int i, j;
            int x, y;



            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    MapState state;
                    try
                    {

                         state = Soko.Map[point.X - 2 + i, point.Y - 2 + j];
                    }
                    catch
                    {
                        continue;
                    }

                    x = length * i;
                    y = length * j;

                    switch (state)
                    {
                        case MapState.GLASS:
                          
                            gp.FillRectangle(Brushes.Gray, x, y, length,length);
                            break;
                        case MapState.WALL:
                            gp.DrawImage(SokoManMap.Properties.Resources.Wall, x, y, length, length);
                            break;
                        case MapState.ROAD:
                            gp.DrawImage(SokoManMap.Properties.Resources.Road, x, y, length, length);
                            break;
                        case MapState.MAN:
                            gp.DrawImage(SokoManMap.Properties.Resources.Man, x, y, length,length);
                            break;
                        case MapState.BOX:
                            gp.DrawImage(SokoManMap.Properties.Resources.Box, x, y, length,length);
                            break;
                        case MapState.DIRECT:
                            gp.DrawImage(SokoManMap.Properties.Resources.Direct, x, y, length,length);
                            break;
                        case MapState.DIRECT_BOX:
                            gp.DrawImage(SokoManMap.Properties.Resources.BoxInDirect, x, y, length,length);
                            break;
                        case MapState.DIRECT_MAN:
                            gp.DrawImage(SokoManMap.Properties.Resources.ManInDirect, x, y, length,length);
                            break;
                    }
                }
            }
            //

            int offx = XOFFSET + length * (point.X - 2);
            int offy = YOFFSET + length * (point.Y - 2);
            g.DrawImage(bmp,offx,offy);

            gp.Dispose();
            bmp.Dispose();
            g.Dispose();

            UpdateStatus();
        }

        private void ReDraw()
        {
            //
            //System.Diagnostics.Debug.WriteLine("ReDrawing..." + DateTime.Now.ToString());
            //
            Graphics g = this.CreateGraphics();
            Bitmap bmp = new Bitmap(WIDTH * length , HEIGHT * length );
            Graphics gp = Graphics.FromImage(bmp);
            DrawImage(gp);

            g.DrawImage(bmp, XOFFSET, YOFFSET);

            gp.Dispose();
            bmp.Dispose();
            g.Dispose();

            UpdateStatus();
        }

        void UpdateStatus()
        {
            String info = string.Format("第{0}步",this.Soko.GetRoadStackCount());
            this.statusLabel.Text = info;
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
                            g.FillRectangle(Brushes.Gray, x, y, length,length);
                            break;
                        case MapState.WALL:
                            g.DrawImage(SokoManMap.Properties.Resources.Wall, x, y, length,length);
                            break;
                        case MapState.ROAD:
                            g.DrawImage(SokoManMap.Properties.Resources.Road, x, y, length,length);
                            break;
                        case MapState.MAN:
                            g.DrawImage(SokoManMap.Properties.Resources.Man, x, y, length,length);
                            break;
                        case MapState.BOX:
                            g.DrawImage(SokoManMap.Properties.Resources.Box, x, y, length,length);
                            break;
                        case MapState.DIRECT:
                            g.DrawImage(SokoManMap.Properties.Resources.Direct, x, y, length,length);
                            break;
                        case MapState.DIRECT_BOX:
                            g.DrawImage(SokoManMap.Properties.Resources.BoxInDirect, x, y, length,length);
                            break;
                        case MapState.DIRECT_MAN:
                            g.DrawImage(SokoManMap.Properties.Resources.ManInDirect, x, y, length,length);
                            break;
                    }
                }
            }
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "map files(*.map)|*.map";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string FileName = dlg.FileName;

                OpenMapFile(FileName);
            }
        }

        private void OpenMapFile(string FileName)
        {
            FileStream file = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter formater = new BinaryFormatter();           
            OriginalMap = (MapState[,])formater.Deserialize(file);
            Soko.Map = OriginalMap;
            file.Close();
            ReDraw();
            this.toolGoBack.Enabled = false;

            this.Text = "勤劳搬运工 — " + FileName;

        }

        

        private void PlayMoveSound()
        {
            if (this.Wave)
            {
                this.SoundMove.Stop();
                this.SoundMove.Play();
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (Soko.Left())
                {
                    PlayMoveSound();
                    ReDraw(Soko.ManLocation);
                    CheckSuccess();
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (Soko.Right())
                {
                    PlayMoveSound();
                    ReDraw(Soko.ManLocation);
                    CheckSuccess();
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (Soko.Up())
                {
                    PlayMoveSound();
                    ReDraw(Soko.ManLocation);
                    CheckSuccess();
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (Soko.Down())
                {
                    PlayMoveSound();
                    ReDraw(Soko.ManLocation);
                    CheckSuccess();
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                this.toolGoBack_Click(null, null);
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.toolResetMap_Click(null, null);
            }

            if (Soko.GetRoadStackCount() > 0)
            {
                this.toolGoBack.Enabled = true;
            }
        }

        private void CheckSuccess()
        {
            if (Soko.CheckSuccess())
            {
                if (MessageBox.Show("You are Success,Play next map?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    toolNext_Click(null, null);
                }
            }
        }      

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                toolGoBack_Click(null, null);
                ReDraw(Soko.ManLocation);
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                int x = (e.X - XOFFSET) / length;
                int y = (e.Y - YOFFSET) / length;

                try
                {
                    List<Point> roads = Soko.GotoLocation(x, y);
                    if (roads != null)
                    {
                        int x1, y1, x2, y2;
                        for (int r = roads.Count - 1; r >= 1; r--)
                        {
                            x1 = roads[r].X;
                            y1 = roads[r].Y;

                            x2 = roads[r - 1].X;
                            y2 = roads[r - 1].Y;

                            if (x2 > x1)
                            {
                                Soko.Right();
                                ReDraw(Soko.ManLocation);
                            }

                            if (x2 < x1)
                            {
                                Soko.Left();
                                ReDraw(Soko.ManLocation);
                            }

                            if (y2 < y1)
                            {
                                Soko.Up();
                                ReDraw(Soko.ManLocation);
                            }

                            if (y2 > y1)
                            {
                                Soko.Down();
                                ReDraw(Soko.ManLocation);
                            }

                            System.Threading.Thread.Sleep(50);
                        }
                    }
                }
                catch (UserException EX)
                {
                    MessageBox.Show(EX.ErrorMessage);
                }
            }

            if (Soko.GetRoadStackCount() > 0)
            {
                this.toolGoBack.Enabled = true;
            }
        }

        //
        private void toolResetMap_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMapFile(MapIndex);                  
            }
            catch (System.Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void toolGoBack_Click(object sender, EventArgs e)
        {
            Soko.GoBack();
            ReDraw();

            if (Soko.GetRoadStackCount() == 0)
            {
                this.toolGoBack.Enabled = false;
            }
        }

        private void toolPrev_Click(object sender, EventArgs e)
        {
            if (MapIndex <= 0)
            {
                return;
            }

            MapIndex--;
          
            LoadMapFile(MapIndex);           
        }

        private void toolNext_Click(object sender, EventArgs e)
        {
            if (MapIndex >= MapLevels.Count - 1)
            {
                return;
            }

            MapIndex++;
           
            LoadMapFile(MapIndex);  
        }
              

        private void toolHelp_Click(object sender, EventArgs e)
        {

        }

        //菜单
        private void meunFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuResetMap_Click(object sender, EventArgs e)
        {
            this.toolResetMap_Click(null, null);
        }

        private void menuGoBack_Click(object sender, EventArgs e)
        {
            this.toolGoBack_Click(null, null);
        }

        private void menuPrev_Click(object sender, EventArgs e)
        {
            this.toolPrev_Click(null, null);
        }

        private void menuNext_Click(object sender, EventArgs e)
        {
            this.toolNext_Click(null, null);
        }

        private void meunSetupWave_Click(object sender, EventArgs e)
        {
            Wave = !Wave;
            this.menuSetupWave.Checked = Wave;
        }

        private void menuSetupMusic_Click(object sender, EventArgs e)
        {
            Music = !Music;
            this.menuSetupMusic.Checked = Music;

            if (!Music)
            {
                mci.Stop();
            }
        }
        
        //
        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.Music)
            {
                if (listMusic.Count == 0)
                {
                    string Path = System.Environment.CurrentDirectory;
                    DirectoryInfo Dir = new DirectoryInfo(Path + "\\Audio");
                    foreach (FileInfo fi in Dir.GetFiles("*.mp3"))
                    {
                        listMusic.Add(fi.FullName);
                    }
                }

                if (listMusic.Count != 0)
                {
                    int Dur = mci.Duration;
                    int Cur = mci.CurrentPosition;

                    if (Cur == Dur)
                    {
                        mci = new MciDevice();

                        int ran = DateTime.Now.Second % listMusic.Count;
                        mci.FileName = listMusic[ran];
                        mci.Play();
                    }
                }
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SokoManMap.Properties.Settings.Default.bMusic = this.Music;
            SokoManMap.Properties.Settings.Default.bAudio = this.Wave;
            SokoManMap.Properties.Settings.Default.iMapIndex = this.MapIndex;
            SokoManMap.Properties.Settings.Default.Save();
        }

        private void toolPlay_Click(object sender, EventArgs e)
        {
            FormPlay player = new FormPlay();
            player.SetHomeSokoban(this.OriginalMap,Soko);
            player.ShowDialog();
        }

          
    }   
}