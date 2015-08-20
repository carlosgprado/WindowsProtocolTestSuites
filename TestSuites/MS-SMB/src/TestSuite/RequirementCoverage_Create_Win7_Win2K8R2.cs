//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneratedTests {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.SpecExplorer.Runtime.Testing;
    using Microsoft.Protocols.TestTools;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Spec Explorer", "3.2.2498.0")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class RequirementCoverage_Create_Win7_Win2K8R2 : PtfTestClassBase {
        
        public RequirementCoverage_Create_Win7_Win2K8R2() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "10000000");
        }
        
        #region Expect Delegates
        public delegate void NegotiateResponseDelegate1(int messageId, bool isSignatureRequired, bool isSignatureEnabled, int dialectIndex, Microsoft.Modeling.Set<Microsoft.Protocol.TestSuites.Smb.Capabilities> serverCapabilities, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus);
        
        public delegate void SessionSetupResponseDelegate1(int messageId, int sessionId, int securitySignatureValue, bool isSigned, bool isGuestAccount, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus);
        
        public delegate void TreeConnectResponseDelegate1(int messageId, int sessionId, int treeId, bool isSecuritySignatureZero, Microsoft.Protocol.TestSuites.Smb.ShareType shareType, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus, bool isSigned, bool isInDfs, bool isSupportExtSignature);
        
        public delegate void ErrorResponseDelegate1(int messageId, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus);
        
        public delegate void NtTransactCreateResponseDelegate1(int messageId, int sessionId, int treeId, bool isSigned, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus);
        
        public delegate void SmbConnectionResponseDelegate1(Microsoft.Protocol.TestSuites.Smb.Platform clientPlatform, Microsoft.Protocol.TestSuites.Smb.Platform sutPlatform);
        
        public delegate void ServerSetupResponseDelegate1(int totalBytesWritten, bool isSupportInfoLevelPassthru, bool isSupportNtSmb, bool isRapServerActive, bool isSupportResumeKey, bool isSupportCopyChunk);
        #endregion
        
        #region Event Metadata
        static System.Reflection.EventInfo SmbConnectionResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocol.TestSuites.Smb.ISmbAdapter), "SmbConnectionResponse");
        
        static System.Reflection.EventInfo ServerSetupResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocol.TestSuites.Smb.IServerSetupAdapter), "ServerSetupResponse");
        
        static System.Reflection.EventInfo NegotiateResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocol.TestSuites.Smb.ISmbAdapter), "NegotiateResponse");
        
        static System.Reflection.EventInfo SessionSetupResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocol.TestSuites.Smb.ISmbAdapter), "SessionSetupResponse");
        
        static System.Reflection.EventInfo TreeConnectResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocol.TestSuites.Smb.ISmbAdapter), "TreeConnectResponse");
        
        static System.Reflection.EventInfo ErrorResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocol.TestSuites.Smb.ISmbAdapter), "ErrorResponse");
        
        static System.Reflection.EventInfo NtTransactCreateResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocol.TestSuites.Smb.ISmbAdapter), "NtTransactCreateResponse");
        #endregion
        
        #region Adapter Instances
        private Microsoft.Protocol.TestSuites.Smb.ISmbAdapter ISmbAdapterInstance;
        
        private Microsoft.Protocol.TestSuites.Smb.IServerSetupAdapter IServerSetupAdapterInstance;
        #endregion
        
        #region Class Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void ClassInitialize(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext context) {
            PtfTestClassBase.Initialize(context);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void ClassCleanup() {
            PtfTestClassBase.Cleanup();
        }
        #endregion
        
        #region Test Initialization and Cleanup
        protected override void TestInitialize() {
            this.InitializeTestManager();
            this.ISmbAdapterInstance = ((Microsoft.Protocol.TestSuites.Smb.ISmbAdapter)(this.Manager.GetAdapter(typeof(Microsoft.Protocol.TestSuites.Smb.ISmbAdapter))));
            this.IServerSetupAdapterInstance = ((Microsoft.Protocol.TestSuites.Smb.IServerSetupAdapter)(this.Manager.GetAdapter(typeof(Microsoft.Protocol.TestSuites.Smb.IServerSetupAdapter))));
            this.Manager.Subscribe(ServerSetupResponseInfo, this.IServerSetupAdapterInstance);
            this.Manager.Subscribe(ErrorResponseInfo, this.ISmbAdapterInstance);
            this.Manager.Subscribe(NegotiateResponseInfo, this.ISmbAdapterInstance);
            this.Manager.Subscribe(NtTransactCreateResponseInfo, this.ISmbAdapterInstance);
            this.Manager.Subscribe(SessionSetupResponseInfo, this.ISmbAdapterInstance);
            this.Manager.Subscribe(SmbConnectionResponseInfo, this.ISmbAdapterInstance);
            this.Manager.Subscribe(TreeConnectResponseInfo, this.ISmbAdapterInstance);
        }
        
        protected override void TestCleanup() {
            base.TestCleanup();
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(), Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Win7_Win2K8R2")]
        public virtual void RequirementCoverage_Create_Win7_Win2K8R2S0() {
            this.Manager.BeginTest("RequirementCoverage_Create_Win7_Win2K8R2S0");
            this.Manager.Comment("reaching state \'S0\'");
            this.Manager.Comment("executing step \'call SmbConnectionRequest()\'");
            this.ISmbAdapterInstance.SmbConnectionRequest();
            this.Manager.Comment("reaching state \'S1\'");
            this.Manager.Comment("checking step \'return SmbConnectionRequest\'");
            this.Manager.Comment("reaching state \'S2\'");
            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(RequirementCoverage_Create_Win7_Win2K8R2.SmbConnectionResponseInfo, null, new SmbConnectionResponseDelegate1(this.RequirementCoverage_Create_Win7_Win2K8R2S0SmbConnectionResponseChecker))) != -1)) {
                this.Manager.Comment("reaching state \'S3\'");
                this.Manager.Comment("executing step \'call ServerSetup(Ntfs,Enabled,True,True,False)\'");
                this.IServerSetupAdapterInstance.ServerSetup(((Microsoft.Protocol.TestSuites.Smb.FileSystemType)(0)), ((Microsoft.Protocol.TestSuites.Smb.SignState)(1)), true, true, false);
                this.Manager.Comment("reaching state \'S4\'");
                this.Manager.Comment("checking step \'return ServerSetup\'");
                this.Manager.Comment("reaching state \'S5\'");
                if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(RequirementCoverage_Create_Win7_Win2K8R2.ServerSetupResponseInfo, null, new ServerSetupResponseDelegate1(this.RequirementCoverage_Create_Win7_Win2K8R2S0ServerSetupResponseChecker))) != -1)) {
                    this.Manager.Comment("reaching state \'S6\'");
                    bool temp0;
                    this.Manager.Comment("executing step \'call CreatePipeAndMailslot({\"Pipe1\"},{\"Mailslot1\"},out _)\'");
                    this.IServerSetupAdapterInstance.CreatePipeAndMailslot(this.Make<Microsoft.Modeling.Set<string>>(new string[] {
                                    "Rep"}, new object[] {
                                    Microsoft.Xrt.Runtime.RuntimeSupport.UpdateMap<string, Microsoft.Xrt.Runtime.Singleton>(Microsoft.Xrt.Runtime.RuntimeSupport.MakeMap<string, Microsoft.Xrt.Runtime.Singleton>(), "Pipe1", this.Make<Microsoft.Xrt.Runtime.RuntimeMapElement<Microsoft.Xrt.Runtime.Singleton>>(new string[] {
                                                    "Element"}, new object[] {
                                                    Microsoft.Xrt.Runtime.Singleton.Single}))}), this.Make<Microsoft.Modeling.Set<string>>(new string[] {
                                    "Rep"}, new object[] {
                                    Microsoft.Xrt.Runtime.RuntimeSupport.UpdateMap<string, Microsoft.Xrt.Runtime.Singleton>(Microsoft.Xrt.Runtime.RuntimeSupport.MakeMap<string, Microsoft.Xrt.Runtime.Singleton>(), "Mailslot1", this.Make<Microsoft.Xrt.Runtime.RuntimeMapElement<Microsoft.Xrt.Runtime.Singleton>>(new string[] {
                                                    "Element"}, new object[] {
                                                    Microsoft.Xrt.Runtime.Singleton.Single}))}), out temp0);
                    this.Manager.Comment("reaching state \'S7\'");
                    this.Manager.Comment("checking step \'return CreatePipeAndMailslot/[out True]\'");
                    TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, temp0, "createPipeStatus of CreatePipeAndMailslot, state S7");
                    this.Manager.Comment("reaching state \'S8\'");
                    this.Manager.Comment("executing step \'call NegotiateRequest(1,True,Required,[PcNet1,LanMan10,Wfw10,LanM" +
                            "an12,LanMan21,NtLanMan])\'");
                    this.ISmbAdapterInstance.NegotiateRequest(1, true, Microsoft.Protocol.TestSuites.Smb.SignState.Required, this.Make<Microsoft.Modeling.Sequence<Microsoft.Protocol.TestSuites.Smb.Dialect>>(new string[] {
                                    "Rep"}, new object[] {
                                    this.Make<Microsoft.Xrt.Runtime.RuntimeList<Microsoft.Protocol.TestSuites.Smb.Dialect>>(new string[] {
                                                "Head",
                                                "Tail"}, new object[] {
                                                Microsoft.Protocol.TestSuites.Smb.Dialect.PcNet1,
                                                this.Make<Microsoft.Xrt.Runtime.RuntimeList<Microsoft.Protocol.TestSuites.Smb.Dialect>>(new string[] {
                                                            "Head",
                                                            "Tail"}, new object[] {
                                                            Microsoft.Protocol.TestSuites.Smb.Dialect.LanMan10,
                                                            this.Make<Microsoft.Xrt.Runtime.RuntimeList<Microsoft.Protocol.TestSuites.Smb.Dialect>>(new string[] {
                                                                        "Head",
                                                                        "Tail"}, new object[] {
                                                                        Microsoft.Protocol.TestSuites.Smb.Dialect.Wfw10,
                                                                        this.Make<Microsoft.Xrt.Runtime.RuntimeList<Microsoft.Protocol.TestSuites.Smb.Dialect>>(new string[] {
                                                                                    "Head",
                                                                                    "Tail"}, new object[] {
                                                                                    Microsoft.Protocol.TestSuites.Smb.Dialect.LanMan12,
                                                                                    this.Make<Microsoft.Xrt.Runtime.RuntimeList<Microsoft.Protocol.TestSuites.Smb.Dialect>>(new string[] {
                                                                                                "Head",
                                                                                                "Tail"}, new object[] {
                                                                                                Microsoft.Protocol.TestSuites.Smb.Dialect.LanMan21,
                                                                                                this.Make<Microsoft.Xrt.Runtime.RuntimeList<Microsoft.Protocol.TestSuites.Smb.Dialect>>(new string[] {
                                                                                                            "Head",
                                                                                                            "Tail"}, new object[] {
                                                                                                            Microsoft.Protocol.TestSuites.Smb.Dialect.NtLanMan,
                                                                                                            ((Microsoft.Xrt.Runtime.RuntimeList<Microsoft.Protocol.TestSuites.Smb.Dialect>)(null))})})})})})})}));
                    this.Manager.Comment("reaching state \'S9\'");
                    this.Manager.Comment("checking step \'return NegotiateRequest\'");
                    this.Manager.Comment("reaching state \'S10\'");
                    if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(RequirementCoverage_Create_Win7_Win2K8R2.NegotiateResponseInfo, null, new NegotiateResponseDelegate1(this.RequirementCoverage_Create_Win7_Win2K8R2S0NegotiateResponseChecker))) != -1)) {
                        this.Manager.Comment("reaching state \'S11\'");
                        this.Manager.Comment("executing step \'call SessionSetupRequest(Admin,2,0,0,True,{CapNtSmbs,CapExtendedS" +
                                "ecurity},False,False,True)\'");
                        this.ISmbAdapterInstance.SessionSetupRequest(((Microsoft.Protocol.TestSuites.Smb.AccountType)(0)), 2, 0, 0, true, this.Make<Microsoft.Modeling.Set<Microsoft.Protocol.TestSuites.Smb.Capabilities>>(new string[] {
                                        "Rep"}, new object[] {
                                        Microsoft.Xrt.Runtime.RuntimeSupport.UpdateMap<Microsoft.Protocol.TestSuites.Smb.Capabilities, Microsoft.Xrt.Runtime.Singleton>(Microsoft.Xrt.Runtime.RuntimeSupport.UpdateMap<Microsoft.Protocol.TestSuites.Smb.Capabilities, Microsoft.Xrt.Runtime.Singleton>(Microsoft.Xrt.Runtime.RuntimeSupport.MakeMap<Microsoft.Protocol.TestSuites.Smb.Capabilities, Microsoft.Xrt.Runtime.Singleton>(), Microsoft.Protocol.TestSuites.Smb.Capabilities.CapNtSmbs, this.Make<Microsoft.Xrt.Runtime.RuntimeMapElement<Microsoft.Xrt.Runtime.Singleton>>(new string[] {
                                                            "Element"}, new object[] {
                                                            Microsoft.Xrt.Runtime.Singleton.Single})), Microsoft.Protocol.TestSuites.Smb.Capabilities.CapExtendedSecurity, this.Make<Microsoft.Xrt.Runtime.RuntimeMapElement<Microsoft.Xrt.Runtime.Singleton>>(new string[] {
                                                        "Element"}, new object[] {
                                                        Microsoft.Xrt.Runtime.Singleton.Single}))}), false, false, true);
                        this.Manager.Checkpoint("MS-SMB_R8388");
                        this.Manager.Comment("reaching state \'S12\'");
                        this.Manager.Comment("checking step \'return SessionSetupRequest\'");
                        this.Manager.Comment("reaching state \'S13\'");
                        if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(RequirementCoverage_Create_Win7_Win2K8R2.SessionSetupResponseInfo, null, new SessionSetupResponseDelegate1(this.RequirementCoverage_Create_Win7_Win2K8R2S0SessionSetupResponseChecker))) != -1)) {
                            this.Manager.Comment("reaching state \'S14\'");
                            this.Manager.Comment("executing step \'call TreeConnectRequest(3,1,False,True,True,\"Share1\",Disk,True)\'");
                            this.ISmbAdapterInstance.TreeConnectRequest(3, 1, false, true, true, "Share1", ((Microsoft.Protocol.TestSuites.Smb.ShareType)(0)), true);
                            this.Manager.Comment("reaching state \'S15\'");
                            this.Manager.Comment("checking step \'return TreeConnectRequest\'");
                            this.Manager.Comment("reaching state \'S16\'");
                            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(RequirementCoverage_Create_Win7_Win2K8R2.TreeConnectResponseInfo, null, new TreeConnectResponseDelegate1(this.RequirementCoverage_Create_Win7_Win2K8R2S0TreeConnectResponseChecker))) != -1)) {
                                this.Manager.Comment("reaching state \'S17\'");
                                this.Manager.Comment("executing step \'call NtTransactCreateRequest(4,1,1,3,\"Dir2\",Disk,True)\'");
                                this.ISmbAdapterInstance.NtTransactCreateRequest(4, 1, 1, 3, "Dir2", ((Microsoft.Protocol.TestSuites.Smb.ShareType)(0)), true);
                                this.Manager.Comment("reaching state \'S18\'");
                                this.Manager.Comment("checking step \'return NtTransactCreateRequest\'");
                                this.Manager.Comment("reaching state \'S19\'");
                                int temp1 = this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(RequirementCoverage_Create_Win7_Win2K8R2.ErrorResponseInfo, null, new ErrorResponseDelegate1(this.RequirementCoverage_Create_Win7_Win2K8R2S0ErrorResponseChecker)), new ExpectedEvent(RequirementCoverage_Create_Win7_Win2K8R2.NtTransactCreateResponseInfo, null, new NtTransactCreateResponseDelegate1(this.RequirementCoverage_Create_Win7_Win2K8R2S0NtTransactCreateResponseChecker)));
                                if ((temp1 == 0)) {
                                    this.Manager.Comment("reaching state \'S20\'");
                                    goto label0;
                                }
                                if ((temp1 == 1)) {
                                    this.Manager.Comment("reaching state \'S21\'");
                                    goto label0;
                                }
                                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(RequirementCoverage_Create_Win7_Win2K8R2.ErrorResponseInfo, null, new ErrorResponseDelegate1(this.RequirementCoverage_Create_Win7_Win2K8R2S0ErrorResponseChecker)), new ExpectedEvent(RequirementCoverage_Create_Win7_Win2K8R2.NtTransactCreateResponseInfo, null, new NtTransactCreateResponseDelegate1(this.RequirementCoverage_Create_Win7_Win2K8R2S0NtTransactCreateResponseChecker)));
                            label0:
;
                            }
                            else {
                                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(RequirementCoverage_Create_Win7_Win2K8R2.TreeConnectResponseInfo, null, new TreeConnectResponseDelegate1(this.RequirementCoverage_Create_Win7_Win2K8R2S0TreeConnectResponseChecker)));
                            }
                        }
                        else {
                            this.Manager.CheckObservationTimeout(false, new ExpectedEvent(RequirementCoverage_Create_Win7_Win2K8R2.SessionSetupResponseInfo, null, new SessionSetupResponseDelegate1(this.RequirementCoverage_Create_Win7_Win2K8R2S0SessionSetupResponseChecker)));
                        }
                    }
                    else {
                        this.Manager.CheckObservationTimeout(false, new ExpectedEvent(RequirementCoverage_Create_Win7_Win2K8R2.NegotiateResponseInfo, null, new NegotiateResponseDelegate1(this.RequirementCoverage_Create_Win7_Win2K8R2S0NegotiateResponseChecker)));
                    }
                }
                else {
                    this.Manager.CheckObservationTimeout(false, new ExpectedEvent(RequirementCoverage_Create_Win7_Win2K8R2.ServerSetupResponseInfo, null, new ServerSetupResponseDelegate1(this.RequirementCoverage_Create_Win7_Win2K8R2S0ServerSetupResponseChecker)));
                }
            }
            else {
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(RequirementCoverage_Create_Win7_Win2K8R2.SmbConnectionResponseInfo, null, new SmbConnectionResponseDelegate1(this.RequirementCoverage_Create_Win7_Win2K8R2S0SmbConnectionResponseChecker)));
            }
            this.Manager.EndTest();
        }
        
        private void RequirementCoverage_Create_Win7_Win2K8R2S0SmbConnectionResponseChecker(Microsoft.Protocol.TestSuites.Smb.Platform clientPlatform, Microsoft.Protocol.TestSuites.Smb.Platform sutPlatform) {
            this.Manager.Comment("checking step \'event SmbConnectionResponse(Win7,Win2K8R2)\'");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.Platform>(this.Manager, Microsoft.Protocol.TestSuites.Smb.Platform.Win7, clientPlatform, "clientPlatform of SmbConnectionResponse, state S2");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.Platform>(this.Manager, Microsoft.Protocol.TestSuites.Smb.Platform.Win2K8R2, sutPlatform, "sutPlatform of SmbConnectionResponse, state S2");
        }
        
        private void RequirementCoverage_Create_Win7_Win2K8R2S0ServerSetupResponseChecker(int totalBytesWritten, bool isSupportInfoLevelPassthru, bool isSupportNtSmb, bool isRapServerActive, bool isSupportResumeKey, bool isSupportCopyChunk) {
            this.Manager.Comment("checking step \'event ServerSetupResponse(1,True,True,True,True,True)\'");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, totalBytesWritten, "totalBytesWritten of ServerSetupResponse, state S5");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupportInfoLevelPassthru, "isSupportInfoLevelPassthru of ServerSetupResponse, state S5");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupportNtSmb, "isSupportNtSmb of ServerSetupResponse, state S5");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isRapServerActive, "isRapServerActive of ServerSetupResponse, state S5");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupportResumeKey, "isSupportResumeKey of ServerSetupResponse, state S5");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupportCopyChunk, "isSupportCopyChunk of ServerSetupResponse, state S5");
        }
        
        private void RequirementCoverage_Create_Win7_Win2K8R2S0NegotiateResponseChecker(int messageId, bool isSignatureRequired, bool isSignatureEnabled, int dialectIndex, Microsoft.Modeling.Set<Microsoft.Protocol.TestSuites.Smb.Capabilities> serverCapabilities, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus) {
            this.Manager.Comment("checking step \'event NegotiateResponse(1,False,True,5,{CapNtSmbs,CapExtendedSecur" +
                    "ity,CapDfs,CapInfoLevelPassThru},Success)\'");
            try {
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, messageId, "messageId of NegotiateResponse, state S10");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSignatureRequired, "isSignatureRequired of NegotiateResponse, state S10");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSignatureEnabled, "isSignatureEnabled of NegotiateResponse, state S10");
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 5, dialectIndex, "dialectIndex of NegotiateResponse, state S10");
                TestManagerHelpers.AssertNotNull(this.Manager, serverCapabilities, "serverCapabilities of NegotiateResponse, state S10");
                TestManagerHelpers.AssertAreEqual<Microsoft.Xrt.Runtime.RuntimeMap<Microsoft.Protocol.TestSuites.Smb.Capabilities, Microsoft.Xrt.Runtime.Singleton>>(this.Manager, Microsoft.Xrt.Runtime.RuntimeSupport.UpdateMap<Microsoft.Protocol.TestSuites.Smb.Capabilities, Microsoft.Xrt.Runtime.Singleton>(Microsoft.Xrt.Runtime.RuntimeSupport.UpdateMap<Microsoft.Protocol.TestSuites.Smb.Capabilities, Microsoft.Xrt.Runtime.Singleton>(Microsoft.Xrt.Runtime.RuntimeSupport.UpdateMap<Microsoft.Protocol.TestSuites.Smb.Capabilities, Microsoft.Xrt.Runtime.Singleton>(Microsoft.Xrt.Runtime.RuntimeSupport.UpdateMap<Microsoft.Protocol.TestSuites.Smb.Capabilities, Microsoft.Xrt.Runtime.Singleton>(Microsoft.Xrt.Runtime.RuntimeSupport.MakeMap<Microsoft.Protocol.TestSuites.Smb.Capabilities, Microsoft.Xrt.Runtime.Singleton>(), Microsoft.Protocol.TestSuites.Smb.Capabilities.CapNtSmbs, this.Make<Microsoft.Xrt.Runtime.RuntimeMapElement<Microsoft.Xrt.Runtime.Singleton>>(new string[] {
                                                "Element"}, new object[] {
                                                Microsoft.Xrt.Runtime.Singleton.Single})), Microsoft.Protocol.TestSuites.Smb.Capabilities.CapExtendedSecurity, this.Make<Microsoft.Xrt.Runtime.RuntimeMapElement<Microsoft.Xrt.Runtime.Singleton>>(new string[] {
                                            "Element"}, new object[] {
                                            Microsoft.Xrt.Runtime.Singleton.Single})), Microsoft.Protocol.TestSuites.Smb.Capabilities.CapDfs, this.Make<Microsoft.Xrt.Runtime.RuntimeMapElement<Microsoft.Xrt.Runtime.Singleton>>(new string[] {
                                        "Element"}, new object[] {
                                        Microsoft.Xrt.Runtime.Singleton.Single})), Microsoft.Protocol.TestSuites.Smb.Capabilities.CapInfoLevelPassThru, this.Make<Microsoft.Xrt.Runtime.RuntimeMapElement<Microsoft.Xrt.Runtime.Singleton>>(new string[] {
                                    "Element"}, new object[] {
                                    Microsoft.Xrt.Runtime.Singleton.Single})), serverCapabilities.Rep, "serverCapabilities of NegotiateResponse, state S10, field selection Rep");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.MessageStatus>(this.Manager, ((Microsoft.Protocol.TestSuites.Smb.MessageStatus)(0)), messageStatus, "messageStatus of NegotiateResponse, state S10");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-SMB_R2308, MS-SMB_R4747");
                throw;
            }
            this.Manager.Checkpoint("MS-SMB_R2308");
            this.Manager.Checkpoint("MS-SMB_R4747");
        }
        
        private void RequirementCoverage_Create_Win7_Win2K8R2S0SessionSetupResponseChecker(int messageId, int sessionId, int securitySignatureValue, bool isSigned, bool isGuestAccount, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus) {
            this.Manager.Comment("checking step \'event SessionSetupResponse(2,1,1,True,False,Success)\'");
            try {
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 2, messageId, "messageId of SessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, sessionId, "sessionId of SessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, securitySignatureValue, "securitySignatureValue of SessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSigned, "isSigned of SessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isGuestAccount, "isGuestAccount of SessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.MessageStatus>(this.Manager, ((Microsoft.Protocol.TestSuites.Smb.MessageStatus)(0)), messageStatus, "messageStatus of SessionSetupResponse, state S13");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-SMB_R105555, MS-SMB_R8380, MS-SMB_R4143, MS-SMB_R" +
                        "4784, MS-SMB_R2193, MS-SMB_R8390, MS-SMB_R2341");
                throw;
            }
            this.Manager.Checkpoint("MS-SMB_R105555");
            this.Manager.Checkpoint("MS-SMB_R8380");
            this.Manager.Checkpoint("MS-SMB_R4143");
            this.Manager.Checkpoint("MS-SMB_R4784");
            this.Manager.Checkpoint("MS-SMB_R2193");
            this.Manager.Checkpoint("MS-SMB_R8390");
            this.Manager.Checkpoint("MS-SMB_R2341");
        }
        
        private void RequirementCoverage_Create_Win7_Win2K8R2S0TreeConnectResponseChecker(int messageId, int sessionId, int treeId, bool isSecuritySignatureZero, Microsoft.Protocol.TestSuites.Smb.ShareType shareType, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus, bool isSigned, bool isInDfs, bool isSupportExtSignature) {
            this.Manager.Comment("checking step \'event TreeConnectResponse(3,1,1,False,Disk,Success,True,False,True" +
                    ")\'");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 3, messageId, "messageId of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, sessionId, "sessionId of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, treeId, "treeId of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSecuritySignatureZero, "isSecuritySignatureZero of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.ShareType>(this.Manager, ((Microsoft.Protocol.TestSuites.Smb.ShareType)(0)), shareType, "shareType of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.MessageStatus>(this.Manager, ((Microsoft.Protocol.TestSuites.Smb.MessageStatus)(0)), messageStatus, "messageStatus of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSigned, "isSigned of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isInDfs, "isInDfs of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupportExtSignature, "isSupportExtSignature of TreeConnectResponse, state S16");
        }
        
        private void RequirementCoverage_Create_Win7_Win2K8R2S0ErrorResponseChecker(int messageId, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus) {
            this.Manager.Comment("checking step \'event ErrorResponse(4,NetworkSessionExpired)\'");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 4, messageId, "messageId of ErrorResponse, state S19");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.MessageStatus>(this.Manager, Microsoft.Protocol.TestSuites.Smb.MessageStatus.NetworkSessionExpired, messageStatus, "messageStatus of ErrorResponse, state S19");
        }
        
        private void RequirementCoverage_Create_Win7_Win2K8R2S0NtTransactCreateResponseChecker(int messageId, int sessionId, int treeId, bool isSigned, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus) {
            this.Manager.Comment("checking step \'event NtTransactCreateResponse(4,1,1,True,Success)\'");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 4, messageId, "messageId of NtTransactCreateResponse, state S19");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, sessionId, "sessionId of NtTransactCreateResponse, state S19");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, treeId, "treeId of NtTransactCreateResponse, state S19");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSigned, "isSigned of NtTransactCreateResponse, state S19");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.MessageStatus>(this.Manager, ((Microsoft.Protocol.TestSuites.Smb.MessageStatus)(0)), messageStatus, "messageStatus of NtTransactCreateResponse, state S19");
        }
        #endregion
    }
}
