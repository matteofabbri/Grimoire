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
	public class Request_for_Quote_Participant_List_DataType : INotifyPropertyChanged
	{
		private Resource_ProviderObjectType supplier_ReferenceField;

		private Purchase_Order_Issue_OptionObjectType issue_Option_ReferenceField;

		private Unique_IdentifierObjectType[] override_Contact_Email_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Resource_ProviderObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Purchase_Order_Issue_OptionObjectType Issue_Option_Reference
		{
			get
			{
				return this.issue_Option_ReferenceField;
			}
			set
			{
				this.issue_Option_ReferenceField = value;
				this.RaisePropertyChanged("Issue_Option_Reference");
			}
		}

		[XmlElement("Override_Contact_Email_Reference", Order = 2)]
		public Unique_IdentifierObjectType[] Override_Contact_Email_Reference
		{
			get
			{
				return this.override_Contact_Email_ReferenceField;
			}
			set
			{
				this.override_Contact_Email_ReferenceField = value;
				this.RaisePropertyChanged("Override_Contact_Email_Reference");
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
