using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_System_Contact_Data_WWSType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType integration_System_Contact_ReferenceField;

		private string descriptionField;

		private WorkerObjectType contact_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Integration_System_Contact_Reference
		{
			get
			{
				return this.integration_System_Contact_ReferenceField;
			}
			set
			{
				this.integration_System_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Integration_System_Contact_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 2)]
		public WorkerObjectType Contact_Reference
		{
			get
			{
				return this.contact_ReferenceField;
			}
			set
			{
				this.contact_ReferenceField = value;
				this.RaisePropertyChanged("Contact_Reference");
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
