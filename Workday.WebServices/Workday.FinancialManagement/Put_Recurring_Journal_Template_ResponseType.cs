using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Recurring_Journal_Template_ResponseType : INotifyPropertyChanged
	{
		private Recurring_Journal_TemplateObjectType recurring_Journal_Template_ReferenceField;

		private Custom_Validations_Exception_Subview_ResponseType[] custom_Validations_Exception_Subview_ResponseField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Recurring_Journal_TemplateObjectType Recurring_Journal_Template_Reference
		{
			get
			{
				return this.recurring_Journal_Template_ReferenceField;
			}
			set
			{
				this.recurring_Journal_Template_ReferenceField = value;
				this.RaisePropertyChanged("Recurring_Journal_Template_Reference");
			}
		}

		[XmlElement("Custom_Validations_Exception_Subview_Response", Order = 1)]
		public Custom_Validations_Exception_Subview_ResponseType[] Custom_Validations_Exception_Subview_Response
		{
			get
			{
				return this.custom_Validations_Exception_Subview_ResponseField;
			}
			set
			{
				this.custom_Validations_Exception_Subview_ResponseField = value;
				this.RaisePropertyChanged("Custom_Validations_Exception_Subview_Response");
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
