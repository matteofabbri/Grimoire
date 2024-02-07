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
	public class Expense_Adjustment_Calculation_Method_DataType : INotifyPropertyChanged
	{
		private Arithmetic_OperatorObjectType arithmetic_Operator_ReferenceField;

		private Expense_Rate_TableObjectType expense_Rate_Table_ReferenceField;

		private bool multiply_Result_by_Quantity_Field;

		private bool multiply_Result_by_Quantity_FieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Arithmetic_OperatorObjectType Arithmetic_Operator_Reference
		{
			get
			{
				return this.arithmetic_Operator_ReferenceField;
			}
			set
			{
				this.arithmetic_Operator_ReferenceField = value;
				this.RaisePropertyChanged("Arithmetic_Operator_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Expense_Rate_TableObjectType Expense_Rate_Table_Reference
		{
			get
			{
				return this.expense_Rate_Table_ReferenceField;
			}
			set
			{
				this.expense_Rate_Table_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Rate_Table_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Multiply_Result_by_Quantity_
		{
			get
			{
				return this.multiply_Result_by_Quantity_Field;
			}
			set
			{
				this.multiply_Result_by_Quantity_Field = value;
				this.RaisePropertyChanged("Multiply_Result_by_Quantity_");
			}
		}

		[XmlIgnore]
		public bool Multiply_Result_by_Quantity_Specified
		{
			get
			{
				return this.multiply_Result_by_Quantity_FieldSpecified;
			}
			set
			{
				this.multiply_Result_by_Quantity_FieldSpecified = value;
				this.RaisePropertyChanged("Multiply_Result_by_Quantity_Specified");
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
