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
	public class Contact_TypeType : INotifyPropertyChanged
	{
		private Business_Entity_Contact_Type_TenantedObjectType contact_Type_ReferenceField;

		private Contact_Type_DataType[] contact_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_Entity_Contact_Type_TenantedObjectType Contact_Type_Reference
		{
			get
			{
				return this.contact_Type_ReferenceField;
			}
			set
			{
				this.contact_Type_ReferenceField = value;
				this.RaisePropertyChanged("Contact_Type_Reference");
			}
		}

		[XmlElement("Contact_Type_Data", Order = 1)]
		public Contact_Type_DataType[] Contact_Type_Data
		{
			get
			{
				return this.contact_Type_DataField;
			}
			set
			{
				this.contact_Type_DataField = value;
				this.RaisePropertyChanged("Contact_Type_Data");
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
