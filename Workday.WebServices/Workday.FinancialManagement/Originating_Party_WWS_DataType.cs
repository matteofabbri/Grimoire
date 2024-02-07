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
	public class Originating_Party_WWS_DataType : INotifyPropertyChanged
	{
		private string organization_NameField;

		private string transaction_Tax_IDField;

		private Address_Information_DataType address_Information_DataField;

		private string organization_Primary_Phone_NumberField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Organization_Name
		{
			get
			{
				return this.organization_NameField;
			}
			set
			{
				this.organization_NameField = value;
				this.RaisePropertyChanged("Organization_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Transaction_Tax_ID
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

		[XmlElement(Order = 2)]
		public Address_Information_DataType Address_Information_Data
		{
			get
			{
				return this.address_Information_DataField;
			}
			set
			{
				this.address_Information_DataField = value;
				this.RaisePropertyChanged("Address_Information_Data");
			}
		}

		[XmlElement(Order = 3)]
		public string Organization_Primary_Phone_Number
		{
			get
			{
				return this.organization_Primary_Phone_NumberField;
			}
			set
			{
				this.organization_Primary_Phone_NumberField = value;
				this.RaisePropertyChanged("Organization_Primary_Phone_Number");
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
