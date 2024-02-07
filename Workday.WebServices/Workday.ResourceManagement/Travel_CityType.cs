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
	public class Travel_CityType : INotifyPropertyChanged
	{
		private Travel_CityObjectType travel_City_ReferenceField;

		private Travel_City_DataType[] travel_City_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Travel_CityObjectType Travel_City_Reference
		{
			get
			{
				return this.travel_City_ReferenceField;
			}
			set
			{
				this.travel_City_ReferenceField = value;
				this.RaisePropertyChanged("Travel_City_Reference");
			}
		}

		[XmlElement("Travel_City_Data", Order = 1)]
		public Travel_City_DataType[] Travel_City_Data
		{
			get
			{
				return this.travel_City_DataField;
			}
			set
			{
				this.travel_City_DataField = value;
				this.RaisePropertyChanged("Travel_City_Data");
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
