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
	public class Get_Integration_Systems_CriteriaType : INotifyPropertyChanged
	{
		private Integration_TemplateObjectType integration_Template_ReferenceField;

		private System_UserObjectType workday_Account_ReferenceField;

		private Cloud_CollectionObjectType cloud_Collection_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_TemplateObjectType Integration_Template_Reference
		{
			get
			{
				return this.integration_Template_ReferenceField;
			}
			set
			{
				this.integration_Template_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Template_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public System_UserObjectType Workday_Account_Reference
		{
			get
			{
				return this.workday_Account_ReferenceField;
			}
			set
			{
				this.workday_Account_ReferenceField = value;
				this.RaisePropertyChanged("Workday_Account_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Cloud_CollectionObjectType Cloud_Collection_Reference
		{
			get
			{
				return this.cloud_Collection_ReferenceField;
			}
			set
			{
				this.cloud_Collection_ReferenceField = value;
				this.RaisePropertyChanged("Cloud_Collection_Reference");
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
