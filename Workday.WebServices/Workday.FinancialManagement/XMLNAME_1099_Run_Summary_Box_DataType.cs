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
	public class XMLNAME_1099_Run_Summary_Box_DataType : INotifyPropertyChanged
	{
		private IRS_1099_MISC_CategoryObjectType iRS_1099_Category_ReferenceField;

		private string iRS_1099_Box_NumberField;

		private string iRS_1099_Amount_CodeField;

		private decimal payment_Amount_for_1099_CategoryField;

		private bool payment_Amount_for_1099_CategoryFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public IRS_1099_MISC_CategoryObjectType IRS_1099_Category_Reference
		{
			get
			{
				return this.iRS_1099_Category_ReferenceField;
			}
			set
			{
				this.iRS_1099_Category_ReferenceField = value;
				this.RaisePropertyChanged("IRS_1099_Category_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string IRS_1099_Box_Number
		{
			get
			{
				return this.iRS_1099_Box_NumberField;
			}
			set
			{
				this.iRS_1099_Box_NumberField = value;
				this.RaisePropertyChanged("IRS_1099_Box_Number");
			}
		}

		[XmlElement(Order = 2)]
		public string IRS_1099_Amount_Code
		{
			get
			{
				return this.iRS_1099_Amount_CodeField;
			}
			set
			{
				this.iRS_1099_Amount_CodeField = value;
				this.RaisePropertyChanged("IRS_1099_Amount_Code");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Payment_Amount_for_1099_Category
		{
			get
			{
				return this.payment_Amount_for_1099_CategoryField;
			}
			set
			{
				this.payment_Amount_for_1099_CategoryField = value;
				this.RaisePropertyChanged("Payment_Amount_for_1099_Category");
			}
		}

		[XmlIgnore]
		public bool Payment_Amount_for_1099_CategorySpecified
		{
			get
			{
				return this.payment_Amount_for_1099_CategoryFieldSpecified;
			}
			set
			{
				this.payment_Amount_for_1099_CategoryFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Amount_for_1099_CategorySpecified");
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
