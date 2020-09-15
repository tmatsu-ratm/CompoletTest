using System;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading;
using System.Windows.Forms;

namespace CompoletTest.WinForms
{
    public partial class Form1 : Form
    {
        private MemoryMappedFile _mmf = null;
        private MemoryMappedViewAccessor _accessor = null;

        private MemoryMappedFile _mmf2 = null;
        private MemoryMappedViewAccessor _accessor2 = null;

        public static readonly int BOOLSIZE = 32;
        public static readonly int INTSIZE = 32;

        public Form1()
        {
            InitializeComponent();

            nxCompolet1.Active = true;
            _mmf = MemoryMappedFile.CreateNew("ToLD", 1024);
            _accessor = _mmf.CreateViewAccessor();
            _mmf2 = MemoryMappedFile.CreateNew("ToLD2", 1024);
            _accessor2 = _mmf2.CreateViewAccessor();
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            // LD → TM
            var sendData = new DataStruct(BOOLSIZE, INTSIZE);
            if (GetDataFromLD(out sendData))
            {
                WriteDataToTM(sendData);
                UpdateLDView(sendData);
            }

            // TM → LD
            var receiveData = new DataStruct(BOOLSIZE, INTSIZE);
            if(GetDataFromTM(out receiveData))
            {
                WriteDataToLD(receiveData);
                UpDateTMView(receiveData);
            }
            
            // LD → EV
            var sendData2 = new DataStruct(BOOLSIZE, INTSIZE);
            if (GetDataFromLD2(out sendData2))
            {
                WriteDataToEV(sendData2);
            }

            // EV → LD
            var receiveData2 = new DataStruct(BOOLSIZE, INTSIZE);
            if (GetDataFromEV(out receiveData2))
            {
                WriteDataToLD2(receiveData2);
            }
            
            timer1.Start();
        }

        private void UpDateTMView(DataStruct receiveData)
        {
            In00label.BackColor = receiveData.bitData[0] ? Color.Lime : Color.White;
            In01label.BackColor = receiveData.bitData[1] ? Color.Lime : Color.White;
            In02label.BackColor = receiveData.bitData[2] ? Color.Lime : Color.White;
            In03label.BackColor = receiveData.bitData[3] ? Color.Lime : Color.White;
            In04label.BackColor = receiveData.bitData[4] ? Color.Lime : Color.White;
            In05label.BackColor = receiveData.bitData[5] ? Color.Lime : Color.White;
            In06label.BackColor = receiveData.bitData[6] ? Color.Lime : Color.White;
            In16label.BackColor = receiveData.bitData[16] ? Color.Lime : Color.White;
            In17label.BackColor = receiveData.bitData[17] ? Color.Lime : Color.White;
            In18label.BackColor = receiveData.bitData[18] ? Color.Lime : Color.White;
            In19label.BackColor = receiveData.bitData[19] ? Color.Lime : Color.White;
            In20label.BackColor = receiveData.bitData[20] ? Color.Lime : Color.White;
            In21label.BackColor = receiveData.bitData[21] ? Color.Lime : Color.White;
            In22label.BackColor = receiveData.bitData[22] ? Color.Lime : Color.White;
            In23label.BackColor = receiveData.bitData[23] ? Color.Lime : Color.White;
            In24label.BackColor = receiveData.bitData[24] ? Color.Lime : Color.White;
            In25label.BackColor = receiveData.bitData[25] ? Color.Lime : Color.White;
            In26label.BackColor = receiveData.bitData[26] ? Color.Lime : Color.White;
            In27label.BackColor = receiveData.bitData[27] ? Color.Lime : Color.White;
            In28label.BackColor = receiveData.bitData[28] ? Color.Lime : Color.White;
            In29label.BackColor = receiveData.bitData[29] ? Color.Lime : Color.White;
            In30label.BackColor = receiveData.bitData[30] ? Color.Lime : Color.White;
            In31label.BackColor = receiveData.bitData[31] ? Color.Lime : Color.White;
            FromAnslabel.Text = receiveData.intData[0].ToString();
            ToAnslabel.Text = receiveData.intData[1].ToString();
        }

        private void UpdateLDView(DataStruct sendData)
        {
            Out00label.BackColor = sendData.bitData[0] ? Color.Lime : Color.White;
            Out01label.BackColor = sendData.bitData[1] ? Color.Lime : Color.White;
            Out08label.BackColor = sendData.bitData[8] ? Color.Lime : Color.White;
            Out09label.BackColor = sendData.bitData[9] ? Color.Lime : Color.White;
            Out10label.BackColor = sendData.bitData[10] ? Color.Lime : Color.White;
            Out11label.BackColor = sendData.bitData[11] ? Color.Lime : Color.White;
            Out12label.BackColor = sendData.bitData[12] ? Color.Lime : Color.White;
            Out13label.BackColor = sendData.bitData[13] ? Color.Lime : Color.White;
            Fromlabel.Text = sendData.intData[0].ToString();
            Tolabel.Text = sendData.intData[1].ToString();
        }

        private bool GetDataFromLD(out DataStruct sendData)
        {
            try
            {
                using (MemoryMappedFile mmf = MemoryMappedFile.OpenExisting("FromLD"))
                {
//                    Mutex mutex = Mutex.OpenExisting("FromLDMutex");
//                    mutex.WaitOne();
                    using (MemoryMappedViewAccessor accessor = mmf.CreateViewAccessor())
                    {
                        LDConnectlabel.BackColor = Color.Lime;
                        sendData = new DataStruct(BOOLSIZE, INTSIZE);
                        _ = accessor.ReadArray(0, sendData.bitData, 0, BOOLSIZE);
                        _ = accessor.ReadArray(sizeof(bool) * sendData.bitData.Length, sendData.intData, 0, INTSIZE);
                    }
//                    mutex.ReleaseMutex();
                    return true;
                }
            }
            catch (FileNotFoundException)
            {
                LDConnectlabel.BackColor = Color.White;
                sendData = new DataStruct(BOOLSIZE, INTSIZE);
                return false;
            }
            catch 
            {
                sendData = new DataStruct(BOOLSIZE,INTSIZE);
                return false;
            }
        }
        private bool GetDataFromLD2(out DataStruct sendData)
        {
            try
            {
                using (MemoryMappedFile mmf = MemoryMappedFile.OpenExisting("FromLD2"))
                {
                    using (MemoryMappedViewAccessor accessor = mmf.CreateViewAccessor())
                    {
                        sendData = new DataStruct(BOOLSIZE, INTSIZE);
                        _ = accessor.ReadArray(0, sendData.bitData, 0, BOOLSIZE);
                        _ = accessor.ReadArray(sizeof(bool) * sendData.bitData.Length, sendData.intData, 0, INTSIZE);
                    }
                    return true;
                }
            }
            catch (FileNotFoundException)
            {
                sendData = new DataStruct(BOOLSIZE, INTSIZE);
                return false;
            }
            catch
            {
                sendData = new DataStruct(BOOLSIZE, INTSIZE);
                return false;
            }
        }

        private void WriteDataToTM(DataStruct sendData)
        {
            if (!nxCompolet1.Active)
                nxCompolet1.Active = true;

            if (nxCompolet1.IsConnected)
            {
                nxCompolet1.WriteVariable("LD_TO_TM_BOOL", sendData.bitData);
                nxCompolet1.WriteVariable("LD_TO_TM_INT", sendData.intData);
            }
        }

        private void WriteDataToEV(DataStruct sendData)
        {
            if (!nxCompolet1.Active)
                nxCompolet1.Active = true;

            if (nxCompolet1.IsConnected)
            {
                nxCompolet1.WriteVariable("LD_TO_EV_BOOL", sendData.bitData);
                nxCompolet1.WriteVariable("LD_TO_EV_INT", sendData.intData);
            }
        }

        private bool GetDataFromTM(out DataStruct receiveData)
        {
            if (!nxCompolet1.Active)
                nxCompolet1.Active = true;

            receiveData = new DataStruct(BOOLSIZE, INTSIZE);

            if (nxCompolet1.IsConnected)
            {
                NXConnectlabel.BackColor = Color.Lime;
                receiveData.bitData = nxCompolet1.ReadVariable("TM_TO_LD_BOOL") as bool[];
                receiveData.intData = nxCompolet1.ReadVariable("TM_TO_LD_INT") as int[];
                return true;
            }
            else
            {
                NXConnectlabel.BackColor = Color.White;
                return false;
            }
        }

        private bool GetDataFromEV(out DataStruct receiveData)
        {
            if (!nxCompolet1.Active)
                nxCompolet1.Active = true;

            receiveData = new DataStruct(BOOLSIZE, INTSIZE);

            if (nxCompolet1.IsConnected)
            {
                receiveData.bitData = nxCompolet1.ReadVariable("EV_TO_LD_BOOL") as bool[];
                receiveData.intData = nxCompolet1.ReadVariable("EV_TO_LD_INT") as int[];
                return true;
            }
            else
            {
                return false;
            }
        }

        private void WriteDataToLD(DataStruct receiveData)
        {
//            bool mutexCreated;
//            Mutex mutex = new Mutex(true, "ToLDMutex", out mutexCreated);
            _accessor.WriteArray(0, receiveData.bitData, 0, receiveData.bitData.Length);
            _accessor.WriteArray(sizeof(bool) * receiveData.bitData.Length, receiveData.intData, 0, receiveData.intData.Length);
//            mutex.ReleaseMutex();
        }

        private void WriteDataToLD2(DataStruct receiveData)
        {
            _accessor2.WriteArray(0, receiveData.bitData, 0, receiveData.bitData.Length);
            _accessor2.WriteArray(sizeof(bool) * receiveData.bitData.Length, receiveData.intData, 0, receiveData.intData.Length);
        }

    }
}
