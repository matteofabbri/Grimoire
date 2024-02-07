using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Additional_Fees_DataType : INotifyPropertyChanged
	{
		private decimal additional_Fee_AmountField;

		private bool additional_Fee_AmountFieldSpecified;

		private CalculationObjectType calculation_ReferenceField;

		private Student_Charge_ItemObjectType additional_Fee_Charge_Item_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Additional_Fee_Amount
		{
			get
			{
				return this.additional_Fee_AmountField;
			}
			set
			{
				this.additional_Fee_AmountField = value;
				this.RaisePropertyChanged("Additional_Fee_Amount");
			}
		}

		[XmlIgnore]
		public bool Additional_Fee_AmountSpecified
		{
			get
			{
				return this.additional_Fee_AmountFieldSpecified;
			}
			set
			{
				this.additional_Fee_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Additional_Fee_AmountSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public CalculationObjectType Calculation_Reference
		{
			get
			{
				return this.calculation_ReferenceField;
			}
			set
			{
				this.calculation_ReferenceField = value;
				this.RaisePropertyChanged("Calculation_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Student_Charge_ItemObjectType Additional_Fee_Charge_Item_Reference
		{
			get
			{
				return this.additional_Fee_Charge_Item_ReferenceField;
			}
			set
			{
				this.additional_Fee_Charge_Item_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Fee_Charge_Item_Reference");
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
