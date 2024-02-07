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
	public class Get_Withholding_Order_Local_Minimum_Wage_Rate_ResponseType : INotifyPropertyChanged
	{
		private Withholding_Order_Local_Minimum_Wage_Rate_RequestType request_CriteriaField;

		private Response_FilterType request_FilterField;

		private Response_ResultsType response_ResultsField;

		private Get_Withholding_Order_Local_Minimum_Wage_DataType[] response_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Withholding_Order_Local_Minimum_Wage_Rate_RequestType Request_Criteria
		{
			get
			{
				return this.request_CriteriaField;
			}
			set
			{
				this.request_CriteriaField = value;
				this.RaisePropertyChanged("Request_Criteria");
			}
		}

		[XmlElement(Order = 1)]
		public Response_FilterType Request_Filter
		{
			get
			{
				return this.request_FilterField;
			}
			set
			{
				this.request_FilterField = value;
				this.RaisePropertyChanged("Request_Filter");
			}
		}

		[XmlElement(Order = 2)]
		public Response_ResultsType Response_Results
		{
			get
			{
				return this.response_ResultsField;
			}
			set
			{
				this.response_ResultsField = value;
				this.RaisePropertyChanged("Response_Results");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Withholding_Order_Local_Minimum_Wage_Data", IsNullable = false)]
		public Get_Withholding_Order_Local_Minimum_Wage_DataType[] Response_Data
		{
			get
			{
				return this.response_DataField;
			}
			set
			{
				this.response_DataField = value;
				this.RaisePropertyChanged("Response_Data");
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
