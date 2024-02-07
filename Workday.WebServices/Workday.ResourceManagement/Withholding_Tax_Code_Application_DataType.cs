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
	public class Withholding_Tax_Code_Application_DataType : INotifyPropertyChanged
	{
		private Tax_CodeObjectType withholding_Tax_Code_ReferenceField;

		private decimal withholding_Taxable_AmountField;

		private Tax_Rate_Application_DataType[] withholding_Tax_Rate_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Tax_CodeObjectType Withholding_Tax_Code_Reference
		{
			get
			{
				return this.withholding_Tax_Code_ReferenceField;
			}
			set
			{
				this.withholding_Tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Withholding_Taxable_Amount
		{
			get
			{
				return this.withholding_Taxable_AmountField;
			}
			set
			{
				this.withholding_Taxable_AmountField = value;
				this.RaisePropertyChanged("Withholding_Taxable_Amount");
			}
		}

		[XmlElement("Withholding_Tax_Rate_Data", Order = 2)]
		public Tax_Rate_Application_DataType[] Withholding_Tax_Rate_Data
		{
			get
			{
				return this.withholding_Tax_Rate_DataField;
			}
			set
			{
				this.withholding_Tax_Rate_DataField = value;
				this.RaisePropertyChanged("Withholding_Tax_Rate_Data");
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
