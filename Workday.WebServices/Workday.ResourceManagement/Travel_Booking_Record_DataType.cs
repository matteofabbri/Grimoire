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
	public class Travel_Booking_Record_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string employee_IDField;

		private string accountholder_NameField;

		private string traveler_NameField;

		private DateTime booking_DateField;

		private bool booking_DateFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private string ticket_NumberField;

		private string travel_ProviderField;

		private string itinerary_NumberField;

		private string itinerary_DescriptionField;

		private string reservation_NumberField;

		private Travel_Booking_Record_TypeObjectType travel_Record_Type_ReferenceField;

		private Unique_IdentifierObjectType booking_Status_ReferenceField;

		private string location_Code_DestinationField;

		private string location_Code_OriginField;

		private string air_RoutingField;

		private Class_of_ServiceObjectType class_Of_Service_ReferenceField;

		private bool purchasedField;

		private bool purchasedFieldSpecified;

		private DateTime purchase_DateField;

		private bool purchase_DateFieldSpecified;

		private decimal source_Ticket_ValueField;

		private bool source_Ticket_ValueFieldSpecified;

		private decimal transaction_Extended_AmountField;

		private bool transaction_Extended_AmountFieldSpecified;

		private CurrencyObjectType source_Currency_ReferenceField;

		private decimal source_Lowest_Logical_AmountField;

		private bool source_Lowest_Logical_AmountFieldSpecified;

		private string last_4_Digits_of_Credit_Card_NumberField;

		private string credit_Card_Transaction_ReferenceField;

		private string destination_CityField;

		private string destination_StateField;

		private string destination_CountryField;

		private string origination_CityField;

		private string origination_StateField;

		private string origination_CountryField;

		private string merchant_CodeField;

		private string merchant_NameField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private decimal source_Daily_AmountField;

		private bool source_Daily_AmountFieldSpecified;

		private string travel_Policy_CodeField;

		private string policy_DescriptionField;

		private Travel_Booking_Record_Name_Match_DataType[] travel_Booking_Record_Name_Match_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Employee_ID
		{
			get
			{
				return this.employee_IDField;
			}
			set
			{
				this.employee_IDField = value;
				this.RaisePropertyChanged("Employee_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Accountholder_Name
		{
			get
			{
				return this.accountholder_NameField;
			}
			set
			{
				this.accountholder_NameField = value;
				this.RaisePropertyChanged("Accountholder_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Traveler_Name
		{
			get
			{
				return this.traveler_NameField;
			}
			set
			{
				this.traveler_NameField = value;
				this.RaisePropertyChanged("Traveler_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Booking_Date
		{
			get
			{
				return this.booking_DateField;
			}
			set
			{
				this.booking_DateField = value;
				this.RaisePropertyChanged("Booking_Date");
			}
		}

		[XmlIgnore]
		public bool Booking_DateSpecified
		{
			get
			{
				return this.booking_DateFieldSpecified;
			}
			set
			{
				this.booking_DateFieldSpecified = value;
				this.RaisePropertyChanged("Booking_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public string Travel_Provider
		{
			get
			{
				return this.travel_ProviderField;
			}
			set
			{
				this.travel_ProviderField = value;
				this.RaisePropertyChanged("Travel_Provider");
			}
		}

		[XmlElement(Order = 8)]
		public string Itinerary_Number
		{
			get
			{
				return this.itinerary_NumberField;
			}
			set
			{
				this.itinerary_NumberField = value;
				this.RaisePropertyChanged("Itinerary_Number");
			}
		}

		[XmlElement(Order = 9)]
		public string Itinerary_Description
		{
			get
			{
				return this.itinerary_DescriptionField;
			}
			set
			{
				this.itinerary_DescriptionField = value;
				this.RaisePropertyChanged("Itinerary_Description");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
		public Travel_Booking_Record_TypeObjectType Travel_Record_Type_Reference
		{
			get
			{
				return this.travel_Record_Type_ReferenceField;
			}
			set
			{
				this.travel_Record_Type_ReferenceField = value;
				this.RaisePropertyChanged("Travel_Record_Type_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Unique_IdentifierObjectType Booking_Status_Reference
		{
			get
			{
				return this.booking_Status_ReferenceField;
			}
			set
			{
				this.booking_Status_ReferenceField = value;
				this.RaisePropertyChanged("Booking_Status_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public string Location_Code_Destination
		{
			get
			{
				return this.location_Code_DestinationField;
			}
			set
			{
				this.location_Code_DestinationField = value;
				this.RaisePropertyChanged("Location_Code_Destination");
			}
		}

		[XmlElement(Order = 14)]
		public string Location_Code_Origin
		{
			get
			{
				return this.location_Code_OriginField;
			}
			set
			{
				this.location_Code_OriginField = value;
				this.RaisePropertyChanged("Location_Code_Origin");
			}
		}

		[XmlElement(Order = 15)]
		public string Air_Routing
		{
			get
			{
				return this.air_RoutingField;
			}
			set
			{
				this.air_RoutingField = value;
				this.RaisePropertyChanged("Air_Routing");
			}
		}

		[XmlElement(Order = 16)]
		public Class_of_ServiceObjectType Class_Of_Service_Reference
		{
			get
			{
				return this.class_Of_Service_ReferenceField;
			}
			set
			{
				this.class_Of_Service_ReferenceField = value;
				this.RaisePropertyChanged("Class_Of_Service_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public bool Purchased
		{
			get
			{
				return this.purchasedField;
			}
			set
			{
				this.purchasedField = value;
				this.RaisePropertyChanged("Purchased");
			}
		}

		[XmlIgnore]
		public bool PurchasedSpecified
		{
			get
			{
				return this.purchasedFieldSpecified;
			}
			set
			{
				this.purchasedFieldSpecified = value;
				this.RaisePropertyChanged("PurchasedSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 18)]
		public DateTime Purchase_Date
		{
			get
			{
				return this.purchase_DateField;
			}
			set
			{
				this.purchase_DateField = value;
				this.RaisePropertyChanged("Purchase_Date");
			}
		}

		[XmlIgnore]
		public bool Purchase_DateSpecified
		{
			get
			{
				return this.purchase_DateFieldSpecified;
			}
			set
			{
				this.purchase_DateFieldSpecified = value;
				this.RaisePropertyChanged("Purchase_DateSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Source_Ticket_Value
		{
			get
			{
				return this.source_Ticket_ValueField;
			}
			set
			{
				this.source_Ticket_ValueField = value;
				this.RaisePropertyChanged("Source_Ticket_Value");
			}
		}

		[XmlIgnore]
		public bool Source_Ticket_ValueSpecified
		{
			get
			{
				return this.source_Ticket_ValueFieldSpecified;
			}
			set
			{
				this.source_Ticket_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Source_Ticket_ValueSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public decimal Transaction_Extended_Amount
		{
			get
			{
				return this.transaction_Extended_AmountField;
			}
			set
			{
				this.transaction_Extended_AmountField = value;
				this.RaisePropertyChanged("Transaction_Extended_Amount");
			}
		}

		[XmlIgnore]
		public bool Transaction_Extended_AmountSpecified
		{
			get
			{
				return this.transaction_Extended_AmountFieldSpecified;
			}
			set
			{
				this.transaction_Extended_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Extended_AmountSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public CurrencyObjectType Source_Currency_Reference
		{
			get
			{
				return this.source_Currency_ReferenceField;
			}
			set
			{
				this.source_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Source_Currency_Reference");
			}
		}

		[XmlElement(Order = 22)]
		public decimal Source_Lowest_Logical_Amount
		{
			get
			{
				return this.source_Lowest_Logical_AmountField;
			}
			set
			{
				this.source_Lowest_Logical_AmountField = value;
				this.RaisePropertyChanged("Source_Lowest_Logical_Amount");
			}
		}

		[XmlIgnore]
		public bool Source_Lowest_Logical_AmountSpecified
		{
			get
			{
				return this.source_Lowest_Logical_AmountFieldSpecified;
			}
			set
			{
				this.source_Lowest_Logical_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Source_Lowest_Logical_AmountSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public string Last_4_Digits_of_Credit_Card_Number
		{
			get
			{
				return this.last_4_Digits_of_Credit_Card_NumberField;
			}
			set
			{
				this.last_4_Digits_of_Credit_Card_NumberField = value;
				this.RaisePropertyChanged("Last_4_Digits_of_Credit_Card_Number");
			}
		}

		[XmlElement(Order = 24)]
		public string Credit_Card_Transaction_Reference
		{
			get
			{
				return this.credit_Card_Transaction_ReferenceField;
			}
			set
			{
				this.credit_Card_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Credit_Card_Transaction_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public string Destination_City
		{
			get
			{
				return this.destination_CityField;
			}
			set
			{
				this.destination_CityField = value;
				this.RaisePropertyChanged("Destination_City");
			}
		}

		[XmlElement(Order = 26)]
		public string Destination_State
		{
			get
			{
				return this.destination_StateField;
			}
			set
			{
				this.destination_StateField = value;
				this.RaisePropertyChanged("Destination_State");
			}
		}

		[XmlElement(Order = 27)]
		public string Destination_Country
		{
			get
			{
				return this.destination_CountryField;
			}
			set
			{
				this.destination_CountryField = value;
				this.RaisePropertyChanged("Destination_Country");
			}
		}

		[XmlElement(Order = 28)]
		public string Origination_City
		{
			get
			{
				return this.origination_CityField;
			}
			set
			{
				this.origination_CityField = value;
				this.RaisePropertyChanged("Origination_City");
			}
		}

		[XmlElement(Order = 29)]
		public string Origination_State
		{
			get
			{
				return this.origination_StateField;
			}
			set
			{
				this.origination_StateField = value;
				this.RaisePropertyChanged("Origination_State");
			}
		}

		[XmlElement(Order = 30)]
		public string Origination_Country
		{
			get
			{
				return this.origination_CountryField;
			}
			set
			{
				this.origination_CountryField = value;
				this.RaisePropertyChanged("Origination_Country");
			}
		}

		[XmlElement(Order = 31)]
		public string Merchant_Code
		{
			get
			{
				return this.merchant_CodeField;
			}
			set
			{
				this.merchant_CodeField = value;
				this.RaisePropertyChanged("Merchant_Code");
			}
		}

		[XmlElement(Order = 32)]
		public string Merchant_Name
		{
			get
			{
				return this.merchant_NameField;
			}
			set
			{
				this.merchant_NameField = value;
				this.RaisePropertyChanged("Merchant_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 33)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 34)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 35)]
		public decimal Source_Daily_Amount
		{
			get
			{
				return this.source_Daily_AmountField;
			}
			set
			{
				this.source_Daily_AmountField = value;
				this.RaisePropertyChanged("Source_Daily_Amount");
			}
		}

		[XmlIgnore]
		public bool Source_Daily_AmountSpecified
		{
			get
			{
				return this.source_Daily_AmountFieldSpecified;
			}
			set
			{
				this.source_Daily_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Source_Daily_AmountSpecified");
			}
		}

		[XmlElement(Order = 36)]
		public string Travel_Policy_Code
		{
			get
			{
				return this.travel_Policy_CodeField;
			}
			set
			{
				this.travel_Policy_CodeField = value;
				this.RaisePropertyChanged("Travel_Policy_Code");
			}
		}

		[XmlElement(Order = 37)]
		public string Policy_Description
		{
			get
			{
				return this.policy_DescriptionField;
			}
			set
			{
				this.policy_DescriptionField = value;
				this.RaisePropertyChanged("Policy_Description");
			}
		}

		[XmlElement("Travel_Booking_Record_Name_Match_Data", Order = 38)]
		public Travel_Booking_Record_Name_Match_DataType[] Travel_Booking_Record_Name_Match_Data
		{
			get
			{
				return this.travel_Booking_Record_Name_Match_DataField;
			}
			set
			{
				this.travel_Booking_Record_Name_Match_DataField = value;
				this.RaisePropertyChanged("Travel_Booking_Record_Name_Match_Data");
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
