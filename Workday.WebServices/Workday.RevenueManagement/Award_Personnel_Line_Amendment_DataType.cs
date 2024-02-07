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
	public class Award_Personnel_Line_Amendment_DataType : INotifyPropertyChanged
	{
		private Award_Personnel_LineObjectType award_Personnel_Line_Amendment_ReferenceField;

		private string award_Personnel_Line_Amendment_Reference_IDField;

		private Award_YearObjectType award_Personnel_Line_Amendment_Budget_Period_ReferenceField;

		private decimal award_Personnel_Line_Amendment_MonthsField;

		private bool award_Personnel_Line_Amendment_MonthsFieldSpecified;

		private decimal award_Personnel_Line_Amendment_Annual_Committed_EffortField;

		private bool award_Personnel_Line_Amendment_Annual_Committed_EffortFieldSpecified;

		private decimal award_Personnel_Line_Amendment_Cost_ShareField;

		private bool award_Personnel_Line_Amendment_Cost_ShareFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_Personnel_LineObjectType Award_Personnel_Line_Amendment_Reference
		{
			get
			{
				return this.award_Personnel_Line_Amendment_ReferenceField;
			}
			set
			{
				this.award_Personnel_Line_Amendment_ReferenceField = value;
				this.RaisePropertyChanged("Award_Personnel_Line_Amendment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Award_Personnel_Line_Amendment_Reference_ID
		{
			get
			{
				return this.award_Personnel_Line_Amendment_Reference_IDField;
			}
			set
			{
				this.award_Personnel_Line_Amendment_Reference_IDField = value;
				this.RaisePropertyChanged("Award_Personnel_Line_Amendment_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Award_YearObjectType Award_Personnel_Line_Amendment_Budget_Period_Reference
		{
			get
			{
				return this.award_Personnel_Line_Amendment_Budget_Period_ReferenceField;
			}
			set
			{
				this.award_Personnel_Line_Amendment_Budget_Period_ReferenceField = value;
				this.RaisePropertyChanged("Award_Personnel_Line_Amendment_Budget_Period_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Award_Personnel_Line_Amendment_Months
		{
			get
			{
				return this.award_Personnel_Line_Amendment_MonthsField;
			}
			set
			{
				this.award_Personnel_Line_Amendment_MonthsField = value;
				this.RaisePropertyChanged("Award_Personnel_Line_Amendment_Months");
			}
		}

		[XmlIgnore]
		public bool Award_Personnel_Line_Amendment_MonthsSpecified
		{
			get
			{
				return this.award_Personnel_Line_Amendment_MonthsFieldSpecified;
			}
			set
			{
				this.award_Personnel_Line_Amendment_MonthsFieldSpecified = value;
				this.RaisePropertyChanged("Award_Personnel_Line_Amendment_MonthsSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Award_Personnel_Line_Amendment_Annual_Committed_Effort
		{
			get
			{
				return this.award_Personnel_Line_Amendment_Annual_Committed_EffortField;
			}
			set
			{
				this.award_Personnel_Line_Amendment_Annual_Committed_EffortField = value;
				this.RaisePropertyChanged("Award_Personnel_Line_Amendment_Annual_Committed_Effort");
			}
		}

		[XmlIgnore]
		public bool Award_Personnel_Line_Amendment_Annual_Committed_EffortSpecified
		{
			get
			{
				return this.award_Personnel_Line_Amendment_Annual_Committed_EffortFieldSpecified;
			}
			set
			{
				this.award_Personnel_Line_Amendment_Annual_Committed_EffortFieldSpecified = value;
				this.RaisePropertyChanged("Award_Personnel_Line_Amendment_Annual_Committed_EffortSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Award_Personnel_Line_Amendment_Cost_Share
		{
			get
			{
				return this.award_Personnel_Line_Amendment_Cost_ShareField;
			}
			set
			{
				this.award_Personnel_Line_Amendment_Cost_ShareField = value;
				this.RaisePropertyChanged("Award_Personnel_Line_Amendment_Cost_Share");
			}
		}

		[XmlIgnore]
		public bool Award_Personnel_Line_Amendment_Cost_ShareSpecified
		{
			get
			{
				return this.award_Personnel_Line_Amendment_Cost_ShareFieldSpecified;
			}
			set
			{
				this.award_Personnel_Line_Amendment_Cost_ShareFieldSpecified = value;
				this.RaisePropertyChanged("Award_Personnel_Line_Amendment_Cost_ShareSpecified");
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
