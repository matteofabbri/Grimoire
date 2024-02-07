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
	public class Integration_Field_Attributes_Field_Configuration_DataType : INotifyPropertyChanged
	{
		private Integration_Document_FieldObjectType field_ReferenceField;

		private string web_Service_AliasField;

		private bool include_in_OutputField;

		private bool include_in_OutputFieldSpecified;

		private bool required_FieldField;

		private bool required_FieldFieldSpecified;

		private decimal maximum_LengthField;

		private bool maximum_LengthFieldSpecified;

		private Integration_Field_Attributes_Field_Configuration_DataType[] integration_Field_Attributes_Field_Configuration_DataField;

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
		public string Web_Service_Alias
		{
			get
			{
				return this.web_Service_AliasField;
			}
			set
			{
				this.web_Service_AliasField = value;
				this.RaisePropertyChanged("Web_Service_Alias");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_in_Output
		{
			get
			{
				return this.include_in_OutputField;
			}
			set
			{
				this.include_in_OutputField = value;
				this.RaisePropertyChanged("Include_in_Output");
			}
		}

		[XmlIgnore]
		public bool Include_in_OutputSpecified
		{
			get
			{
				return this.include_in_OutputFieldSpecified;
			}
			set
			{
				this.include_in_OutputFieldSpecified = value;
				this.RaisePropertyChanged("Include_in_OutputSpecified");
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

		[XmlElement("Integration_Field_Attributes_Field_Configuration_Data", Order = 5)]
		public Integration_Field_Attributes_Field_Configuration_DataType[] Integration_Field_Attributes_Field_Configuration_Data
		{
			get
			{
				return this.integration_Field_Attributes_Field_Configuration_DataField;
			}
			set
			{
				this.integration_Field_Attributes_Field_Configuration_DataField = value;
				this.RaisePropertyChanged("Integration_Field_Attributes_Field_Configuration_Data");
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
