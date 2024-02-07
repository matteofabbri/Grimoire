using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payment_Election_Enrollment_for_Worker_DataType : INotifyPropertyChanged
	{
		private Payment_Election_EnrollableObjectType role_ID_ReferenceField;

		private CountryObjectType country_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Payment_Election_Rule_Group_DataType[] payment_Election_Rule_Group_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payment_Election_EnrollableObjectType Role_ID_Reference
		{
			get
			{
				return this.role_ID_ReferenceField;
			}
			set
			{
				this.role_ID_ReferenceField = value;
				this.RaisePropertyChanged("Role_ID_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
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

		[XmlElement("Payment_Election_Rule_Group_Data", Order = 3)]
		public Payment_Election_Rule_Group_DataType[] Payment_Election_Rule_Group_Data
		{
			get
			{
				return this.payment_Election_Rule_Group_DataField;
			}
			set
			{
				this.payment_Election_Rule_Group_DataField = value;
				this.RaisePropertyChanged("Payment_Election_Rule_Group_Data");
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
