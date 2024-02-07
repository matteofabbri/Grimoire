using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Earning_Deduction_Code_Summary_DataType : INotifyPropertyChanged
	{
		private Pay_ComponentObjectType code_ReferenceField;

		private string external_Payroll_CodeField;

		private bool position_BasedField;

		private bool position_BasedFieldSpecified;

		private Position_ElementObjectType position_ReferenceField;

		private object[] itemsField;

		private decimal prorated_AmountField;

		private bool prorated_AmountFieldSpecified;

		private DateTime maximum_of_Event_Effective_Dates_and_Recent_FTE_Change_DateField;

		private bool maximum_of_Event_Effective_Dates_and_Recent_FTE_Change_DateFieldSpecified;

		private Coverage_DataType[] coverage_DataField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private FrequencyObjectType frequency_ReferenceField;

		private Goal_AmountType[] goal_AmountField;

		private Costing_Worktag_DataType[] costing_Worktag_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Pay_ComponentObjectType Code_Reference
		{
			get
			{
				return this.code_ReferenceField;
			}
			set
			{
				this.code_ReferenceField = value;
				this.RaisePropertyChanged("Code_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string External_Payroll_Code
		{
			get
			{
				return this.external_Payroll_CodeField;
			}
			set
			{
				this.external_Payroll_CodeField = value;
				this.RaisePropertyChanged("External_Payroll_Code");
			}
		}

		[XmlElement(Order = 2)]
		public bool Position_Based
		{
			get
			{
				return this.position_BasedField;
			}
			set
			{
				this.position_BasedField = value;
				this.RaisePropertyChanged("Position_Based");
			}
		}

		[XmlIgnore]
		public bool Position_BasedSpecified
		{
			get
			{
				return this.position_BasedFieldSpecified;
			}
			set
			{
				this.position_BasedFieldSpecified = value;
				this.RaisePropertyChanged("Position_BasedSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement("Amount_Data", typeof(Amount_DataType), Order = 4), XmlElement("Percentage", typeof(decimal), Order = 4)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Prorated_Amount
		{
			get
			{
				return this.prorated_AmountField;
			}
			set
			{
				this.prorated_AmountField = value;
				this.RaisePropertyChanged("Prorated_Amount");
			}
		}

		[XmlIgnore]
		public bool Prorated_AmountSpecified
		{
			get
			{
				return this.prorated_AmountFieldSpecified;
			}
			set
			{
				this.prorated_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Prorated_AmountSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Maximum_of_Event_Effective_Dates_and_Recent_FTE_Change_Date
		{
			get
			{
				return this.maximum_of_Event_Effective_Dates_and_Recent_FTE_Change_DateField;
			}
			set
			{
				this.maximum_of_Event_Effective_Dates_and_Recent_FTE_Change_DateField = value;
				this.RaisePropertyChanged("Maximum_of_Event_Effective_Dates_and_Recent_FTE_Change_Date");
			}
		}

		[XmlIgnore]
		public bool Maximum_of_Event_Effective_Dates_and_Recent_FTE_Change_DateSpecified
		{
			get
			{
				return this.maximum_of_Event_Effective_Dates_and_Recent_FTE_Change_DateFieldSpecified;
			}
			set
			{
				this.maximum_of_Event_Effective_Dates_and_Recent_FTE_Change_DateFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_of_Event_Effective_Dates_and_Recent_FTE_Change_DateSpecified");
			}
		}

		[XmlElement("Coverage_Data", Order = 7)]
		public Coverage_DataType[] Coverage_Data
		{
			get
			{
				return this.coverage_DataField;
			}
			set
			{
				this.coverage_DataField = value;
				this.RaisePropertyChanged("Coverage_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
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

		[XmlElement(DataType = "date", Order = 9)]
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

		[XmlElement(Order = 10)]
		public FrequencyObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement("Goal_Amount", Order = 11)]
		public Goal_AmountType[] Goal_Amount
		{
			get
			{
				return this.goal_AmountField;
			}
			set
			{
				this.goal_AmountField = value;
				this.RaisePropertyChanged("Goal_Amount");
			}
		}

		[XmlElement("Costing_Worktag_Data", Order = 12)]
		public Costing_Worktag_DataType[] Costing_Worktag_Data
		{
			get
			{
				return this.costing_Worktag_DataField;
			}
			set
			{
				this.costing_Worktag_DataField = value;
				this.RaisePropertyChanged("Costing_Worktag_Data");
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
