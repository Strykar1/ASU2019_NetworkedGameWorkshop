﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;

namespace ASU2019_NetworkedGameWorkshop.controller {
    public class NetworkManager {
        public const int DEFAULT_PORT = 47999;

        private const int PING_TIMEOUT = 999;

        private static readonly TimeSpan PORT_CHECK_TIMEOUT = TimeSpan.FromSeconds(1);

        public static List<string> LocalIP { get; private set; }
        public static List<string> LocalIPBase { get; private set; }

        static NetworkManager() {
            LocalIP = new List<string>();
            LocalIPBase = new List<string>();
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            for(int i = 0; i < host.AddressList.Length; i++) {
                if(host.AddressList[i].AddressFamily == AddressFamily.InterNetwork) {
                    string ip = host.AddressList[i].ToString();
                    LocalIP.Add(ip);
                    LocalIPBase.Add(ip.Substring(0, ip.LastIndexOf('.') + 1));
                }
            }
        }

        public static Tuple<string, long>[] getServersInNetwork(int port) {
            ConcurrentBag<Tuple<string, long>> activeIPs = new ConcurrentBag<Tuple<string, long>>();
            CountdownEvent countdownEvent = new CountdownEvent((254 * LocalIPBase.Count) + 1);
            new Thread(new ThreadStart(() => {
                foreach(string ipBase in LocalIPBase) {
                    for(int i = 1; i < 255; i++) {
                        Ping p = new Ping();
                        p.PingCompleted += new PingCompletedEventHandler((object sender, PingCompletedEventArgs e) => {
                            if(e.Reply != null && e.Reply.Status == IPStatus.Success) {
                                try {
                                    using(var client = new TcpClient()) {
                                        IAsyncResult asyncResult = client.BeginConnect((string) e.UserState, port, null, null);
                                        if(asyncResult.AsyncWaitHandle.WaitOne(PORT_CHECK_TIMEOUT)) {
                                            activeIPs.Add(Tuple.Create((string) e.UserState, e.Reply.RoundtripTime));
                                            client.EndConnect(asyncResult);
                                        }
                                    }
                                } catch(SocketException) { }
                            }
                            countdownEvent.Signal();
                        });
                        string ip = ipBase + i.ToString();
                        p.SendAsync(ip, PING_TIMEOUT, ip);
                    }
                }
            })).Start();
            countdownEvent.Signal();
            countdownEvent.Wait();
            return activeIPs.ToArray();
        }
    }
}
