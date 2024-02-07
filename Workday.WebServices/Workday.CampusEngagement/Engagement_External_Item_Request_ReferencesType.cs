using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CampusEngagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Engagement_External_Item_Request_ReferencesType : INotifyPropertyChanged
	{
		private Engagement_External_ItemObjectType[] engagement_External_Item_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Engagement_External_Item_Reference", Order = 0)]
		public Engagement_External_ItemObjectType[] Engagement_External_Item_Reference
		{
			get
			{
				return this.engagement_External_Item_ReferenceField;
			}
			set
			{
				this.engagement_External_Item_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_External_Item_Reference");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
