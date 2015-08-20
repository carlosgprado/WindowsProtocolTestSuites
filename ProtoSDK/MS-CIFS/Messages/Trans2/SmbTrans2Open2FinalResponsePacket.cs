// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Microsoft.Protocols.TestTools.StackSdk;

namespace Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Cifs
{
    /// <summary>
    /// Packets for SmbTrans2Open2Final Response
    /// </summary>
    [CLSCompliant(false)]
    public class SmbTrans2Open2FinalResponsePacket : SmbTransaction2FinalResponsePacket
    {
        #region Fields

        private TRANS2_OPEN2_Response_Trans2_Parameters trans2Parameters;

        #endregion


        #region Properties

        /// <summary>
        /// get or set the Trans2_Parameters:TRANS2_OPEN2_Response_Trans2_Parameters
        /// </summary>
        public TRANS2_OPEN2_Response_Trans2_Parameters Trans2Parameters
        {
            get
            {
                return this.trans2Parameters;
            }
            set
            {
                this.trans2Parameters = value;
            }
        }

        #endregion


        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public SmbTrans2Open2FinalResponsePacket()
            : base()
        {
            this.InitDefaultValue();
        }


        /// <summary>
        /// Constructor: Create a request directly from a buffer.
        /// </summary>
        public SmbTrans2Open2FinalResponsePacket(byte[] data)
            : base(data)
        {
        }


        /// <summary>
        /// Deep copy constructor.
        /// </summary>
        public SmbTrans2Open2FinalResponsePacket(SmbTrans2Open2FinalResponsePacket packet)
            : base(packet)
        {
            this.InitDefaultValue();

            this.trans2Parameters.Fid = packet.trans2Parameters.Fid;
            this.trans2Parameters.FileAttributes = packet.trans2Parameters.FileAttributes;
            this.trans2Parameters.CreationTime = packet.trans2Parameters.CreationTime;
            this.trans2Parameters.FileDataSize = packet.trans2Parameters.FileDataSize;
            this.trans2Parameters.AccessMode = packet.trans2Parameters.AccessMode;
            this.trans2Parameters.ResourceType = packet.trans2Parameters.ResourceType;
            this.trans2Parameters.NMPipeStatus = packet.trans2Parameters.NMPipeStatus;
            this.trans2Parameters.OpenResults = packet.trans2Parameters.OpenResults;
            this.trans2Parameters.Reserved = packet.trans2Parameters.Reserved;
            this.trans2Parameters.ExtendedAttributeErrorOffset =
                packet.trans2Parameters.ExtendedAttributeErrorOffset;
            this.trans2Parameters.ExtendedAttributeLength = packet.trans2Parameters.ExtendedAttributeLength;
        }

        #endregion


        #region override methods

        /// <summary>
        /// to create an instance of the StackPacket class that is identical to the current StackPacket. 
        /// </summary>
        /// <returns>a new Packet cloned from this.</returns>
        public override StackPacket Clone()
        {
            return new SmbTrans2Open2FinalResponsePacket(this);
        }


        /// <summary>
        /// Encode the struct of Trans2Parameters into the byte array in SmbData.Trans2_Parameters
        /// </summary>
        protected override void EncodeTrans2Parameters()
        {
            this.smbData.Trans2_Parameters = CifsMessageUtils.ToBytes<TRANS2_OPEN2_Response_Trans2_Parameters>(
                this.trans2Parameters);
        }


        /// <summary>
        /// Encode the struct of Trans2Data into the byte array in SmbData.Trans2_Data
        /// </summary>
        protected override void EncodeTrans2Data()
        {
        }


        /// <summary>
        /// to decode the Trans2 parameters: from the general Trans2Parameters to the concrete Trans2 Parameters.
        /// </summary>
        protected override void DecodeTrans2Parameters()
        {
            if (this.smbData.Trans2_Parameters != null && this.smbData.Trans2_Parameters.Length > 0)
            {
                this.trans2Parameters = TypeMarshal.ToStruct<TRANS2_OPEN2_Response_Trans2_Parameters>(
                    this.smbData.Trans2_Parameters);
            }
        }


        /// <summary>
        /// to decode the Trans2 data: from the general Trans2Dada to the concrete Trans2 Data.
        /// </summary>
        protected override void DecodeTrans2Data()
        {
        }

        #endregion


        #region initialize fields with default value

        /// <summary>
        /// init packet, set default field data
        /// </summary>
        private void InitDefaultValue()
        {
        }

        #endregion
    }
}