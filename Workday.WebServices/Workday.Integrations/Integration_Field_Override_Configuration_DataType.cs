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
	public class Integration_Field_Override_Configuration_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType integration_Business_Object_ReferenceField;

		private Integration_Field_Override_Field_Configuration_DataType[] integration_Document_Field_Override_Configuration_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Integration_Business_Object_Reference
		{
			get
			{
				return this.integration_Business_Object_ReferenceField;
			}
			set
			{
				this.integration_Business_Object_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Business_Object_Reference");
			}
		}

		[XmlElement("Integration_Document_Field_Override_Configuration_Data", Order = 1)]
		public Integration_Field_Override_Field_Configuration_DataType[] Integration_Document_Field_Override_Configuration_Data
		{
			get
			{
				return this.integration_Document_Field_Override_Configuration_DataField;
			}
			set
			{
				this.integration_Document_Field_Override_Configuration_DataField = value;
				this.RaisePropertyChanged("Integration_Document_Field_Override_Configuration_Data");
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
