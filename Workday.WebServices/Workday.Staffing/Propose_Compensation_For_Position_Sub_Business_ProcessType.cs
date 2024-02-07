using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Propose_Compensation_For_Position_Sub_Business_ProcessType : INotifyPropertyChanged
	{
		private Business_Sub_Process_ParametersType business_Sub_Process_ParametersField;

		private Compensation_Proposed_For_Position_DataType propose_Compensation_for_Position_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_Sub_Process_ParametersType Business_Sub_Process_Parameters
		{
			get
			{
				return this.business_Sub_Process_ParametersField;
			}
			set
			{
				this.business_Sub_Process_ParametersField = value;
				this.RaisePropertyChanged("Business_Sub_Process_Parameters");
			}
		}

		[XmlElement(Order = 1)]
		public Compensation_Proposed_For_Position_DataType Propose_Compensation_for_Position_Data
		{
			get
			{
				return this.propose_Compensation_for_Position_DataField;
			}
			set
			{
				this.propose_Compensation_for_Position_DataField = value;
				this.RaisePropertyChanged("Propose_Compensation_for_Position_Data");
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
