﻿using System;
using System.Collections.Generic;

namespace Assets.Unity.Charon.Editor.Models
{
	public sealed class LicenseInfo
	{
		public string SerialNumber { get; set; }
		public string Type { get; set; }
		public OrganizationRef Organization { get; set; }
		public AccountRef Recipient { get; set; }
		public DateTime ExpirationDate { get; set; }
		public DateTime IssuanceDate { get; set; }

		public Dictionary<string, string> Features { get; set; }
	}
}
