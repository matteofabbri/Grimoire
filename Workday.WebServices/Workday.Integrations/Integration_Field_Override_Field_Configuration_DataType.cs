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
	public class Integration_Field_Override_Field_Configuration_DataType : INotifyPropertyChanged
	{
		private Integration_Document_FieldObjectType field_ReferenceField;

		private External_FieldObjectType external_Field_ReferenceField;

		private Integration_Field_Override_Parameter_Initialization_DataType[] external_Parameter_Assignment_DataField;

		private bool required_FieldField;

		private bool required_FieldFieldSpecified;

		private decimal maximum_LengthField;

		private bool maximum_LengthFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_Document_FieldObjectType Field_Reference
		{
			get
			{
				return this.field_ReferenceField;
			}
			set
			{
				this.field_ReferenceField = value;
				this.RaisePropertyChanged("Field_Reference");
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

		[XmlElement("External_Parameter_Assignment_Data", Order = 2)]
		public Integration_Field_Override_Parameter_Initialization_DataType[] External_Parameter_Assignment_Data
		{
			get
			{
				return this.external_Parameter_Assignment_DataField;
			}
			set
			{
				this.external_Parameter_Assignment_DataField = value;
				this.RaisePropertyChanged("External_Parameter_Assignment_Data");
			}
		}

		[XmlElement(Order = 3)]
		public bool Required_Field
		{
			get
			{
				return this.required_FieldField;
			}
			set
			{
				this.required_FieldField = value;
				this.RaisePropertyChanged("Required_Field");
			}
		}

		[XmlIgnore]
		public bool Required_FieldSpecified
		{
			get
			{
				return this.required_FieldFieldSpecified;
			}
			set
			{
				this.required_FieldFieldSpecified = value;
				this.RaisePropertyChanged("Required_FieldSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Maximum_Length
		{
			get
			{
				return this.maximum_LengthField;
			}
			set
			{
				this.maximum_LengthField = value;
				this.RaisePropertyChanged("Maximum_Length");
			}
		}

		[XmlIgnore]
		public bool Maximum_LengthSpecified
		{
			get
			{
				return this.maximum_LengthFieldSpecified;
			}
			set
			{
				this.maximum_LengthFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_LengthSpecified");
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
