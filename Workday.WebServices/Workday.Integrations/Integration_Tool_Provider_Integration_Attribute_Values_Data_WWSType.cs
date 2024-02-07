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
	public class Integration_Tool_Provider_Integration_Attribute_Values_Data_WWSType : INotifyPropertyChanged
	{
		private External_Instance_ObjectType integration_Attribute_Provider_ReferenceField;

		private Integration_Attribute_Integration_Attribute_Value_Data_WWSType[] integration_Attribute_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public External_Instance_ObjectType Integration_Attribute_Provider_Reference
		{
			get
			{
				return this.integration_Attribute_Provider_ReferenceField;
			}
			set
			{
				this.integration_Attribute_Provider_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Attribute_Provider_Reference");
			}
		}

		[XmlElement("Integration_Attribute_Data", Order = 1)]
		public Integration_Attribute_Integration_Attribute_Value_Data_WWSType[] Integration_Attribute_Data
		{
			get
			{
				return this.integration_Attribute_DataField;
			}
			set
			{
				this.integration_Attribute_DataField = value;
				this.RaisePropertyChanged("Integration_Attribute_Data");
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
