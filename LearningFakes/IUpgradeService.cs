using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LearningFakes
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceTest" in both code and config file together.
    [ServiceContract]
    /// <summary>
    /// Check the current device version check if upgrades are required, check last upgrade date etc.
    /// </summary>
    public interface IUpgradeService
    {
        [OperationContract]
        int currentSWVersion(int x);
        [OperationContract]
        bool isSWUpgradeRequired(int DeviceID);
        [OperationContract]
        DateTime lastUpgradeDate(int DeviceID);
        [OperationContract]
        bool upgradeDevice(int DeviceID);
    }
}
