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
	public class Worker_Benefit_Eligibility_DataType : INotifyPropertyChanged
	{
		private Benefit_PlanObjectType[] benefit_Plan_ReferenceField;

		private Plan_Eligiblity_Dates_DataType[] plan_Eligibility_Dates_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Benefit_Plan_Reference", Order = 0)]
		public Benefit_PlanObjectType[] Benefit_Plan_Reference
		{
			get
			{
				return this.benefit_Plan_ReferenceField;
			}
			set
			{
				this.benefit_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Plan_Reference");
			}
		}

		[XmlElement("Plan_Eligibility_Dates_Data", Order = 1)]
		public Plan_Eligiblity_Dates_DataType[] Plan_Eligibility_Dates_Data
		{
			get
			{
				return this.plan_Eligibility_Dates_DataField;
			}
			set
			{
				this.plan_Eligibility_Dates_DataField = value;
				this.RaisePropertyChanged("Plan_Eligibility_Dates_Data");
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
