using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Headcount_Plan_TemplateType : INotifyPropertyChanged
	{
		private Headcount_Plan_TemplateObjectType headcount_Plan_Template_ReferenceField;

		private Headcount_Plan_Template_DataType headcount_Plan_Template_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Headcount_Plan_TemplateObjectType Headcount_Plan_Template_Reference
		{
			get
			{
				return this.headcount_Plan_Template_ReferenceField;
			}
			set
			{
				this.headcount_Plan_Template_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Plan_Template_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Headcount_Plan_Template_DataType Headcount_Plan_Template_Data
		{
			get
			{
				return this.headcount_Plan_Template_DataField;
			}
			set
			{
				this.headcount_Plan_Template_DataField = value;
				this.RaisePropertyChanged("Headcount_Plan_Template_Data");
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
