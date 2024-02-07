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
	public class Car_Rental_AgencyType : INotifyPropertyChanged
	{
		private Car_Rental_AgencyObjectType car_Rental_Agency_ReferenceField;

		private Car_Rental_Agency_DataType[] car_Rental_Agency_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Car_Rental_AgencyObjectType Car_Rental_Agency_Reference
		{
			get
			{
				return this.car_Rental_Agency_ReferenceField;
			}
			set
			{
				this.car_Rental_Agency_ReferenceField = value;
				this.RaisePropertyChanged("Car_Rental_Agency_Reference");
			}
		}

		[XmlElement("Car_Rental_Agency_Data", Order = 1)]
		public Car_Rental_Agency_DataType[] Car_Rental_Agency_Data
		{
			get
			{
				return this.car_Rental_Agency_DataField;
			}
			set
			{
				this.car_Rental_Agency_DataField = value;
				this.RaisePropertyChanged("Car_Rental_Agency_Data");
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
