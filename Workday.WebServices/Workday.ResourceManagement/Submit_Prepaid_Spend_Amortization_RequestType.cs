using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Prepaid_Spend_Amortization_RequestType : INotifyPropertyChanged
	{
		private Financials_Business_Process_ParametersType business_Process_ParametersField;

		private Prepaid_Spend_Amortization_DataType prepaid_Spend_Amortization_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Financials_Business_Process_ParametersType Business_Process_Parameters
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

		[XmlElement(Order = 1)]
		public Prepaid_Spend_Amortization_DataType Prepaid_Spend_Amortization_Data
		{
			get
			{
				return this.prepaid_Spend_Amortization_DataField;
			}
			set
			{
				this.prepaid_Spend_Amortization_DataField = value;
				this.RaisePropertyChanged("Prepaid_Spend_Amortization_Data");
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
