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
	public class Expense_Item_Attribute_Group_DataType : INotifyPropertyChanged
	{
		private string expense_Item_Attribute_Group_IDField;

		private string expense_Item_Attribute_Group_NameField;

		private AirlineObjectType[] airline_ReferenceField;

		private AirportObjectType[] airport_ReferenceField;

		private Car_Rental_AgencyObjectType[] car_Rental_Agency_ReferenceField;

		private HotelObjectType[] hotel_ReferenceField;

		private Travel_CityObjectType[] travel_City_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Expense_Item_Attribute_Group_ID
		{
			get
			{
				return this.expense_Item_Attribute_Group_IDField;
			}
			set
			{
				this.expense_Item_Attribute_Group_IDField = value;
				this.RaisePropertyChanged("Expense_Item_Attribute_Group_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Expense_Item_Attribute_Group_Name
		{
			get
			{
				return this.expense_Item_Attribute_Group_NameField;
			}
			set
			{
				this.expense_Item_Attribute_Group_NameField = value;
				this.RaisePropertyChanged("Expense_Item_Attribute_Group_Name");
			}
		}

		[XmlElement("Airline_Reference", Order = 2)]
		public AirlineObjectType[] Airline_Reference
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

		[XmlElement("Airport_Reference", Order = 3)]
		public AirportObjectType[] Airport_Reference
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

		[XmlElement("Car_Rental_Agency_Reference", Order = 4)]
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

		[XmlElement("Hotel_Reference", Order = 5)]
		public HotelObjectType[] Hotel_Reference
		{
			get
			{
				return this.hotel_ReferenceField;
			}
			set
			{
				this.hotel_ReferenceField = value;
				this.RaisePropertyChanged("Hotel_Reference");
			}
		}

		[XmlElement("Travel_City_Reference", Order = 6)]
		public Travel_CityObjectType[] Travel_City_Reference
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
