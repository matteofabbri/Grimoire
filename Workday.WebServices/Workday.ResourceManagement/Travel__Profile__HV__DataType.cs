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
	public class Travel__Profile__HV__DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType worker_Travel_Profile_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private AirlineObjectType[] airline_ReferenceField;

		private Business_AssetObjectType business_Asset_ReferenceField;

		private HotelObjectType[] hotel_ReferenceField;

		private CountryObjectType[] travel_Country_ReferenceField;

		private Vehicle_TypeObjectType vehicle_Type_ReferenceField;

		private Car_Rental_AgencyObjectType[] car_Rental_Agency_ReferenceField;

		private Fuel_TypeObjectType fuel_Type_ReferenceField;

		private Engine_CapacityObjectType engine_Capacity_ReferenceField;

		private Vehicle_PlanObjectType vehicle_Plan_ReferenceField;

		private Expense_Item_Accumulator_Balance_DataType[] expense_Item_Accumulator_Balance_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Worker_Travel_Profile_Reference
		{
			get
			{
				return this.worker_Travel_Profile_ReferenceField;
			}
			set
			{
				this.worker_Travel_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Travel_Profile_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
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

		[XmlElement(Order = 3)]
		public Business_AssetObjectType Business_Asset_Reference
		{
			get
			{
				return this.business_Asset_ReferenceField;
			}
			set
			{
				this.business_Asset_ReferenceField = value;
				this.RaisePropertyChanged("Business_Asset_Reference");
			}
		}

		[XmlElement("Hotel_Reference", Order = 4)]
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

		[XmlElement("Travel_Country_Reference", Order = 5)]
		public CountryObjectType[] Travel_Country_Reference
		{
			get
			{
				return this.travel_Country_ReferenceField;
			}
			set
			{
				this.travel_Country_ReferenceField = value;
				this.RaisePropertyChanged("Travel_Country_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Vehicle_TypeObjectType Vehicle_Type_Reference
		{
			get
			{
				return this.vehicle_Type_ReferenceField;
			}
			set
			{
				this.vehicle_Type_ReferenceField = value;
				this.RaisePropertyChanged("Vehicle_Type_Reference");
			}
		}

		[XmlElement("Car_Rental_Agency_Reference", Order = 7)]
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

		[XmlElement(Order = 8)]
		public Fuel_TypeObjectType Fuel_Type_Reference
		{
			get
			{
				return this.fuel_Type_ReferenceField;
			}
			set
			{
				this.fuel_Type_ReferenceField = value;
				this.RaisePropertyChanged("Fuel_Type_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Engine_CapacityObjectType Engine_Capacity_Reference
		{
			get
			{
				return this.engine_Capacity_ReferenceField;
			}
			set
			{
				this.engine_Capacity_ReferenceField = value;
				this.RaisePropertyChanged("Engine_Capacity_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Vehicle_PlanObjectType Vehicle_Plan_Reference
		{
			get
			{
				return this.vehicle_Plan_ReferenceField;
			}
			set
			{
				this.vehicle_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Vehicle_Plan_Reference");
			}
		}

		[XmlElement("Expense_Item_Accumulator_Balance_Data", Order = 11)]
		public Expense_Item_Accumulator_Balance_DataType[] Expense_Item_Accumulator_Balance_Data
		{
			get
			{
				return this.expense_Item_Accumulator_Balance_DataField;
			}
			set
			{
				this.expense_Item_Accumulator_Balance_DataField = value;
				this.RaisePropertyChanged("Expense_Item_Accumulator_Balance_Data");
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
