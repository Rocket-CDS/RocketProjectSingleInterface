using DNNrocketAPI.Components;
using RocketProjectSingleInterface.Components;
using Simplisity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketProjectSingleInterface.API
{
    public partial class StartConnect : DNNrocketAPI.APInterface
    {
        public override Dictionary<string, object> ProcessCommand(string paramCmd, SimplisityInfo systemInfo, SimplisityInfo interfaceInfo, SimplisityInfo postInfo, SimplisityInfo paramInfo, string langRequired = "")
        {
            paramCmd = paramCmd.Replace("rocketprojectsingleinterface_", "rocketcontent_");
            systemInfo.SetXmlProperty("genxml/systemkey", "rocketprojectsingleinterface");
            var contentStartConnect = new RocketContent.API.StartConnect();
            return contentStartConnect.ProcessCommand(paramCmd, systemInfo, interfaceInfo, postInfo, paramInfo, langRequired);
        }
    }

}
