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
	public class Resource_Order__Line_for_Issue_Purchase_Order_Outbound_Sub_ViewType : INotifyPropertyChanged
	{
		private bool purchase_Order_Line_CanceledField;

		private bool purchase_Order_Line_CanceledFieldSpecified;

		private Job_ProfileObjectType job_Profile_ReferenceField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private decimal contract_Pay_RateField;

		private bool contract_Pay_RateFieldSpecified;

		private Position_Time_TypeObjectType position_Time_Type_ReferenceField;

		private decimal scheduled_HoursField;

		private bool scheduled_HoursFieldSpecified;

		private decimal uNSPSC_CodeField;

		private bool uNSPSC_CodeFieldSpecified;

		private decimal line_NumberField;

		private bool line_NumberFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Purchase_Order_Line_Canceled
		{
			get
			{
				return this.purchase_Order_Line_CanceledField;
			}
			set
			{
				this.purchase_Order_Line_CanceledField = value;
				this.RaisePropertyChanged("Purchase_Order_Line_Canceled");
			}
		}

		[XmlIgnore]
		public bool Purchase_Order_Line_CanceledSpecified
		{
			get
			{
				return this.purchase_Order_Line_CanceledFieldSpecified;
			}
			set
			{
				this.purchase_Order_Line_CanceledFieldSpecified = value;
				this.RaisePropertyChanged("Purchase_Order_Line_CanceledSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Job_ProfileObjectType Job_Profile_Reference
		{
			get
			{
				return this.job_Profile_ReferenceField;
			}
			set
			{
				this.job_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Job_Profile_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(Order = 4)]
		public decimal Contract_Pay_Rate
		{
			get
			{
				return this.contract_Pay_RateField;
			}
			set
			{
				this.contract_Pay_RateField = value;
				this.RaisePropertyChanged("Contract_Pay_Rate");
			}
		}

		[XmlIgnore]
		public bool Contract_Pay_RateSpecified
		{
			get
			{
				return this.contract_Pay_RateFieldSpecified;
			}
			set
			{
				this.contract_Pay_RateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Pay_RateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Position_Time_TypeObjectType Position_Time_Type_Reference
		{
			get
			{
				return this.position_Time_Type_ReferenceField;
			}
			set
			{
				this.position_Time_Type_ReferenceField = value;
				this.RaisePropertyChanged("Position_Time_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Scheduled_Hours
		{
			get
			{
				return this.scheduled_HoursField;
			}
			set
			{
				this.scheduled_HoursField = value;
				this.RaisePropertyChanged("Scheduled_Hours");
			}
		}

		[XmlIgnore]
		public bool Scheduled_HoursSpecified
		{
			get
			{
				return this.scheduled_HoursFieldSpecified;
			}
			set
			{
				this.scheduled_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Scheduled_HoursSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal UNSPSC_Code
		{
			get
			{
				return this.uNSPSC_CodeField;
			}
			set
			{
				this.uNSPSC_CodeField = value;
				this.RaisePropertyChanged("UNSPSC_Code");
			}
		}

		[XmlIgnore]
		public bool UNSPSC_CodeSpecified
		{
			get
			{
				return this.uNSPSC_CodeFieldSpecified;
			}
			set
			{
				this.uNSPSC_CodeFieldSpecified = value;
				this.RaisePropertyChanged("UNSPSC_CodeSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Line_Number
		{
			get
			{
				return this.line_NumberField;
			}
			set
			{
				this.line_NumberField = value;
				this.RaisePropertyChanged("Line_Number");
			}
		}

		[XmlIgnore]
		public bool Line_NumberSpecified
		{
			get
			{
				return this.line_NumberFieldSpecified;
			}
			set
			{
				this.line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Line_NumberSpecified");
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
