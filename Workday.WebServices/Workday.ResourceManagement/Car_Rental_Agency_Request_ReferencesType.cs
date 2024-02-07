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
	public class Car_Rental_Agency_Request_ReferencesType : INotifyPropertyChanged
	{
		private Car_Rental_AgencyObjectType[] car_Rental_Agency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Car_Rental_Agency_Reference", Order = 0)]
		public Car_Rental_AgencyObjectType[] Car_Rental_Agency_Reference
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
