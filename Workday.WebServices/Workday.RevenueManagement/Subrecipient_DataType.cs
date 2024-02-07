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
	public class Subrecipient_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string dUNS4Field;

		private Is_SAM_RegisteredObjectType is_SAM_Registered_ReferenceField;

		private Tax_LocationObjectType tax_Location_ReferenceField;

		private Address_ReferenceObjectType address_ReferenceField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string DUNS4
		{
			get
			{
				return this.dUNS4Field;
			}
			set
			{
				this.dUNS4Field = value;
				this.RaisePropertyChanged("DUNS4");
			}
		}

		[XmlElement(Order = 2)]
		public Is_SAM_RegisteredObjectType Is_SAM_Registered_Reference
		{
			get
			{
				return this.is_SAM_Registered_ReferenceField;
			}
			set
			{
				this.is_SAM_Registered_ReferenceField = value;
				this.RaisePropertyChanged("Is_SAM_Registered_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Tax_LocationObjectType Tax_Location_Reference
		{
			get
			{
				return this.tax_Location_ReferenceField;
			}
			set
			{
				this.tax_Location_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Location_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Address_ReferenceObjectType Address_Reference
		{
			get
			{
				return this.address_ReferenceField;
			}
			set
			{
				this.address_ReferenceField = value;
				this.RaisePropertyChanged("Address_Reference");
			}
		}

		[XmlElement("Attachment_Data", Order = 5)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
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
