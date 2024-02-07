using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Subrecipient_Request_ReferencesType : INotifyPropertyChanged
	{
		private Subrecipient_AbstractObjectType[] subrecipient_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Subrecipient_Reference", Order = 0)]
		public Subrecipient_AbstractObjectType[] Subrecipient_Reference
		{
			get
			{
				return this.subrecipient_ReferenceField;
			}
			set
			{
				this.subrecipient_ReferenceField = value;
				this.RaisePropertyChanged("Subrecipient_Reference");
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
