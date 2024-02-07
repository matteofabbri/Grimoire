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
	public class Currency_Rate_Type_DataType : INotifyPropertyChanged
	{
		private string currency_Rate_Type_IDField;

		private string currency_Rate_Type_DescriptionField;

		private bool currency_Rate_Type_DefaultField;

		private bool currency_Rate_Type_DefaultFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Currency_Rate_Type_ID
		{
			get
			{
				return this.currency_Rate_Type_IDField;
			}
			set
			{
				this.currency_Rate_Type_IDField = value;
				this.RaisePropertyChanged("Currency_Rate_Type_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Currency_Rate_Type_Description
		{
			get
			{
				return this.currency_Rate_Type_DescriptionField;
			}
			set
			{
				this.currency_Rate_Type_DescriptionField = value;
				this.RaisePropertyChanged("Currency_Rate_Type_Description");
			}
		}

		[XmlElement(Order = 2)]
		public bool Currency_Rate_Type_Default
		{
			get
			{
				return this.currency_Rate_Type_DefaultField;
			}
			set
			{
				this.currency_Rate_Type_DefaultField = value;
				this.RaisePropertyChanged("Currency_Rate_Type_Default");
			}
		}

		[XmlIgnore]
		public bool Currency_Rate_Type_DefaultSpecified
		{
			get
			{
				return this.currency_Rate_Type_DefaultFieldSpecified;
			}
			set
			{
				this.currency_Rate_Type_DefaultFieldSpecified = value;
				this.RaisePropertyChanged("Currency_Rate_Type_DefaultSpecified");
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
