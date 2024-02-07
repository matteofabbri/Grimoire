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
	public class Remove_Retiree_Status_Sub_Business_ProcessType : INotifyPropertyChanged
	{
		private Business_Sub_Process_ParametersType business_Sub_Process_ParametersField;

		private Remove_Retiree_Status_Sub_Process_DetailsType remove_Retiree_Status_DetailsField;

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
		public Remove_Retiree_Status_Sub_Process_DetailsType Remove_Retiree_Status_Details
		{
			get
			{
				return this.remove_Retiree_Status_DetailsField;
			}
			set
			{
				this.remove_Retiree_Status_DetailsField = value;
				this.RaisePropertyChanged("Remove_Retiree_Status_Details");
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
