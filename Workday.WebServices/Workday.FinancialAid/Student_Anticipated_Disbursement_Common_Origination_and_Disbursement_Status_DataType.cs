using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Anticipated_Disbursement_Common_Origination_and_Disbursement_Status_DataType : INotifyPropertyChanged
	{
		private Common_Origination_and_Disbursement_StatusObjectType common_Origination_and_Disbursement_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Common_Origination_and_Disbursement_StatusObjectType Common_Origination_and_Disbursement_Status_Reference
		{
			get
			{
				return this.common_Origination_and_Disbursement_Status_ReferenceField;
			}
			set
			{
				this.common_Origination_and_Disbursement_Status_ReferenceField = value;
				this.RaisePropertyChanged("Common_Origination_and_Disbursement_Status_Reference");
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
