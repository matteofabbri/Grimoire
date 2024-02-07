using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Run_Pay_Calculation_ResponseType : INotifyPropertyChanged
	{
		private Exception_DataType[][] application_Instance_Related_Exceptions_DataField;

		private Background_Process_Runtime_DataType[] background_Process_Runtime_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Exceptions_Data", typeof(Exception_DataType[]), IsNullable = false), XmlArrayItem("Exception_Data", typeof(Exception_DataType), IsNullable = false, NestingLevel = 1)]
		public Exception_DataType[][] Application_Instance_Related_Exceptions_Data
		{
			get
			{
				return this.application_Instance_Related_Exceptions_DataField;
			}
			set
			{
				this.application_Instance_Related_Exceptions_DataField = value;
				this.RaisePropertyChanged("Application_Instance_Related_Exceptions_Data");
			}
		}

		[XmlElement("Background_Process_Runtime_Data", Order = 1)]
		public Background_Process_Runtime_DataType[] Background_Process_Runtime_Data
		{
			get
			{
				return this.background_Process_Runtime_DataField;
			}
			set
			{
				this.background_Process_Runtime_DataField = value;
				this.RaisePropertyChanged("Background_Process_Runtime_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
