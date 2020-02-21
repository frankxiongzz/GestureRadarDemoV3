using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;

namespace GestureRadarDemoV3
{
    public partial class Form1 : MetroForm
    {
        public class Point3D
        {
            public float x, y, z;
            public Point3D(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        };

        private Size originalSize;
        private Size originalXYSize;
        private Size originalYZSize;

        private int mAverageZ = 256;

        private List<Point3D> path3DList;

        //使用GestureRadarSDK进行开发，用C#调用C++的DLL读取串口
        private delegate void GestureRadarSDKCallBack(float x, float y, float z);
        private delegate void GestureRadarSDKSwipeCallBack(string strName);
        private delegate void GestureRadarSDKTrailCallBack(string strName, double score, float minX, float maxX, float minY, float maxY, float z);


        private static GestureRadarSDKCallBack callBackHandle;
        private static GestureRadarSDKTrailCallBack trailSDKRecogniseHandle;
        private static GestureRadarSDKSwipeCallBack swipeSDKRecogniseHandle;

        [DllImport("GestureRadarSDK")]
        private static extern void tvt_register_loop_callBack(bool bRecognizeSwipe,
            bool bRecognizeTrail,
            int nTemplateNum,
            string[] strTemplateNames,
            GestureRadarSDKCallBack callBack,
            GestureRadarSDKSwipeCallBack swipeCallBack,
            GestureRadarSDKTrailCallBack trailCallBack);

        [DllImport("GestureRadarSDK")]
        private static extern void tvt_release_loop_callBack();

        [DllImport("GestureRadarSDK")]
        public static extern bool tvt_write_raw_data(Byte[] rawData, int rawDataLen);

        public delegate void SetPanelCallBack();

        public void GestureRadarReceiveData(float x, float y, float z)
        {
            if (z > mAverageZ)
            {
                path3DList.Add(new Point3D(x, y, z));
                if (path3DList.Count > 10)
                {
                    path3DList.RemoveAt(0);
                }
                return;
            }
            else
            {
                path3DList.Add(new Point3D(x, y, z));
                if (path3DList.Count > 10)
                {
                    path3DList.RemoveAt(0);
                }
                picBoxXY.Invalidate();

                SetPanelCallBack d = delegate
                {
                    metroProgressBarZ.Value = (int)z;
                    metroLabelZ.Text = z.ToString();
                };
                metroProgressBarZ.Invoke(d);
            }
        }
        public void GestureRadarTraildata(string strName, double score, float minX, float maxX, float minY, float maxY, float z)
        {
        }
        public void GestureRadarSwipeData(string strName)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path3DList = new List<Point3D>();

            callBackHandle = GestureRadarReceiveData;
            trailSDKRecogniseHandle = GestureRadarTraildata;
            swipeSDKRecogniseHandle = GestureRadarSwipeData;
            tvt_register_loop_callBack(false, false, 0, null, callBackHandle, swipeSDKRecogniseHandle, trailSDKRecogniseHandle);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.originalSize.Width == 0 || this.originalSize.Height == 0)
            {
                return;
            }

            float RadioW = (float)this.Size.Width / (float)originalSize.Width;

            picBoxXY.Width = (int)(originalXYSize.Width * RadioW);
            picBoxYZ.Width = (int)(originalYZSize.Width * RadioW);

        }

        private void picBoxXY_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            float nResizeRadioW = (float)picBoxXY.Width / 80;
            float nResizeRadioH = (float)picBoxXY.Height / 80;

            for (int i = 0; i < path3DList.Count; i++)
            {
                Point3D point = path3DList[i];
                brush.Color = Color.FromArgb(25 * i, Color.Black);
                e.Graphics.FillEllipse(brush, (point.x + 40) * nResizeRadioW, (80 - (point.y + 40)) * nResizeRadioH, 10, 10);
            }

        }

        public bool isShowParam = false;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (isShowParam)
            {
                isShowParam = false;
                this.Width -= 200;
            }
            else
            {
                isShowParam = true;
                this.Width += 200;
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine(metroTextBoxMsg.Text);
            byte[] byteArray = System.Text.Encoding.Default.GetBytes(metroTextBoxMsg.Text);
            byte[] sendArray = new byte[byteArray.Length + 2];
            for (int i = 0; i < byteArray.Length; i++)
            {
                sendArray[i] = byteArray[i];
            }
            sendArray[sendArray.Length - 2] = 0x0D;
            sendArray[sendArray.Length - 1] = 0x0A;
            tvt_write_raw_data(sendArray, sendArray.Length);
            metroTextBoxMsg.Clear();
        }
    }
}
