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
	public class Report_Parameter_Initialization_DataType : INotifyPropertyChanged
	{
		private string xML_NameField;

		private Simple_Work_Data_Parameter_Initialization_DataType simple_Work_Data_Parameter_Initialization_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string XML_Name
		{
			get
			{
				return this.xML_NameField;
			}
			set
			{
				this.xML_NameField = value;
				this.RaisePropertyChanged("XML_Name");
			}
		}

		[XmlElement(Order = 1)]
		public Simple_Work_Data_Parameter_Initialization_DataType Simple_Work_Data_Parameter_Initialization_Data
		{
			get
			{
				return this.simple_Work_Data_Parameter_Initialization_DataField;
			}
			set
			{
				this.simple_Work_Data_Parameter_Initialization_DataField = value;
				this.RaisePropertyChanged("Simple_Work_Data_Parameter_Initialization_Data");
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
