// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
namespace Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Fscc
{
    /// <summary>
    /// the request packet of FileModeInformation 
    /// </summary>
    [CLSCompliant(false)]
    public class FsccFileModeInformationRequestPacket : FsccStandardPacket<FILE_MODE_INFORMATION>
    {
        #region Properties

        /// <summary>
        /// the command of fscc packet 
        /// </summary>
        public override uint Command
        {
            get
            {
                return (uint)FileInformationCommand.FileModeInformation;
            }
        }


        #endregion

        #region Constructors

        /// <summary>
        /// default constructor 
        /// </summary>
        public FsccFileModeInformationRequestPacket()
            : base()
        {
        }


        #endregion
    }
}
