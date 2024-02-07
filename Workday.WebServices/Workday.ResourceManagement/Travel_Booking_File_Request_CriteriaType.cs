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
	public class Travel_Booking_File_Request_CriteriaType : INotifyPropertyChanged
	{
		private DateTime travel_Booking_Record_Load_Date__Start_DateField;

		private bool travel_Booking_Record_Load_Date__Start_DateFieldSpecified;

		private DateTime travel_Booking_Record_Load_Date__End_DateField;

		private bool travel_Booking_Record_Load_Date__End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Travel_Booking_Record_Load_Date_-_Start_Date", DataType = "date", Order = 0)]
		public DateTime Travel_Booking_Record_Load_Date__Start_Date
		{
			get
			{
				return this.travel_Booking_Record_Load_Date__Start_DateField;
			}
			set
			{
				this.travel_Booking_Record_Load_Date__Start_DateField = value;
				this.RaisePropertyChanged("Travel_Booking_Record_Load_Date__Start_Date");
			}
		}

		[XmlIgnore]
		public bool Travel_Booking_Record_Load_Date__Start_DateSpecified
		{
			get
			{
				return this.travel_Booking_Record_Load_Date__Start_DateFieldSpecified;
			}
			set
			{
				this.travel_Booking_Record_Load_Date__Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Travel_Booking_Record_Load_Date__Start_DateSpecified");
			}
		}

		[XmlElement("Travel_Booking_Record_Load_Date_-_End_Date", DataType = "date", Order = 1)]
		public DateTime Travel_Booking_Record_Load_Date__End_Date
		{
			get
			{
				return this.travel_Booking_Record_Load_Date__End_DateField;
			}
			set
			{
				this.travel_Booking_Record_Load_Date__End_DateField = value;
				this.RaisePropertyChanged("Travel_Booking_Record_Load_Date__End_Date");
			}
		}

		[XmlIgnore]
		public bool Travel_Booking_Record_Load_Date__End_DateSpecified
		{
			get
			{
				return this.travel_Booking_Record_Load_Date__End_DateFieldSpecified;
			}
			set
			{
				this.travel_Booking_Record_Load_Date__End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Travel_Booking_Record_Load_Date__End_DateSpecified");
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
