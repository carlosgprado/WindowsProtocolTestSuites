// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Microsoft.Protocols.TestTools.StackSdk;

namespace Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Cifs
{
    /// <summary>
    /// Packets for SmbCreateTemporary Request
    /// </summary>
    [CLSCompliant(false)]
    public class SmbCreateTemporaryRequestPacket : SmbSingleRequestPacket
    {
        #region Fields

        private SMB_COM_CREATE_TEMPORARY_Request_SMB_Parameters smbParameters;
        private SMB_COM_CREATE_TEMPORARY_Request_SMB_Data smbData;

        #endregion


        #region Properties

        /// <summary>
        /// get or set the Smb_Parameters:SMB_COM_CREATE_TEMPORARY_Request_SMB_Parameters
        /// </summary>
        public SMB_COM_CREATE_TEMPORARY_Request_SMB_Parameters SmbParameters
        {
            get
            {
                return this.smbParameters;
            }
            set
            {
                this.smbParameters = value;
            }
        }


        /// <summary>
        /// get or set the Smb_Data:SMB_COM_CREATE_TEMPORARY_Request_SMB_Data
        /// </summary>
        public SMB_COM_CREATE_TEMPORARY_Request_SMB_Data SmbData
        {
            get
            {
                return this.smbData;
            }
            set
            {
                this.smbData = value;
            }
        }

        #endregion


        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public SmbCreateTemporaryRequestPacket()
            : base()
        {
            this.InitDefaultValue();
        }


        /// <summary>
        /// Constructor: Create a request directly from a buffer.
        /// </summary>
        public SmbCreateTemporaryRequestPacket(byte[] data)
            : base(data)
        {
        }


        /// <summary>
        /// Deep copy constructor.
        /// </summary>
        public SmbCreateTemporaryRequestPacket(SmbCreateTemporaryRequestPacket packet)
            : base(packet)
        {
            this.InitDefaultValue();

            this.smbParameters.WordCount = packet.SmbParameters.WordCount;
            this.smbParameters.FileAttributes = packet.SmbParameters.FileAttributes;
            this.smbParameters.CreationTime = new UTime();
            this.smbParameters.CreationTime.Time = packet.SmbParameters.CreationTime.Time;

            this.smbData.ByteCount = packet.SmbData.ByteCount;
            this.smbData.BufferFormat = packet.SmbData.BufferFormat;

            if (packet.smbData.DirectoryName != null)
            {
                this.smbData.DirectoryName = new byte[packet.smbData.DirectoryName.Length];
                Array.Copy(packet.smbData.DirectoryName,
                    this.smbData.DirectoryName, packet.smbData.DirectoryName.Length);
            }
            else
            {
                this.smbData.DirectoryName = new byte[0];
            }
        }

        #endregion


        #region override methods

        /// <summary>
        /// to create an instance of the StackPacket class that is identical to the current StackPacket. 
        /// </summary>
        /// <returns>a new Packet cloned from this.</returns>
        public override StackPacket Clone()
        {
            return new SmbCreateTemporaryRequestPacket(this);
        }


        /// <summary>
        /// Encode the SMB_COM_CREATE_TEMPORARY_Request_SMB_Parameters struct to SmbParameters struct
        /// </summary>
        protected override void EncodeParameters()
        {
            this.smbParametersBlock = TypeMarshal.ToStruct<SmbParameters>(
                CifsMessageUtils.ToBytes<SMB_COM_CREATE_TEMPORARY_Request_SMB_Parameters>(this.smbParameters));
        }


        /// <summary>
        /// Encode the SMB_COM_CREATE_TEMPORARY_Request_SMB_Data struct to SmbData struct
        /// </summary>
        protected override void EncodeData()
        {
            this.smbDataBlock = TypeMarshal.ToStruct<SmbData>(
                CifsMessageUtils.ToBytes<SMB_COM_CREATE_TEMPORARY_Request_SMB_Data>(this.SmbData));
        }


        /// <summary>
        /// to decode the smb parameters: from the general SmbParameters to the concrete Smb Parameters.
        /// </summary>
        protected override void DecodeParameters()
        {
            this.smbParameters = TypeMarshal.ToStruct<SMB_COM_CREATE_TEMPORARY_Request_SMB_Parameters>(
                TypeMarshal.ToBytes(this.smbParametersBlock));
        }


        /// <summary>
        /// to decode the smb data: from the general SmbDada to the concrete Smb Data.
        /// </summary>
        protected override void DecodeData()
        {
            this.smbData = TypeMarshal.ToStruct<SMB_COM_CREATE_TEMPORARY_Request_SMB_Data>(
                TypeMarshal.ToBytes(this.smbDataBlock));
        }

        #endregion


        #region initialize fields with default value

        /// <summary>
        /// init packet, set default field data
        /// </summary>
        private void InitDefaultValue()
        {
            this.smbData.DirectoryName = new byte[0];
        }

        #endregion
    }
}
