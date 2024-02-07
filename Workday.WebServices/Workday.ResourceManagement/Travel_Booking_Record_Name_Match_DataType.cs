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
	public class Travel_Booking_Record_Name_Match_DataType : INotifyPropertyChanged
	{
		private decimal travel_Booking_Record_Confidence_PercentageField;

		private bool travel_Booking_Record_Confidence_PercentageFieldSpecified;

		private Abstract_Spend_Data_NameObjectType origination_Travel_City_ReferenceField;

		private Abstract_Spend_Data_NameObjectType destination_Travel_City_ReferenceField;

		private Abstract_Spend_Data_NameObjectType merchant_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Travel_Booking_Record_Confidence_Percentage
		{
			get
			{
				return this.travel_Booking_Record_Confidence_PercentageField;
			}
			set
			{
				this.travel_Booking_Record_Confidence_PercentageField = value;
				this.RaisePropertyChanged("Travel_Booking_Record_Confidence_Percentage");
			}
		}

		[XmlIgnore]
		public bool Travel_Booking_Record_Confidence_PercentageSpecified
		{
			get
			{
				return this.travel_Booking_Record_Confidence_PercentageFieldSpecified;
			}
			set
			{
				this.travel_Booking_Record_Confidence_PercentageFieldSpecified = value;
				this.RaisePropertyChanged("Travel_Booking_Record_Confidence_PercentageSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Abstract_Spend_Data_NameObjectType Origination_Travel_City_Reference
		{
			get
			{
				return this.origination_Travel_City_ReferenceField;
			}
			set
			{
				this.origination_Travel_City_ReferenceField = value;
				this.RaisePropertyChanged("Origination_Travel_City_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Abstract_Spend_Data_NameObjectType Destination_Travel_City_Reference
		{
			get
			{
				return this.destination_Travel_City_ReferenceField;
			}
			set
			{
				this.destination_Travel_City_ReferenceField = value;
				this.RaisePropertyChanged("Destination_Travel_City_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Abstract_Spend_Data_NameObjectType Merchant_Reference
		{
			get
			{
				return this.merchant_ReferenceField;
			}
			set
			{
				this.merchant_ReferenceField = value;
				this.RaisePropertyChanged("Merchant_Reference");
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
