using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Award_Promotion_DataType : INotifyPropertyChanged
	{
		private Event_Classification_SubcategoryObjectType promotion_Reason_ReferenceField;

		private Position_GroupObjectType new_Position_ReferenceField;

		private Job_ProfileObjectType job_Profile_ReferenceField;

		private Compensation_GradeObjectType compensation_Grade_new_from_Promotion_Adjustment_ReferenceField;

		private Compensation_Grade_ProfileObjectType grade_Profile_ReferenceField;

		private LocationObjectType location_ReferenceField;

		private decimal scheduled_Weekly_HoursField;

		private bool scheduled_Weekly_HoursFieldSpecified;

		private decimal promotion_PercentField;

		private bool promotion_PercentFieldSpecified;

		private decimal promotion_AmountField;

		private bool promotion_AmountFieldSpecified;

		private decimal new_Pay_AmountField;

		private bool new_Pay_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Event_Classification_SubcategoryObjectType Promotion_Reason_Reference
		{
			get
			{
				return this.promotion_Reason_ReferenceField;
			}
			set
			{
				this.promotion_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Promotion_Reason_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Position_GroupObjectType New_Position_Reference
		{
			get
			{
				return this.new_Position_ReferenceField;
			}
			set
			{
				this.new_Position_ReferenceField = value;
				this.RaisePropertyChanged("New_Position_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Compensation_GradeObjectType Compensation_Grade_new_from_Promotion_Adjustment_Reference
		{
			get
			{
				return this.compensation_Grade_new_from_Promotion_Adjustment_ReferenceField;
			}
			set
			{
				this.compensation_Grade_new_from_Promotion_Adjustment_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Grade_new_from_Promotion_Adjustment_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Compensation_Grade_ProfileObjectType Grade_Profile_Reference
		{
			get
			{
				return this.grade_Profile_ReferenceField;
			}
			set
			{
				this.grade_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Grade_Profile_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Scheduled_Weekly_Hours
		{
			get
			{
				return this.scheduled_Weekly_HoursField;
			}
			set
			{
				this.scheduled_Weekly_HoursField = value;
				this.RaisePropertyChanged("Scheduled_Weekly_Hours");
			}
		}

		[XmlIgnore]
		public bool Scheduled_Weekly_HoursSpecified
		{
			get
			{
				return this.scheduled_Weekly_HoursFieldSpecified;
			}
			set
			{
				this.scheduled_Weekly_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Scheduled_Weekly_HoursSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Promotion_Percent
		{
			get
			{
				return this.promotion_PercentField;
			}
			set
			{
				this.promotion_PercentField = value;
				this.RaisePropertyChanged("Promotion_Percent");
			}
		}

		[XmlIgnore]
		public bool Promotion_PercentSpecified
		{
			get
			{
				return this.promotion_PercentFieldSpecified;
			}
			set
			{
				this.promotion_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Promotion_PercentSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Promotion_Amount
		{
			get
			{
				return this.promotion_AmountField;
			}
			set
			{
				this.promotion_AmountField = value;
				this.RaisePropertyChanged("Promotion_Amount");
			}
		}

		[XmlIgnore]
		public bool Promotion_AmountSpecified
		{
			get
			{
				return this.promotion_AmountFieldSpecified;
			}
			set
			{
				this.promotion_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Promotion_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal New_Pay_Amount
		{
			get
			{
				return this.new_Pay_AmountField;
			}
			set
			{
				this.new_Pay_AmountField = value;
				this.RaisePropertyChanged("New_Pay_Amount");
			}
		}

		[XmlIgnore]
		public bool New_Pay_AmountSpecified
		{
			get
			{
				return this.new_Pay_AmountFieldSpecified;
			}
			set
			{
				this.new_Pay_AmountFieldSpecified = value;
				this.RaisePropertyChanged("New_Pay_AmountSpecified");
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
