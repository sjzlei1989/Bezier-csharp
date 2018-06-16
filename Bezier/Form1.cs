using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bezier
{
    public partial class Bezier : Form {
        const int DOTWIDTH = 10;
        Graphics g;
        List<PointF> dots = new List<PointF>();
        int _controlPointsCount = 0;
        int controlPointsCount {
            set {
                _controlPointsCount = value;
                trackBarValueLabel.Text = _controlPointsCount.ToString();
            }
            get {
                return _controlPointsCount;
            }
        }

        /// <summary>
        /// 是否已经画过线了
        /// </summary>
        bool drawed = false;
        public Bezier() {
            InitializeComponent();
            controlPointsCount = trackBar.Value;
            Image img = new Bitmap(pictrueBox.Width, pictrueBox.Height);
            pictrueBox.Image = img;
            g = Graphics.FromImage(img);
            g.Clear(Color.White);
        }

        private void trackBar_valueChanged(object sender, EventArgs e) {
            controlPointsCount = trackBar.Value;
        }

        private void pictureBox_Click(object sender, EventArgs e) {
            if(drawed) {
                drawed = false;
                dots.Clear();
                g.Clear(Color.White);
                pictrueBox.Refresh();
                return;
            }
            if(dots.Count < controlPointsCount) {
                MouseEventArgs margs = e as MouseEventArgs;
                DrawDot(g, Brushes.Red, margs.X, margs.Y, DOTWIDTH);
                pictrueBox.Refresh();
                string str = string.Format("[{0}, {1}]", margs.X, margs.Y);
                g.DrawString(str, new Font("宋体", 10), Brushes.Green, 10, 10 + dots.Count * 20);
                pictrueBox.Refresh();
                dots.Add(margs.Location);
                if(dots.Count == controlPointsCount) {
                    //TODO 开始画线
                    List<Segment> segs = new List<Segment>();
                    for(int i = 0; i < dots.Count - 1; i++) {
                        g.DrawLine(Pens.Gray, dots[i], dots[i + 1]);
                        segs.Add(new Segment(dots[i], dots[i + 1]));
                    }
                    float radio = 0.0f; //比例
                    float step = 0.001f; //步进值
                    while(radio <= 1.0f) {
                        DrawDot(g, Brushes.Green, FindBezierPoint(dots.ToArray(), radio), 3);
                        pictrueBox.Refresh();
                        radio += step;
                        System.Threading.Thread.Sleep(5);
                    }
                    drawed = true;
                }
            }
        }

        private PointF FindBezierPoint(PointF[] _points, float _r) {
            var segs = GetSegments(_points);
            if(segs == null) {
                throw new Exception("no segments");
            }
            if(segs.Length == 1) {
                return segs[0].GetPointByDistance(_r);
            }
            else {
                List<PointF> tmpPoints = new List<PointF>();
                for(int i = 0; i < segs.Length; i++) {
                    tmpPoints.Add(segs[i].GetPointByDistance(_r));
                }
                return FindBezierPoint(tmpPoints.ToArray(), _r);
            }
        }

        private Segment[] GetSegments(PointF[] _points) {
            if(_points.Length <= 1) {
                return null;
            }
            List<Segment> segs = new List<Segment>();
            for(int i = 0; i < _points.Length - 1; i++) {
                Segment s = new Segment(_points[i], _points[i + 1]);
                segs.Add(s);
            }
            return segs.ToArray();
        }

        private void DrawDot(Graphics _g, Brush _b, PointF _p, float _width) {
            DrawDot(_g, _b, _p.X, _p.Y, _width);
        }
        private void DrawDot(Graphics _g, Brush _b, float _x, float _y, float _width) {
            _g.FillEllipse(_b, new RectangleF(_x - _width / 2, _y - _width / 2, _width, _width));
        }
        private void DrawSegment(Graphics _g, Pen _p, Segment _s) {
            _g.DrawLine(_p, _s.start, _s.end);
        }
    }

    public class Segment
    {
        public PointF start;
        public PointF end;

        public Segment(PointF _s, PointF _e) {
            start = _s;
            end = _e;
        }

        /// <summary>
        /// 获取距离起点一定距离的点的坐标
        /// </summary>
        /// <param name="_d"></param>
        /// <returns></returns>
        public PointF GetPointByDistance(float _d) {
            if(_d < 0 || _d > 1) {
                return Point.Empty;
            }
            return new PointF(start.X + (end.X - start.X) * _d, start.Y + (end.Y - start.Y) * _d);
        }
    }
}
