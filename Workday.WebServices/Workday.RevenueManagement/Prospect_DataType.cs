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
	public class Prospect_DataType : INotifyPropertyChanged
	{
		private string prospect_IDField;

		private string customer_IDField;

		private string prospect_NameField;

		private External_SourceObjectType prospect_Source_ReferenceField;

		private Contact_Information_DataType contact_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Prospect_ID
		{
			get
			{
				return this.prospect_IDField;
			}
			set
			{
				this.prospect_IDField = value;
				this.RaisePropertyChanged("Prospect_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Customer_ID
		{
			get
			{
				return this.customer_IDField;
			}
			set
			{
				this.customer_IDField = value;
				this.RaisePropertyChanged("Customer_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Prospect_Name
		{
			get
			{
				return this.prospect_NameField;
			}
			set
			{
				this.prospect_NameField = value;
				this.RaisePropertyChanged("Prospect_Name");
			}
		}

		[XmlElement(Order = 3)]
		public External_SourceObjectType Prospect_Source_Reference
		{
			get
			{
				return this.prospect_Source_ReferenceField;
			}
			set
			{
				this.prospect_Source_ReferenceField = value;
				this.RaisePropertyChanged("Prospect_Source_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Contact_Information_DataType Contact_Data
		{
			get
			{
				return this.contact_DataField;
			}
			set
			{
				this.contact_DataField = value;
				this.RaisePropertyChanged("Contact_Data");
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
