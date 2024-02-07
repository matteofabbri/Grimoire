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
	public class Integration_Tool_Provider_Integration_Map_Values_Data_WWSType : INotifyPropertyChanged
	{
		private External_Instance_ObjectType integration_Map_Provider_ReferenceField;

		private Integration_Map_Integration_Map_Value_Data_WWSType[] integration_Map_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public External_Instance_ObjectType Integration_Map_Provider_Reference
		{
			get
			{
				return this.integration_Map_Provider_ReferenceField;
			}
			set
			{
				this.integration_Map_Provider_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Map_Provider_Reference");
			}
		}

		[XmlElement("Integration_Map_Data", Order = 1)]
		public Integration_Map_Integration_Map_Value_Data_WWSType[] Integration_Map_Data
		{
			get
			{
				return this.integration_Map_DataField;
			}
			set
			{
				this.integration_Map_DataField = value;
				this.RaisePropertyChanged("Integration_Map_Data");
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
