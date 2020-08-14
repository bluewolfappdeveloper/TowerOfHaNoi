using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace thap_ha_noi
{
    public partial class Form1 : Form
    {

        int i,movecount,a;
        PictureBox[] disks;
        Stack<PictureBox> disksA, disksB, disksC,firstclickeddick,secondclickeddick;

        const int firsty = 554, diskhigh = 35; 
        public Form1()
        {
            InitializeComponent();
            disks = new PictureBox [] {pic1,pic2,pic3,pic4,pic5,pic6,pic7,pic8};
            piccota.Tag= disksA =new Stack<PictureBox>();
            piccotb.Tag = disksB = new Stack<PictureBox>();
            piccotc.Tag = disksC = new Stack<PictureBox>();
        }

        public static void PlayMusic(string filename)
        {
            SoundPlayer sound = new SoundPlayer(filename);
            sound.Play();
        }
        public static void StopMusic(string filename)
        {
            SoundPlayer sound = new SoundPlayer(filename);
            sound.Stop();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (num.Value >= 9)
            {
                num.Value = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trò chơi THÁP HÀ NỘI với 3 cọc A, B, C, số đĩa có thể chọn trong khoảng từ 1 đến 8. Nhiệm vụ là hãy di chuyển tất cả các đĩa từ cọc A sang cọc C theo luật: \n - Mỗi lần chỉ được di chuyển 1 đĩa trên cùng của cọc \n - Đĩa nằm trên phải nhỏ hơn đĩa nằm dưới", "LUẬT CHƠI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region reset
            time.Stop(); i = 0;
            chiuthua t = new chiuthua();
            t.ShowDialog();
            foreach (PictureBox disk in disks) disk.Visible = false;
            txttime.Text = "0";
            movecount = 0; firstclickeddick = secondclickeddick = null;
            txtmovecount.Text = "0";
            disksA.Clear(); disksB.Clear(); disksC.Clear();
            piccota.BorderStyle = piccotb.BorderStyle = piccotc.BorderStyle = BorderStyle.None;
            btnplay.Visible = true;
            btnplayagain.Visible = false;
            btngiveup.Enabled = false;
            num.Enabled = true;
            
            #endregion
        }

        private void time_Tick(object sender, EventArgs e)
        {
            i++;
            txttime.Text = i.ToString() ;
        }

        private void btnplayagain_Click(object sender, EventArgs e)
        {
            #region reset
            time.Stop(); i = 0; num.Enabled = false;
             foreach (PictureBox disk in disks) disk.Visible = false;
             txttime.Text = "0";
             movecount = 0; firstclickeddick = secondclickeddick = null;
             txtmovecount.Text ="0";
             disksA.Clear(); disksB.Clear(); disksC.Clear();
             piccota.BorderStyle = piccotb.BorderStyle = piccotc.BorderStyle = BorderStyle.None;
             btnplay.Visible = true;
             btnplayagain.Visible = false;
             btngiveup.Enabled = false;
            #endregion
            #region khoitao
             btnplayagain.Visible = true;
             btnplay.Visible = false;
             btngiveup.Enabled = true;
             int x = 19;
             int y = firsty + 35;
             a = 0;
             for (a = 8; a >= (int)num.Value; a--)
             {
                 x = x + 10;
             }

             for (a = (int)num.Value - 1; a >= 0; --a)
             {
                 x = x + 10; y = y - 35;
                 disks[a].Location = new Point(x, y);
                 disks[a].Visible = true;
                 disksA.Push(disks[a]);
             }
             time.Start();


            #endregion
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            #region reset
            time.Stop(); i = 0;
            num.Enabled = false;
            foreach (PictureBox disk in disks) disk.Visible = false;
            txttime.Text = "0";
            movecount = 0; firstclickeddick = secondclickeddick = null;
            txtmovecount.Text = "0";
            disksA.Clear(); disksB.Clear(); disksC.Clear();
            piccota.BorderStyle = piccotb.BorderStyle = piccotc.BorderStyle = BorderStyle.None;
            btnplay.Visible = true;
            btnplayagain.Visible = false;
            #endregion

            #region khoitao
            btnplayagain.Visible = true;
            btnplay.Visible = false;
            btngiveup.Enabled = true;
            int x = 19;
            int y = firsty + 35; 
            a = 0;
            for (a = 8; a >= (int)num.Value; a--) 
            {
                x = x + 10;  
            }
         
           for (a = (int)num.Value -1; a >= 0; --a)
            {
                x = x + 10; y = y-35;
                disks[a].Location = new Point(x,y);
                disks[a].Visible = true;
                disksA.Push(disks[a]);
            }
                time.Start();


            #endregion

              
        }

        private void piccot_Click(object sender, EventArgs e)
        {
            
            if (num.Enabled) return;
            PictureBox clickcot = (PictureBox)sender;
            Stack<PictureBox> diskofclickcot = (Stack<PictureBox>)clickcot.Tag;
            if (firstclickeddick == null)
            {
                if (diskofclickcot.Count == 0)
                {
                    PlayMusic("sound1.wav");
                    return;
                }
                    
                firstclickeddick = diskofclickcot;
                clickcot.BorderStyle = BorderStyle.FixedSingle;
            } else if (secondclickeddick == null)
            {
                if (diskofclickcot == firstclickeddick)
                {
                    firstclickeddick = null;
                    clickcot.BorderStyle = BorderStyle.None;
                    return;
                }
                secondclickeddick = diskofclickcot;
                ProcessMovingDisk(clickcot);
            }

        }
        private void ProcessMovingDisk(PictureBox  clickcot)
        {
            int x = clickcot.Location.X+10;
            if (secondclickeddick.Count == 0)
            {
                
                for (a = 8; a >= int.Parse(firstclickeddick.Peek().Tag.ToString()); a--)
                {
                    x = x + 10;
                }
                
                MoveDick(new Point (x+10,firsty));

            } else
            {
                PictureBox firsttopdick =  firstclickeddick.Peek();
                PictureBox secondtopdick = secondclickeddick.Peek();
                if (int.Parse(firsttopdick.Tag.ToString()) < int.Parse(secondtopdick.Tag.ToString()))
                {
                    x = 20;
                    int y = firsty;

                    for (a = 8; a >= int.Parse(firstclickeddick.Peek().Tag.ToString()); a--)
                    {
                        x = x + 10;
                    }
                    x = clickcot.Location.X + x;
                    //MessageBox.Show(secondclickeddick.Count.ToString());
                    for (a = 1; a <= secondclickeddick.Count; a++) y = y - 35;
                    MoveDick(new Point(x, y));
                }
                else
                {
                    PlayMusic("sound1.wav");
                    secondclickeddick = null;
                }

            }
        }

        private void  MoveDick(Point point)
        {
            //MessageBox.Show(point.X.ToString() + " " + point.Y.ToString());
            PictureBox firsttopdick = firstclickeddick.Pop();
            firsttopdick.Location = point;
            secondclickeddick.Push(firsttopdick);
            ++movecount;
            txtmovecount.Text = movecount.ToString();
            firstclickeddick = secondclickeddick = null;
            piccota.BorderStyle = piccotb.BorderStyle = piccotc.BorderStyle = BorderStyle.None;

            if (disksC.Count == (int)num.Value)
            {
                
                chucmung1 f = new chucmung1();
                chucmung2 g = new chucmung2();
                time.Stop();
                switch (int.Parse(num.Value.ToString()))
                {
                    case 1: if (movecount == 1) PlayMusic("sound2.wav"); else PlayMusic("sound3.wav"); break;
                    case 2: if (movecount == 3) PlayMusic("sound2.wav"); else PlayMusic("sound3.wav"); break;
                    case 3: if (movecount == 7) PlayMusic("sound2.wav"); else PlayMusic("sound3.wav"); break;
                    case 4: if (movecount == 15) PlayMusic("sound2.wav"); else PlayMusic("sound3.wav"); break;
                    case 5: if (movecount == 31) PlayMusic("sound2.wav"); else PlayMusic("sound3.wav"); break;
                    case 6: if (movecount == 63) PlayMusic("sound2.wav"); else PlayMusic("sound3.wav"); break;
                    case 7: if (movecount == 127) PlayMusic("sound2.wav"); else PlayMusic("sound3.wav"); break;
                    case 8: if (movecount == 255) PlayMusic("sound2.wav"); else PlayMusic("sound3.wav"); break;
                };
                switch (int.Parse(num.Value.ToString()))
                {
                    case 1: if (movecount == 1) f.ShowDialog(); else g.ShowDialog();  break;
                    case 2: if (movecount == 3) f.ShowDialog(); else g.ShowDialog(); break;
                    case 3: if (movecount == 7) f.ShowDialog(); else g.ShowDialog(); break;
                    case 4: if (movecount == 15) f.ShowDialog(); else g.ShowDialog(); break;
                    case 5: if (movecount == 31) f.ShowDialog(); else g.ShowDialog(); break;
                    case 6: if (movecount == 63) f.ShowDialog(); else g.ShowDialog(); break;
                    case 7: if (movecount == 127) f.ShowDialog(); else g.ShowDialog(); break;
                    case 8: if (movecount == 255) f.ShowDialog(); else g.ShowDialog(); break;
                };
                switch (int.Parse(num.Value.ToString()))
                {
                    case 1: if (movecount == 1) StopMusic("sound2.wav"); else StopMusic("sound3.wav"); break;
                    case 2: if (movecount == 3) StopMusic("sound2.wav"); else StopMusic("sound3.wav"); break;
                    case 3: if (movecount == 7) StopMusic("sound2.wav"); else StopMusic("sound3.wav"); break;
                    case 4: if (movecount == 15) StopMusic("sound2.wav"); else StopMusic("sound3.wav"); break;
                    case 5: if (movecount == 31) StopMusic("sound2.wav"); else StopMusic("sound3.wav"); break;
                    case 6: if (movecount == 63) StopMusic("sound2.wav"); else StopMusic("sound3.wav"); break;
                    case 7: if (movecount == 127) StopMusic("sound2.wav"); else StopMusic("sound3.wav"); break;
                    case 8: if (movecount == 255) StopMusic("sound2.wav"); else StopMusic("sound3.wav"); break;
                };
                time.Stop(); i = 0; num.Enabled = true;
                foreach (PictureBox disk in disks) disk.Visible = false;
                txttime.Text = "0";
                movecount = 0; firstclickeddick = secondclickeddick = null;
                txtmovecount.Text = "0";
                disksA.Clear(); disksB.Clear(); disksC.Clear();
                piccota.BorderStyle = piccotb.BorderStyle = piccotc.BorderStyle = BorderStyle.None;
                btnplay.Visible = true;
                btnplayagain.Visible = false;
                btngiveup.Enabled = false;
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox clickdisk = (PictureBox)sender;
            if (disksA.Contains(clickdisk))
                piccot_Click(piccota, new EventArgs());
            else if (disksB.Contains(clickdisk))
                piccot_Click(piccotb, new EventArgs());
            else if (disksC.Contains(clickdisk))
                piccot_Click(piccotc, new EventArgs());

        }

    
    }
}
