using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DIsk_Scheduling
{
    public partial class frmMain : Form
    {
        private int Win_Width = 1920;
        private int Win_Height = 1080;
        private int HeadPosition;
        private int maxTrack = 199;

        private List<int> xData = new List<int> ();
        private List<int> requestQueue = new List<int>();
        private List<int> result = new List<int>();
        private List<int> paintQueue = new List<int>();

        Random random = new Random();
        private int randomA = 0;
        private int randomB = 199;

        private Timer timer = new Timer();

        private int currentStep = 0;
        private bool isAnimating = false;

        private Image Play_IMG = Properties.Resources.play;
        private Image Pause_IMG = Properties.Resources.pause;
        public frmMain()
        {
            InitializeComponent();
            this.Size = new Size(Win_Width, Win_Height);
            btn_ToLeft.Enabled = false;
            btn_ToRight.Enabled = false;
            

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            HeadValue.Minimum = 0; 
            HeadValue.Maximum = maxTrack;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lb_Time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            if (isAnimating && paintQueue.Count > 0)
            {
                currentStep++;
                if (currentStep >= paintQueue.Count)
                {
                    isAnimating = false; // hoàn tất animation
                }
                panel_Graph.Invalidate(); // vẽ lại
            }
        }
        private bool UserInput()
        {
            if (txt_HeadValue.Text == string.Empty || txt_Input.Text == string.Empty)
            {
                MessageBox.Show("Please type enough input to start", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_HeadValue.Focus();
                return false;
            }
            if (int.TryParse(txt_HeadValue.Text, out int value))
            {
                if (value < 0 || value > maxTrack)
                {
                    MessageBox.Show($"Please enter a value between {0} and {maxTrack} !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_HeadValue.Focus();
                    return false;
                }
                HeadValue.Value = value;
                HeadPosition = value;
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the head position!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_HeadValue.Focus();
                return false;
            }
            try
            {
                xData = txt_Input.Text.Split(',').Select(s => int.Parse(s.Trim())).ToList();
                foreach (var x in xData)
                {
                    if (x < 0 || x > maxTrack)
                    {
                        MessageBox.Show($"Please enter a value between {0} and {maxTrack} !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_Input.Focus();
                        return false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid input! Please enter numbers separated by commas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Input.Focus();
                return false;
            }
            return true;
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            txt_SeekCnt.Clear();
            if (!UserInput()) return;
       
            if (!btn_FCFS.Checked && !btn_SSTF.Checked && !btn_Scan.Checked && !btn_cscan.Checked && !btn_clook.Checked && !btn_Look.Checked)
            {
                MessageBox.Show("Please select type to start", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (btn_FCFS.Checked)
            {
                FCFS();
            }
            else if (btn_SSTF.Checked)
            {
                SSTF();
            }
            else
            {
                if (!btn_ToLeft.Checked && !btn_ToRight.Checked)
                {
                    MessageBox.Show("Please choose type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (btn_Scan.Checked)
                {
                    SCAN();
                }
                if (btn_cscan.Checked)
                {
                    CSCAN();
                }
                if (btn_clook.Checked)
                {
                    CLOOK();
                }
                if (btn_Look.Checked)
                {
                    LOOK();
                }
            }
            currentStep = 0;
            isAnimating = true; // bắt đầu animation
            btnPause.Enabled = true;
            btnRedo.Enabled = true;
            btnUndo.Enabled = true;
            panel_Graph.Invalidate();
        }
        private void resetAll()
        {
            btn_FCFS.Checked = false;   
            btn_Scan.Checked = false;
            btn_SSTF.Checked = false;
            btn_cscan.Checked = false;
            btn_clook.Checked = false;
            btn_Look.Checked = false;
            btn_ToLeft.Checked = false;
            btn_ToRight.Checked = false;   

            txt_Input.Clear();
            txt_SeekCnt.Clear();
            txt_HeadValue.Clear();
            paintQueue.Clear();
            result.Clear();
            xData.Clear();
            requestQueue.Clear();

            btnPause.Enabled = false;
            btnRedo.Enabled = false;
            btnUndo.Enabled = false;

            panel_Graph.Invalidate();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            resetAll();
        }
        private int RandomValues(int RangeA, int RangeB, int distance, List<int> listRand) // Random từ A->B với khoảng cách các giá trị >= distance
        {
            if (RangeA > RangeB) 
            {
                int temp = RangeA;
                RangeA = RangeB;
                RangeB = temp;
            }
            int rnd = 0;
            bool ok = true;
            do
            {
                ok = true;
                rnd = random.Next(RangeA, RangeB);
                foreach (int j in listRand)
                {
                    if (Math.Abs(j - rnd) < distance || j == rnd)
                    {
                        ok = false;
                        break;
                    }
                }
            }
            while (!ok);
            return rnd;
        }
        private void btn_FillRandom_Click(object sender, EventArgs e)
        {
            txt_HeadValue.TextChanged -= txt_HeadValue_TextChanged;
            resetAll();
            string s = string.Empty;
            int n = random.Next(8, 15);
            int rnd = 0;
            for (int i = 0; i <= n; i++)
            {
                rnd = RandomValues(randomA, randomB, 4, requestQueue);
                if (i == n) 
                {
                    rnd = RandomValues(requestQueue.Min(), requestQueue.Max(), 4, requestQueue);
                    break;
                }
                requestQueue.Add(rnd);
                s += rnd.ToString();
                if (i < n - 1) s += ", ";
            }
            HeadValue.Value = rnd;
            txt_HeadValue.Clear();
            txt_HeadValue.Text = rnd.ToString();
            txt_Input.Clear();
            txt_Input.Text = s;
            txt_HeadValue.TextChanged += txt_HeadValue_TextChanged;
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Input.Clear();
            txt_SeekCnt.Clear();
            txt_HeadValue.Clear();

            paintQueue.Clear();
            result.Clear();
            xData.Clear();
            requestQueue.Clear();
        }
        private void DrawArrowFilled(Graphics g, int x1, int y1, int x2, int y2, float arrowLength, float arrowAngle)
        {
            double angle = Math.Atan2(y2 - y1, x2 - x1);

            PointF arrowP1 = new PointF(
                x2 - arrowLength * (float)Math.Cos(angle - Math.PI / 180 * arrowAngle),
                y2 - arrowLength * (float)Math.Sin(angle - Math.PI / 180 * arrowAngle)
            );

            PointF arrowP2 = new PointF(
                x2 - arrowLength * (float)Math.Cos(angle + Math.PI / 180 * arrowAngle),
                y2 - arrowLength * (float)Math.Sin(angle + Math.PI / 180 * arrowAngle)
            );

            PointF[] triangle = new PointF[] { new PointF(x2, y2), arrowP1, arrowP2 };
            g.FillPolygon(Brushes.Red, triangle);
        }
        private void panel_Graph_Paint(object sender, PaintEventArgs e)
        {
            if (paintQueue.Count <= 0)
            {
                return;
            }

            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);

            var list = xData.ToList();
            list.Add(HeadPosition);
            list.Sort();
            // Tính toán khoảng cách
            int panelWidth = panel_Graph.Width;
            int panelHeight = panel_Graph.Height;
            int marginLR = 20; // lề trái và phải
            int marginTB = 25; // lề trên và dưới
            int timelineLength = panelWidth - 2 * marginLR;

            int minValue = list.Min();
            int maxValue = list.Max();
            
            // Vẽ trục timeline
            int y = marginTB;
            g.DrawLine(pen, marginLR, y, panelWidth - marginLR, y);

            // Vẽ từng mốc trên timeline
            foreach (int value in list)
            {
                float percent = (float)(value - minValue) / (maxValue - minValue); // giá trị tương đối
                int x = marginLR + (int)(percent * timelineLength);

                // Ghi nhãn
                string label = value.ToString();
                Font font = new Font("Segoe UI", 10, FontStyle.Bold);
                SizeF size = g.MeasureString(label, font);
                g.DrawString(label, font, Brushes.Black, x - size.Width / 2, y - 25);
                
                // Vẽ tick
                using (Pen dashedPen = new Pen(Color.Blue, 2f)) // 4f hoặc 5f tùy độ dày bạn muốn
                {
                    dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    g.DrawLine(dashedPen, x, y - 10, x, y + Win_Height);
                }
                updateButton();
            }

            int n = paintQueue.Count;
            int startY = marginTB;
            int endY = panel_Graph.Height - 50;
            int totalHeight = endY - startY;
            int segmentHeight = totalHeight / n;

            // Vẽ đường nối theo thứ tự trong result
            int yBase = marginTB;
            if (paintQueue.Count > 0)
            {
                int total = paintQueue.Count;
                int marginTop = marginTB;
                int marginBottom = 10;
                int availableHeight = panel_Graph.Height - marginTop - marginBottom;
                int totalPoints = 1 + paintQueue.Count;
                int spacing = availableHeight / Math.Max(totalPoints - 1, 1);

                int currentHead = HeadPosition; // hoặc HeadPosition nếu có

                List<int> xPoints = new List<int>();
                List<int> yPoints = new List<int>();

                // Tính sẵn các điểm (gồm điểm đầu - currentHead)
                for (int i = 0; i <= total; i++)
                {
                    int val = (i == 0) ? currentHead : paintQueue[i - 1];
                    float percent = (float)(val - minValue) / (maxValue - minValue);
                    int x = marginLR + (int)(percent * timelineLength);
                    y = marginTop + i * spacing;

                    xPoints.Add(x);
                    yPoints.Add(y);
                }

                int drawUntil = Math.Min(currentStep, paintQueue.Count);
                for (int i = 0; i < drawUntil; i++)
                {
                    int x1 = xPoints[i];
                    int y1 = yPoints[i];
                    int x2 = xPoints[i + 1];
                    int y2 = yPoints[i + 1];

                    using (Pen mainPen = new Pen(Color.Black, 3f))
                    {
                        g.DrawLine(mainPen, x1, y1, x2, y2);
                    }

                    int radius = 16; // Hinh tron to nho (R)
                    g.FillEllipse(Brushes.DarkGray, x1 - radius / 2, y1 - radius / 2, radius, radius);
                    g.FillEllipse(Brushes.DarkGray, x2 - radius / 2, y2 - radius / 2, radius, radius);

                    DrawArrowFilled(g, x1, y1, x2, y2, 20, 30);
                }
            }
        }
        private int calSeekCount()
        {
            int tmp = HeadPosition;
            int seekCount = 0;
            foreach(int x in result)
            {
                seekCount += Math.Abs(x - tmp);
                tmp = x;
            }
            return seekCount;
        }
        private void FCFS()
        {
            int res = HeadPosition;
            result = xData;
            paintQueue = xData;
            txt_SeekCnt.Text = calSeekCount().ToString();
        }
        private void SSTF()
        {
            int removeE = HeadPosition;
            var lists = xData.ToList();
            while (lists.Count > 0) 
            {
                int tmp = 0;
                int sum = int.MaxValue;
                foreach (int i in lists)
                {
                    if (sum > Math.Abs(removeE - i))
                    {
                        sum = Math.Abs(removeE - i);
                        tmp = i;
                    }
                }

                removeE = tmp;
                result.Add(tmp);
                lists.Remove(removeE);
            }
            
            txt_SeekCnt.Text = calSeekCount().ToString();
            paintQueue = result;
        }
        private void splitXData(ref List<int> left, ref List<int> right, bool Larger)
        {
            foreach (int i in xData)
            {
                if (i == HeadPosition)
                {
                    if (Larger) right.Add(i);
                    else left.Add(i);
                }
                else if (i < HeadPosition) left.Add(i);
                else right.Add(i);
            }
        }
        private void SCAN()
        {
            bool toward = true;

            if (btn_ToLeft.Checked)
            {
                toward = false;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            splitXData(ref left, ref right, toward);

            if (toward && !right.Contains(maxTrack))
            {
                right.Add(maxTrack);
                xData.Add(maxTrack);
            }
            else if (!toward && !left.Contains(0))
            {
                left.Add(0);
                xData.Add(0);
            }

            right.Sort();
            left.Sort((a, b) => b.CompareTo(a));

            if (toward) result = right.Concat(left).ToList();
            else result = left.Concat(right).ToList();

            txt_SeekCnt.Text = calSeekCount().ToString();
            paintQueue = result;
        }
        private void CSCAN()
        {
            bool larger = true;

            if (btn_ToLeft.Checked)
            {
                larger = false;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            splitXData(ref left, ref right, larger);

            if (!right.Contains(maxTrack))
            {
                right.Add(maxTrack);
                xData.Add(maxTrack);
            }

            if (!left.Contains(0))
            {
                left.Add(0);
                xData.Add(0);
            }

            if (larger)
            {
                right.Sort();
                left.Sort();
                result = right.Concat(left).ToList();
            }
            else
            {
                Comparison<int> com = (a, b) => b.CompareTo(a);
                right.Sort(com);
                left.Sort(com);
                result = left.Concat(right).ToList();
            }

            paintQueue = result;
            txt_SeekCnt.Text = calSeekCount().ToString();
        }
        private void LOOK()
        {
            bool larger = true;

            if (btn_ToLeft.Checked)
            {
                larger = false;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            splitXData(ref left, ref right, larger);

            right.Sort();
            left.Sort((a, b) => b.CompareTo(a));

            if (larger) result = right.Concat(left).ToList();
            else result = left.Concat(right).ToList();

            paintQueue = result;
            txt_SeekCnt.Text = calSeekCount().ToString();
        }
        private void CLOOK()
        {
            bool larger = true;

            if (btn_ToLeft.Checked)
            {
                larger = false;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            splitXData(ref left, ref right, larger);

            if (larger)
            {
                right.Sort();
                left.Sort();
                result = right.Concat(left).ToList();
            }
            else
            {
                Comparison<int> com = (a, b) => b.CompareTo(a);
                right.Sort(com);
                left.Sort(com);
                result = left.Concat(right).ToList();
            }

            paintQueue = result;
            txt_SeekCnt.Text = calSeekCount().ToString();
        }
        private void HeadValue_ValueChanged(object sender, EventArgs e)
        {
            int data = (int)HeadValue.Value;
            HeadPosition = data;
            txt_HeadValue.Text = data.ToString();
            currentStep = 0;
            isAnimating = true; // bắt đầu animation
            panel_Graph.Invalidate();
            
        }
        private void txt_HeadValue_TextChanged(object sender, EventArgs e)
        {
            if (txt_HeadValue.Text == string.Empty)
            {
                HeadValue.Value = 0;
                txt_HeadValue.Text = string.Empty;
                return;
            }
            if (int.TryParse(txt_HeadValue.Text, out int value))
            {
                // Gán giá trị vào HeadValue và HeadPosition nếu hợp lệ
                value = Math.Max((int)HeadValue.Minimum, Math.Min((int)HeadValue.Maximum, value));
                HeadValue.Value = value;
                HeadPosition = value;
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the head position!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_Scan_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_Scan.Checked || btn_cscan.Checked || btn_clook.Checked || btn_Look.Checked)
            {
                btn_ToLeft.Enabled = true;
                btn_ToRight.Enabled = true;
            }
            else
            {
                btn_ToLeft.Enabled = false;
                btn_ToRight.Enabled = false;
            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            isAnimating = !isAnimating;
            if (isAnimating)
            {
                btnPause.Image = Pause_IMG;
            }
            else
            {
                btnPause.Image = Play_IMG;
            }
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (currentStep > 0)
            {
                currentStep--;
                isAnimating = false;
                panel_Graph.Invalidate(); // vẽ lại
                btnPause.Image = Play_IMG;
            }
        }
        private void btnRedo_Click(object sender, EventArgs e)
        {
            int n = paintQueue.Count;
            if (currentStep < n)
            {
                currentStep++;
                isAnimating = false;
                panel_Graph.Invalidate(); // vẽ lại
                btnPause.Image = Play_IMG;
            }
        }
        private void updateButton()
        {
            int n = paintQueue.Count;
            if(currentStep == n)
            {
                btnRedo.Enabled = false;
                btnPause.Enabled = false;
            } 
            else if(currentStep == 0) {
                btnUndo.Enabled = false;
            }
            else
            {
                btnUndo.Enabled = true;
                btnRedo.Enabled = true;
                btnPause.Enabled = true;
            }
        }
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp helpForm = new frmHelp();
            helpForm.ShowDialog();
        }
    }
}
