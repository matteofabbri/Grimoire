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
	public class SubrecipientType : INotifyPropertyChanged
	{
		private Subrecipient_AbstractObjectType subrecipient_ReferenceField;

		private Subrecipient_DataType[] subrecipient_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Subrecipient_AbstractObjectType Subrecipient_Reference
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

		[XmlElement("Subrecipient_Data", Order = 1)]
		public Subrecipient_DataType[] Subrecipient_Data
		{
			get
			{
				return this.subrecipient_DataField;
			}
			set
			{
				this.subrecipient_DataField = value;
				this.RaisePropertyChanged("Subrecipient_Data");
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
