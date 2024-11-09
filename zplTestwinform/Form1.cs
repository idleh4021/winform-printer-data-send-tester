using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Sockets;
using ZPLEditor;

namespace zplTestwinform
{
    public partial class Form1 : Form
    {
        private string zpl = "";
        private Timer timer = new Timer();

        ZPLMaker maker;

        public Form1()
        {
            InitializeComponent();
            Loadprinter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maker = new ZPLMaker();
            

            btn_macro_stop.Enabled = false;
            timer.Tick += new EventHandler(TimerTick);
            tEdit_Interval.DecimalPlaces = 1;

            //초기값
            tBoxIPAddress.Text = "192.168.0.255";
            tBoxPort.Text = "9100";

            //테스트용 명령어 초기값
            //tbox_Data.Text = "^XA\r\n^SEE:UHANGUL.DAT^FS\r\n^CW1,E:KFONT3.FNT^CI26^FS\r\n^FO50,10^A1,40,40^FD테스트1^FS\r\n^FO50,50^A1,40,40^FD테스트2^FS\r\n^XZ";
        }

        private void Loadprinter()
        {
            //foreach (string printer in PrinterSettings.InstalledPrinters)

            //{
            //    this.cbox_Printer.Items.Add(printer.ToString());

            //    PrinterSettings p = new PrinterSettings();

            //    p.PrinterName = printer;

            //    if (p.IsDefaultPrinter)

            //    {
            //        cbox_Printer.Text = p.PrinterName.ToString();
            //    }
            //}

            cbox_Printer.DataSource = PrinterDriver.getList();
            cbox_Printer.SelectedItem = PrinterDriver.getDefaultDriver();

        }

        public void PrintUSB(string PrinterName, string strcmd)
        {
            //string PrintName = getPrinterName(sectionName);

            IntPtr pUnmanagedBytes = new IntPtr(0);
            int nLength;
            try
            {
                byte[] byteData = Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding("euc-kr"), Encoding.UTF8.GetBytes(strcmd));
                nLength = Convert.ToInt32(byteData.Length);
                pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
                Marshal.Copy(byteData, 0, pUnmanagedBytes, nLength);
                RawPrinterHelper.SendBytesToPrinter(PrinterName, pUnmanagedBytes, nLength);
                Marshal.FreeCoTaskMem(pUnmanagedBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Usb Printer Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void btn_sendUSB_Click(object sender, EventArgs e)
        {
            zpl = tbox_Data.Text;
            PrintUSB(cbox_Printer.SelectedItem.ToString(), zpl);
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            tbox_filepath.Text = ShowFileOpenDialog();
        }

        public string ShowFileOpenDialog()
        {
            //파일오픈창 생성 및 설정
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "전송 파일 선택",
                FileName = "",
                Filter = "모든 파일 (*.*) | *.*"
            };

            //파일 오픈창 로드
            DialogResult dr = ofd.ShowDialog();

            //OK버튼 클릭시
            if (dr == DialogResult.OK)
            {
                //File명과 확장자를 가지고 온다.
                string fileName = ofd.SafeFileName;
                //File경로와 File명을 모두 가지고 온다.
                string fileFullName = ofd.FileName;
                //File경로만 가지고 온다.
                string filePath = fileFullName.Replace(fileName, "");

                return fileFullName;
            }
            //취소버튼 클릭시 또는 ESC키로 파일창을 종료 했을경우
            else if (dr == DialogResult.Cancel)
            {
                return "";
            }

            return "";
        }

        private void btn_sendfile_Click(object sender, EventArgs e)
        {
            //string data = File.ReadAllText(tbox_filepath.Text);

            var sr = new StreamReader(tbox_filepath.Text, System.Text.Encoding.GetEncoding(949));
            string sendData = sr.ReadToEnd();
            PrintUSB(cbox_Printer.Text, sendData);
            if (sr != null)
            {
                sr.Close();
            }
            /*
            if (File.Exists(tbox_filepath.Text))
            {
                System.IO.File.Copy(tbox_filepath.Text, cbox_Printer.Text);
            }
            else
            {
                MessageBox.Show("파일이 존재하지 않습니다.", "경고");
            }
            */
        }

        private void btn_macro_start_Click(object sender, EventArgs e)
        {
            var sec = tEdit_Interval.Value;

            if (sec == 0)
            {
                MessageBox.Show("인터벌을 입력하세요");
                return;
            }
            if (tbox_Data.Text == "" || tbox_Data.Text == null)
            {
                MessageBox.Show("전송 데이터를 입력하세요");
                return;
            }

            var interval = 1000 * sec;

            try
            {
                timer.Interval = Convert.ToInt32(interval);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            cbox_Printer.Enabled = false;
            btn_macro_start.Enabled = false;
            tEdit_Interval.Enabled = false;
            tbox_Data.Enabled = false;
            btn_macro_stop.Enabled = true;

            TimerTick(this, e);
            timer.Start();
        }

        private int GetRadioConnect()
        {
            if (rBtnDriver.Checked)
                return 1;
            else if (rBtnFile.Checked)
                return 2;
            else if (rBtnSocket.Checked)
                return 3;
            else
                return 0;
        }

        private void btn_macro_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            cbox_Printer.Enabled = true;
            btn_macro_start.Enabled = true;
            tEdit_Interval.Enabled = true;
            tbox_Data.Enabled = true;
            btn_macro_stop.Enabled = false;
        }

        private void TimerTick(object sender, System.EventArgs e)
        {
            switch (GetRadioConnect())
            {
                case 1:
                    btn_sendUSB.PerformClick();
                    break;
                case 2:
                    btn_sendfile.PerformClick();
                    break;
                case 3:
                    btn_SocketSend.PerformClick();
                    break;
                case 0:
                default:
                    btn_macro_stop.PerformClick();
                    MessageBox.Show("잘못된 선택입니다.");
                    break;
            }
        }

        private void btn_SocketSend_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(tBoxIPAddress.Text);
                TcpClient client = new TcpClient(ip.ToString(), int.Parse(tBoxPort.Text));
                NetworkStream networkStream = client.GetStream();

                //한글사용을 위한 인코딩 사용
                StreamWriter streamWriter = new StreamWriter(networkStream, Encoding.Default);
                streamWriter.Write(tbox_Data.Text);
                streamWriter.Flush();

                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}