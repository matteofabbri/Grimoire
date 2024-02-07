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
	public class Integration_Scheduled_Future_Process_DataType : INotifyPropertyChanged
	{
		private Integration_System_IdentifierObjectType integration_System_ReferenceField;

		private Integration_Parameter_Initialization_DataType[] integration_Parameter_Initialization_DataField;

		private Integration_Report_Parameter_Initialization_DataType[] integration_Report_Parameter_Initialization_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_System_IdentifierObjectType Integration_System_Reference
		{
			get
			{
				return this.integration_System_ReferenceField;
			}
			set
			{
				this.integration_System_ReferenceField = value;
				this.RaisePropertyChanged("Integration_System_Reference");
			}
		}

		[XmlElement("Integration_Parameter_Initialization_Data", Order = 1)]
		public Integration_Parameter_Initialization_DataType[] Integration_Parameter_Initialization_Data
		{
			get
			{
				return this.integration_Parameter_Initialization_DataField;
			}
			set
			{
				this.integration_Parameter_Initialization_DataField = value;
				this.RaisePropertyChanged("Integration_Parameter_Initialization_Data");
			}
		}

		[XmlElement("Integration_Report_Parameter_Initialization_Data", Order = 2)]
		public Integration_Report_Parameter_Initialization_DataType[] Integration_Report_Parameter_Initialization_Data
		{
			get
			{
				return this.integration_Report_Parameter_Initialization_DataField;
			}
			set
			{
				this.integration_Report_Parameter_Initialization_DataField = value;
				this.RaisePropertyChanged("Integration_Report_Parameter_Initialization_Data");
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
