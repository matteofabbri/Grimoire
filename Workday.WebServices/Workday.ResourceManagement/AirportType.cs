using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class AirportType : INotifyPropertyChanged
	{
		private AirportObjectType airport_ReferenceField;

		private Airport_DataType[] airport_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public AirportObjectType Airport_Reference
		{
			get
			{
				return this.airport_ReferenceField;
			}
			set
			{
				this.airport_ReferenceField = value;
				this.RaisePropertyChanged("Airport_Reference");
			}
		}

		[XmlElement("Airport_Data", Order = 1)]
		public Airport_DataType[] Airport_Data
		{
			get
			{
				return this.airport_DataField;
			}
			set
			{
				this.airport_DataField = value;
				this.RaisePropertyChanged("Airport_Data");
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
