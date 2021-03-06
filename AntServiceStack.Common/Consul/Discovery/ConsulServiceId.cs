// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/. 
namespace AntServiceStack.Common.Consul.Discovery
{
    public class ConsulServiceId
    {
        public string Id { get; set; }
        public string[] Tags { get; set; }
    }
}