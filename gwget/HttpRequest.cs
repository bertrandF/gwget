using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace gwget
{
    // State object for receiving data from remote device.
    public class StateObject
    {
        // Client socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public const int BufferSize = 1024;
        // Receive buffer.
        public byte[] buffer = new byte[BufferSize];
        // Received data string.
        public StringBuilder sb = new StringBuilder();
        // Http request object
        public HttpRequest httpReq;
    }

   public  class HttpResponse 
    {
       private string text;
       public string Text { get { return text; } set { parseResponse(value); text = value; } }
        public string Page { get; private set; }
        public string Headers { get; private set; }

        public HttpResponse() 
        {
            this.Text = "";
        }

        public void parseResponse(string text) {
            int offset = text.IndexOf(HttpRequest.HTTP_EOL + HttpRequest.HTTP_EOL);
            if (offset > 0)
            {
                this.Headers = text.Substring(0, offset);
                this.Page = text.Substring(offset);
            }
        }
    }

    public class HttpRequest
    {
        public static readonly string HTTP_EOL = "\r\n";
        private Socket socket;
        public Uri Uri { get; private set; }
        public Dictionary<string, string> Headers { get; private set; }
        public string Method { get; set; }
        public string HttpVersion { get; set; }
        public string RawHeaders { get; set; }
        public string Data { get; set; }
        public HttpResponse httpRes { get; set; }
        
        
        public HttpRequest(Uri uri) {
            this.Uri = uri;
            this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.Headers = new Dictionary<string, string>();
            this.Headers.Clear();
            this.Method = "GET";
            this.HttpVersion = "HTTP/1.1";
            this.Data = "";
            this.httpRes = new HttpResponse();
        }

        public void Close() {
            if(this.socket.Connected)
                this.socket.Close();
        }

        public void SendRequest(AsyncCallback callback) {
            try
            {
                this.socket.Connect(Uri.Host, Uri.Port);
                if (!this.socket.Connected) return; // <-- Manage error !!!
            } catch(SocketException e) {
                System.Windows.Forms.MessageBox.Show(e.Message, "Connection Error");
                return;
            }

            this.socket.Send(MakeBytesFromString(this.Method + " " + this.Uri.PathAndQuery + " " + this.HttpVersion + HttpRequest.HTTP_EOL));
            foreach (string k in this.Headers.Keys)
            {
                var value = this.Headers[k];
                if(value != "")
                    this.socket.Send(MakeBytesFromString(k + ": " + value + HttpRequest.HTTP_EOL));
            }
            if (this.RawHeaders != "")
            {
                this.socket.Send(MakeBytesFromString(this.RawHeaders));
                if (this.RawHeaders.Substring(this.RawHeaders.Length - 2) != HttpRequest.HTTP_EOL) 
                    this.socket.Send(MakeBytesFromString(HttpRequest.HTTP_EOL));
            }
            this.socket.Send(MakeBytesFromString(HttpRequest.HTTP_EOL + HttpRequest.HTTP_EOL));
            if (this.Data != "")
                this.socket.Send(MakeBytesFromString(this.Data));

            StateObject state = new StateObject();
            state.workSocket = this.socket;
            state.httpReq = this;
            this.socket.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, callback, state);

            //HttpResponse httpResp = new HttpResponse();
            //byte[] buffer = new byte[1024];
            //int bytes = 0;
            //do {
            //    bytes = this.socket.Receive(buffer, buffer.Length, 0);
            //    httpResp.Text += MakeStringFromBytes(buffer);
            //}while(bytes > 0);
            //this.socket.Close();
        }


        // TODO: Take care of the encoding !!!
        public static byte[] MakeBytesFromString(string str) 
        {
            return System.Text.Encoding.ASCII.GetBytes(str);
        }
        public static string MakeStringFromBytes(byte[] bytes) 
        {
            return System.Text.Encoding.ASCII.GetString(bytes);
        }
    }
}
