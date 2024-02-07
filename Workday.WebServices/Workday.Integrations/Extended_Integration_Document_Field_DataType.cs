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
	public class Extended_Integration_Document_Field_DataType : INotifyPropertyChanged
	{
		private string field_NameField;

		private string descriptionField;

		private Unique_IdentifierObjectType field_Data_Type_ReferenceField;

		private string reference_ID_TypeField;

		private External_FieldObjectType external_Field_ReferenceField;

		private Integration_Field_Override_Parameter_Initialization_DataType[] integration_Field_Override_Parameter_Initialization_DataField;

		private Integration_Document_Stack_DataType[] integration_Document_Stacks_for_Integration_Document_Field_Configuration_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Field_Name
		{
			get
			{
				return this.field_NameField;
			}
			set
			{
				this.field_NameField = value;
				this.RaisePropertyChanged("Field_Name");
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
		public Unique_IdentifierObjectType Field_Data_Type_Reference
		{
			get
			{
				return this.field_Data_Type_ReferenceField;
			}
			set
			{
				this.field_Data_Type_ReferenceField = value;
				this.RaisePropertyChanged("Field_Data_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Reference_ID_Type
		{
			get
			{
				return this.reference_ID_TypeField;
			}
			set
			{
				this.reference_ID_TypeField = value;
				this.RaisePropertyChanged("Reference_ID_Type");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement("Integration_Field_Override_Parameter_Initialization_Data", Order = 5)]
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

		[XmlElement("Integration_Document_Stacks_for_Integration_Document_Field_Configuration_Data", Order = 6)]
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
