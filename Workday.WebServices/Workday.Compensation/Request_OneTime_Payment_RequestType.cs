using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Request_One-Time_Payment_RequestType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Request_OneTime_Payment_RequestType : INotifyPropertyChanged
	{
		private Business_Process_ParametersType business_Process_ParametersField;

		private Request_OneTime_Payment_DataType oneTime_Payment_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_Process_ParametersType Business_Process_Parameters
		{
			get
			{
				return this.business_Process_ParametersField;
			}
			set
			{
				this.business_Process_ParametersField = value;
				this.RaisePropertyChanged("Business_Process_Parameters");
			}
		}

		[XmlElement("One-Time_Payment_Data", Order = 1)]
		public Request_OneTime_Payment_DataType OneTime_Payment_Data
		{
			get
			{
				return this.oneTime_Payment_DataField;
			}
			set
			{
				this.oneTime_Payment_DataField = value;
				this.RaisePropertyChanged("OneTime_Payment_Data");
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
