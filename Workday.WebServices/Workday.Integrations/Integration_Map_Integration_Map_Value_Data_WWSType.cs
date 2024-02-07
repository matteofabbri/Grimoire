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
	public class Integration_Map_Integration_Map_Value_Data_WWSType : INotifyPropertyChanged
	{
		private External_Instance_ObjectType integration_Map_ReferenceField;

		private string integration_Map_NameField;

		private Integration_Abstract_Value_DataType default_Value_DataField;

		private Integration_Map_Value_Data_WWSType[] integration_Map_Value_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public External_Instance_ObjectType Integration_Map_Reference
		{
			get
			{
				return this.integration_Map_ReferenceField;
			}
			set
			{
				this.integration_Map_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Map_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Integration_Map_Name
		{
			get
			{
				return this.integration_Map_NameField;
			}
			set
			{
				this.integration_Map_NameField = value;
				this.RaisePropertyChanged("Integration_Map_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Integration_Abstract_Value_DataType Default_Value_Data
		{
			get
			{
				return this.default_Value_DataField;
			}
			set
			{
				this.default_Value_DataField = value;
				this.RaisePropertyChanged("Default_Value_Data");
			}
		}

		[XmlElement("Integration_Map_Value_Data", Order = 3)]
		public Integration_Map_Value_Data_WWSType[] Integration_Map_Value_Data
		{
			get
			{
				return this.integration_Map_Value_DataField;
			}
			set
			{
				this.integration_Map_Value_DataField = value;
				this.RaisePropertyChanged("Integration_Map_Value_Data");
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
