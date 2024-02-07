using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Service_Center_RepresentativeType : INotifyPropertyChanged
	{
		private Service_Center_RepresentativeObjectType service_Center_Representative_ReferenceField;

		private Service_Center_Representative_DataType service_Center_Representative_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Service_Center_RepresentativeObjectType Service_Center_Representative_Reference
		{
			get
			{
				return this.service_Center_Representative_ReferenceField;
			}
			set
			{
				this.service_Center_Representative_ReferenceField = value;
				this.RaisePropertyChanged("Service_Center_Representative_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Service_Center_Representative_DataType Service_Center_Representative_Data
		{
			get
			{
				return this.service_Center_Representative_DataField;
			}
			set
			{
				this.service_Center_Representative_DataField = value;
				this.RaisePropertyChanged("Service_Center_Representative_Data");
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
