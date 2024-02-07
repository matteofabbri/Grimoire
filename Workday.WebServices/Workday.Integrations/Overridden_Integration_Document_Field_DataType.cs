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
	public class Overridden_Integration_Document_Field_DataType : INotifyPropertyChanged
	{
		private Integration_Document_FieldObjectType integration_Document_Field_ReferenceField;

		private External_FieldObjectType external_Field_ReferenceField;

		private Integration_Field_Override_Parameter_Initialization_DataType[] integration_Field_Override_Parameter_Initialization_DataField;

		private Integration_Document_Stack_DataType[] integration_Document_Stacks_for_Integration_Document_Field_Configuration_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_Document_FieldObjectType Integration_Document_Field_Reference
		{
			get
			{
				return this.integration_Document_Field_ReferenceField;
			}
			set
			{
				this.integration_Document_Field_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Document_Field_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public External_FieldObjectType External_Field_Reference
		{
			get
			{
				return this.external_Field_ReferenceField;
			}
			set
			{
				this.external_Field_ReferenceField = value;
				this.RaisePropertyChanged("External_Field_Reference");
			}
		}

		[XmlElement("Integration_Field_Override_Parameter_Initialization_Data", Order = 2)]
		public Integration_Field_Override_Parameter_Initialization_DataType[] Integration_Field_Override_Parameter_Initialization_Data
		{
			get
			{
				return this.integration_Field_Override_Parameter_Initialization_DataField;
			}
			set
			{
				this.integration_Field_Override_Parameter_Initialization_DataField = value;
				this.RaisePropertyChanged("Integration_Field_Override_Parameter_Initialization_Data");
			}
		}

		[XmlElement("Integration_Document_Stacks_for_Integration_Document_Field_Configuration_Data", Order = 3)]
		public Integration_Document_Stack_DataType[] Integration_Document_Stacks_for_Integration_Document_Field_Configuration_Data
		{
			get
			{
				return this.integration_Document_Stacks_for_Integration_Document_Field_Configuration_DataField;
			}
			set
			{
				this.integration_Document_Stacks_for_Integration_Document_Field_Configuration_DataField = value;
				this.RaisePropertyChanged("Integration_Document_Stacks_for_Integration_Document_Field_Configuration_Data");
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
