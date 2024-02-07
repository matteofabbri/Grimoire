using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Tax_ID_DataType : INotifyPropertyChanged
	{
		private string tax_ID_TextField;

		private Tax_ID_TypeObjectType tax_ID_Type_ReferenceField;

		private bool transaction_Tax_IDField;

		private bool transaction_Tax_IDFieldSpecified;

		private bool primary_Tax_IDField;

		private bool primary_Tax_IDFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Tax_ID_Text
		{
			get
			{
				return this.tax_ID_TextField;
			}
			set
			{
				this.tax_ID_TextField = value;
				this.RaisePropertyChanged("Tax_ID_Text");
			}
		}

		[XmlElement(Order = 1)]
		public Tax_ID_TypeObjectType Tax_ID_Type_Reference
		{
			get
			{
				return this.tax_ID_Type_ReferenceField;
			}
			set
			{
				this.tax_ID_Type_ReferenceField = value;
				this.RaisePropertyChanged("Tax_ID_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Transaction_Tax_ID
		{
			get
			{
				return this.transaction_Tax_IDField;
			}
			set
			{
				this.transaction_Tax_IDField = value;
				this.RaisePropertyChanged("Transaction_Tax_ID");
			}
		}

		[XmlIgnore]
		public bool Transaction_Tax_IDSpecified
		{
			get
			{
				return this.transaction_Tax_IDFieldSpecified;
			}
			set
			{
				this.transaction_Tax_IDFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Tax_IDSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Primary_Tax_ID
		{
			get
			{
				return this.primary_Tax_IDField;
			}
			set
			{
				this.primary_Tax_IDField = value;
				this.RaisePropertyChanged("Primary_Tax_ID");
			}
		}

		[XmlIgnore]
		public bool Primary_Tax_IDSpecified
		{
			get
			{
				return this.primary_Tax_IDFieldSpecified;
			}
			set
			{
				this.primary_Tax_IDFieldSpecified = value;
				this.RaisePropertyChanged("Primary_Tax_IDSpecified");
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
