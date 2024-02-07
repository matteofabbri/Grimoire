using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Propose_Compensation_For_Leave_of_Absence_Sub_Business_ProcessType : INotifyPropertyChanged
	{
		private Position_ElementObjectType position_Element_for_Compensation_Transaction_ReferenceField;

		private Event_Classification_SubcategoryObjectType reason_ReferenceField;

		private Business_Sub_Process_ParametersType business_Sub_Process_ParametersField;

		private Compensation_Proposed_For_Position_DataType propose_Compensation_for_Leave_of_Absence_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Position_ElementObjectType Position_Element_for_Compensation_Transaction_Reference
		{
			get
			{
				return this.position_Element_for_Compensation_Transaction_ReferenceField;
			}
			set
			{
				this.position_Element_for_Compensation_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Position_Element_for_Compensation_Transaction_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Event_Classification_SubcategoryObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Compensation_Proposed_For_Position_DataType Propose_Compensation_for_Leave_of_Absence_Data
		{
			get
			{
				return this.propose_Compensation_for_Leave_of_Absence_DataField;
			}
			set
			{
				this.propose_Compensation_for_Leave_of_Absence_DataField = value;
				this.RaisePropertyChanged("Propose_Compensation_for_Leave_of_Absence_Data");
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
