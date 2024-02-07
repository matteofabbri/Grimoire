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
	public class Taxable_Document_DataType : INotifyPropertyChanged
	{
		private string tax_Calculation_DetailsField;

		private Taxable_Document_Line_DataType[] taxable_Document_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Tax_Calculation_Details
		{
			get
			{
				return this.tax_Calculation_DetailsField;
			}
			set
			{
				this.tax_Calculation_DetailsField = value;
				this.RaisePropertyChanged("Tax_Calculation_Details");
			}
		}

		[XmlElement("Taxable_Document_Line_Data", Order = 1)]
		public Taxable_Document_Line_DataType[] Taxable_Document_Line_Data
		{
			get
			{
				return this.taxable_Document_Line_DataField;
			}
			set
			{
				this.taxable_Document_Line_DataField = value;
				this.RaisePropertyChanged("Taxable_Document_Line_Data");
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
