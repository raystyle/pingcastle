﻿//
// Copyright (c) Ping Castle. All rights reserved.
// https://www.pingcastle.com
//
// Licensed under the Non-Profit OSL. See LICENSE file in the project root for full license information.
//
using System;
using System.Collections.Generic;
using System.Text;

namespace PingCastle.Healthcheck.Rules
{
	[HeatlcheckRuleModel("S-PrimaryGroup", HealthcheckRiskRuleCategory.StaleObjects, HealthcheckRiskModelCategory.ObjectConfig)]
	[HeatlcheckRuleComputation(RuleComputationType.TriggerOnPresence, 15)]
    public class HeatlcheckRuleStaledPrimaryGroup : HeatlcheckRuleBase
    {
		protected override int? AnalyzeDataNew(HealthcheckData healthcheckData)
        {
			return healthcheckData.UserAccountData.NumberBadPrimaryGroup;
        }
    }
}
