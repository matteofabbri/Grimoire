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
	public class Tax_Category_DataType : INotifyPropertyChanged
	{
		private string tax_Category_IDField;

		private string tax_Category_NameField;

		private bool subject_to_RecoverabilityField;

		private bool subject_to_RecoverabilityFieldSpecified;

		private bool withholding_TaxField;

		private bool withholding_TaxFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Tax_Category_ID
		{
			get
			{
				return this.tax_Category_IDField;
			}
			set
			{
				this.tax_Category_IDField = value;
				this.RaisePropertyChanged("Tax_Category_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Tax_Category_Name
		{
			get
			{
				return this.tax_Category_NameField;
			}
			set
			{
				this.tax_Category_NameField = value;
				this.RaisePropertyChanged("Tax_Category_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Subject_to_Recoverability
		{
			get
			{
				return this.subject_to_RecoverabilityField;
			}
			set
			{
				this.subject_to_RecoverabilityField = value;
				this.RaisePropertyChanged("Subject_to_Recoverability");
			}
		}

		[XmlIgnore]
		public bool Subject_to_RecoverabilitySpecified
		{
			get
			{
				return this.subject_to_RecoverabilityFieldSpecified;
			}
			set
			{
				this.subject_to_RecoverabilityFieldSpecified = value;
				this.RaisePropertyChanged("Subject_to_RecoverabilitySpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Withholding_Tax
		{
			get
			{
				return this.withholding_TaxField;
			}
			set
			{
				this.withholding_TaxField = value;
				this.RaisePropertyChanged("Withholding_Tax");
			}
		}

		[XmlIgnore]
		public bool Withholding_TaxSpecified
		{
			get
			{
				return this.withholding_TaxFieldSpecified;
			}
			set
			{
				this.withholding_TaxFieldSpecified = value;
				this.RaisePropertyChanged("Withholding_TaxSpecified");
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
