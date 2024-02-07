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
	public class Business_Connection_DataType : INotifyPropertyChanged
	{
		private string business_Connection_IDField;

		private CustomerObjectType customer_ReferenceField;

		private CustomerObjectType shipTo_Customer_ReferenceField;

		private bool default_ShipTo_CustomerField;

		private bool default_ShipTo_CustomerFieldSpecified;

		private string default_ShipTo_AddressField;

		private string address_Reference_IDField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Business_Connection_ID
		{
			get
			{
				return this.business_Connection_IDField;
			}
			set
			{
				this.business_Connection_IDField = value;
				this.RaisePropertyChanged("Business_Connection_ID");
			}
		}

		[XmlElement(Order = 1)]
		public CustomerObjectType Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement("Ship-To_Customer_Reference", Order = 2)]
		public CustomerObjectType ShipTo_Customer_Reference
		{
			get
			{
				return this.shipTo_Customer_ReferenceField;
			}
			set
			{
				this.shipTo_Customer_ReferenceField = value;
				this.RaisePropertyChanged("ShipTo_Customer_Reference");
			}
		}

		[XmlElement("Default_Ship-To_Customer", Order = 3)]
		public bool Default_ShipTo_Customer
		{
			get
			{
				return this.default_ShipTo_CustomerField;
			}
			set
			{
				this.default_ShipTo_CustomerField = value;
				this.RaisePropertyChanged("Default_ShipTo_Customer");
			}
		}

		[XmlIgnore]
		public bool Default_ShipTo_CustomerSpecified
		{
			get
			{
				return this.default_ShipTo_CustomerFieldSpecified;
			}
			set
			{
				this.default_ShipTo_CustomerFieldSpecified = value;
				this.RaisePropertyChanged("Default_ShipTo_CustomerSpecified");
			}
		}

		[XmlElement("Default_Ship-To_Address", Order = 4)]
		public string Default_ShipTo_Address
		{
			get
			{
				return this.default_ShipTo_AddressField;
			}
			set
			{
				this.default_ShipTo_AddressField = value;
				this.RaisePropertyChanged("Default_ShipTo_Address");
			}
		}

		[XmlElement(Order = 5)]
		public string Address_Reference_ID
		{
			get
			{
				return this.address_Reference_IDField;
			}
			set
			{
				this.address_Reference_IDField = value;
				this.RaisePropertyChanged("Address_Reference_ID");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
