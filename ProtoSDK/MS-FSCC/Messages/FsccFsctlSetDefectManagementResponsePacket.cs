// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Fscc
{
    /// <summary>
    /// the response packet of FSCTL_SET_DEFECT_MANAGEMENT 
    /// </summary>
    [CLSCompliant(false)]
    public class FsccFsctlSetDefectManagementResponsePacket : FsccStandardPacket<FsctlSetDefectManagementReplyStatus>
    {
        #region Properties

        /// <summary>
        /// the command of fscc packet 
        /// </summary>
        public override uint Command
        {
            get
            {
                return (uint)FsControlCommand.FSCTL_SET_DEFECT_MANAGEMENT;
            }
        }


        #endregion

        #region Constructors

        /// <summary>
        /// default constructor 
        /// </summary>
        public FsccFsctlSetDefectManagementResponsePacket()
            : base()
        {
        }


        #endregion
    }
}
