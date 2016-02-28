﻿namespace Assets.Unity.Charon.Editor.Models
{
	public sealed class OrganizationRef
	{
		public string Id { get; set; }
		public string Name { get; set; }

		public override string ToString()
		{
			return string.Format("{0}, id: {1}", this.Name, this.Id);
		}
	}
}