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
	public class Project_Billing_Rate_Sheet_DataType : INotifyPropertyChanged
	{
		private string project_Billing_Rate_Sheet_IDField;

		private string project_Billing_Rate_Sheet_NameField;

		private CurrencyObjectType currency_ReferenceField;

		private DateTime effective_DateField;

		private Project_Billing_Rate_DataType[] project_Billing_RatesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_Billing_Rate_Sheet_ID
		{
			get
			{
				return this.project_Billing_Rate_Sheet_IDField;
			}
			set
			{
				this.project_Billing_Rate_Sheet_IDField = value;
				this.RaisePropertyChanged("Project_Billing_Rate_Sheet_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Project_Billing_Rate_Sheet_Name
		{
			get
			{
				return this.project_Billing_Rate_Sheet_NameField;
			}
			set
			{
				this.project_Billing_Rate_Sheet_NameField = value;
				this.RaisePropertyChanged("Project_Billing_Rate_Sheet_Name");
			}
		}

		[XmlElement(Order = 2)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlElement("Project_Billing_Rates", Order = 4)]
		public Project_Billing_Rate_DataType[] Project_Billing_Rates
		{
			get
			{
				return this.project_Billing_RatesField;
			}
			set
			{
				this.project_Billing_RatesField = value;
				this.RaisePropertyChanged("Project_Billing_Rates");
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
