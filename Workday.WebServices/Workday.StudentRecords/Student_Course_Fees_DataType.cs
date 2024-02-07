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
	public class Student_Course_Fees_DataType : INotifyPropertyChanged
	{
		private decimal course_Fee_AmountField;

		private bool course_Fee_AmountFieldSpecified;

		private CalculationObjectType calculation_ReferenceField;

		private Student_Charge_ItemObjectType course_Fee_Charge_Item_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Course_Fee_Amount
		{
			get
			{
				return this.course_Fee_AmountField;
			}
			set
			{
				this.course_Fee_AmountField = value;
				this.RaisePropertyChanged("Course_Fee_Amount");
			}
		}

		[XmlIgnore]
		public bool Course_Fee_AmountSpecified
		{
			get
			{
				return this.course_Fee_AmountFieldSpecified;
			}
			set
			{
				this.course_Fee_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Course_Fee_AmountSpecified");
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
		public Student_Charge_ItemObjectType Course_Fee_Charge_Item_Reference
		{
			get
			{
				return this.course_Fee_Charge_Item_ReferenceField;
			}
			set
			{
				this.course_Fee_Charge_Item_ReferenceField = value;
				this.RaisePropertyChanged("Course_Fee_Charge_Item_Reference");
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
