using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Internal_Catalog_Request_CriteriaType : INotifyPropertyChanged
	{
		private string catalog_NameField;

		private CurrencyObjectType currency_ReferenceField;

		private Internal_Service_ProviderObjectType internal_Service_Provider_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Catalog_Name
		{
			get
			{
				return this.catalog_NameField;
			}
			set
			{
				this.catalog_NameField = value;
				this.RaisePropertyChanged("Catalog_Name");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Internal_Service_ProviderObjectType Internal_Service_Provider_Reference
		{
			get
			{
				return this.internal_Service_Provider_ReferenceField;
			}
			set
			{
				this.internal_Service_Provider_ReferenceField = value;
				this.RaisePropertyChanged("Internal_Service_Provider_Reference");
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
