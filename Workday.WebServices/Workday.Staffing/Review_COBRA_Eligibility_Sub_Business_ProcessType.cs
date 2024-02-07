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
	public class Review_COBRA_Eligibility_Sub_Business_ProcessType : INotifyPropertyChanged
	{
		private Business_Sub_Process_ParametersType business_Sub_Process_ParametersField;

		private Review_COBRA_Eligibility_DataType[] review_COBRA_Eligibility_DataField;

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

		[XmlElement("Review_COBRA_Eligibility_Data", Order = 1)]
		public Review_COBRA_Eligibility_DataType[] Review_COBRA_Eligibility_Data
		{
			get
			{
				return this.review_COBRA_Eligibility_DataField;
			}
			set
			{
				this.review_COBRA_Eligibility_DataField = value;
				this.RaisePropertyChanged("Review_COBRA_Eligibility_Data");
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
