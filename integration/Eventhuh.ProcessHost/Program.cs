// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SampleSender
{
    using System;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Azure.EventHubs;
    using SampleEphReceiver;

    public class Program
    {
       
   
        public static void Main(string[] args)
        {
           //Senders.SendAsync().GetAwaiter().GetResult();
           Recievers.ExecAsync().GetAwaiter().GetResult();
        }

    
    }
}
