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
	public class Future_Payment_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private Future_Payment_PlanObjectType compensation_Plan_ReferenceField;

		private decimal individual_Target_AmountField;

		private bool individual_Target_AmountFieldSpecified;

		private CurrencyObjectType individual_Target_Currency_ReferenceField;

		private DateTime individual_Target_Payment_DateField;

		private bool individual_Target_Payment_DateFieldSpecified;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Future_Payment_PlanObjectType Compensation_Plan_Reference
		{
			get
			{
				return this.compensation_Plan_ReferenceField;
			}
			set
			{
				this.compensation_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Individual_Target_Amount
		{
			get
			{
				return this.individual_Target_AmountField;
			}
			set
			{
				this.individual_Target_AmountField = value;
				this.RaisePropertyChanged("Individual_Target_Amount");
			}
		}

		[XmlIgnore]
		public bool Individual_Target_AmountSpecified
		{
			get
			{
				return this.individual_Target_AmountFieldSpecified;
			}
			set
			{
				this.individual_Target_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Individual_Target_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public CurrencyObjectType Individual_Target_Currency_Reference
		{
			get
			{
				return this.individual_Target_Currency_ReferenceField;
			}
			set
			{
				this.individual_Target_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Individual_Target_Currency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Individual_Target_Payment_Date
		{
			get
			{
				return this.individual_Target_Payment_DateField;
			}
			set
			{
				this.individual_Target_Payment_DateField = value;
				this.RaisePropertyChanged("Individual_Target_Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Individual_Target_Payment_DateSpecified
		{
			get
			{
				return this.individual_Target_Payment_DateFieldSpecified;
			}
			set
			{
				this.individual_Target_Payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Individual_Target_Payment_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
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
