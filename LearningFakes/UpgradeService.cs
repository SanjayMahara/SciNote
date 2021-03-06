﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LearningFakes
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceTest" in both code and config file together.
    public class UpgradeService : IUpgradeService
    {
        /// <summary>
        /// Dummy functionlity always returns 5.
        /// </summary>
        /// <param name="DeviceID"></param>
        /// <returns></returns>
        public int currentSWVersion(int DeviceID)
        {
            // Check the version and return the version.

            return 5;
        }

        public bool isSWUpgradeRequired(int DeviceID)
        {
            throw new NotImplementedException();
        }

        public DateTime lastUpgradeDate(int DeviceID)
        {
            // The datetime is dependent on the device in field.
            return DateTime.Now;
        }

        public bool upgradeDevice(int DeviceID)
        {
            if (isSWUpgradeRequired(DeviceID))
            {
                //Upgrade Device functionlity to be added here.
                return true;
            }
            return false;
        }
    }
}
