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
	public class Travel_Profile_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Vehicle_TypeObjectType vehicle_Type_ReferenceField;

		private Business_AssetObjectType[] resource_ReferenceField;

		private Fuel_TypeObjectType fuel_Type_ReferenceField;

		private Engine_CapacityObjectType engine_Capacity_ReferenceField;

		private Vehicle_PlanObjectType vehicle_Plan_ReferenceField;

		private AirlineObjectType[] airline_ReferenceField;

		private Car_Rental_AgencyObjectType[] car_Rental_Agency_ReferenceField;

		private HotelObjectType[] hotel_ReferenceField;

		private CountryObjectType[] travel_Country_ReferenceField;

		private Worker_Travel_Profile_Attachment_DataType[] attachment_DataField;

		private Expense_Item_Accumulator_Balance_DataType[] expense_Item_Accumulator_Balance_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement("Resource_Reference", Order = 2)]
		public Business_AssetObjectType[] Resource_Reference
		{
			get
			{
				return this.resource_ReferenceField;
			}
			set
			{
				this.resource_ReferenceField = value;
				this.RaisePropertyChanged("Resource_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement("Airline_Reference", Order = 6)]
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

		[XmlElement("Hotel_Reference", Order = 8)]
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

		[XmlElement("Travel_Country_Reference", Order = 9)]
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

		[XmlElement("Attachment_Data", Order = 10)]
		public Worker_Travel_Profile_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
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
