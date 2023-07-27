using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Collections;
using WebSocketSharp;
using WebSocketSharp.Server;
using CSCore.SoundIn;
using System.Diagnostics;
using Microsoft.Win32.SafeHandles;
using System.Threading;
using System.Globalization;
using System.Drawing.Drawing2D;
using CSCore.Streams;
using System.Drawing.Imaging;
using NAudio.Wave;
using NAudio;
using NAudio.Extras;

namespace DesktopController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("winmm.dll", EntryPoint = "timeBeginPeriod")]
        public static extern uint TimeBeginPeriod(uint ms);
        [DllImport("winmm.dll", EntryPoint = "timeEndPeriod")]
        public static extern uint TimeEndPeriod(uint ms);
        [DllImport("ntdll.dll", EntryPoint = "NtSetTimerResolution")]
        public static extern void NtSetTimerResolution(uint DesiredResolution, bool SetResolution, ref uint CurrentResolution);
        public static uint CurrentResolution = 0;
		public static bool closed = false, scanning = false, running = false, listening1 = false, playing1 = false, listening2 = false, playing2 = false, listening3 = false, playing3 = false;
		public static WebSocketServer wssaudio;
		public static byte[] audiorawdataavailable;
		public static WasapiCapture soundIn = new CSCore.SoundIn.WasapiLoopbackCapture();
		public static WebSocket wscaudio1, wscaudio2, wscaudio3;
		public static string currentAudioBytes = null;
		public static BufferedWaveProvider src1, src2, src3;
		public static WaveOut soundOut1, soundOut2, soundOut3;
		public static EqualizerBand[] bands;
		public static float volumeleft, volumeright;
		public static NAudio.Extras.Equalizer equalizer1, equalizer2, equalizer3;
		private static VolumeStereoSampleProvider stereo1, stereo2, stereo3;
		private static MediaFoundationReader audioFileReader1, audioFileReader2, audioFileReader3;
		public static bool managed = false, manager = false;
		private void Form1_Shown(object sender, EventArgs e)
        {
            TimeBeginPeriod(1);
            NtSetTimerResolution(1, true, ref CurrentResolution);
			InitSoundPlay();
			if (File.Exists("tempsave"))
            {
                using (StreamReader file = new StreamReader("tempsave"))
                {
                    tb1st.Text = file.ReadLine();
                    tblast.Text = file.ReadLine();
                    tb1.Text = file.ReadLine();
                    tb2.Text = file.ReadLine();
                    tb3.Text = file.ReadLine();
                    cb1.Checked = bool.Parse(file.ReadLine());
                    cb2.Checked = bool.Parse(file.ReadLine());
                    cb3.Checked = bool.Parse(file.ReadLine());
					cbmanager.Checked = bool.Parse(file.ReadLine());
					cbmanaged.Checked = bool.Parse(file.ReadLine());
				}
            }
		}
		private void InitSoundPlay()
		{
			SetEqualizer();
			audioFileReader1 = new MediaFoundationReader("silence.mp3");
			stereo1 = new VolumeStereoSampleProvider(audioFileReader1.ToSampleProvider());
			equalizer1 = new NAudio.Extras.Equalizer(stereo1, Form1.bands);
			soundOut1 = new WaveOut();
			soundOut1.Init(equalizer1);
			soundOut1.Play();
			audioFileReader2 = new MediaFoundationReader("silence.mp3");
			stereo2 = new VolumeStereoSampleProvider(audioFileReader2.ToSampleProvider());
			equalizer2 = new NAudio.Extras.Equalizer(stereo2, Form1.bands);
			soundOut2 = new WaveOut();
			soundOut2.Init(equalizer2);
			soundOut2.Play();
			audioFileReader3 = new MediaFoundationReader("silence.mp3");
			stereo3 = new VolumeStereoSampleProvider(audioFileReader3.ToSampleProvider());
			equalizer3 = new NAudio.Extras.Equalizer(stereo3, Form1.bands);
			soundOut3 = new WaveOut();
			soundOut3.Init(equalizer3);
			soundOut3.Play();
		}
		private void cbmanaged_CheckStateChanged(object sender, EventArgs e)
		{
			if (cbmanaged.Checked)
            {
				cbmanager.Checked = false;
				manager = false;
				managed = true;
			}
            else
			{
				cbmanager.Checked = true;
				manager = true;
				managed = false;
			}
		}
		private void cbmanager_CheckStateChanged(object sender, EventArgs e)
		{
			if (cbmanager.Checked)
			{
				cbmanaged.Checked = false;
				managed = false;
				manager = true;
			}
			else
			{
				cbmanaged.Checked = true;
				managed = true;
				manager = false;
			}
		}
		private void btplay1_Click(object sender, EventArgs e)
		{
			if (!playing1)
			{
				playing1 = true;
				btplay1.Text = "Playing";
			}
			else if (playing1)
			{
				playing1 = false;
				btplay1.Text = "Play";
			}
		}
		private void btplay2_Click(object sender, EventArgs e)
		{
			if (!playing2)
			{
				playing2 = true;
				btplay2.Text = "Playing";
			}
			else if (playing2)
			{
				playing2 = false;
				btplay2.Text = "Play";
			}
		}
		private void btplay3_Click(object sender, EventArgs e)
		{
			if (!playing3)
			{
				playing3 = true;
				btplay3.Text = "Playing";
			}
			else if (playing3)
			{
				playing3 = false;
				btplay3.Text = "Play";
			}
		}
		private void btlisten1_Click(object sender, EventArgs e)
		{
			if (!listening1)
			{
				listening1 = true;
				btlisten1.Text = "Listening";
			}
			else if (listening1)
			{
				listening1 = false;
				btlisten1.Text = "Listen";
			}
		}
		private void btlisten2_Click(object sender, EventArgs e)
		{
			if (!listening2)
			{
				listening2 = true;
				btlisten2.Text = "Listening";
			}
			else if (listening2)
			{
				listening2 = false;
				btlisten2.Text = "Listen";
			}
		}
		private void btlisten3_Click(object sender, EventArgs e)
		{
			if (!listening3)
			{
				listening3 = true;
				btlisten3.Text = "Listening";
			}
			else if (listening3)
			{
				listening3 = false;
				btlisten3.Text = "Listen";
			}
		}
		private void LocalClientAudio1()
		{
			string ip = tb1.Text;
			int result = Convert.ToInt32(ip.Substring(ip.LastIndexOf('.') + 1)) + 62000;
			string port = result.ToString();
			wscaudio1 = new WebSocket("ws://" + ip + ":" + port + "/Audio");
			wscaudio1.OnMessage += Ws1_OnMessage;
			while (!wscaudio1.IsAlive)
			{
				wscaudio1.Connect();
				wscaudio1.Send("Hello from client");
				Thread.Sleep(1000);
			}
			SetAudioByteArray1();
		}
		private void SetAudioByteArray1()
		{
			SetEqualizer();
			src1 = new BufferedWaveProvider(WaveFormat.CreateIeeeFloatWaveFormat(48000, 2));
			stereo1 = new VolumeStereoSampleProvider(src1.ToSampleProvider());
			equalizer1 = new NAudio.Extras.Equalizer(stereo1, Form1.bands);
			soundOut1 = new WaveOut();
			soundOut1.Init(equalizer1);
			soundOut1.Play();
		}
		private static void Ws1_OnMessage(object sender, MessageEventArgs e)
		{
			if (((listening1) & manager) | managed)
			{
				byte[] rawdata = e.RawData;
				src1.AddSamples(rawdata, 0, rawdata.Length);
			}
		}
		private void LocalClientAudio2()
		{
			string ip = tb2.Text;
			int result = Convert.ToInt32(ip.Substring(ip.LastIndexOf('.') + 1)) + 62000;
			string port = result.ToString();
			wscaudio2 = new WebSocket("ws://" + ip + ":" + port + "/Audio");
			wscaudio2.OnMessage += Ws2_OnMessage;
			while (!wscaudio2.IsAlive)
			{
				wscaudio2.Connect();
				wscaudio2.Send("Hello from client");
				Thread.Sleep(1000);
			}
			SetAudioByteArray2();
		}
		private void SetAudioByteArray2()
		{
			SetEqualizer();
			src2 = new BufferedWaveProvider(WaveFormat.CreateIeeeFloatWaveFormat(48000, 2));
			stereo2 = new VolumeStereoSampleProvider(src2.ToSampleProvider());
			equalizer2 = new NAudio.Extras.Equalizer(stereo2, Form1.bands);
			soundOut2 = new WaveOut();
			soundOut2.Init(equalizer2);
			soundOut2.Play();
		}
		private static void Ws2_OnMessage(object sender, MessageEventArgs e)
		{
			if (((listening2) & manager) | managed)
			{
				byte[] rawdata = e.RawData;
				src2.AddSamples(rawdata, 0, rawdata.Length);
			}
		}
		private void LocalClientAudio3()
		{
			string ip = tb3.Text;
			int result = Convert.ToInt32(ip.Substring(ip.LastIndexOf('.') + 1)) + 62000;
			string port = result.ToString();
			wscaudio3 = new WebSocket("ws://" + ip + ":" + port + "/Audio");
			wscaudio3.OnMessage += Ws3_OnMessage;
			while (!wscaudio3.IsAlive)
			{
				wscaudio3.Connect();
				wscaudio3.Send("Hello from client");
				Thread.Sleep(1000);
			}
			SetAudioByteArray3();
		}
		private void SetAudioByteArray3()
		{
			SetEqualizer();
			src3 = new BufferedWaveProvider(WaveFormat.CreateIeeeFloatWaveFormat(48000, 2));
			stereo3 = new VolumeStereoSampleProvider(src3.ToSampleProvider());
			equalizer3 = new NAudio.Extras.Equalizer(stereo3, Form1.bands);
			soundOut3 = new WaveOut();
			soundOut3.Init(equalizer3);
			soundOut3.Play();
		}
		private static void Ws3_OnMessage(object sender, MessageEventArgs e)
		{
			if (((listening3) & manager) | managed)
			{
				byte[] rawdata = e.RawData;
				src3.AddSamples(rawdata, 0, rawdata.Length);
			}
		}
		private void SetEqualizer()
		{
			bands = new EqualizerBand[]
					{
						new EqualizerBand {Bandwidth = 0.8f, Frequency = 100, Gain = 0},
						new EqualizerBand {Bandwidth = 0.8f, Frequency = 200, Gain = 0},
						new EqualizerBand {Bandwidth = 0.8f, Frequency = 400, Gain = 0},
						new EqualizerBand {Bandwidth = 0.8f, Frequency = 800, Gain = 0},
						new EqualizerBand {Bandwidth = 0.8f, Frequency = 1200, Gain = 0},
						new EqualizerBand {Bandwidth = 0.8f, Frequency = 2400, Gain = 0},
						new EqualizerBand {Bandwidth = 0.8f, Frequency = 4800, Gain = 0},
						new EqualizerBand {Bandwidth = 0.8f, Frequency = 9600, Gain = 0},
					};
			volumeleft = 1f;
			volumeright = 1f;
		}
		private void btstart_Click(object sender, EventArgs e)
		{
			if (!running & (cb1.Checked | cb2.Checked | cb3.Checked))
			{
				running = true;
				btstart.Text = "Stop";
				Task.Run(() => LocalServerAudio());
				if (cb1.Checked)
					Task.Run(() => LocalClientAudio1());
				if (cb2.Checked)
					Task.Run(() => LocalClientAudio2());
				if (cb3.Checked)
					Task.Run(() => LocalClientAudio3());
			}
			else if (running)
			{
				running = false;
				btstart.Text = "Start";
				wssaudio.Stop();
				soundIn.Stop();
				wscaudio1.Close();
				soundOut1.Stop();
			}
		}
        private void LocalServerAudio()
		{
			string localip = GetLocalIP();
			int result = Convert.ToInt32(localip.Substring(localip.LastIndexOf('.') + 1)) + 62000;
			string port = result.ToString();
			wssaudio = new WebSocketServer("ws://" + localip + ":" + port);
			wssaudio.AddWebSocketService<Audio>("/Audio");
			wssaudio.Start();
			GetAudioByteArray();
		}
        public static void GetAudioByteArray()
		{
			soundIn.Initialize();
			SoundInSource soundInSource = new SoundInSource(soundIn) { FillWithZeros = false };
			soundInSource.DataAvailable += (sound, card) =>
			{
				byte[] rawdata = new byte[card.ByteCount];
				Array.Copy(card.Data, card.Offset, rawdata, 0, card.ByteCount);
				audiorawdataavailable = rawdata;
			};
			soundIn.Start();
		}
		public static string GetLocalIP()
		{
			string firstAddress = (from address in NetworkInterface.GetAllNetworkInterfaces().Select(x => x.GetIPProperties()).SelectMany(x => x.UnicastAddresses).Select(x => x.Address)
								   where !IPAddress.IsLoopback(address) && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork
								   select address).FirstOrDefault().ToString();
			return firstAddress;
		}
		private void btscan_Click(object sender, EventArgs e)
		{
			if (!scanning)
			{
				scanning = true;
				btscan.Text = "Scanning IP";
				Task.Run(() =>
				{
					rtscan.Text = "";
					foreach (IPAddress addr in new IPEnumeration(tb1st.Text, tblast.Text))
					{
						if (IPHelper.getMAC(addr).Contains(":"))
						{
							rtscan.Text += addr.ToString() + ", " + IPHelper.getMAC(addr) + ", " + GetLocalName(addr) + Environment.NewLine;
						}
						if (!scanning)
							break;
					}
					scanning = false;
					btscan.Text = "Scan IP";
				});
            }
			else if (scanning)
            {
				scanning = false;
				btscan.Text = "Scan IP";
			}
		}
		public static string GetLocalName(IPAddress adress)
		{
			var hostname = Dns.GetHostEntry(adress.ToString()).HostName;
			return hostname;
		}
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            closed = true;
            using (StreamWriter createdfile = new StreamWriter("tempsave"))
            {
                createdfile.WriteLine(tb1st.Text);
                createdfile.WriteLine(tblast.Text);
                createdfile.WriteLine(tb1.Text);
                createdfile.WriteLine(tb2.Text);
                createdfile.WriteLine(tb3.Text);
                createdfile.WriteLine(cb1.Checked);
                createdfile.WriteLine(cb2.Checked);
                createdfile.WriteLine(cb3.Checked);
				createdfile.WriteLine(cbmanager.Checked);
				createdfile.WriteLine(cbmanaged.Checked);
			}
        }
	}
	public class IPEnumeration : IEnumerable
	{
		private string startAddress;
		private string endAddress;
		internal static Int64 AddressToInt(IPAddress addr)
		{
			byte[] addressBits = addr.GetAddressBytes();

			Int64 retval = 0;
			for (int i = 0; i < addressBits.Length; i++)
			{
				retval = (retval << 8) + (int)addressBits[i];
			}

			return retval;
		}
		internal static Int64 AddressToInt(string addr)
		{
			return AddressToInt(IPAddress.Parse(addr));
		}
		internal static IPAddress IntToAddress(Int64 addr)
		{
			return IPAddress.Parse(addr.ToString());
		}
		public IPEnumeration(string startAddress, string endAddress)
		{
			this.startAddress = startAddress;
			this.endAddress = endAddress;
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)GetEnumerator();
		}
		public IPEnumerator GetEnumerator()
		{
			return new IPEnumerator(startAddress, endAddress);
		}
	}
	public class IPEnumerator : IEnumerator
	{
		private string startAddress;
		private string endAddress;
		private Int64 currentIP;
		private Int64 endIP;
		public IPEnumerator(string startAddress, string endAddress)
		{
			this.startAddress = startAddress;
			this.endAddress = endAddress;

			currentIP = IPEnumeration.AddressToInt(startAddress);
			endIP = IPEnumeration.AddressToInt(endAddress);
		}
		public bool MoveNext()
		{
			currentIP++;
			return (currentIP <= endIP);
		}
		public void Reset()
		{
			currentIP = IPEnumeration.AddressToInt(startAddress);
		}
		object IEnumerator.Current
		{
			get
			{
				return Current;
			}
		}
		public IPAddress Current
		{
			get
			{
				try
				{
					return IPEnumeration.IntToAddress(currentIP);
				}
				catch (IndexOutOfRangeException)
				{
					throw new InvalidOperationException();
				}
			}
		}
	}
	public static class IPHelper
	{
		[DllImport("iphlpapi.dll", ExactSpelling = true)]
		public static extern int SendARP(int DestIP, int SrcIP, byte[] pMacAddr, ref uint PhyAddrLen);

		public static string getMAC(IPAddress address)
		{
			int intAddress = BitConverter.ToInt32(address.GetAddressBytes(), 0);

			byte[] macAddr = new byte[6];
			uint macAddrLen = (uint)macAddr.Length;
			if (SendARP(intAddress, 0, macAddr, ref macAddrLen) != 0)
				return "(NO ARP result)";

			string[] str = new string[(int)macAddrLen];
			for (int i = 0; i < macAddrLen; i++)
				str[i] = macAddr[i].ToString("x2");

			return string.Join(":", str);
		}
	}
	public class Audio : WebSocketBehavior
	{
		protected override void OnMessage(MessageEventArgs e)
		{
			base.OnMessage(e);
			while (Form1.running)
			{
				if (Form1.audiorawdataavailable != null & (Form1.managed | ((Form1.playing1 | Form1.playing2 | Form1.playing3) & Form1.manager)))
				{
					try
					{
						Send(Form1.audiorawdataavailable);
						Form1.audiorawdataavailable = null;
					}
					catch { }
				}
				System.Threading.Thread.Sleep(10);
			}
		}
	}
	/// <summary>
	/// Very simple sample provider supporting adjustable gain
	/// </summary>
	public class VolumeStereoSampleProvider : ISampleProvider
	{
		private readonly ISampleProvider source;

		/// <summary>
		/// Allows adjusting the volume left channel, 1.0f = full volume
		/// </summary>
		public float VolumeLeft { get; set; }

		/// <summary>
		/// Allows adjusting the volume right channel, 1.0f = full volume
		/// </summary>
		public float VolumeRight { get; set; }

		/// <summary>
		/// Initializes a new instance of VolumeStereoSampleProvider
		/// </summary>
		/// <param name="source">Source sample provider, must be stereo</param>
		public VolumeStereoSampleProvider(ISampleProvider source)
		{
			this.source = source;
			VolumeLeft = Form1.volumeleft;
			VolumeRight = Form1.volumeright;
		}

		/// <summary>
		/// WaveFormat
		/// </summary>
		public NAudio.Wave.WaveFormat WaveFormat => source.WaveFormat;

		/// <summary>
		/// Reads samples from this sample provider
		/// </summary>
		/// <param name="buffer">Sample buffer</param>
		/// <param name="offset">Offset into sample buffer</param>
		/// <param name="sampleCount">Number of samples desired</param>
		/// <returns>Number of samples read</returns>
		public int Read(float[] buffer, int offset, int sampleCount)
		{
			int samplesRead = source.Read(buffer, offset, sampleCount);

			for (int n = 0; n < sampleCount; n += 2)
			{
				buffer[offset + n] *= VolumeLeft;
				buffer[offset + n + 1] *= VolumeRight;
			}

			return samplesRead;
		}
	}
}