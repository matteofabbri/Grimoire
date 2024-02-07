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
	public class Integration_Attribute_Integration_Attribute_Value_Data_WWSType : INotifyPropertyChanged
	{
		private External_Instance_ObjectType integration_Attribute_ReferenceField;

		private string integration_Attribute_NameField;

		private Integration_Attribute_Value_Data_WWSType[] integration_Attribute_Value_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public External_Instance_ObjectType Integration_Attribute_Reference
		{
			get
			{
				return this.integration_Attribute_ReferenceField;
			}
			set
			{
				this.integration_Attribute_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Attribute_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Integration_Attribute_Name
		{
			get
			{
				return this.integration_Attribute_NameField;
			}
			set
			{
				this.integration_Attribute_NameField = value;
				this.RaisePropertyChanged("Integration_Attribute_Name");
			}
		}

		[XmlElement("Integration_Attribute_Value_Data", Order = 2)]
		public Integration_Attribute_Value_Data_WWSType[] Integration_Attribute_Value_Data
		{
			get
			{
				return this.integration_Attribute_Value_DataField;
			}
			set
			{
				this.integration_Attribute_Value_DataField = value;
				this.RaisePropertyChanged("Integration_Attribute_Value_Data");
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
