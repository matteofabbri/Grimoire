using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Merchant_Customer_Profile_RequestType : INotifyPropertyChanged
	{
		private Customer_Credit_Card_ProfileObjectType merchant_Customer_Profile_ReferenceField;

		private Customer_Credit_Card_Profile_DataType merchant_Customer_Profile_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_Credit_Card_ProfileObjectType Merchant_Customer_Profile_Reference
		{
			get
			{
				return this.merchant_Customer_Profile_ReferenceField;
			}
			set
			{
				this.merchant_Customer_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Merchant_Customer_Profile_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Customer_Credit_Card_Profile_DataType Merchant_Customer_Profile_Data
		{
			get
			{
				return this.merchant_Customer_Profile_DataField;
			}
			set
			{
				this.merchant_Customer_Profile_DataField = value;
				this.RaisePropertyChanged("Merchant_Customer_Profile_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
