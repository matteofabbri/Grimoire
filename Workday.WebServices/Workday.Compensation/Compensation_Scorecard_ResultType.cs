using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensation_Scorecard_ResultType : INotifyPropertyChanged
	{
		private Scoreset_ContainerObjectType compensation_Scorecard_Result_ReferenceField;

		private Compensation_Scorecard_Result_DataType[] compensation_Scorecard_Result_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Scoreset_ContainerObjectType Compensation_Scorecard_Result_Reference
		{
			get
			{
				return this.compensation_Scorecard_Result_ReferenceField;
			}
			set
			{
				this.compensation_Scorecard_Result_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Scorecard_Result_Reference");
			}
		}

		[XmlElement("Compensation_Scorecard_Result_Data", Order = 1)]
		public Compensation_Scorecard_Result_DataType[] Compensation_Scorecard_Result_Data
		{
			get
			{
				return this.compensation_Scorecard_Result_DataField;
			}
			set
			{
				this.compensation_Scorecard_Result_DataField = value;
				this.RaisePropertyChanged("Compensation_Scorecard_Result_Data");
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
