using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace PortScan
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form //класс главной формы
    {
        public static ManualResetEvent connectDone = new ManualResetEvent(false);
        
        
        
        
        public MainForm() // описание методов главной формы
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent(); // инициализация компонентов главной формы
            
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        
        void Button1Click(object sender, EventArgs e) // обработка метода кнопки
        {
            try
            {
                int BeginPort = Convert.ToInt32(nBeginPort.Value);  // создаем переменную BeginPort и заносим в нее значение порта, от
                int EndPort = Convert.ToInt32(nEndPort.Value); // создаем переменную EndPort и заносим в нее конечное значение, до
                int str=0;// переменная для индексации в List.View
                int i; // дополнит.переменная для цикла
            
                progressBarCheck.Maximum = EndPort - BeginPort + 1; // установление максимума полоски заполнения

                progressBarCheck.Value = 0; // обнуление полоски
                listViewPortStatus.Items.Clear(); // очищение поля вывода
            
                IPAddress addr = IPAddress.Parse(tIPAddress.Text); // заносим в перем. addr значение введенного IP-адреса
        
                for (i = BeginPort; i <= EndPort; i++)  // цикл
                {
                
                    IPEndPoint ep = new IPEndPoint(addr, i);  // создаем перем. ep и заносим в нее IP-адрес и номер текущего порта
                    //Создаем и инициализируем сокет, параметры - адресное пространство, тип сокета, тип протокола
                    Socket soc = new Socket(AddressFamily.InterNetwork,
                                            SocketType.Stream,
                                            ProtocolType.Tcp);
                    //Пытаемся соединиться с сервером
                    IAsyncResult asyncResult = soc.BeginConnect(ep, new AsyncCallback(ConnectCallback), soc); 
                    // как здесь работает asyncResult? Он получает сигнал - дошло до опрашиваемого порта или не дошло?
               
                    if (!asyncResult.AsyncWaitHandle.WaitOne(30, false))
                        // условие - если сигнал от порта не пришел обратно в течении 30 секунд, то
                 {
                        soc.Close(); // закрываем сокет и далее пишем, что порт закрыт
                   /* listView1.Items.Add("Порт " + i.ToString());
                        listView1.Items[i-BeginPort].SubItems.Add("закрыт");     
                        listView1.Refresh();*/
                        progressBarCheck.Value += 1;
                    
                 }
                    else
                    {
                        soc.Close(); // закрываем сокет и далее пишем, что порт открыт
                        listViewPortStatus.Items.Add(i.ToString());
                        listViewPortStatus.Items[str].SubItems.Add("Open");
                        str++;
                        progressBarCheck.Value += 1;
                    }
                }
            }
            catch (Exception err)
            {
            }

        }

        private static void ConnectCallback(IAsyncResult ar) // статистический метод с параметром ar, отображ-м инфу - дошел сигнал до порта или нет
        {
         try 
         {
             Socket client = (Socket) ar.AsyncState; // создаем сокет client и заносим в него инфу - дошел сигнал до порта или нет
             client.EndConnect(ar); // завершаем посылку сигнала на сокет client
             connectDone.Set();  // отсылаем сигнал от порта обратно
         } 
         catch (Exception err) // обработка исключения
         {
         }
        }
	
    }
}
