/**
 *  gwget is a little GUI http client
    Copyright (C) 2013  Bertrand Feuillerat

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see [http://www.gnu.org/licenses/].
 * **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace gwget
{
    // ---------------------------------------------------
    // *************** STATE OBJECT **********************
    // State object for receiving data from remote device.
    // ---------------------------------------------------
    public class StateObject
    {
        // Members
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

    // -------------------------------------------------
    // *************** HTTP RESPONSE *******************
    // Object representing the response sent to the user
    // -------------------------------------------------
   public  class HttpResponse 
    {
       // Properties
       // Complete response
       private string text;
       public string Text { get { return text; } set { parseResponse(value); text = value; } }
       // Web page only
        public string Page { get; private set; }
       //Headers
        public string Headers { get; private set; }

       // Constructor
        public HttpResponse() 
        {
            this.Text = "";
        }

       // Parse the whole Http response to extract the header and page.
       // TODO: What if page compressed ?
        public void parseResponse(string text) {
            int offset = text.IndexOf(HttpRequest.HTTP_EOL + HttpRequest.HTTP_EOL);
            if (offset > 0)
            {
                this.Headers = text.Substring(0, offset);
                this.Page = text.Substring(offset);
            }
        }
    }

   // -------------------------------------------------
   // *************** HTTP REQUEST ********************
   // User-made request
   // -------------------------------------------------
    public class HttpRequest
    {
        // Properties
        public static readonly string HTTP_EOL = "\r\n";
        private Socket socket;
        public Uri Uri { get; private set; }
        public Dictionary<string, string> Headers { get; private set; }
        public string Method { get; set; }
        public string HttpVersion { get; set; }
        public string RawHeaders { get; set; }
        public string Data { get; set; }
        public HttpResponse httpRes { get; set; }
        
        // Constructor
        public HttpRequest(Uri uri) {
            this.Uri = uri;
            this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.Headers = new Dictionary<string, string>();
            this.Headers.Clear();
            this.Method = "GET";
            this.HttpVersion = "HTTP/1.1";
            this.Data = "";
            this.RawHeaders = "";
            this.httpRes = new HttpResponse();
        }

        // Close connections
        public void Close() {
            if(this.socket.Connected)
                this.socket.Close();
        }

        // Senf the forged request
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
        }


        // Convertion: String <-> Bytes
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
