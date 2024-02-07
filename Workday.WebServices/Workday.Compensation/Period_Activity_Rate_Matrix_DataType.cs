using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Period_Activity_Rate_Matrix_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string period_Activity_Rate_Table_NameField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Condition_RuleObjectType[] condition_Rule_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Period_Activity_Rate_Matrix_Entry_DataType[] period_Activity_Rate_Matrix_Entry_DataField;

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
		public string Period_Activity_Rate_Table_Name
		{
			get
			{
				return this.period_Activity_Rate_Table_NameField;
			}
			set
			{
				this.period_Activity_Rate_Table_NameField = value;
				this.RaisePropertyChanged("Period_Activity_Rate_Table_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement("Condition_Rule_Reference", Order = 3)]
		public Condition_RuleObjectType[] Condition_Rule_Reference
		{
			get
			{
				return this.condition_Rule_ReferenceField;
			}
			set
			{
				this.condition_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Condition_Rule_Reference");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement("Period_Activity_Rate_Matrix_Entry_Data", Order = 6)]
		public Period_Activity_Rate_Matrix_Entry_DataType[] Period_Activity_Rate_Matrix_Entry_Data
		{
			get
			{
				return this.period_Activity_Rate_Matrix_Entry_DataField;
			}
			set
			{
				this.period_Activity_Rate_Matrix_Entry_DataField = value;
				this.RaisePropertyChanged("Period_Activity_Rate_Matrix_Entry_Data");
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
