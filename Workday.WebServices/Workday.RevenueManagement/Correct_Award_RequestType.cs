using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Correct_Award_RequestType : INotifyPropertyChanged
	{
		private Award_ContractObjectType award_ReferenceField;

		private Financials_Business_Process_ParametersType business_Process_ParametersField;

		private Award_Contract_DataType award_DataField;

		private bool in_Correct_EventField;

		private bool in_Correct_EventFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_ContractObjectType Award_Reference
		{
			get
			{
				return this.award_ReferenceField;
			}
			set
			{
				this.award_ReferenceField = value;
				this.RaisePropertyChanged("Award_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Award_Contract_DataType Award_Data
		{
			get
			{
				return this.award_DataField;
			}
			set
			{
				this.award_DataField = value;
				this.RaisePropertyChanged("Award_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool In_Correct_Event
		{
			get
			{
				return this.in_Correct_EventField;
			}
			set
			{
				this.in_Correct_EventField = value;
				this.RaisePropertyChanged("In_Correct_Event");
			}
		}

		[XmlIgnore]
		public bool In_Correct_EventSpecified
		{
			get
			{
				return this.in_Correct_EventFieldSpecified;
			}
			set
			{
				this.in_Correct_EventFieldSpecified = value;
				this.RaisePropertyChanged("In_Correct_EventSpecified");
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
