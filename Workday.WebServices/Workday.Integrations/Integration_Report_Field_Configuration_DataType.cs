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
	public class Integration_Report_Field_Configuration_DataType : INotifyPropertyChanged
	{
		private Integration_Document_FieldObjectType report_Alias_ReferenceField;

		private Custom_Report_DefinitionObjectType custom_Report_Definition_ReferenceField;

		private string rEST_EndpointField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_Document_FieldObjectType Report_Alias_Reference
		{
			get
			{
				return this.report_Alias_ReferenceField;
			}
			set
			{
				this.report_Alias_ReferenceField = value;
				this.RaisePropertyChanged("Report_Alias_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Custom_Report_DefinitionObjectType Custom_Report_Definition_Reference
		{
			get
			{
				return this.custom_Report_Definition_ReferenceField;
			}
			set
			{
				this.custom_Report_Definition_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Report_Definition_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string REST_Endpoint
		{
			get
			{
				return this.rEST_EndpointField;
			}
			set
			{
				this.rEST_EndpointField = value;
				this.RaisePropertyChanged("REST_Endpoint");
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
