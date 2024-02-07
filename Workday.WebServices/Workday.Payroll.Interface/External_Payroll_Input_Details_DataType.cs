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
	public class External_Payroll_Input_Details_DataType : INotifyPropertyChanged
	{
		private Application_BatchObjectType batch_ReferenceField;

		private DateTime start_DateField;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private PositionObjectType position_ReferenceField;

		private Tenanted_Payroll_WorktagObjectType worktag_ReferenceField;

		private decimal input_ValueField;

		private bool input_ValueFieldSpecified;

		private decimal goal_AmountField;

		private bool goal_AmountFieldSpecified;

		private decimal adjustment_ValueField;

		private bool adjustment_ValueFieldSpecified;

		private string commentField;

		private CurrencyObjectType currency_ReferenceField;

		private External_Payroll_Input_Currency_Conversion_DataType currency_Conversion_Details_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Application_BatchObjectType Batch_Reference
		{
			get
			{
				return this.batch_ReferenceField;
			}
			set
			{
				this.batch_ReferenceField = value;
				this.RaisePropertyChanged("Batch_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement(Order = 3)]
		public PositionObjectType Position_Reference
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

		[XmlElement(Order = 4)]
		public Tenanted_Payroll_WorktagObjectType Worktag_Reference
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public External_Payroll_Input_Currency_Conversion_DataType Currency_Conversion_Details_Data
		{
			get
			{
				return this.currency_Conversion_Details_DataField;
			}
			set
			{
				this.currency_Conversion_Details_DataField = value;
				this.RaisePropertyChanged("Currency_Conversion_Details_Data");
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
