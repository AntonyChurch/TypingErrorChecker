using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace NumberOfBackspaces
{
    public partial class form : Form
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private LowLevelKeyboardProc _proc;
        private IntPtr _hookID = IntPtr.Zero;
        private bool counting = false;
        private int errorCount = 0;
        private int wordsTyped = 0;
        private double errorsPerWord = 0;
        private double errorsPerMinute = 0;
        private Stopwatch loggedTime = new Stopwatch();
        private Timer updateTitleTimer = new Timer();

        public form()
        {
            InitializeComponent();

            _proc = HookCallback;
            updateTitleTimer.Interval = 1000;
            updateTitleTimer.Tick += updateTitleTimer_Tick;
            updateTitleTimer.Start();
        }

        void updateTitleTimer_Tick(object sender, EventArgs e)
        {
            if (counting)
            {
                this.Text = "Count Errors for: " + (int)(loggedTime.ElapsedMilliseconds / 1000) + " seconds";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetHook(_proc);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            loggedTime.Start();
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
            counting = true;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            loggedTime.Stop();
            stopBtn.Enabled = false;
            startBtn.Enabled = true;
            counting = false;
            this.Text = "Count Errors";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            errorCount = 0;
            wordsTyped = 0;

            countLabel.Text = "Count: 0";
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(
        int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                if ((Keys)vkCode == Keys.Back)
                {
                    if (counting)
                    {
                        ++errorCount;                        
                        errorsPerWord = wordsTyped / errorCount;
                        errorsPerMinute = (loggedTime.ElapsedMilliseconds / 1000 / 60) / errorCount;
                        countLabel.Text = "Count: " + errorCount;
                        mistakesPerMinuteLbl.Text = "MPM: " + errorsPerMinute.ToString("0.00");
                        mistakesPerWordLbl.Text = "MPW: " + errorsPerWord.ToString("0.00");
                    }
                }
                else if ((Keys)vkCode == Keys.Space)
                {
                    if (counting)
                    {
                        ++wordsTyped;
                        wordsCountedLbl.Text = "Words: " + wordsTyped;
                    }
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        
    }
}
