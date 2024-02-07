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
	public class External_Payroll_Input_DataType : INotifyPropertyChanged
	{
		private string payroll_Input_IDField;

		private EmployeeObjectType payee_ReferenceField;

		private Pay_ComponentObjectType pay_Component_Workday_ReferenceField;

		private string external_Payroll_CodeField;

		private string batch_IDField;

		private DateTime start_DateField;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Position_ElementObjectType position_ReferenceField;

		private Payroll_WorktagObjectType worktag_ReferenceField;

		private decimal input_ValueField;

		private bool input_ValueFieldSpecified;

		private decimal goal_AmountField;

		private bool goal_AmountFieldSpecified;

		private decimal adjustment_ValueField;

		private bool adjustment_ValueFieldSpecified;

		private string commentField;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Payroll_Input_ID
		{
			get
			{
				return this.payroll_Input_IDField;
			}
			set
			{
				this.payroll_Input_IDField = value;
				this.RaisePropertyChanged("Payroll_Input_ID");
			}
		}

		[XmlElement(Order = 1)]
		public EmployeeObjectType Payee_Reference
		{
			get
			{
				return this.payee_ReferenceField;
			}
			set
			{
				this.payee_ReferenceField = value;
				this.RaisePropertyChanged("Payee_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Pay_ComponentObjectType Pay_Component_Workday_Reference
		{
			get
			{
				return this.pay_Component_Workday_ReferenceField;
			}
			set
			{
				this.pay_Component_Workday_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Component_Workday_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public string Batch_ID
		{
			get
			{
				return this.batch_IDField;
			}
			set
			{
				this.batch_IDField = value;
				this.RaisePropertyChanged("Batch_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement(DataType = "date", Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public Payroll_WorktagObjectType Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Input_Value
		{
			get
			{
				return this.input_ValueField;
			}
			set
			{
				this.input_ValueField = value;
				this.RaisePropertyChanged("Input_Value");
			}
		}

		[XmlIgnore]
		public bool Input_ValueSpecified
		{
			get
			{
				return this.input_ValueFieldSpecified;
			}
			set
			{
				this.input_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Input_ValueSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Goal_Amount
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

		[XmlIgnore]
		public bool Goal_AmountSpecified
		{
			get
			{
				return this.goal_AmountFieldSpecified;
			}
			set
			{
				this.goal_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Goal_AmountSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Adjustment_Value
		{
			get
			{
				return this.adjustment_ValueField;
			}
			set
			{
				this.adjustment_ValueField = value;
				this.RaisePropertyChanged("Adjustment_Value");
			}
		}

		[XmlIgnore]
		public bool Adjustment_ValueSpecified
		{
			get
			{
				return this.adjustment_ValueFieldSpecified;
			}
			set
			{
				this.adjustment_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Adjustment_ValueSpecified");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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
