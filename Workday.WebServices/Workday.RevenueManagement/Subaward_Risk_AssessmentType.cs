using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Subaward_Risk_AssessmentType : INotifyPropertyChanged
	{
		private Risk_EvaluationObjectType subaward_Risk_Assessment_ReferenceField;

		private Subaward_Risk_Assessment_DataType[] subaward_Risk_Assessment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Risk_EvaluationObjectType Subaward_Risk_Assessment_Reference
		{
			get
			{
				return this.subaward_Risk_Assessment_ReferenceField;
			}
			set
			{
				this.subaward_Risk_Assessment_ReferenceField = value;
				this.RaisePropertyChanged("Subaward_Risk_Assessment_Reference");
			}
		}

		[XmlElement("Subaward_Risk_Assessment_Data", Order = 1)]
		public Subaward_Risk_Assessment_DataType[] Subaward_Risk_Assessment_Data
		{
			get
			{
				return this.subaward_Risk_Assessment_DataField;
			}
			set
			{
				this.subaward_Risk_Assessment_DataField = value;
				this.RaisePropertyChanged("Subaward_Risk_Assessment_Data");
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
