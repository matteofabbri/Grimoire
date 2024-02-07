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
	public class AirlineType : INotifyPropertyChanged
	{
		private AirlineObjectType airline_ReferenceField;

		private Airline_DataType[] airline_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public AirlineObjectType Airline_Reference
		{
			get
			{
				return this.airline_ReferenceField;
			}
			set
			{
				this.airline_ReferenceField = value;
				this.RaisePropertyChanged("Airline_Reference");
			}
		}

		[XmlElement("Airline_Data", Order = 1)]
		public Airline_DataType[] Airline_Data
		{
			get
			{
				return this.airline_DataField;
			}
			set
			{
				this.airline_DataField = value;
				this.RaisePropertyChanged("Airline_Data");
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
