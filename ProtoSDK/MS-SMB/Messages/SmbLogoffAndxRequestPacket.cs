// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Smb
{
    /// <summary>
    ///  Packets for SmbLogoffAndx Request
    /// </summary>
    [CLSCompliant(false)]
    public class SmbLogoffAndxRequestPacket : Cifs.SmbLogoffAndxRequestPacket
    {
        #region Convert from base class

        /// <summary>
        /// initialize packet from base packet. 
        /// </summary>
        /// <param name = "packet">the base packet to initialize this packet. </param>
        public SmbLogoffAndxRequestPacket(Cifs.SmbLogoffAndxRequestPacket packet)
            : base(packet)
        {
        }


        #endregion

        #region Constructor

        /// <summary>
        /// Constructor. 
        /// </summary>
        public SmbLogoffAndxRequestPacket()
            : base()
        {
        }


        /// <summary>
        /// Constructor: Create a request directly from a buffer. 
        /// </summary>
        public SmbLogoffAndxRequestPacket(byte[] data)
            : base(data)
        {
        }


        /// <summary>
        /// Deep copy constructor. 
        /// </summary>
        public SmbLogoffAndxRequestPacket(SmbLogoffAndxRequestPacket packet)
            : base(packet)
        {
        }


        #endregion
    }
}
