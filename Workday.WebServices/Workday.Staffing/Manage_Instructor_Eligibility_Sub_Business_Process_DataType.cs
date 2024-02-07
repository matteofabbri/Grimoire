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
	public class Manage_Instructor_Eligibility_Sub_Business_Process_DataType : INotifyPropertyChanged
	{
		private Business_Sub_Process_ParametersType[] business_Sub_Process_ParametersField;

		private Instructor_Eligibility_Line_DataType[] instructor_Eligibility_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Business_Sub_Process_Parameters", Order = 0)]
		public Business_Sub_Process_ParametersType[] Business_Sub_Process_Parameters
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

		[XmlElement("Instructor_Eligibility_Line_Data", Order = 1)]
		public Instructor_Eligibility_Line_DataType[] Instructor_Eligibility_Line_Data
		{
			get
			{
				return this.instructor_Eligibility_Line_DataField;
			}
			set
			{
				this.instructor_Eligibility_Line_DataField = value;
				this.RaisePropertyChanged("Instructor_Eligibility_Line_Data");
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
