using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class History_Payment_Input_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private Position_ElementObjectType position_ReferenceField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private decimal taxable_WagesField;

		private bool taxable_WagesFieldSpecified;

		private decimal subject_WagesField;

		private bool subject_WagesFieldSpecified;

		private Payroll_Input_Worktags_DataType payroll_Input_Worktags_DataField;

		private string commentField;

		private History_Payment_Input_Line_DataType[] history_Payment_Input_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Deduction_Reference", typeof(Deduction__All_ObjectType), Order = 0), XmlElement("Earning_Reference", typeof(Earning__All_ObjectType), Order = 0)]
		public object Item
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public decimal Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlIgnore]
		public bool AmountSpecified
		{
			get
			{
				return this.amountFieldSpecified;
			}
			set
			{
				this.amountFieldSpecified = value;
				this.RaisePropertyChanged("AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Taxable_Wages
		{
			get
			{
				return this.taxable_WagesField;
			}
			set
			{
				this.taxable_WagesField = value;
				this.RaisePropertyChanged("Taxable_Wages");
			}
		}

		[XmlIgnore]
		public bool Taxable_WagesSpecified
		{
			get
			{
				return this.taxable_WagesFieldSpecified;
			}
			set
			{
				this.taxable_WagesFieldSpecified = value;
				this.RaisePropertyChanged("Taxable_WagesSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Subject_Wages
		{
			get
			{
				return this.subject_WagesField;
			}
			set
			{
				this.subject_WagesField = value;
				this.RaisePropertyChanged("Subject_Wages");
			}
		}

		[XmlIgnore]
		public bool Subject_WagesSpecified
		{
			get
			{
				return this.subject_WagesFieldSpecified;
			}
			set
			{
				this.subject_WagesFieldSpecified = value;
				this.RaisePropertyChanged("Subject_WagesSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Payroll_Input_Worktags_DataType Payroll_Input_Worktags_Data
		{
			get
			{
				return this.payroll_Input_Worktags_DataField;
			}
			set
			{
				this.payroll_Input_Worktags_DataField = value;
				this.RaisePropertyChanged("Payroll_Input_Worktags_Data");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement("History_Payment_Input_Line_Data", Order = 7)]
		public History_Payment_Input_Line_DataType[] History_Payment_Input_Line_Data
		{
			get
			{
				return this.history_Payment_Input_Line_DataField;
			}
			set
			{
				this.history_Payment_Input_Line_DataField = value;
				this.RaisePropertyChanged("History_Payment_Input_Line_Data");
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
