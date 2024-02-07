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
	public class Integration_Transport_Protocol_Assignment_DataType : INotifyPropertyChanged
	{
		private Integration_Transport_Protocol_Data_WWSType integration_Transport_Protocol_DataField;

		private Integration_File_Utility_DataType integration_File_Utility_DataField;

		private Integration_Payload_DataType integration_Payload_DataField;

		private OMS_EnvironmentObjectType[] restricted_To_Environment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_Transport_Protocol_Data_WWSType Integration_Transport_Protocol_Data
		{
			get
			{
				return this.integration_Transport_Protocol_DataField;
			}
			set
			{
				this.integration_Transport_Protocol_DataField = value;
				this.RaisePropertyChanged("Integration_Transport_Protocol_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Integration_File_Utility_DataType Integration_File_Utility_Data
		{
			get
			{
				return this.integration_File_Utility_DataField;
			}
			set
			{
				this.integration_File_Utility_DataField = value;
				this.RaisePropertyChanged("Integration_File_Utility_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Integration_Payload_DataType Integration_Payload_Data
		{
			get
			{
				return this.integration_Payload_DataField;
			}
			set
			{
				this.integration_Payload_DataField = value;
				this.RaisePropertyChanged("Integration_Payload_Data");
			}
		}

		[XmlElement("Restricted_To_Environment_Reference", Order = 3)]
		public OMS_EnvironmentObjectType[] Restricted_To_Environment_Reference
		{
			get
			{
				return this.restricted_To_Environment_ReferenceField;
			}
			set
			{
				this.restricted_To_Environment_ReferenceField = value;
				this.RaisePropertyChanged("Restricted_To_Environment_Reference");
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
