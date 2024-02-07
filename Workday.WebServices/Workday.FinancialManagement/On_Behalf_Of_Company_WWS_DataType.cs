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
	public class On_Behalf_Of_Company_WWS_DataType : INotifyPropertyChanged
	{
		private string on_Behalf_Of_Company_NameField;

		private string on_Behalf_Of_Company_Tax_IDField;

		private Address_Information_DataType on_Behalf_Of_Company_Address_DataField;

		private string on_Behalf_Of_Company_Primary_Phone_NumberField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string On_Behalf_Of_Company_Name
		{
			get
			{
				return this.on_Behalf_Of_Company_NameField;
			}
			set
			{
				this.on_Behalf_Of_Company_NameField = value;
				this.RaisePropertyChanged("On_Behalf_Of_Company_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string On_Behalf_Of_Company_Tax_ID
		{
			get
			{
				return this.on_Behalf_Of_Company_Tax_IDField;
			}
			set
			{
				this.on_Behalf_Of_Company_Tax_IDField = value;
				this.RaisePropertyChanged("On_Behalf_Of_Company_Tax_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Address_Information_DataType On_Behalf_Of_Company_Address_Data
		{
			get
			{
				return this.on_Behalf_Of_Company_Address_DataField;
			}
			set
			{
				this.on_Behalf_Of_Company_Address_DataField = value;
				this.RaisePropertyChanged("On_Behalf_Of_Company_Address_Data");
			}
		}

		[XmlElement(Order = 3)]
		public string On_Behalf_Of_Company_Primary_Phone_Number
		{
			get
			{
				return this.on_Behalf_Of_Company_Primary_Phone_NumberField;
			}
			set
			{
				this.on_Behalf_Of_Company_Primary_Phone_NumberField = value;
				this.RaisePropertyChanged("On_Behalf_Of_Company_Primary_Phone_Number");
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
