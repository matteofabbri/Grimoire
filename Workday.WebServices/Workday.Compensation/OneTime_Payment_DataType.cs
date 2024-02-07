using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "One-Time_Payment_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class OneTime_Payment_DataType : INotifyPropertyChanged
	{
		private OneTime_Payment_PlanObjectType one_Time_Payment_Plan_ReferenceField;

		private DateTime scheduled_Payment_DateField;

		private bool scheduled_Payment_DateFieldSpecified;

		private DateTime coverage_Start_DateField;

		private bool coverage_Start_DateFieldSpecified;

		private DateTime coverage_End_DateField;

		private bool coverage_End_DateFieldSpecified;

		private decimal itemField;

		private ItemChoiceType2 itemElementNameField;

		private CurrencyObjectType currency_ReferenceField;

		private string commentField;

		private bool do_Not_PayField;

		private bool do_Not_PayFieldSpecified;

		private Tenanted_Payroll_WorktagObjectType[] one_Time_Payment_Worktags_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public OneTime_Payment_PlanObjectType One_Time_Payment_Plan_Reference
		{
			get
			{
				return this.one_Time_Payment_Plan_ReferenceField;
			}
			set
			{
				this.one_Time_Payment_Plan_ReferenceField = value;
				this.RaisePropertyChanged("One_Time_Payment_Plan_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Scheduled_Payment_Date
		{
			get
			{
				return this.scheduled_Payment_DateField;
			}
			set
			{
				this.scheduled_Payment_DateField = value;
				this.RaisePropertyChanged("Scheduled_Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Scheduled_Payment_DateSpecified
		{
			get
			{
				return this.scheduled_Payment_DateFieldSpecified;
			}
			set
			{
				this.scheduled_Payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Scheduled_Payment_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Coverage_Start_Date
		{
			get
			{
				return this.coverage_Start_DateField;
			}
			set
			{
				this.coverage_Start_DateField = value;
				this.RaisePropertyChanged("Coverage_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Coverage_Start_DateSpecified
		{
			get
			{
				return this.coverage_Start_DateFieldSpecified;
			}
			set
			{
				this.coverage_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Coverage_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Coverage_End_Date
		{
			get
			{
				return this.coverage_End_DateField;
			}
			set
			{
				this.coverage_End_DateField = value;
				this.RaisePropertyChanged("Coverage_End_Date");
			}
		}

		[XmlIgnore]
		public bool Coverage_End_DateSpecified
		{
			get
			{
				return this.coverage_End_DateFieldSpecified;
			}
			set
			{
				this.coverage_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Coverage_End_DateSpecified");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Amount", typeof(decimal), Order = 4), XmlElement("Percent", typeof(decimal), Order = 4)]
		public decimal Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 5), XmlIgnore]
		public ItemChoiceType2 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement(Order = 6)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
			}
		}

		[XmlElement(Order = 8)]
		public bool Do_Not_Pay
		{
			get
			{
				return this.do_Not_PayField;
			}
			set
			{
				this.do_Not_PayField = value;
				this.RaisePropertyChanged("Do_Not_Pay");
			}
		}

		[XmlIgnore]
		public bool Do_Not_PaySpecified
		{
			get
			{
				return this.do_Not_PayFieldSpecified;
			}
			set
			{
				this.do_Not_PayFieldSpecified = value;
				this.RaisePropertyChanged("Do_Not_PaySpecified");
			}
		}

		[XmlElement("One_Time_Payment_Worktags_Reference", Order = 9)]
		public Tenanted_Payroll_WorktagObjectType[] One_Time_Payment_Worktags_Reference
		{
			get
			{
				return this.one_Time_Payment_Worktags_ReferenceField;
			}
			set
			{
				this.one_Time_Payment_Worktags_ReferenceField = value;
				this.RaisePropertyChanged("One_Time_Payment_Worktags_Reference");
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
