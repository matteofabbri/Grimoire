using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Taxable_Document_Line_DataType : INotifyPropertyChanged
	{
		private Taxable_Document_LineObjectType taxable_Document_Line_ReferenceField;

		private decimal calculated_Tax_AmountField;

		private bool calculated_Tax_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Taxable_Document_LineObjectType Taxable_Document_Line_Reference
		{
			get
			{
				return this.taxable_Document_Line_ReferenceField;
			}
			set
			{
				this.taxable_Document_Line_ReferenceField = value;
				this.RaisePropertyChanged("Taxable_Document_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Calculated_Tax_Amount
		{
			get
			{
				return this.calculated_Tax_AmountField;
			}
			set
			{
				this.calculated_Tax_AmountField = value;
				this.RaisePropertyChanged("Calculated_Tax_Amount");
			}
		}

		[XmlIgnore]
		public bool Calculated_Tax_AmountSpecified
		{
			get
			{
				return this.calculated_Tax_AmountFieldSpecified;
			}
			set
			{
				this.calculated_Tax_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Calculated_Tax_AmountSpecified");
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
