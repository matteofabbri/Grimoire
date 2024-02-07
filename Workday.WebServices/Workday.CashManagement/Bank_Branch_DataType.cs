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
	public class Bank_Branch_DataType : INotifyPropertyChanged
	{
		private string bank_Branch_IDField;

		private Financial_InstitutionObjectType financial_Institution_ReferenceField;

		private string bank_Branch_ID_NumberField;

		private Business_Entity_WWS_DataType business_Entity_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Bank_Branch_ID
		{
			get
			{
				return this.bank_Branch_IDField;
			}
			set
			{
				this.bank_Branch_IDField = value;
				this.RaisePropertyChanged("Bank_Branch_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Financial_InstitutionObjectType Financial_Institution_Reference
		{
			get
			{
				return this.financial_Institution_ReferenceField;
			}
			set
			{
				this.financial_Institution_ReferenceField = value;
				this.RaisePropertyChanged("Financial_Institution_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Bank_Branch_ID_Number
		{
			get
			{
				return this.bank_Branch_ID_NumberField;
			}
			set
			{
				this.bank_Branch_ID_NumberField = value;
				this.RaisePropertyChanged("Bank_Branch_ID_Number");
			}
		}

		[XmlElement(Order = 3)]
		public Business_Entity_WWS_DataType Business_Entity_Data
		{
			get
			{
				return this.business_Entity_DataField;
			}
			set
			{
				this.business_Entity_DataField = value;
				this.RaisePropertyChanged("Business_Entity_Data");
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
