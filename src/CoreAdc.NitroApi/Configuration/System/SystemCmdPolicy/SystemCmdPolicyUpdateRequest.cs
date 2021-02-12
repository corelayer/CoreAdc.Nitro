﻿using System.Net.Http;
using CoreAdc.NitroInterfaces;
using CoreAdc.NitroModel.Configuration.System.SystemCmdPolicy;

namespace CoreAdc.NitroApi.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyUpdateRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Put;
        public sealed override string ResourcePath => "/nitro/v1/config/systemcmdpolicy";
        public sealed override INitroRequestOptions Options => new SystemCmdPolicyUpdateRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot { get; }


        public SystemCmdPolicyUpdateRequest(SystemCmdPolicyUpdateRequestData SystemCmdPolicyUpdateRequestData)
        {
            DataRoot = new SystemCmdPolicyUpdateRequestDataRoot(SystemCmdPolicyUpdateRequestData);
        }
    }
}
