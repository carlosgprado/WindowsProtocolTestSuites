// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Microsoft.Protocols.TestTools.StackSdk;

namespace Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Cifs
{
    /// <summary>
    /// Packets for SmbTrans2FindNotifyNextFinal Response
    /// </summary>
    [CLSCompliant(false)]
    public class SmbTrans2FindNotifyNextFinalResponsePacket : SmbTransaction2FinalResponsePacket
    {
        #region Fields

        // none

        #endregion


        #region Properties

        // none

        #endregion


        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public SmbTrans2FindNotifyNextFinalResponsePacket()
            : base()
        {
            this.InitDefaultValue();
        }


        /// <summary>
        /// Constructor: Create a request directly from a buffer.
        /// </summary>
        public SmbTrans2FindNotifyNextFinalResponsePacket(byte[] data)
            : base(data)
        {
        }


        /// <summary>
        /// Deep copy constructor.
        /// </summary>
        public SmbTrans2FindNotifyNextFinalResponsePacket(SmbTrans2FindNotifyNextFinalResponsePacket packet)
            : base(packet)
        {
            this.InitDefaultValue();
        }

        #endregion


        #region override methods

        /// <summary>
        /// to create an instance of the StackPacket class that is identical to the current StackPacket. 
        /// </summary>
        /// <returns>a new Packet cloned from this.</returns>
        public override StackPacket Clone()
        {
            return new SmbTrans2FindNotifyNextFinalResponsePacket(this);
        }


        /// <summary>
        /// Encode the struct of Trans2Parameters into the byte array in SmbData.Trans2_Parameters
        /// </summary>
        protected override void EncodeTrans2Parameters()
        {
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