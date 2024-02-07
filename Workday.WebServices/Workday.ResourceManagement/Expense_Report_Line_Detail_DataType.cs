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
	public class Expense_Report_Line_Detail_DataType : INotifyPropertyChanged
	{
		private string account_NumberField;

		private string business_TopicsField;

		private string business_ReasonField;

		private string reservation_NumberField;

		private string ticket_NumberField;

		private string merchantField;

		private string merchant_Tax_IDField;

		private CountryObjectType country_ReferenceField;

		private Country_RegionObjectType travel_Region_ReferenceField;

		private Travel_LocationObjectType origination_Location_ReferenceField;

		private Travel_LocationObjectType destination_Location_ReferenceField;

		private HotelObjectType hotel_ReferenceField;

		private Car_Rental_AgencyObjectType car_Rental_Agency_ReferenceField;

		private AirlineObjectType airline_ReferenceField;

		private Vehicle_PlanObjectType vehicle_Plan_ReferenceField;

		private Vehicle_TypeObjectType vehicle_Type_ReferenceField;

		private Engine_CapacityObjectType engine_Capacity_ReferenceField;

		private Fuel_TypeObjectType fuel_Type_ReferenceField;

		private Attendee_DataType[] attendee_Reference_DataField;

		private Recipient_DataType[] recipient_Reference_DataField;

		private Passenger_DataType[] passenger_Reference_DataField;

		private decimal number_of_PersonsField;

		private bool number_of_PersonsFieldSpecified;

		private DateTime arrival_DateField;

		private bool arrival_DateFieldSpecified;

		private DateTime arrival_TimeField;

		private bool arrival_TimeFieldSpecified;

		private DateTime departure_DateField;

		private bool departure_DateFieldSpecified;

		private DateTime departure_TimeField;

		private bool departure_TimeFieldSpecified;

		private decimal number_of_DaysField;

		private bool number_of_DaysFieldSpecified;

		private decimal number_of_HoursField;

		private bool number_of_HoursFieldSpecified;

		private decimal number_of_Breakfasts_ProvidedField;

		private bool number_of_Breakfasts_ProvidedFieldSpecified;

		private decimal number_of_Lunches_ProvidedField;

		private bool number_of_Lunches_ProvidedFieldSpecified;

		private decimal number_of_Dinners_ProvidedField;

		private bool number_of_Dinners_ProvidedFieldSpecified;

		private decimal number_of_Nights_Private_AccommodationField;

		private bool number_of_Nights_Private_AccommodationFieldSpecified;

		private Expense_EligibilityObjectType eligibility_ReferenceField;

		private Class_of_ServiceObjectType class_of_Service_ReferenceField;

		private decimal daily_RateField;

		private bool daily_RateFieldSpecified;

		private string reference_NumberField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Account_Number
		{
			get
			{
				return this.account_NumberField;
			}
			set
			{
				this.account_NumberField = value;
				this.RaisePropertyChanged("Account_Number");
			}
		}

		[XmlElement(Order = 1)]
		public string Business_Topics
		{
			get
			{
				return this.business_TopicsField;
			}
			set
			{
				this.business_TopicsField = value;
				this.RaisePropertyChanged("Business_Topics");
			}
		}

		[XmlElement(Order = 2)]
		public string Business_Reason
		{
			get
			{
				return this.business_ReasonField;
			}
			set
			{
				this.business_ReasonField = value;
				this.RaisePropertyChanged("Business_Reason");
			}
		}

		[XmlElement(Order = 3)]
		public string Reservation_Number
		{
			get
			{
				return this.reservation_NumberField;
			}
			set
			{
				this.reservation_NumberField = value;
				this.RaisePropertyChanged("Reservation_Number");
			}
		}

		[XmlElement(Order = 4)]
		public string Ticket_Number
		{
			get
			{
				return this.ticket_NumberField;
			}
			set
			{
				this.ticket_NumberField = value;
				this.RaisePropertyChanged("Ticket_Number");
			}
		}

		[XmlElement(Order = 5)]
		public string Merchant
		{
			get
			{
				return this.merchantField;
			}
			set
			{
				this.merchantField = value;
				this.RaisePropertyChanged("Merchant");
			}
		}

		[XmlElement(Order = 6)]
		public string Merchant_Tax_ID
		{
			get
			{
				return this.merchant_Tax_IDField;
			}
			set
			{
				this.merchant_Tax_IDField = value;
				this.RaisePropertyChanged("Merchant_Tax_ID");
			}
		}

		[XmlElement(Order = 7)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Country_RegionObjectType Travel_Region_Reference
		{
			get
			{
				return this.travel_Region_ReferenceField;
			}
			set
			{
				this.travel_Region_ReferenceField = value;
				this.RaisePropertyChanged("Travel_Region_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Travel_LocationObjectType Origination_Location_Reference
		{
			get
			{
				return this.origination_Location_ReferenceField;
			}
			set
			{
				this.origination_Location_ReferenceField = value;
				this.RaisePropertyChanged("Origination_Location_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Travel_LocationObjectType Destination_Location_Reference
		{
			get
			{
				return this.destination_Location_ReferenceField;
			}
			set
			{
				this.destination_Location_ReferenceField = value;
				this.RaisePropertyChanged("Destination_Location_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public HotelObjectType Hotel_Reference
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement("Attendee_Reference_Data", Order = 18)]
		public Attendee_DataType[] Attendee_Reference_Data
		{
			get
			{
				return this.attendee_Reference_DataField;
			}
			set
			{
				this.attendee_Reference_DataField = value;
				this.RaisePropertyChanged("Attendee_Reference_Data");
			}
		}

		[XmlElement("Recipient_Reference_Data", Order = 19)]
		public Recipient_DataType[] Recipient_Reference_Data
		{
			get
			{
				return this.recipient_Reference_DataField;
			}
			set
			{
				this.recipient_Reference_DataField = value;
				this.RaisePropertyChanged("Recipient_Reference_Data");
			}
		}

		[XmlElement("Passenger_Reference_Data", Order = 20)]
		public Passenger_DataType[] Passenger_Reference_Data
		{
			get
			{
				return this.passenger_Reference_DataField;
			}
			set
			{
				this.passenger_Reference_DataField = value;
				this.RaisePropertyChanged("Passenger_Reference_Data");
			}
		}

		[XmlElement(Order = 21)]
		public decimal Number_of_Persons
		{
			get
			{
				return this.number_of_PersonsField;
			}
			set
			{
				this.number_of_PersonsField = value;
				this.RaisePropertyChanged("Number_of_Persons");
			}
		}

		[XmlIgnore]
		public bool Number_of_PersonsSpecified
		{
			get
			{
				return this.number_of_PersonsFieldSpecified;
			}
			set
			{
				this.number_of_PersonsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_PersonsSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 22)]
		public DateTime Arrival_Date
		{
			get
			{
				return this.arrival_DateField;
			}
			set
			{
				this.arrival_DateField = value;
				this.RaisePropertyChanged("Arrival_Date");
			}
		}

		[XmlIgnore]
		public bool Arrival_DateSpecified
		{
			get
			{
				return this.arrival_DateFieldSpecified;
			}
			set
			{
				this.arrival_DateFieldSpecified = value;
				this.RaisePropertyChanged("Arrival_DateSpecified");
			}
		}

		[XmlElement(DataType = "time", Order = 23)]
		public DateTime Arrival_Time
		{
			get
			{
				return this.arrival_TimeField;
			}
			set
			{
				this.arrival_TimeField = value;
				this.RaisePropertyChanged("Arrival_Time");
			}
		}

		[XmlIgnore]
		public bool Arrival_TimeSpecified
		{
			get
			{
				return this.arrival_TimeFieldSpecified;
			}
			set
			{
				this.arrival_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Arrival_TimeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 24)]
		public DateTime Departure_Date
		{
			get
			{
				return this.departure_DateField;
			}
			set
			{
				this.departure_DateField = value;
				this.RaisePropertyChanged("Departure_Date");
			}
		}

		[XmlIgnore]
		public bool Departure_DateSpecified
		{
			get
			{
				return this.departure_DateFieldSpecified;
			}
			set
			{
				this.departure_DateFieldSpecified = value;
				this.RaisePropertyChanged("Departure_DateSpecified");
			}
		}

		[XmlElement(DataType = "time", Order = 25)]
		public DateTime Departure_Time
		{
			get
			{
				return this.departure_TimeField;
			}
			set
			{
				this.departure_TimeField = value;
				this.RaisePropertyChanged("Departure_Time");
			}
		}

		[XmlIgnore]
		public bool Departure_TimeSpecified
		{
			get
			{
				return this.departure_TimeFieldSpecified;
			}
			set
			{
				this.departure_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Departure_TimeSpecified");
			}
		}

		[XmlElement(Order = 26)]
		public decimal Number_of_Days
		{
			get
			{
				return this.number_of_DaysField;
			}
			set
			{
				this.number_of_DaysField = value;
				this.RaisePropertyChanged("Number_of_Days");
			}
		}

		[XmlIgnore]
		public bool Number_of_DaysSpecified
		{
			get
			{
				return this.number_of_DaysFieldSpecified;
			}
			set
			{
				this.number_of_DaysFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_DaysSpecified");
			}
		}

		[XmlElement(Order = 27)]
		public decimal Number_of_Hours
		{
			get
			{
				return this.number_of_HoursField;
			}
			set
			{
				this.number_of_HoursField = value;
				this.RaisePropertyChanged("Number_of_Hours");
			}
		}

		[XmlIgnore]
		public bool Number_of_HoursSpecified
		{
			get
			{
				return this.number_of_HoursFieldSpecified;
			}
			set
			{
				this.number_of_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_HoursSpecified");
			}
		}

		[XmlElement(Order = 28)]
		public decimal Number_of_Breakfasts_Provided
		{
			get
			{
				return this.number_of_Breakfasts_ProvidedField;
			}
			set
			{
				this.number_of_Breakfasts_ProvidedField = value;
				this.RaisePropertyChanged("Number_of_Breakfasts_Provided");
			}
		}

		[XmlIgnore]
		public bool Number_of_Breakfasts_ProvidedSpecified
		{
			get
			{
				return this.number_of_Breakfasts_ProvidedFieldSpecified;
			}
			set
			{
				this.number_of_Breakfasts_ProvidedFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_Breakfasts_ProvidedSpecified");
			}
		}

		[XmlElement(Order = 29)]
		public decimal Number_of_Lunches_Provided
		{
			get
			{
				return this.number_of_Lunches_ProvidedField;
			}
			set
			{
				this.number_of_Lunches_ProvidedField = value;
				this.RaisePropertyChanged("Number_of_Lunches_Provided");
			}
		}

		[XmlIgnore]
		public bool Number_of_Lunches_ProvidedSpecified
		{
			get
			{
				return this.number_of_Lunches_ProvidedFieldSpecified;
			}
			set
			{
				this.number_of_Lunches_ProvidedFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_Lunches_ProvidedSpecified");
			}
		}

		[XmlElement(Order = 30)]
		public decimal Number_of_Dinners_Provided
		{
			get
			{
				return this.number_of_Dinners_ProvidedField;
			}
			set
			{
				this.number_of_Dinners_ProvidedField = value;
				this.RaisePropertyChanged("Number_of_Dinners_Provided");
			}
		}

		[XmlIgnore]
		public bool Number_of_Dinners_ProvidedSpecified
		{
			get
			{
				return this.number_of_Dinners_ProvidedFieldSpecified;
			}
			set
			{
				this.number_of_Dinners_ProvidedFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_Dinners_ProvidedSpecified");
			}
		}

		[XmlElement(Order = 31)]
		public decimal Number_of_Nights_Private_Accommodation
		{
			get
			{
				return this.number_of_Nights_Private_AccommodationField;
			}
			set
			{
				this.number_of_Nights_Private_AccommodationField = value;
				this.RaisePropertyChanged("Number_of_Nights_Private_Accommodation");
			}
		}

		[XmlIgnore]
		public bool Number_of_Nights_Private_AccommodationSpecified
		{
			get
			{
				return this.number_of_Nights_Private_AccommodationFieldSpecified;
			}
			set
			{
				this.number_of_Nights_Private_AccommodationFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_Nights_Private_AccommodationSpecified");
			}
		}

		[XmlElement(Order = 32)]
		public Expense_EligibilityObjectType Eligibility_Reference
		{
			get
			{
				return this.eligibility_ReferenceField;
			}
			set
			{
				this.eligibility_ReferenceField = value;
				this.RaisePropertyChanged("Eligibility_Reference");
			}
		}

		[XmlElement(Order = 33)]
		public Class_of_ServiceObjectType Class_of_Service_Reference
		{
			get
			{
				return this.class_of_Service_ReferenceField;
			}
			set
			{
				this.class_of_Service_ReferenceField = value;
				this.RaisePropertyChanged("Class_of_Service_Reference");
			}
		}

		[XmlElement(Order = 34)]
		public decimal Daily_Rate
		{
			get
			{
				return this.daily_RateField;
			}
			set
			{
				this.daily_RateField = value;
				this.RaisePropertyChanged("Daily_Rate");
			}
		}

		[XmlIgnore]
		public bool Daily_RateSpecified
		{
			get
			{
				return this.daily_RateFieldSpecified;
			}
			set
			{
				this.daily_RateFieldSpecified = value;
				this.RaisePropertyChanged("Daily_RateSpecified");
			}
		}

		[XmlElement(Order = 35)]
		public string Reference_Number
		{
			get
			{
				return this.reference_NumberField;
			}
			set
			{
				this.reference_NumberField = value;
				this.RaisePropertyChanged("Reference_Number");
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
