using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Notification_Sub_Type_ConfigurationType : INotifyPropertyChanged
	{
		private Notification_CategorizableObjectType notification_Sub_Type_ReferenceField;

		private Unique_IdentifierObjectType[] notification_channels_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Notification_CategorizableObjectType Notification_Sub_Type_Reference
		{
			get
			{
				return this.notification_Sub_Type_ReferenceField;
			}
			set
			{
				this.notification_Sub_Type_ReferenceField = value;
				this.RaisePropertyChanged("Notification_Sub_Type_Reference");
			}
		}

		[XmlElement("Notification_channels_Reference", Order = 1)]
		public Unique_IdentifierObjectType[] Notification_channels_Reference
		{
			get
			{
				return this.notification_channels_ReferenceField;
			}
			set
			{
				this.notification_channels_ReferenceField = value;
				this.RaisePropertyChanged("Notification_channels_Reference");
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
