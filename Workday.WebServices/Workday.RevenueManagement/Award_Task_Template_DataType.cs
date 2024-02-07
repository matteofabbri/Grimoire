using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Task_Template_DataType : INotifyPropertyChanged
	{
		private string award_Task_Template_IDField;

		private Award_Task_TypeObjectType award_Task_Type_ReferenceField;

		private string commentsField;

		private decimal occurs_on_Year_NumberField;

		private bool occurs_on_Year_NumberFieldSpecified;

		private bool occurs_on_Final_Award_Year_OnlyField;

		private bool occurs_on_Final_Award_Year_OnlyFieldSpecified;

		private bool occurs_on_Every_Award_YearField;

		private bool occurs_on_Every_Award_YearFieldSpecified;

		private bool no_RecurrenceField;

		private bool no_RecurrenceFieldSpecified;

		private Award_Posting_Interval_NameObjectType[] offset_from_Posting_Intervals_ReferenceField;

		private Award_Task_Template_Due_Date_Offset_DataType award_Task_Template_Due_Date_DataField;

		private Award_Task_Template_Start_Date_Offset_DataType award_Task_Template_Start_Date_DataField;

		private Award_Task_Template_End_Date_Offset_DataType award_Task_Template_End_Date_DataField;

		private Award_Task_Role_Assignment_DataType[] role_Assignment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Award_Task_Template_ID
		{
			get
			{
				return this.award_Task_Template_IDField;
			}
			set
			{
				this.award_Task_Template_IDField = value;
				this.RaisePropertyChanged("Award_Task_Template_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Award_Task_TypeObjectType Award_Task_Type_Reference
		{
			get
			{
				return this.award_Task_Type_ReferenceField;
			}
			set
			{
				this.award_Task_Type_ReferenceField = value;
				this.RaisePropertyChanged("Award_Task_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
				this.RaisePropertyChanged("Comments");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Occurs_on_Year_Number
		{
			get
			{
				return this.occurs_on_Year_NumberField;
			}
			set
			{
				this.occurs_on_Year_NumberField = value;
				this.RaisePropertyChanged("Occurs_on_Year_Number");
			}
		}

		[XmlIgnore]
		public bool Occurs_on_Year_NumberSpecified
		{
			get
			{
				return this.occurs_on_Year_NumberFieldSpecified;
			}
			set
			{
				this.occurs_on_Year_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Occurs_on_Year_NumberSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Occurs_on_Final_Award_Year_Only
		{
			get
			{
				return this.occurs_on_Final_Award_Year_OnlyField;
			}
			set
			{
				this.occurs_on_Final_Award_Year_OnlyField = value;
				this.RaisePropertyChanged("Occurs_on_Final_Award_Year_Only");
			}
		}

		[XmlIgnore]
		public bool Occurs_on_Final_Award_Year_OnlySpecified
		{
			get
			{
				return this.occurs_on_Final_Award_Year_OnlyFieldSpecified;
			}
			set
			{
				this.occurs_on_Final_Award_Year_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Occurs_on_Final_Award_Year_OnlySpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Occurs_on_Every_Award_Year
		{
			get
			{
				return this.occurs_on_Every_Award_YearField;
			}
			set
			{
				this.occurs_on_Every_Award_YearField = value;
				this.RaisePropertyChanged("Occurs_on_Every_Award_Year");
			}
		}

		[XmlIgnore]
		public bool Occurs_on_Every_Award_YearSpecified
		{
			get
			{
				return this.occurs_on_Every_Award_YearFieldSpecified;
			}
			set
			{
				this.occurs_on_Every_Award_YearFieldSpecified = value;
				this.RaisePropertyChanged("Occurs_on_Every_Award_YearSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool No_Recurrence
		{
			get
			{
				return this.no_RecurrenceField;
			}
			set
			{
				this.no_RecurrenceField = value;
				this.RaisePropertyChanged("No_Recurrence");
			}
		}

		[XmlIgnore]
		public bool No_RecurrenceSpecified
		{
			get
			{
				return this.no_RecurrenceFieldSpecified;
			}
			set
			{
				this.no_RecurrenceFieldSpecified = value;
				this.RaisePropertyChanged("No_RecurrenceSpecified");
			}
		}

		[XmlElement("Offset_from_Posting_Intervals_Reference", Order = 7)]
		public Award_Posting_Interval_NameObjectType[] Offset_from_Posting_Intervals_Reference
		{
			get
			{
				return this.offset_from_Posting_Intervals_ReferenceField;
			}
			set
			{
				this.offset_from_Posting_Intervals_ReferenceField = value;
				this.RaisePropertyChanged("Offset_from_Posting_Intervals_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Award_Task_Template_Due_Date_Offset_DataType Award_Task_Template_Due_Date_Data
		{
			get
			{
				return this.award_Task_Template_Due_Date_DataField;
			}
			set
			{
				this.award_Task_Template_Due_Date_DataField = value;
				this.RaisePropertyChanged("Award_Task_Template_Due_Date_Data");
			}
		}

		[XmlElement(Order = 9)]
		public Award_Task_Template_Start_Date_Offset_DataType Award_Task_Template_Start_Date_Data
		{
			get
			{
				return this.award_Task_Template_Start_Date_DataField;
			}
			set
			{
				this.award_Task_Template_Start_Date_DataField = value;
				this.RaisePropertyChanged("Award_Task_Template_Start_Date_Data");
			}
		}

		[XmlElement(Order = 10)]
		public Award_Task_Template_End_Date_Offset_DataType Award_Task_Template_End_Date_Data
		{
			get
			{
				return this.award_Task_Template_End_Date_DataField;
			}
			set
			{
				this.award_Task_Template_End_Date_DataField = value;
				this.RaisePropertyChanged("Award_Task_Template_End_Date_Data");
			}
		}

		[XmlElement("Role_Assignment_Data", Order = 11)]
		public Award_Task_Role_Assignment_DataType[] Role_Assignment_Data
		{
			get
			{
				return this.role_Assignment_DataField;
			}
			set
			{
				this.role_Assignment_DataField = value;
				this.RaisePropertyChanged("Role_Assignment_Data");
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
